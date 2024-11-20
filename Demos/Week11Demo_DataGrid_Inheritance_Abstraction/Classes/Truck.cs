using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Demo_DataGrid_Inheritance_Abstraction.Classes
{
    public class Truck : Vehicle
    {

        public int Gvw { get; set; }
        public int NumAxels { get; set; }
        public int TowingCapacity { get; set; }

        public Truck() : base() { }

        public Truck(string vin, string make, string model, int yearManufacture, Color colour, int gvw, int numAxels, int towingCapacity) : base(vin, make, model, yearManufacture, colour)
        {
            Gvw = gvw;
            NumAxels = numAxels;
            TowingCapacity = towingCapacity;
        }

    }
}
