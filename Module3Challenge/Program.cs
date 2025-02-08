using System;
class HungryAnimals
{
static void Main(string[] args)
{
// Step 1: Ask the user for the animal's hunger level
Console.Write("Enter the animal's hunger level (1-10): ");
int hungerLevel = Convert.ToInt32(Console.ReadLine());
// Step 2: If-Else Statement for Animal's Response
if (hungerLevel >= 8)
{
Console.WriteLine("Lion: Roar! I need a big meal!");
}
else if (hungerLevel >= 5)
{
Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
}
else
{
Console.WriteLine("Tortoise: Slow and steady - I'll have some lettuce.");
}
// Step 3: Ternary Operator for Animal Sound
string animalSound = (hungerLevel >= 8) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";
Console.WriteLine(animalSound);
// Step 4: Switch Statement for Zoo Days
Console.Write("\nEnter a day of the week (1-7): ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
case 1:
Console.WriteLine("It's Sunday Funday! Bring the whole family!");
break;
case 2:
Console.WriteLine("Join us for Tortoise Tuesday!");
break;
case 3:
Console.WriteLine("Wildlife Wednesday: Enjoy animal encounters!");
break;
case 4:
Console.WriteLine("Seniors get 10% off admission on Thursday!");
break;
case 5:
Console.WriteLine("Join us for Fun Fact Friday!");
break;
case 6:
Console.WriteLine("Super Saturday: Meet our zookeepers!");
break;
case 7:
Console.WriteLine("Lazy Sunday: Relax and enjoy the park!");
break;
default:
Console.WriteLine("Please enter a valid day (1-7).");
break;
}
}
}