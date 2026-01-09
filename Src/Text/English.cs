namespace OOPAdventure;

// English language implementation
public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, What is your name?";
        DefaultName = "No name.";
        Welcome = "Welcome {0} to your OOP Adventure.";
        DefaultRoomName = "Room {0} ({1},{2})";
        DefaultRoomDescription = " You are in a room with doors to the the {0}.";
        ActionError = "You can't do that.";
        Go = "Go";
        GoError = "You can't go that way.";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
        RoomNew = "You entered {0}.";
        RoomOld = "You return to {0}.";
        And = "and";
        Comma = ",";
        Space = " ";
    }
}