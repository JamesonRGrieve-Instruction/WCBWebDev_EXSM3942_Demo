MyFirstClass myFirstObject = new MyFirstClass();

myFirstObject.myCharProp = '!';

public class MyFirstClass
{ 
    // Constructor (instantiates the class).
    public MyFirstClass()
    {

    }
    public int myIntField;

    // Auto-implemented property (meaning there is no additional validation or formatting, or any other logic applied to the accessor/mutator).
    // It also hides the backing field.

    // Behind this is something like:
    // private string myStringField;
    public string myStringProp { get; set; }


    // Fully-implemented property:
    private char myCharField;
    public char myCharProp
    {
        get
        {
            return myCharField;
        }
        set
        {
            myCharField = value;
        }
    }
}


