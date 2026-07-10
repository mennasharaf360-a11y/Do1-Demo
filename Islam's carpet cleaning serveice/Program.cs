int smallPrice = 25;
int largePrice = 35;
double taxRate = 0.06;

Console.WriteLine("Islam's Carpet Cleaning Service");
Console.WriteLine("Charges:");
Console.WriteLine("$25 per small");
Console.WriteLine("$35 per large");
Console.WriteLine("Sales tax rate is 6%");
Console.WriteLine("Estimates are valid for 30 days ");

Console.WriteLine();
Console.Write("Number of small carpets: ");
string numberSmallInput = Console.ReadLine();
int numberSmall = Convert.ToByte(numberSmallInput);

Console.Write("Number of large carpets: ");
string numberLargeInput = Console.ReadLine();
int numberLarge = Convert.ToByte(numberLargeInput);

double cost = (numberSmall * smallPrice) + (numberLarge * largePrice);
double tax = cost * taxRate;
double total = cost + tax;

Console.WriteLine();
Console.WriteLine("Estimate for carpet cleaning service");
Console.WriteLine("Number of small carpets: " + numberSmall);
Console.WriteLine("Number of large carpets: " + numberLarge);
Console.WriteLine("Price per small room: $" + smallPrice);
Console.WriteLine("Price per large room: $" + largePrice);
Console.WriteLine("Cost: $" + cost);
Console.WriteLine("Tax: $" + tax);
Console.WriteLine("============================");
Console.WriteLine("Total estimate: $" + total);
Console.WriteLine("This estimate is valid for 30 days");

