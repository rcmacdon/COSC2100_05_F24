using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Demo_DataGrid_Inheritance_Abstraction.Classes
{
    public class Car : Vehicle
    {
        public string BodyType { get; set; }
        public int NumDoors { get; set; }

        public Car() : base() { 
        
        }

        public Car(string vin, string make, string model, int yearManufacture, Color colour, string bodyType, int numDoors) : base(vin, make, model, yearManufacture, colour)
        {
            BodyType = bodyType;
            NumDoors = numDoors;
        }

        public override string ToString()
        {
            return base.ToString() + ' ' + BodyType ;

        }
    }
}
