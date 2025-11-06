namespace OOP_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine(" ██████╗  ██████╗ ██████╗     ██╗  ██╗ ██████╗ ████████╗███████╗██╗     \r\n██╔═══██╗██╔═══██╗██╔══██╗    ██║  ██║██╔═══██╗╚══██╔══╝██╔════╝██║     \r\n██║   ██║██║   ██║██████╔╝    ███████║██║   ██║   ██║   █████╗  ██║     \r\n██║   ██║██║   ██║██╔═══╝     ██╔══██║██║   ██║   ██║   ██╔══╝  ██║     \r\n╚██████╔╝╚██████╔╝██║         ██║  ██║╚██████╔╝   ██║   ███████╗███████╗\r\n ╚═════╝  ╚═════╝ ╚═╝         ╚═╝  ╚═╝ ╚═════╝    ╚═╝   ╚══════╝╚══════╝\r\n                                                                        ");
                //Menu.PrintMenu();
                //runProgram = Menu.RunProgram();
                //Console.ReadKey();
                //Console.Clear();
                ArrowMenu test = new ArrowMenu();
                test.MenuChoice();
            }
        }
    }
}
