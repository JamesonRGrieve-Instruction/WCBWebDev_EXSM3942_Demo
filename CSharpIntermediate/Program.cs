// In-class: Create a class for a dog. It should have a property for a name (string), breed (string) and age (int).

// Rather than having a separate variable for each pet, we can use a polymorphic list (a list of Pets, allowing both Dogs and Cats to be added since they inherit from Pet).
List<Pet> myPets = new List<Pet>();

// We can add Dogs and Cats to the list with no errors, the same way we would normally add single types.
myPets.Add(new Dog("Fido", "Golden Retriever", 2));
myPets.Add(new Dog("Max", "Black Labrador", 4));
myPets.Add(new Cat("Meowski", 2));

// When we foreach through the polymorphic list, we use the same (parent) type for which it was declared.
// Note that without casting, we can only access the properties of that parent (No Dog or Cat specific properties).
foreach (Pet thePet in myPets)
{
    string maturity = "0";
    // Take the current pet (thePet), get it's class name (GetType()), and convert that class name to a string (ToString()). 
    // That becomes either "Dog" or "Cat", which is easy to switch on, to access the correct property.
    // This is essential because if you try to cast a Dog as a Cat, it will make about as much sense to C# as it would to a vet if you showed up with a Black Lab and said it was a cat.
    switch (thePet.GetType().ToString())
    {
        case "Dog":
            // Once we determing that a given pet is a Dog, we can cast the Pet represenation to a Dog ( (Dog)thePet ).
            // From there, we have access to Dog properties, so we can take the DogAge, convert it to a string, and store it for output.
            maturity = ((Dog)thePet).DogAge.ToString();
            break;
        case "Cat":
            // The same is true of CatAge.
            maturity = ((Cat)thePet).CatAge.ToString();
            break;
        default:
            // Currently we only deal with Dogs and Cats, but we may add a third pet type in the future, and it's possible we might forget to add another case here.
            // This Exception ensures we don't have any funky behaviour, and it will very aggressively notify us if we try.
            throw new Exception("Cannot identify pet type.");
    }

    // Once we've got the maturity value for the pet, we can output it where we had DogAge / CatAge in our single object examples.
    Console.WriteLine(thePet.Name + " has been alive for " + thePet.HumanAge + " years, which roughly equates to the maturity of a " + maturity + " year old human.");
}


// Abstract classes provide properties and methods to their children, but cannot be instantiated themselves.
// This means all classes that inherit from Pet will have Name and HumanAge implicitly.

// 1a
public abstract class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Age { get; set; }
}
// 1b
public class Student : Person { 
    public Student(string firstName, string lastName, int age, string studentID)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        StudentID = studentID;
    }
    private int studentID;
    public string StudentID { get; set; }
}
//1c
public class Teacher : Person
{
    public Teacher(string firstName, string lastName, int age, int staffID)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        StaffID= staffID;
    }
    public int StaffID { get; set; }
}