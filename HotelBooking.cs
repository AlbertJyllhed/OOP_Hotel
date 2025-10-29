namespace OOP_Hotel
{
    internal class HotelBooking
    {
        //Vi skiter i fält
        //public string _guestname = "Guest";

        public DateTime StartDate { get; set; }
        public string GuestName { get; set; } = "Guest";

        public DateTime EndDate { get; set; }


        
        public HotelBooking(string guestname,DateTime startdate,int lenghtofstayindays)
        {
            GuestName = guestname;
            StartDate = startdate;
            EndDate = startdate.AddDays(lenghtofstayindays);

        }

        public void PrintInfo()
        {
            Console.WriteLine($"{GuestName}\nAnkomst:{StartDate.ToShortDateString()}\nAvresa:{EndDate.ToShortDateString()}");
        }

    }
}
