using System;

namespace OOP
{
    public abstract class Animal : Object
    {
        private readonly DateTime _dateOfBirth;

        protected Animal(DateTime dateOfBirth, string name)
        {
            Console.WriteLine("Creating an animal");

            if (dateOfBirth > DateTime.Now)
            {
                throw new Exception("Date of birth has to be in the past");
            }

            _dateOfBirth = dateOfBirth;
            Name = name;
        }

        public string Name { get; }

        public int Age { get => (int)((DateTime.Now - _dateOfBirth).TotalDays / 365); } // not considered years with 366 days.

        public abstract void Voice();

        public override string ToString()
        {
            return $"Name: {Name}; Age: {Age}";
        }

        protected virtual void SpecialAction()
        {
            Console.WriteLine("Has brain");
        }
    }
}
