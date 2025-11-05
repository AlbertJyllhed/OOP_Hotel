namespace OOP_Hotel.Rooms
{
    internal class SingleRoom : Room
    {
        public SingleRoom(int roomNumber) : base(roomNumber)
        {
            RoomType = "Singelrum";
            PricePerNight = 800;
            GuestCapacity = 1;
            Amenities = ["Gratis WiFi", "Minibar", "Telefon"];
            Vacant = true;
        }
    }
}
