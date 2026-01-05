namespace OOPAdventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, What is your name?";
        DefaultName = "No name.";
        Welcome = "Welcome {0} to your OOP Adventure.";
        DefaultRoomName = "Room {0} ({1}, {2})";
        DefaultRoomDescription = "You are in a room with doors to the the {0}";
    }
}