///////////////////////////////////////
///         PhysApplication         ///
///        by Damien Stamates       ///
///             Objects             ///
///////////////////////////////////////4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysApplication.Objects {
    class variableMenuObject {
        public string Name;
        public bool Checked;
        public bool Selected;
        public variableMenuObject (string name_, bool selected_, bool checked_) {
            Name = name_;
            Selected = selected_;
            Checked = checked_;
        }
    }
}
