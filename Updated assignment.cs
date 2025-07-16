Console.WriteLine("Please put in your name");
string? myName = Console.ReadLine();

int i = 0;

foreach (char c in myName)
{
    i++;
}
Console.WriteLine("The number of characters in your name is " + i);




/**string myName = "tobechukwu";
int i = 0;

foreach (char c in myName)
{
    i++;
}

Console.WriteLine("The number of characters is " + i); **/