using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IHaveFeet
    {
        int GetNumberOfFeet();

    }
    interface IMakesNoise
    {

        string MakesNoise();


    }



    class Animal
    {
        private string _name;
        private double _weight;
        private char gender;

        public string Name { get; set; }
        public double Weight { get; set;}
        public char Gender { get; set; }

        public Animal(string name, double weight, char gender)
        {
            this.Name = name;
            this.Weight = weight;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return Name + this.GetType().Name + Weight + Gender;
        }
        

    }
}
