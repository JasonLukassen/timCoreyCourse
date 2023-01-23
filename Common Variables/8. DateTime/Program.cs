
//  Common Variables    -   DateTime


using System.Globalization;

//DateTime today = DateTime.Now;
DateTime today = DateTime.UtcNow;

//DateTime birthday = DateTime.Parse(s: "6/08/1998");

//DateTime birthday = DateTime.ParseExact("6/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);

//Console.WriteLine(birthday.ToString());


Console.WriteLine(today.ToString(format: "MMMM dd, yyyy HH:mm zzz"));

