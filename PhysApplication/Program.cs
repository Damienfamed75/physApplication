///////////////////////////////////////
///         PhysApplication         ///
///        by Damien Stamates       ///
///            v.1.0.0.0            ///
///////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysApplication.Menu;

namespace PhysApplication
{
    class Program
    {
        public static MainMenuCalc mainMenu = new MainMenuCalc();
        public static KnownValueCalc valMenu = new KnownValueCalc();
        public static void Main(string[] args)
        {
            mainMenu.CreateMenu();
            mainMenu.MenuNav();
            valMenu.CreateMenu();
        }
    }
}
