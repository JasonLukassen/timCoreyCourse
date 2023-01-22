//  Common Variables    -   Int


//  yes - 2, 18, 2854, -9
//  no  - 1.2, -5,7

//  Signed Int32
//  a signed Int can be +/- Two billion

//  Unsigned Int32
//  an Unsigned Int can be +/- 4 billion


//  a bit   = 0 or 1
//  a Byte  = 8 bits - 00000000 
//  think about turning lightswitched of and on.
//      0   = 2
//      00  = 4
//      000 = 8

int age = 0;

age = 43;

int ageInTenYears = age + 10;

//age = age + 10;
//age += 10;



Console.WriteLine($"You are {age} years old");
Console.WriteLine($"You are {age.ToString()} years old");

Console.WriteLine(ageInTenYears);

//  Don't divide ints   -   Console.WriteLine(age / 2);