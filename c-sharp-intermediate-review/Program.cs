//C# General Review

//code up here, can access name
//code up here, cannot access age
/*class Person
{
    public string name;
    //code in here, can access name
    private int age = 18;
    //code in here, can access age
    
}*/

//code down here, can access name
//code down here, cannot access age

//Inheritance
//Inheritance saves us from having to write repeated code

/*Honda myHonda = new Honda();
myHonda.motor = "2.5 Litre";
Console.WriteLine(myHonda.motor);

Sierra mySierra = new Sierra();
mySierra.convertible = true;    
Console.WriteLine(mySierra.convertible);
class Vehicle
{
    public string motor;
    public int numWheels;
}

class Honda : Vehicle
{
    public bool convertible;
}

class Sierra : Honda
{
    public bool box;
}*/

//Polymorphism 

//Static Polymorphism
/*Adder myAdder = new Adder();
myAdder.adder(1,1);
class Adder
{
    public int adder (int first, string second)
    {
        return first;
    }
    public int adder (int first, int second)
    {
        return (first + second);
    }
    public int adder (int first, int second, int third)
    {
        return (first + second + third);
    }
}*/

//Dynamic Polymorphism

/*DeathStar myDeathStar = new DeathStar();
Console.WriteLine(myDeathStar.name);
myDeathStar.name = "Galactic Terror";
Console.WriteLine(myDeathStar.name);
class SpaceStation
{
    public string name;
    public int stationCapacity;
    public virtual void fireLaser()
    {
        Console.WriteLine("Pew pew");
    }
}

class DeathStar : SpaceStation
{
    public override void fireLaser()
    {
        Console.WriteLine("Zoom zoom");
    }
}

//A sealed class cannot be inherited by any other class
//Abstract vs Virtual Methods
//Abstract methods do not provide code, so the derived classes MUST override the method
//Virtual methods CAN provide, so the derived classes CAN override the method

abstract class Car
{
    public int numDoors;
    public string engineType;
    public int numWheels;
}*/

//String Interpolation
/*string carName = "Ford";
string ownerName = "Kristian";
string modelType = "Model-T";

string introduction = $"{ownerName} owns a {carName} {modelType}.";
Console.WriteLine(introduction);
string introduction2 = ownerName + " owns a " + carName + " " + modelType + ".";
Console.WriteLine(introduction2);*/

//Property stores information
//Method stores a function
//Public means that a property or method can be accessed by all parts of your program
//Private means that a property or method can ONLY be accessed by the class itself
//When you want to openly change and read from a property or method, use public
//When you want to keep a property or method hidden, use private



/*Car myCar = new Car();
myCar.CarBrand = "Honda";
Console.WriteLine(myCar.CarBrand);
myCar.CarBrand = "Toyota";
myCar.CarBrand = "Honda";
class Car
{
    private string carBrand;
    public string CarBrand
    {
        get { return carBrand; }
        set { carBrand = value; }
    }
}*/

//C# Switch

/*int myChoice = 2000;
switch (myChoice)
{
    case 1:
        Console.WriteLine("Hello World");
        break;
    case 2:
        Console.WriteLine("Goodbye");
        break;
    default:
        Console.WriteLine("Invalid choice! Please try again");
        break;
}*/








