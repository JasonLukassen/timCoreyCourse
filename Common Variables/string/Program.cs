//  Common Variables    -   String


//string decloration
string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Hong";
lastName = "Mow";
filePath = "C:\\Temp\\Demo"; 
filePath = @"C:\Temp\demo";

string testString = $@"The file for {firstName} is at C\SampleFiles";

//-----------------------------------------------------------------------------

//string interpolation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine(value: $"{firstName} {lastName}");
Console.WriteLine(testString);

