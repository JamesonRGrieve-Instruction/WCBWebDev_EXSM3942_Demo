// Use our models namespace so we have access to the models and the dbcontext.
using CSharpIntermediate.Models;
using Microsoft.EntityFrameworkCore;

// Any time we want to access the database, if we wrap it in a using statement it ensures that when we are done, the connection isn't hanging open.
using (DatabaseContext context = new DatabaseContext())
{
    // Query 1: The context gets a DbSet of the Products and converts it to a list.
    // Converting to a list closes the connection which allows us to reopen it for loading purposes on the next line.
    // (Whenever you encounter a "Connection already in use" error, ensure you don't have any DbSets that you're working with directly. If so, convert to list.
    foreach (Product product in context.Products.ToList())
    {
        // EXPLICIT LOADING
        // Explicit loading only loads associated records for specific records you're looking at. 
        // Now that we have our products stored in memory outside of the database, we can command ef to load the associated data for the product category.
        context.Entry(product).Reference(x => x.ProductCategory).Load();
        // Once we have the assocaited data, we can output the category info with the product in a WriteLine.
        Console.WriteLine(product.ProductCategory.Name + ": " + product.Name + " costs " + product.SalePrice);
    }


    // EAGER LOADING
    // Eager loading includes ALL associated records for the entire data set. This can be a memory hog depending on your implementation.
    foreach (Product product in context.Products.Include(product => product.ProductCategory))
    {
        // Once we have the assocaited data, we can output the category info with the product in a WriteLine.
        Console.WriteLine(product.ProductCategory.Name + ": " + product.Name + " costs " + product.SalePrice);
    }


}
