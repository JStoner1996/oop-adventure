using OOPAdventure;

Text.LoadLanguage(new English());

Console.WriteLine(Text.Language.ChooseYourName);

var name = Console.ReadLine();

if (name == string.Empty)
{
    name = Text.Language.DefaultName;
}

var player = new Player(name);

Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);

Actions.Instance.Register(new Go(house));

var run = true;

Room lastRoom = null;

// Main game loop
while (run)
{
    //  Check for room change and display room info
    if (lastRoom != house.CurrentRoom)
    {
        Console.WriteLine(house.CurrentRoom.ToString());
        lastRoom = house.CurrentRoom;

    }

    // Ask for player input
    Console.Write(Text.Language.WhatToDo);

    var input = Console.ReadLine().ToLower();

    // check if the player wants to quit
    if (input == Text.Language.Quit)
    {
        run = false;
    }
    else
    {
        Actions.Instance.Execute(input.Split(" "));
    }
}