using System.Text;

namespace OOPAdventure;

public class Room
{
    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;

    public Dictionary<Directions, int> Neighbours { get; set; } = new()
    {
        { Directions.North, -1  },
        { Directions.East, -1 },
        { Directions.South, -1 },
        { Directions.West, -1 },
        { Directions.None, -1 },
    };

    public bool Visited { get; set; }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        if (Visited)
        {
            stringBuilder.Append(string.Format(Text.Language.RoomOld, Name));
        }
        else
        {
            stringBuilder.Append(string.Format(Text.Language.RoomNew, Name));
        }

        var names = Enum.GetNames(typeof(Directions));

        // Get available directions 
        var directions = (from p in names where Neighbours[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p.ToLower()).ToArray();

        var description = string.Format(Description, Text.Language.JoinedWordList(directions, Text.Language.And));

        stringBuilder.Append(description);

        return stringBuilder.ToString();
    }
}