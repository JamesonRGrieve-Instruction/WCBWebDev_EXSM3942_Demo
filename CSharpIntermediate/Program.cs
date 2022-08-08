// Use our models namespace so we have access to the models and the dbcontext.
using CSharpIntermediate.Models;
using Microsoft.EntityFrameworkCore;


// SELECT Example
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
        // Explicit loading is sort of equivalent to a SELECT * and providing a specific primary key value (one query per record).
        // Now that we have our products stored in memory outside of the database, we can command ef to load the associated data for the product category.
        context.Entry(product).Reference(x => x.ProductCategory).Load();
        // SELECT * FROM ProductCategory WHERE ID IN (SELECT Product.CategoryID FROM Product WHERE Name = 'Milk');
        // Once we have the assocaited data, we can output the category info with the product in a WriteLine.
        Console.WriteLine(product.ProductCategory.Name + ": " + product.Name + " costs " + product.SalePrice);
    }


    // EAGER LOADING
    // Eager loading includes ALL associated records for the entire data set. This can be a memory hog depending on your implementation.
    // Eager loading is sort of equivalent to a SELECT * with a join to the target table (one query for everything).
    foreach (Product product in context.Products.Include(product => product.ProductCategory))
    // SELECT * FROM Product INNER JOIN ProductCategory ON ProductCategory.ID = Product.CategoryID;
    {
        // Once we have the assocaited data, we can output the category info with the product in a WriteLine.
        Console.WriteLine(product.ProductCategory.Name + ": " + product.Name + " costs " + product.SalePrice);
    }
}

// Not Mapped Property Example
// Even though ReorderNecessary is NotMapped, it references Mapped properties, so we need the context.
using (DatabaseContext context = new DatabaseContext())
{
    // 1. Defining List.
    // 2. Get All Products.
    // 3. Filter All Products.
    // 4. Add Filtered Products to List.
    // 5. Write Filtered Products to Console.
    foreach (Product product in context.Products.ToList().Where(product => product.ReorderNecessary).ToList()) Console.WriteLine("Please Reorder " + product.Name);
    // The first ToList() (or another translation out of DbSet/IQueryable) is required as ReorderNecessary is not in the database, meaning it will throw an exception when it tries to translate it to SQL.
}

// INSERT Example
string category, name;
decimal price;
int qoh;

Console.Write("Please enter the new product name: ");
name = Console.ReadLine().Trim();
Console.Write("Please enter the new product category: ");
category = Console.ReadLine().Trim();
Console.Write("Please enter the new product sale price: ");
price = decimal.Parse(Console.ReadLine());
Console.Write("Please enter the new product quantity on hand: ");
qoh = int.Parse(Console.ReadLine());
using (DatabaseContext context = new DatabaseContext())
{
    try
    {
        // EF automatically opens a transaction at the creation of the context.
        context.Products.Add(new Product(name, qoh, price)
        {
            ProductCategory = context.ProductCategories.Where(x => x.Name == category).Single()
        });
    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR: " + ex.Message);
    }
    // Commit Transaction
    context.SaveChanges();
}

// UPDATE Example
string oldname, newname;
Console.Write("Please enter the product name to update: ");
oldname = Console.ReadLine().Trim();
Console.Write("Please enter the new product name: ");
newname = Console.ReadLine().Trim();

using (DatabaseContext context = new DatabaseContext())
{
    context.Products.Where(x => x.Name == oldname).Single().Name = newname;

    context.SaveChanges();
}



string prodname;
int inventoryToAdd;
Console.Write("Please enter the product name to update: ");
prodname = Console.ReadLine().Trim();
Console.Write("Please enter the amount of product recieved: ");
inventoryToAdd = int.Parse(Console.ReadLine());

using (DatabaseContext context = new DatabaseContext())
{
    context.Products.Where(x => x.Name == prodname).Single().RecieveStock(inventoryToAdd);

    context.SaveChanges();
}