void ListCharacters(string theString)
{
    // Output: If the character we're looking at (first character) is not space, log it out.
    if (theString[0] != ' ') Console.WriteLine(theString[0]);
    // Loop: If the string has more than one character (there are characters we haven't logged), call the function again excluding the first character in the string.
    if (theString.Length > 1) ListCharacters(theString.Substring(1));
    
}

// By defaulting the current and previous parameters, the method can be called without them
// This allows someone using the method to pass only num, but we can use the defaults in the recursive calls.
void Fibbonacci(int num, int current = 0, int previous = 0)
{
    Console.WriteLine(current);
    // Because the first case will loop infinitely (0+0=0), we have to give it a bit of a kickstart.
        // The ternary statement in this case kicks current over to 1 if it's zero, which allows the current+previous to not get stuck at 0+0.
    if (num > 0) Fibbonacci(num-1, current>0?current+previous:1, current);

}

ListCharacters("Hello, World");

Fibbonacci(15);