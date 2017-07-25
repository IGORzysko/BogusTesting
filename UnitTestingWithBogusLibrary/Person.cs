using System;
using System.ComponentModel.DataAnnotations;

namespace UnitTestingWithBogusLibrary
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Person(string name, string surname, string address)
        {
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
        }

        public enum Gender
        {
            Male,
            Female
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public Gender Sex { get; set; }

        public string Address { get; set; }

        public void DisplayData()
        {
            Console.WriteLine($"{Name}, {Surname}, {Sex}, {Address}");
        }
    }
}
