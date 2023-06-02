using System;

namespace EnumAndProperties
{
    internal class Person
    {
        private byte age;
        private int grade;
        // public string name;
        // public string address;
        private DateTime dob;

        // getter setter
        public byte Age
        {
            get { return age; }
            set
            {
                if (value > 30 && value < 40)
                {
                    age = value;
                }
            }
        }

        //Auto Implemented Properties 
        public int salary { get; set; }

        //Read-only Properties
        public char s { get; }

    }
}

