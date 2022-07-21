//Partial Solution to C# Pen OOP Exercise
//Note: this solution not exhaustive, but it contains a good portion of the exercise requirements

Pen myPen = new Pen();
myPen.Brand = "Bic";
myPen.InkColor = "Red";
myPen.MaxInk = 999;
myPen.HasLid = true;

Console.WriteLine(myPen.Brand);
Console.WriteLine(myPen.InkColor);
Console.WriteLine(myPen.MaxInk);
Console.WriteLine(myPen.HasLid);

myPen.Write();
Console.WriteLine(myPen.InkLevel + "%");

myPen.Write(100000);
Console.WriteLine(myPen.InkLevel + "%");

class Pen
{
    public string Brand;
    public string InkColor;
    public double InkLevel
    {
        get;
        private set;
    }
    public int MaxInk;
    public bool HasLid;
    public void Write()
    {
        int characters = 10;
        double consumedInk = 0.05 * characters;
        if ((MaxInk - consumedInk) > 0)
        {
            InkLevel = Math.Round(100 * ((MaxInk - consumedInk) / MaxInk), 2);
        }
        else
        {
            Console.WriteLine("Error: Insufficient Ink Level!");
        }
            
    }
    public void Write(int characterCount)
    {
        int characters = characterCount;
        double consumedInk = 0.05 * characters;
        if ((MaxInk - consumedInk) > 0)
        {
            InkLevel = Math.Round(100 * ((MaxInk - consumedInk) / MaxInk), 2);
        }
        else
        {
            Console.WriteLine("Error: Insufficient Ink Level!");
        }
    }
}

//(MaxInk - consumedInk) / MaxInk) => gives us a percentage
//so we can use an if statement to check if percentage is > 100
//if percentage is > 100, set percentage to 100
//else, do nothing