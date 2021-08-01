using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice
{
    class Info : PhoneBook
    {
        string name, num;

        public Info(string name, string num)
        {
            this.name = name;
            this.num = num;
        }

        public override string ToString()
        {
            string str = "";

            str += "Name: " + this.name + ", Number: " + this.num;

            return str;
        }
        
        public string getName()
        {
            return this.name;
        }

        public string getNum()
        {
            return this.num;
        }
        
    }
}
