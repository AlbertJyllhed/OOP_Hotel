using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP_Hotel
{
   internal class Guest
   {
      static List<Guest> guests = new List<Guest>();

      private static int _idCounter = 0;
      public string FirstName { get; set; } = "FirstName";
      public string LastName { get; set; } = "LastName";
      public int PhoneNumber { get; set; } = 000;
      public string Email { get; set; } = "@";
      public int CustomerId { get; }

      public Guest(string firstName, string lastName, int phoneNumber, string email)
      {

         FirstName = firstName;
         LastName = lastName;
         PhoneNumber = phoneNumber;
         Email = email;

         CustomerId = ++ _idCounter;
      }

      public static void CreateGuestCard()
      {
         Console.Write("Förnamn:");
         string firstName = Console.ReadLine();
         Console.Write("Efternamn:");
         string lastName = Console.ReadLine();
         Console.Write("TelefonNr:");
         int phone;
         while(!int.TryParse(Console.ReadLine().Trim(), out phone))
         {
            Console.WriteLine("Ogiltigt format på telefonnummer.\nEndast siffror");
         }

         string email = "";
         bool correctEmail = false;
         while (!correctEmail)
         {
            Console.Write("Email:");
            email = Console.ReadLine();

            if (email.Contains("@"))
            {
               correctEmail = true;
               break;
            }
            Console.WriteLine("Ogiltigt format");
         }
         
         var guest = new Guest(firstName,lastName,phone,email);
         guests.Add(guest);
         Console.WriteLine("Kundkortskapat");
         Console.WriteLine($"Gäst:{guest.FirstName} {guest.LastName}\nTel: {guest.PhoneNumber}\n" +
            $"Email: {guest.Email}\nKund Id: {guest.CustomerId}");

         Console.WriteLine("Vill du ska en reservation med gästkortet? y/n");
         string input = Console.ReadLine().ToLower();
         if(input == "y")
         {
            Menu.CreateReservationFromGuestCard(guest);
         }

      }

     

      public static void ShowGuests()
      {
         Console.WriteLine("Gäst info");
         foreach(var guest in guests)
         {
            Console.WriteLine($"Gäst:{guest.FirstName} {guest.LastName}\nTel: {guest.PhoneNumber}\n" +
            $"Email: {guest.Email}\nKund Id: {guest.CustomerId}");
         }
      }

      public static void SearchGuest()
      {
         List<Guest> match = new List<Guest>();
         

         Console.WriteLine("Ange gästens förnamn:");
         string firstName = Console.ReadLine();

         Console.WriteLine("Ange gästens efternamn:");
         string lastName = Console.ReadLine();
         int count = 0;

         for(int i = 0; i < guests.Count; i++)
         {
            if (guests[i].FirstName == firstName && guests[i].LastName == lastName)
            {
               match.Add(guests[i]);
            }
         }

         foreach(var guest in match)
         {
            count++;
            Console.WriteLine($"{count}{guest.FirstName} {guest.LastName} {guest.Email}");
         }
         Console.WriteLine("Ange vilken gäst du önskar boka för:");
         int input = Menu.GetInputNumber();

         
         Menu.CreateReservationFromGuestCard(match[input - 1]);
      }
      

   }
}
