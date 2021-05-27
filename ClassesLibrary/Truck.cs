using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        //fields - N/A
        //props
        public float LoadCapacityLbs { get; set; }

        //ctors
        public Truck(string make, string model, int year, float weight, float loadCapacityLbs) : base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }
        public Truck()
        {

        }
        //methods
        public override string ToString()
        {
            return base.ToString() + "\nLoad Capacity: " + LoadCapacityLbs + "pounds.";
        }

    }
}
