namespace OOPAdventure;

public class Go : Action
{
    // Override the Go action name
    public override string Name => Text.Language.Go;


    // Gets the reference to the house
    private readonly House _house;

    // Constructor to initialize the house reference
    public Go(House house)
    {
        _house = house;
    }

    public override void Execute(string[] args)
    {
        var currentRoom = _house.CurrentRoom;

        // Clean up the direction input, e.g., "north" -> "North"
        var dir = args[1].Substring(0, 1).ToUpper() + args[1].Substring(1).ToLower();

        // Convert the string to the Directions enum, failed sets direction to None
        Enum.TryParse(dir, out Directions newDirection);


        // Gets index of the next room in the specified direction
        var nextRoomIndex = currentRoom.Neighbours[newDirection];

        // Check to see if the next room index is valid
        if (nextRoomIndex == -1 | newDirection == Directions.None)
        {
            Console.WriteLine(Text.Language.GoError);
        }
        else
        {
            // Move to the next room
            _house.GoToRoom(nextRoomIndex);
        }

    }

}