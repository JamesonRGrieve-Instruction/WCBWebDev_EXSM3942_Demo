char userChoice = '!';
double budget = 1000.00;
List<Product> inventory = new List<Product>() {
    new SimpleProduct("Potato Chips", 1.99, 0.50),
    new SimpleProduct("Toilet Paper", 6.75, 2.50),
    new SimpleProduct("Bunch of Bananas", 0.75, 0.11),
    new SimpleProduct("Can of Soda", 0.99, 0.45),
    new SimpleProduct("Bag of Gummy Bears", 2.50, 0.89)
};



do
{
    Console.Write("Welcome to The Store!\n----------\n1. Record Sale\n2. Check Inventory\n3. Restock Inventory\n4. Check Budget\n0. Exit\nPlease Select An Option: ");
    userChoice = Console.ReadKey().KeyChar;
    Console.Clear();

    switch (userChoice)
    {
        case '1':
            // Display list of products.
            // 1.a
            for (int i = 0; i < inventory.Count; i++) Console.WriteLine((i + 1) + ") " + inventory[i].ProductName + ", Price: " + inventory[i].SalePrice);
            // 1.a.i
            Console.Write("Please select a product number: ");
            try
            {
                Product chosenProduct = inventory[int.Parse(Console.ReadLine()) - 1];
                Console.Write("How many were sold?: ");
                int numSold = int.Parse(Console.ReadLine());
                chosenProduct.StockRemaining -= numSold;
                // 1.a.ii
                budget += chosenProduct.SalePrice * numSold;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid: "+ex.Message);
            }
            break;
        case '2':
            // 1.b
            for (int i = 0; i < inventory.Count; i++) Console.WriteLine((i + 1) + ") " + inventory[i].ProductName + ", " + inventory[i].StockRemaining, " remaining.");
            break;
        case '3':
            // 1.c
            for (int i = 0; i < inventory.Count; i++) Console.WriteLine((i + 1) + ") " + inventory[i].ProductName + ", " + inventory[i].StockRemaining, " remaining. Cost: "+ inventory[i].PurchasePrice);
            // 1.c.i
            Console.Write("Please select a product number: ");
            try
            {
                Product chosenProduct = inventory[int.Parse(Console.ReadLine()) - 1];
                Console.Write("How many to buy?: ");
                int numBought = int.Parse(Console.ReadLine());
                // 1.c.iii
                if (budget - chosenProduct.PurchasePrice * numBought < 0) throw new Exception("Not enough money!");
                // 1.c.ii
                budget -= chosenProduct.PurchasePrice * numBought;
                chosenProduct.StockRemaining += numBought;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid: " + ex.Message);
            }
            break;
        case '4':
            // d
            Console.WriteLine("Current Budget Balance: $" + budget);
            break;
        default:
            break;
    }
} while (userChoice != '0');


public abstract class Product
{
    public string ProductName { get; set; }
    public double SalePrice { get; set; }
    public double PurchasePrice { get; set; }
    private int _stockRemaining;
    public int StockRemaining
    {
        get
        {
            return _stockRemaining;
        }
        set
        {
            // 1.a.iv
            if (_stockRemaining == 0 && value < 0) throw new Exception("Product not available!");
            // If we don't have enough stock, throw an exception.
            // 1.a.iii
            if (value < 0) throw new Exception("Not enough stock!");
            // If no exception was thrown, set the value.
            _stockRemaining = value;
        }
    }

    void RemoveStock(int amount)
    {
        StockRemaining -= amount;
    }
    void AddStock(int amount)
    {
        StockRemaining += amount;
    }
}

public class SimpleProduct : Product
{
    public SimpleProduct(string name, double saleprice, double purchaseprice)
    {
        ProductName = name;
        SalePrice = saleprice;
        PurchasePrice = purchaseprice;
    }
}