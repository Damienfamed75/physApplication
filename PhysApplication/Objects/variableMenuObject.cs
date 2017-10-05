using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysApplication.Objects {
    class variableMenuObject {
        string Name;
        bool Checked;
        bool Selected;
        public variableMenuObject (string name_, bool selected_, bool checked_) {
            Name = name_;
            Selected = selected_;
            Checked = checked_;
        }
    }
}
