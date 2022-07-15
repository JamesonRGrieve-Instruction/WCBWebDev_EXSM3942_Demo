//Access Modifiers

//Public: code is accessible for all classes, fields, methods, and properties

Dog myPet = new Dog();
Console.WriteLine(myPet.sound);
class Dog
{
    public string sound = "bark";       
}

//Private: code is accessible only within the same class

class Cat
{
    private string sound = "meow";
    static void Main(string[] args)
    {
        Cat myPet = new Cat();
        Console.WriteLine(myPet.sound);
    }
}

//Protected: code is accessible within the same class, or in an inherited class

//Value Type VS Reference Type
//Value type holds the data value in its own memory space, directly contains values
//Reference type stores the address where the value is being stored

char myLetter = 'a'; //value
string myName = "Bo"; //reference 
int myNum = 5; //value
string[] myGroceries = new string[] { "Bacon", "Cheese", "Eggs" }; //reference
class Horse
{
    public string sound = "neigh";
}; //reference
*/

//Reference type from one method to another, the system does not create a separate copy, so the original value
//will change
//Value type from one method to another, the system creates a separate copy, so the original value does
//not change

int number = 2;

static void doubler(int i)
{
    i = i * 2;
    Console.WriteLine(i);
}

Console.WriteLine(number);
doubler(number);
Console.WriteLine(number);

string[] students = new string[] { "Jane", "John", "Jones" };

foreach (string student in students)
{
    Console.WriteLine(student);
}

students[2] = "Jack";

foreach (string student in students)
{
    Console.WriteLine(student);
}

//Structs
//A struct is a value type data type that represents data structures
//Can contain constructors, constants, fields, methods, properties, operators

gpsCoordinates gps = new gpsCoordinates();
gps.setLocationNullIsland();

Console.WriteLine("Longitude:" + gps.longitude);
Console.WriteLine("Latitude:" + gps.latitude);

struct gpsCoordinates
{
    public int longitude { get; set; }
    public int latitude { get; set; }

    public void setLocationNullIsland()
    {
        longitude = 0;
        latitude = 0;
    }
}

//Objects with object properties

Car myCar = new Car();
Console.WriteLine(myCar.brand);
Car.Engine engine = new Car.Engine();
Console.WriteLine(engine.engineType);

class Car
{
    public string brand = "Ford";
    public string model = "F-150";
    public class Engine
    {
        public string engineType = "EcoBoost V-6";
        public int horsePower = 325;
    }
}

//Object Methods
//Object method is essentially a function within an object

studentRecord student1 = new studentRecord("Johnny", "C++", 60);
//Console.WriteLine(student1.finalGrade);
studentRecord student2 = new studentRecord("Tupac", "Rolling Weed", 22);
Console.WriteLine(student2);
class studentRecord
{
    public string name;
    public string program;
    public int finalGrade;

    public studentRecord(string name, string program, int finalGrade)
    {
        this.name = name;
        this.program = program;
        this.finalGrade = finalGrade;
    }

    public bool passedCourse()
    {
        if (finalGrade >= 70)
        {
            return true;
        }
        return false;
    }

    public override string ToString() //Overrides allow us to change the standard output 
    {
        return "Student name: " + name + "\nProgram: " + program + "\nPassed Course?: " + passedCourse();
    }

}








