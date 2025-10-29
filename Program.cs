namespace OOP_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.PrintMenu();
                Menu.ChooseMenuOption();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
