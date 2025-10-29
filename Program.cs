namespace OOP_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = Menu.RunProgram();

            while (runProgram)
            {
                Menu.PrintMenu();
                runProgram = Menu.RunProgram();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
