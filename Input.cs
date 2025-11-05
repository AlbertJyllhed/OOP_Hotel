namespace OOP_Hotel
{
    internal static class Input
    {
        public static int GetInt()
        {
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Felaktig inmatning, ange heltal.");
            }

            return choice;
        }

        public static string GetString()
        {
            string? input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Felaktig inmatning, ange text.");
                input = Console.ReadLine();
            }

            return input.Trim();
        }
    }
}
