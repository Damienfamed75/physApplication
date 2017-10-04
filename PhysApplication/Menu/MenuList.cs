using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysApplication.Menu {
    public class MenuList {
        public List<menuObject> categories = new List<menuObject>();
        private bool val = true;
        public MenuList(string[] args) {
            if (args == null) val = false;
            categories.Add(new menuObject("velocity", true));
            categories.Add(new menuObject("time", false));
            categories.Add(new menuObject("distance", false));
            if (val) foreach (string n in args) categories.Add(new menuObject(n, false));
        }
    }
}
