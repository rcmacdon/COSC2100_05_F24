using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Demo_DataGrid_Inheritance_Abstraction.Classes
{

    /* Accessibility Levels
     * Public       - can be accessed from everywhere
     * Private      - can be access from the current class
     * Protected    - can be accessed from current class and parent-classes
     * Internal     - can be accesed from with the current namespace(assembly)
     */

    public abstract class Vehicle
    {
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearManufacture { get; set; }

        public Color Colour { get; set; }


        protected Vehicle() { }

        public Vehicle(string vin, string make, string model, int yearManufacture, Color colour)
        {
            Vin = vin;
            Make = make;
            Model = model;
            YearManufacture = yearManufacture;
            Colour = colour;
        }

        public override string ToString()
        {
            return YearManufacture.ToString() + ' ' + Make + ' ' + Model;
        }

    }
}
