// In-class: Create a class for a dog. It should have a property for a name (string), breed (string) and age (int).


Dog aDog = new Dog("Fido", "Golden Retriever", 3);

Console.WriteLine(aDog.Name + " has been alive for " + aDog.HumanAge + " years, which roughly equates to the maturity of a " + aDog.DogAge + " year old human.");


public class Dog { 
    public Dog(string name, string breed, int age)
    {
        Name = name;
        Breed = breed;
        HumanAge = age;
    }

    public string Name { get; set; }
    public string Breed { get; set; }
    public int HumanAge { get; set; }
   
    // Read-only (derived) properties are properties with no setter, they merely return a value derived from other values.
    public int DogAge
    {
        get
        {
            return 15 + ((HumanAge-1) * 5);
        }
    }
}
