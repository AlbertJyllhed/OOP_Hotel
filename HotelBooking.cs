namespace OOP_Hotel
{
    internal class HotelBooking
    {
        //Vi skiter i fält
        //public string _guestname = "Guest";

        public DateTime StartDate { get; set; }
        public string GuestName { get; set; } = "Guest";

        public DateTime EndDate { get; set; }

        public int Pricepernight { get; set; } = 1500;

        public int Lenghtofstayindays { get; set; } = 0;

        public int Totalinvoice { get; set; }

        public bool Checkin { get; set; } = false;

        public List<string> Guestwishlist = new List<string>();


        public HotelBooking(string guestname, DateTime startdate, int lenghtofstayindays)
        {
            GuestName = guestname;
            StartDate = startdate;
            Lenghtofstayindays = lenghtofstayindays;
            EndDate = startdate.AddDays(lenghtofstayindays);
            Totalinvoice = Lenghtofstayindays * Pricepernight;

        }

        public void PrintInfo()
        {
           
            Console.WriteLine($"{GuestName}\nAnkomst:{StartDate.ToShortDateString()}\n" +
                $"Avresa:{EndDate.ToShortDateString()}\nTotalpris:{Totalinvoice}");
        }

        public void AddToWishlist()
        {
            Console.WriteLine("Har du något särskillt önskemål? Y/N");

           

            string Wish=Console.ReadLine();
            Guestwishlist.Add(Wish);

        }

    }
}
