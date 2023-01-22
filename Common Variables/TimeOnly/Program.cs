
// Common variables -   TimeOnly


TimeOnly opensAt = TimeOnly.Parse(s: "08:00");

TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(opensAt);
Console.WriteLine(rightNow);