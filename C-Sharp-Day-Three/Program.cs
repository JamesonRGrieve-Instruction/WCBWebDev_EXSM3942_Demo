﻿//Inheritance
//Base class: the class that is inherited from
//Derived class: the class that inherits from another class
//Tying back to ERDs, inheritance is an "is-a" relationship
//Multiple inheritance is not supported by C#, this means there can only be one base class per derived
//A "sealed" class ensures that other classes cannot inherit from the sealed class

//Inheritance

/*Surgeon mySurgeon = new Surgeon();
mySurgeon.braggingRights();
mySurgeon.name = "Bob";
mySurgeon.numOfSurgeriesCompeleted = 2;
Console.WriteLine(mySurgeon.numOfSurgeriesCompeleted);
class Doctor
{
    public string name;
    public void braggingRights()
    {
        Console.WriteLine("Call me doctor!");
    }
}

class Surgeon : Doctor
{
    public int numOfSurgeriesCompeleted;
}

class Dentist : Doctor
{
    public int numOfTeethCleaned;
}*/

//Polymorphism
//Polymorphism is the ability of a single class to have multiple implementations with the same name
//Static Polymorphism: same method names with different parameters
//Static Polymorphism Example:

/*Multiplier myMultipier = new Multiplier();
Console.WriteLine(myMultipier.multiply(2, 3, 4));
Console.WriteLine(myMultipier.multiply(2, 3));
class Multiplier
{
    public int multiply (int first, int second)
    {
        return first * second;
    }
    public int multiply (int first, int second, int third)
    {
        return first * second * third;
    }
}*/

//Dynamic Polymorphism: create abstract classes that provide partial implementation of a class
//Dynamic Polymorphism Example:

Surgeon mySurgeon = new Surgeon();
mySurgeon.braggingRights();

class Doctor
{
    public string name;
    public void braggingRights()
    {
        Console.WriteLine("Call me doctor!");
    }
}

class Surgeon : Doctor
{
    public int numOfSurgeriesCompleted;
    public void braggingRights()
    {
        Console.WriteLine("Call me doctor death!");
    }
}

