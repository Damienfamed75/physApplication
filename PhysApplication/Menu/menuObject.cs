using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysApplication.Menu {
    public struct menuObject {
        public string Name;
        public bool Marked;
        public menuObject(string n, bool m) {
            Name = n;
            Marked = m;
        }
    }
}
