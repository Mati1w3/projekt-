using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class CharacterChoose
    {
        public static int[] characterClassSelection()
        {
            int[] stats = new int[4];
            
            stats[0] = 25; // hp
            stats[1] = 30; // siła
            stats[2] = 25; // max hp
            stats[3] = 3; // punkty

            return stats;
        }
    }
}
