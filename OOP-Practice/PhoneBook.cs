using System;
using System.Collections;
using System.Text;

namespace OOP_Practice
{
    class PhoneBook
    {
        ArrayList contacts = new ArrayList();

        public override string ToString()
        {
            string str = "";
            int counter = 1;

            foreach (Info contact in contacts)
            {
                str += counter + ". " + contact + "\n";
                counter++;
            }

            return str;
        }

        public void add(string name, string num)
        {
            contacts.Add(new Info(name, num));
        }

        public void search(string index)
        {
            ArrayList searchResults = new ArrayList();
            string substring;
            int cap = 1;

            foreach (Info contact in contacts)
            {
                for (int i = 1; i < contact.getName().Length - 1; i++)
                {
                    for (int j = 0; j < cap && cap < contact.getName().Length - 1; j++)
                    {
                        substring = contact.getName().Substring(j, i);
                        cap++;
                        if (index == substring.ToLower())
                        {
                            searchResults.Add(contact);
                        }
                    }
                    cap = 1;
                }
            }
            Console.WriteLine(searchDisplay(searchResults));
        }

        public string searchDisplay(ArrayList searchResults)
        {
            string str = "";
            int counter = 1;

            foreach (Info result in searchResults)
            {
                str += counter + ". " + result + "\n";
                counter++;
            }

            return str;
        }


        public void remove(int index)
        {
            Console.WriteLine(contacts[index] + " has been deleted.");
            contacts.RemoveAt(index);
        }

    }
}
