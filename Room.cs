namespace OOP_Hotel
{
    internal abstract class Room
    {
        public string RoomType { get; set; } = "Rum";
        public int RoomNumber { get; set; } = 1;
        public int PricePerNight { get; set; } = 1500;
        public int GuestCapacity { get; set; } = 1;
        public string[] Amenities { get; set; } = [];
        public bool Vacant { get; set; } = true;

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public virtual void PrintRoomInfo()
        {
            Console.WriteLine($"{RoomType} {RoomNumber}\n" +
                $"Pris per natt: {PricePerNight}\n" +
                $"Antal gäster: {GuestCapacity}\n" +
                $"Faciliteter:");

            foreach (string amenity in Amenities)
            {
                Console.WriteLine($"* {amenity}");
            }

            if (Vacant)
            {
                Console.WriteLine("Rummet finns att boka.");
            }
        }

        public int GetPriceForStay(int nights) => PricePerNight * nights;

        public bool CanBook(int guestAmount) => guestAmount < GuestCapacity && Vacant;
    }
}
