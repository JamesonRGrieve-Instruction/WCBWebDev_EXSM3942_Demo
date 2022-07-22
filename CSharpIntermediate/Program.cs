// 2a
List<Person> people = new List<Person>()
{ 
    new Student("John", "Doe", 22, "1"),
    new Student("Jane", "Doe", 25, "00002"),
    new Teacher("Patty", "Poe", 40, 1),
    new Student("Todd", "Doe", 21, "S00003"),
    new Teacher("John", "Johnson", 45, 2),
    new Student("Hannah", "Doe", 26, "4"),
    new Student("Potato", "Doe", 28, "5")
};

// 2c
people = people.OrderBy(x => x.GetType().ToString()=="Teacher"?"1":"2" + x.LastName + x.FirstName).ToList();
/* TeacherJohnson
 * TeacherPoe
 * StudentDoe
 * StudentDoe
 * StudentDoe
 * StudentDoe
 * StudentDoe
 */
foreach (Person person in people)
{
    // 2bii
    if (person.GetType().ToString() == "Teacher")
    {
        Console.WriteLine("X"+((Teacher)person).StaffID.ToString("D5")+" - " + person.FirstName[0]+". "+person.LastName);
    }
    // 2bi
    else
    {
        Console.WriteLine(((Student)person).StudentID + " - " + person.FirstName + " " + person.LastName);
    }
}


// Abstract classes provide properties and methods to their children, but cannot be instantiated themselves.
// This means all classes that inherit from Pet will have Name and HumanAge implicitly.

// 1a
public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Age { get; set; }
}
// 1b
public class Student : Person
{
    public Student(string firstName, string lastName, int age, string studentID)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        StudentID = studentID;
    }
    private int _studentID;
    public string StudentID
    {
        get 
        {
            return "S" + _studentID.ToString("D5");
        }
        set
        {
            // Allows us to accept: "5", "00005" or "S00005" as valid values.
            string toSet = value.Trim().Trim('S');
            try
            {
                _studentID = int.Parse(toSet);
            }
            // Typically we wouldn't have Console IO in a class. I'm keeping this here to keep everything together.
            // Instead, you should let the exception leave the class, and catch it where the assignment is being made.
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
//1c
public class Teacher : Person
{
    public Teacher(string firstName, string lastName, int age, int staffID)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        StaffID = staffID;
    }
    public int StaffID { get; set; }
}