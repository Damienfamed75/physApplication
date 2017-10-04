using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysApplication
{
    class Program
    {
        public static List<string> categ = new List<string>();
        static void Initialize()
        {
            categ.Add("time");
            categ.Add("velocity");
            categ.Add("acceleration");
            categ.Add("distance");
        }
        public static void Main(string[] args)
        {
            Initialize();
            Menu.KnownValueCalc menu = new Menu.KnownValueCalc();

        }
    }
}
