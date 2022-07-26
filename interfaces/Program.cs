//Abstract vs Virtual
//Abstract methods do not provide code and derived classes MUST override the method
//Virtual methods can provide code, and derived classes CAN override the method

//Abstract Class Example:

/*Honda civic = new Honda();
civic.engine = "V-6";
civic.numWheel = 4;
civic.numDoor = 4;

Honda prelude = new Honda();
prelude.engine = "4 Cylinder";
prelude.numWheel = 4;
prelude.numDoor = 2;

abstract class Vehicle
{
    public string engine { get; set; }
    public int numWheel { get; set; }
    public int numDoor { get; set; }
    public abstract bool isCar();
}

class Honda : Vehicle
{
    public override bool isCar()
    {
        return true;
    }
}*/

//Virtual Example
//We cannot have an abstract method in a non-abstract class

/*Boeing_737 myPlane = new Boeing_737();
myPlane.engine = "CFM56";
myPlane.numWheel = 6;
myPlane.numDoor = 6;
Console.WriteLine(myPlane.isCar());

Toyota myCar = new Toyota();
Console.WriteLine(myCar.isCar());

class Vehicle
{
    public string engine { get; set; }
    public int numWheel { get; set; }
    public int numDoor { get; set; }
    public virtual bool isCar()
    {
        return true;
    }
}

class Honda : Vehicle
{

}

class Toyota : Vehicle
{

}
class Boeing_737 : Vehicle
{
    public override bool isCar()
    {
        return false;
    }
}*/

//Interfaces
//An interface is an abstract class which can only contain abstract properties and methods
//Interfaces cannot be used directly to make objects
//Much like abstract methods, interface methods cannot have bodies
//When an interface is inherited, all methods must be overridden
//By default, interface properties and methods are public and abstract
//A class can implement multiple interfaces

/*familyDoctor Bo = new familyDoctor();
Bo.name = "Bo";
Bo.age = 26;
Bo.businessAddress = "123 business park";
Bo.homeAddress = "789 home street";
Bo.yearsOfPractice = 5;
Console.WriteLine(Bo.isAdult());
Console.WriteLine(Bo.isExperienced());
interface person
{
    string name { get; set; }
    int age { get; set; }
    bool isAdult();
}

interface doctor
{
    string businessAddress { get; set; }
    string homeAddress { get; set; }
    int yearsOfPractice { get; set; }
    bool isExperienced();
}

class familyDoctor : person, doctor
{
    public string name { get; set; }
    public int age { get; set; }
    public string businessAddress { get; set; }
    public string homeAddress { get; set; }
    public int yearsOfPractice { get; set; }
    public bool isAdult()
    {
        if (age > 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isExperienced()
    {
        if (yearsOfPractice > 25)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}*/

//Difference between an abstract class and an interface?
//A class can only inherit from one abstract class
//A class can inherit from one OR more interfaces
//An abstract class can implement both abstract and non-abstract methods
//An interface must only have abstract methods
//An abstract class can use variables, fields, properties, and methods
//An interface can only use properties and methods
//An abstract class can have a constructor
//An interface cannot have a constructor
//An abstract class can have different access modifiers
//An interface has its members implicitly public (error if anything is NOT public)




