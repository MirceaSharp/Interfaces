using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Elephant:Animal,IMakesNoise,IHaveFeet
    {

        public Elephant(string name, double weight, char gender) : base(name, weight, gender)
        {

        }

        public string MakesNoise()
        {
            return "elephant noise";
        }

        public int GetNumberOfFeet()
        {
            return 4;
        }

    }
}
