void ListCharacters(string theString)
{
    // Output: If the character we're looking at (first character) is not space, log it out.
    if (theString[0] != ' ') Console.WriteLine(theString[0]);
    // Loop: If the string has more than one character (there are characters we haven't logged), call the function again excluding the first character in the string.
    if (theString.Length > 1) ListCharacters(theString.Substring(1));
    
}


void Fibbonacci(int num, int current = 0, int previous = 0)
{
    if (current == 0 && previous == 0)
    {
        Console.WriteLine(0);
        Fibbonacci(num-1, 1, 0);
    }
    else
    {
        Console.WriteLine(current);
        if (num > 0) Fibbonacci(num - 1, current + previous, current);
    }
}

ListCharacters("Hello, World");

Fibbonacci(15);