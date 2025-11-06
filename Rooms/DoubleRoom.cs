namespace OOP_Hotel.Rooms
{
    internal class DoubleRoom : Room
    {
        public DoubleRoom(int roomNumber) : base(roomNumber)
        {
            RoomType = "Dubbelrum";
            PricePerNight = 1500;
            GuestCapacity = 2;
            Amenities = ["Gratis WiFi", "Minibar", "TV", "Telefon"];
            Vacant = true;
        }
    }
}
