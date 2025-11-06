namespace OOP_Hotel
{
    internal class HotelBooking
    {
        public string GuestName { get; set; } = "Guest";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PricePerNight { get; set; } = 1500;
        public int LengthOfStayInDays { get; set; } = 0;
        public int TotalInvoice { get; set; }
        public bool CheckIn { get; set; } = false;
        public List<string> GuestWishList { get; set; } = [];

        public HotelBooking(string guestname, DateTime startdate, int lenghtofstayindays)
        {
            GuestName = guestname;
            StartDate = startdate;
            EndDate = startdate.AddDays(lenghtofstayindays);
            LengthOfStayInDays = lenghtofstayindays;
            TotalInvoice = LengthOfStayInDays * PricePerNight;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{GuestName}\nAnkomst:{StartDate.ToShortDateString()}\n" +
                $"Avresa:{EndDate.ToShortDateString()}\nTotalpris:{TotalInvoice}");
        }

        public void AddToWishlist()
        {
            Console.WriteLine("Har du något särskillt önskemål? Y/N");

            string? Wish = Console.ReadLine();
            GuestWishList.Add(Wish);
        }
    }
}
