using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterManager.WebMVC.Helpers
{
    public static class ModifierExtensions
    {
        public static int Modifier(int attribute)
        {
            int modifier = 0;

            if (attribute == 1)
            {
                modifier = -5;
            }
            else if (attribute >= 2 && attribute <= 3)
            {
                modifier = -4;
            }
            else if (attribute >= 4 && attribute <= 5)
            {
                modifier = -3;
            }
            else if (attribute >= 6 && attribute <= 7)
            {
                modifier = -2;
            }
            else if (attribute >= 8 && attribute <= 9)
            {
                modifier = -1;
            }
            else if (attribute >= 10 && attribute <= 11)
            {
                modifier = 0;
            }
            else if (attribute >= 12 && attribute <= 13)
            {
                modifier = +1;
            }
            else if (attribute >= 14 && attribute <= 15)
            {
                modifier = +2;
            }
            else if (attribute >= 16 && attribute <= 17)
            {
                modifier = +3;
            }
            else if (attribute >= 18 && attribute <= 19)
            {
                modifier = +4;
            }
            else if (attribute >= 20 && attribute <= 21)
            {
                modifier = +5;
            }
            else if (attribute >= 22 && attribute <= 23)
            {
                modifier = +6;
            }
            else if (attribute >= 24 && attribute <= 25)
            {
                modifier = +7;
            }
            else if (attribute >= 26 && attribute <= 27)
            {
                modifier = +8;
            }
            else if (attribute >= 28 && attribute <= 29)
            {
                modifier = +9;
            }
            else if (attribute == 30)
            {
                modifier = +10;
            }

            return modifier;
        }
    }
}