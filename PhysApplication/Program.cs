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
        public static void Main(string[] args)
        {
            mainMenu.CreateMenu();
            mainMenu.MenuNav();
        }
    }
}
