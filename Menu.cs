namespace OOP_Hotel
{
    internal static class Menu
    {
        static List<HotelBooking> Bookings { get; set; } = [];

        public static void PrintMenu()
        {
            Console.WriteLine("1. Skapa bokning");
            Console.WriteLine("2. Checka in");
            Console.WriteLine("3. Checka ut");
            Console.WriteLine("4. Visa bokning");
            Console.WriteLine("0. Avsluta");
        }

        public static bool RunProgram()
        {
            int choice = GetInputNumber();

            switch (choice)
            {
                case 1:
                    CreateBooking();
                    break;
                case 2:
                    CheckIn();
                    break;
                case 3:
                    CheckOut();
                    break;
                case 4:
                    ShowBooking();
                    break;
                case 0:
                    return false;
                default:
                    Console.WriteLine("Felaktig inmatning.");
                    break;
            }

            return true;
        }

        public static void CreateBooking()
        {
            Console.WriteLine("Skriv gästens namn:");
            string? name = Console.ReadLine();

            Console.WriteLine("Skriv gästens ankomstdatum:");
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Felaktig inmatning, ange datum.");
            }

            Console.WriteLine("Skriv antal nätter:");
            int daysToStay = GetInputNumber();

            var booking = new HotelBooking(name, date, daysToStay);
            Bookings.Add(booking);
        }

        public static void CheckIn()
        {
            int count = 0;

            Console.WriteLine("Vilken gäst vill du checka in?");
            foreach (var booking in Bookings)
            {
                Console.WriteLine($"{count + 1}. {booking.GuestName} Ankomst: {booking.StartDate:d}");
                count++;
            }

            int choice = GetInputNumber();
            Bookings[choice - 1].CheckIn = true;
        }

        public static void CheckOut()
        {
            int count = 0;

            Console.WriteLine("Vilken gäst vill du checka ut?");
            foreach (var booking in Bookings)
            {
                Console.WriteLine($"{count + 1}. {booking.GuestName} " +
                    $"Ankomst: {booking.StartDate:d}, " +
                    $"Avresa: {booking.EndDate:d}");
                count++;
            }

            int choice = GetInputNumber();
            Bookings[choice - 1].CheckIn = false;
            Bookings.RemoveAt(choice - 1);
        }

        public static void ShowBooking()
        {
            int count = 0;

            foreach (var booking in Bookings)
            {
                Console.WriteLine($"{count + 1}. {booking.GuestName} " +
                    $"Ankomst: {booking.StartDate:d}, " +
                    $"Avresa: {booking.EndDate:d}");
                count++;
            }
        }

        public static int GetInputNumber()
        {
            int choice;

            while(!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Felaktig inmatning, ange heltal.");
            }

            return choice;
        }
    }
}
