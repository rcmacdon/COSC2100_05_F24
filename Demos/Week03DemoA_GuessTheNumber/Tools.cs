/* COSC2100 - Week 3 Demo A
 * ________________
 * Sept 17, 2024
 * Contains various generic tools that we can use
 * */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03DemoA_GuessTheNumber
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
