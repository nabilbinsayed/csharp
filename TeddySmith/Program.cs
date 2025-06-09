string myName1 = "Nabil";
string myName2 = " Bin Sayed";

string FullName = myName1 + myName2;

Console.WriteLine(FullName);

Console.WriteLine($"My name is {FullName}");

string VName = FullName.Replace("Nabil", "Adel");

Console.WriteLine("My brother's name is " + VName);
Console.WriteLine($"My brother's name is {VName}");