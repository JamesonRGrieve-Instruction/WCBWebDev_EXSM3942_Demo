mySpaceStation bobmarley1 = new mySpaceStation();
bobmarley1.spaceStationLocation = "Wyoming";
bobmarley1.spaceStationSize = 5.5;
bobmarley1.spaceStationCapacity = 60000;
bobmarley1.shieldIntegrity = -0.1;
Console.WriteLine(bobmarley1);

abstract class SpaceStation
{
    public string spaceStationLocation { get; set; } 
    public double spaceStationSize { get; set; } 
    public int spaceStationCapacity { get; set; }
    public abstract string fireLaser();
}

class DeathStar : SpaceStation
{
    public int exhaustPorts { get; set; }
    public override string fireLaser()
    {
        return "Bom bom!";
    }
    public override string ToString()
    {
        return "The Death Star is currently at: " + spaceStationLocation + "." +
            "\nIt is " + spaceStationSize + " kilomters in length and can hold " +
            spaceStationCapacity + " individuals." +
            "\nThere are " + exhaustPorts + " exhaust ports on this space station." +
            "\nWhen I fire its laser, it makes the sound " + fireLaser();
    }
}

class ISS : SpaceStation
{
    public int shieldGenerator { get; set; }
    public override string fireLaser()
    {
        return "Bzz bzz!";
    }
    public override string ToString()
    {
        return "The ISS is currently at: " + spaceStationLocation + "." +
            "\nIt is " + spaceStationSize + " kilomters in length and can hold " +
            spaceStationCapacity + " individuals." +
            "\nThere are " + shieldGenerator + " shield generators on this space station." +
            "\nWhen I fire its laser, it makes the sound " + fireLaser();
    }
}

class mySpaceStation : SpaceStation
{
    public double shieldIntegrity { get; set; }
    public bool destroyed()
    {
        if (shieldIntegrity <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public override string fireLaser()
    {
        return "Pew pew!";
    }
    public override string ToString()
    {
        return "My space station is currently at: " + spaceStationLocation + "." +
            "\nIt is " + spaceStationSize + " kilomters in length and can hold " +
            spaceStationCapacity + " individuals." +
            "\nShield integrity is at " + shieldIntegrity + "%" +
            "\nSpace Station Destroyed?: " + destroyed() +
            "\nWhen I fire its laser, it makes the sound " + fireLaser();
    }
}


