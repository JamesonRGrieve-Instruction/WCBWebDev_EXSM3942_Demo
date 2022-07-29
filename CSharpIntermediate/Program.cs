// Object Instantiation
Person johnPerson = new Person()
{
    FirstName = "John",
    LastName = "Doe",
    Age = 30,
    BirthDate = new DateOnly(1992, 1, 1)
};

Person janePerson = new Person()
{
    FirstName = "Jane",
    LastName = "Doe",
    Age = 29,
    BirthDate = new DateOnly(1993, 2, 2)
};

// Object Variable Assignment (Reference)
Person a = janePerson;
Person b = janePerson;

// Object Property Mutation
a.FirstName = "Joan";
// Object Property Access
Console.WriteLine(b.FirstName);

// Class Declaration
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Age { get; set; }

    public DateOnly BirthDate { get; set; }
}

