namespace OOP_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelBooking test = new HotelBooking("Kalle", DateTime.Now, 2);
            test.PrintInfo();
        }
    }
}
