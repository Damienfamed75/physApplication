using System;
using System.Collections.Generic;
using System.Linq;
using PhysApplication.Objects;

namespace PhysApplication.Menu {
    public class MainMenuCalc {
        public static MenuList menuItems = new MenuList(null); // passes null for the parameter when instantiating class as an object
        public static List<menuObject> menuCategories = menuItems.categories; // Sets variables as the list inside menuItems
        static KnownValueCalc valMenu = new KnownValueCalc(); // Instantiates new value menu
        public static bool endMainMenu = false;
        public void CreateMenu() {  // TODO Think about splitting to new file
            Console.Clear();
            double b = 1.4661;
            Console.Write($"Please Select One Object:\n\n");
            
            foreach (menuObject a in menuCategories) {
                Console.WriteLine(a.Marked?$"{a.Name} <":a.Name);
            }
        }
        private void KeyAnalyze(string key) {
            if (key == null) return;
            if (key.ToUpper() == "UPARROW") Move(true);
            if (key.ToUpper() == "DOWNARROW") Move(false);
            if (key.ToUpper() == "ESCAPE") System.Environment.Exit(1);
        }
        private void Move(bool upMove) {
            int j = 1;
            for(int i = 0; i < menuCategories.Count(); i++) {
                if (menuItems.categories[i].Marked) {
                    j = i;
                    menuCategories[i] = new menuObject(menuCategories[i].Name, false);
                }
            }
            if (j == 0 && upMove) menuCategories[menuCategories.Count() - 1] = new menuObject(menuCategories[menuCategories.Count() - 1].Name, true);
            else if (j == menuCategories.Count - 1 && !upMove) menuCategories[0] = new menuObject(menuCategories[0].Name, true);
            else if (upMove)  menuCategories[j - 1] = new menuObject(menuCategories[j - 1].Name, true);
            else if (!upMove) menuCategories[j + 1] = new menuObject(menuCategories[j + 1].Name, true);
        }
        public void MenuNav() {
            string key = null;
            do {
                KeyAnalyze(key = Console.ReadKey().Key.ToString());
                CreateMenu();
            } while (key.ToUpper() != "ENTER");
            valMenu.CreateMenu();
            valMenu.MenuNav();
        }
    }
}