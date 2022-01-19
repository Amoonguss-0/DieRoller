using DieRoller;

Die myDie = new Die(); // when a die is created, a random FaceValue should be set
byte currentValue = myDie.FaceValue;
Console.WriteLine("Do you want to roll a die type (y/n)");
string input1 = Console.ReadLine();
while (input1 != "n")
{
    myDie.Roll();
    Console.WriteLine("Do you want to hold? (y/n)");
    string input2 = Console.ReadLine();
    if (input2 == "y")
    {
        myDie.IsHeld = true;
        Console.WriteLine(myDie.FaceValue);
    }
    if (input2 == "n"){
        myDie.IsHeld= false;
        Console.WriteLine(myDie.FaceValue);
    }
    Console.WriteLine("Do you want to roll a die type (y/n)");
    input1 = Console.ReadLine();
}
if (input1 == "n")
{
    Console.WriteLine("Ok See you later");
}

Console.ReadKey();