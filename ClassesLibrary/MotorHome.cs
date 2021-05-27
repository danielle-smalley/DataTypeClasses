using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesLibrary
{
    public class MotorHome : Vehicle //MotorHome is now a child of Vehicle and will inherit everything but ctor
    {
        //fields - N/A

        //props
        public int NumberOfBeds { get; set; } //we inherited props from Vehicle, so only needed to add NumberofBeds

        //ctors
       // public MotorHome(int numberOfBeds) : base(make, model, year, weight) - PROBLEM - when I formatted it this way, it showed the datatypes for Vehicle, yet when I put them in it said they don't exist here.
       public MotorHome(string make, string model, int year, float weight, int numberOfBeds) : base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }
        //methods
        public MotorHome()
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nNumber of Beds: " + NumberOfBeds + "\n";
        }

    }//end class
}//end namespace
