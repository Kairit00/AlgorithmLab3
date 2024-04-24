using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLab3
{
    internal class Person
    {
        // Characteristics of person with their type
        public string Name { get; set; }
        public int Id { get; set; }
        public string Occupation { get; set; }

        public Person(string name, int id, string occupation) // Person constructor
        {
            Name = name;
            Id = id;
            Occupation = occupation;
        }
        public override string ToString() => $"Namn: {Name}, Id: {Id}, Yrke: {Occupation}"; // Return the person's elemets
    }
}
