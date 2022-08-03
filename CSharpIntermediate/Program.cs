// Initialize the variable to track where we are.
int count = 0; // Initialize
// Define the test condition that runs before every iteration.
while (count <= 100) // Test
{
    // Process the data (output it to the console).
    Console.WriteLine(count); // Process
    // Increment the variable that tracks where we are.
    count += 5; // Modify
}




void CountByFive(int current, int max)
{
    // Process the data (output it to the console).
    Console.WriteLine(current); // Process
    // Perform a test to determine whether subsequent iterations should run.
    if (current < max) // Test
    {
        // Call the subsequent iteration with a modified current value.
        CountByFive(current + 5 /* Modify */, max);
    }
}
// Call the first iteration, defining the starting value, and what the end value is (it never changes in subsequent iterations).
CountByFive(0 /* Initialize */, 100);