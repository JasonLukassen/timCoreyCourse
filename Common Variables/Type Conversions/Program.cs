
//  Common Variables    -   Type Conversions


Console.Write(value: "What is your are: ");
string? ageText = Console.ReadLine();

//Console.WriteLine(ageText + 15);

//int age = int.Parse(ageText);

//int age;

bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine(value: $"This is valid: {isValidInt}. The number was {age}");

//Console.WriteLine(age + 15);

double testDouble = age;

decimal testDecimal = (decimal)testDouble;