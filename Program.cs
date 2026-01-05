using OOPAdventure;

Console.WriteLine("Hello, What is your name?");

var name = Console.ReadLine();

if (name == string.Empty)
{
    name = "No name.";
}

var player = new Player(name);

Console.WriteLine("Welcome {0}, to your OOP Adventure.", player.Name);