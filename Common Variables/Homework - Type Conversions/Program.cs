
//  Common Variables    -   Homework - Type Conversions

/*
    Capture a user's age from the Console and then
    identify how old they will be in 25 years, as well
    as how old they were 25 years ago. Print that
    information to the Console in natural language.
*/


Console.WriteLine("Enter your current age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You are currently {age} years old.");
Console.WriteLine($"You will be {age + 25} years old in 25 years");
Console.WriteLine($"You were {age - 25} years old 25 years ago");