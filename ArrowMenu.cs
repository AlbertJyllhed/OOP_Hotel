using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP_Hotel
{
    internal class ArrowMenu
    {
        
        public int index;

        public List<string> menuchoices = new List<string>() { "1. Skapa bokning", "2. Checka in", "3. Checka ut","4.Visa bokning","\n5. Avsluta" };

        ConsoleKeyInfo Keypressed;


        public void MenuChoice()
        {
            Console.CursorVisible = false;
            Menu.ShowHeader();
            Console.WriteLine("Välkommen!\nVad vill du göra?\n");

            for (int index = 0; index < menuchoices.Count; index++)
            {
                if (index == 0)
                {

                    Console.Write(" " + menuchoices[index] + " <---\n");
                }
                else
                    Console.WriteLine(menuchoices[index]);

            }

            index = 0;

            do
            {
                Keypressed = Console.ReadKey();
                if (Keypressed.Key == ConsoleKey.UpArrow && index > 0)
                {
                    index--;
                    Console.Clear();
                    Menu.ShowHeader();
                    Console.WriteLine("Välkommen!\nVad vill du göra?\n");
                    for (int j = 0; j < menuchoices.Count; j++)
                    {
                        if (j == index)
                        {
                            Console.WriteLine(" " + menuchoices[index] + " <---");

                        }
                        else
                        {
                            Console.WriteLine(menuchoices[j]);
                        }
                    }

                }
                else if (Keypressed.Key == ConsoleKey.DownArrow && index < menuchoices.Count - 1)
                {
                    index++;
                    Console.Clear();
                    Menu.ShowHeader();
                    Console.WriteLine("Välkommen!\nVad vill du göra?\n");
                    for (int j = 0; j < menuchoices.Count; j++)
                    {
                        if (j == index)
                        {
                            Console.WriteLine(" " + menuchoices[index] + " <---");

                        }
                        else
                        {
                            Console.WriteLine(menuchoices[j]);
                        }
                    }
                }

            } while (Keypressed.Key != ConsoleKey.Enter);


        }

    }
}
