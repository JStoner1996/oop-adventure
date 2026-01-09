namespace OOPAdventure;

public partial class House
{
    private int CalculateRoomIndex(int c, int r)
    {
        // Clamp to allow -1 for out of bounds checks
        return Math.Clamp(c, -1, Width) + Math.Clamp(r, -1, Height) * Width;
    }

    public void CreateRooms(int width, int height)
    {
        Width = Math.Clamp(width, 2, 10);
        Height = Math.Clamp(height, 2, 10);

        var total = Width * Height;

        Rooms = new Room[total];

        // For loop to create rooms
        for (var i = 0; i < total; i++)
        {
            // Create a temporary room
            var tmpRoom = new Room();

            // Calucate column and row of new room
            var c = i % Width;
            var r = i / Width;

            // create unique name for new room
            tmpRoom.Name = String.Format(Text.Language.DefaultRoomName, i, c, r);


            //calculates neighbours
            if (c < Width - 1)
            {
                tmpRoom.Neighbours[Directions.East] = CalculateRoomIndex(c + 1, r);
            }

            if (c > 0)
            {
                tmpRoom.Neighbours[Directions.West] = CalculateRoomIndex(c - 1, r);
            }

            if (r < Height - 1)
            {
                tmpRoom.Neighbours[Directions.South] = CalculateRoomIndex(c, r + 1);
            }
            if (r > 0)
            {
                tmpRoom.Neighbours[Directions.North] = CalculateRoomIndex(c, r - 1);
            }

            Rooms[i] = tmpRoom;
        }
    }
}