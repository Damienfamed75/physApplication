using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysApplication.Menu
{
    /*
    public struct ListMenu {
        public List<string> categories = new List<string>();
        public int a;
        public ListMenu(int i) {
            a = i;
        }
    }*/
    public class MenuList {
        public List<string> categories = new List<string>();
        private bool val = true;
        public MenuList(string[] args = ["absolutelynothing"]) {
            if (args == null) val = false;
            if (val) foreach (string n in args) categories.Add(n);
            categories.Add("velocity");
            categories.Add("time");
            categories.Add("distance");
        }
    }
}
