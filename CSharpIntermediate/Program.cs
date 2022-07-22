Console.WriteLine("Loop Example");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("Recursive Example");
void Count(int start, int end)
{
    Console.WriteLine(start);
    if (start < end) Count(start + 1, end);
    Console.WriteLine("End: " + start);
}
Count(1, 5);

Console.WriteLine("Visual Code Example");
Console.WriteLine(1);
    Console.WriteLine(2);
        Console.WriteLine(3);
            Console.WriteLine(4);   
                Console.WriteLine(5);
                Console.WriteLine("End: " + 5);
            Console.WriteLine("End: " + 4);
        Console.WriteLine("End: " + 3);
    Console.WriteLine("End: " + 2);
Console.WriteLine("End: " + 1);



void Test()
{
    Console.WriteLine("Hello");
    Test2(); // Calls line 23.
} // Passes back to after 26.

void Test2()
{
    Console.WriteLine("World");
} // Passes back to after 20.

Test(); // Calls line 17.