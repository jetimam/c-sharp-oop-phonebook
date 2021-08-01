using System;
using System.Collections;

namespace OOP_Practice
{
    class Start
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            string name, num, searchIndex;
            int menuInput, removeIndex;

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add contact | 2. Search contacts | 3. Show all contacts | 4. Remove contact | 5. Quit phone book");

                menuInput = Convert.ToInt32(Console.ReadLine());

                switch (menuInput)
                {
                    case 1:
                        name = Utils.stringInput("Please enter the name of the contact.");
                        num = Utils.stringInput("Please enter the number of the contact.");

                        phoneBook.add(name, num);

                        break;
                    case 2:
                        searchIndex = Utils.stringInput("Please enter what index you wish to search.");

                        phoneBook.search(searchIndex);

                        break;
                    case 3:
                        Console.WriteLine(phoneBook);

                        break;
                    case 4:
                        Console.WriteLine(phoneBook);

                        removeIndex = Utils.intInput("Please enter the index of the contact.") - 1;
                        
                        phoneBook.remove(removeIndex);

                        break;
                    case 5:
                        System.Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine("Enter a valid input.");
                        break;
                }
            }
        }
    }
}
