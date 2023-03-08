using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class CharacterChoose3
    {
        public static int[] characterClassSelection3()
        {
            int[] stats = new int[4];
            
            stats[0] = 30; // hp
            stats[1] = 20; // siła
            stats[2] = 30; // max hp
            stats[3] = 5;  // punkty

            return stats;
        }
    }
}
