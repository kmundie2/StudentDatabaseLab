
static void Main(string[] args)
{

}

string[] name = new string[9] { "Mike", "Joe", "Bob", "TJ", "Alex", "Sarah", "Bill", "Eric", "David" };
string[] hometown = new string[9] { "Detroit", "Grand Rapids", "Ann Arbor", "Chicago", "New York", "Miami", "Los Angeles", "Houston", "Atlanta" };
string[] favoriteFood = new string[9] { "Pizza", "Wings", "Tacos", "Apples", "Burgers", "Steak", "Fries", "Chicken", "Chips" };


Console.WriteLine("Welcome!");
Console.WriteLine("");
Console.WriteLine("Which student would you like to learn more about? Please enter a number 1 thru 9: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int studentNumber) && studentNumber >= 1 && studentNumber <= name.Length)
{
    int index = studentNumber - 1;

    Console.WriteLine($"Student {studentNumber}: {name[index]}");

    Console.Write("Enter 'Hometown' or 'Favorite Food': ");
    string info = Console.ReadLine();

    if (info.Equals("Hometown", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Hometown: {hometown[index]}");
    }
    else if (info.Equals("Favorite Food", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Favorite Food: {favoriteFood[index]}");
    }
    else
    {
        Console.WriteLine("Invalid submission. Please enter 'Hometown' or 'Favorite Food'.");
    }

    Console.Write("Would you like to learn about another student? (yes/no): ");
    string student2 = Console.ReadLine();
    if (student2.Equals("yes", StringComparison.OrdinalIgnoreCase))
    {
        Main(args);
    }
    else
    {
        Console.WriteLine("Okay. Goodbye!");
    }
}
else
{
    Console.WriteLine("Invalid student number. Please enter a number between 1 and 9.");
}

Console.ReadKey();