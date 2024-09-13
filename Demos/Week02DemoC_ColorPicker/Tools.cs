using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02DemoC_ColorPicker
{
    public static class Tools
    {

        private static Random random = new Random();

        public static int RandomInt (int min, int max)
        {
            return random.Next(min, max);
        }

        public static Color RandomColor()
        {
            return Color.FromArgb(255, RandomInt(0, 255), RandomInt(0,255), RandomInt(0,255));
        }



    }
}
