using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class CharacterChoose2
    {
        public static int[] characterClassSelection2()
        {
            int[] stats = new int[4];
           
            stats[0] = 20; // hp
            stats[1] = 25; // siła
            stats[2] = 20; // max hp
            stats[3] = 5; // punkty

            return stats;
        }
    }
}
