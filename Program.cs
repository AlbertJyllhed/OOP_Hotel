namespace OOP_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelBooking test = new HotelBooking("Kalle", DateTime.Now, 21);
            test.PrintInfo();
        }
    }
}
