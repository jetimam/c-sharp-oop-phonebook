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

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add Number | 2. Search Number | 3. Delete Number | 4. Quit PhoneBook");

                int menuInput = Convert.ToInt32(Console.ReadLine());

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
                        phoneBook.remove();
                        break;
                    default:
                        Console.WriteLine("Enter a valid input.");
                        break;
                }
            }
        }
    }
}
