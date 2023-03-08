using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Postac
    {
        public static int Reg(int maxzycie, int zycie)
        {
            int uj = maxzycie - zycie;
            int i = 0;
            while(i < uj)
            {
                zycie++;
                i++;
            }
            return zycie;
           
        }
        public static int Ula(int sila)
        {
            sila += 5;
            return sila;
        }
        public static int Ulz(int maxzycie)
        {
            maxzycie += 5;
            return maxzycie;
        }


    }
}
