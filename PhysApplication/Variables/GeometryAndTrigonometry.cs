///////////////////////////////////////
///         PhysApplication         ///
///        by Damien Stamates       ///
///            Variables            ///
///////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysApplication.Objects;

namespace PhysApplication.Variables {
    class GeometryAndTrigonometry {
        public List<variableMenuObject> GeometryAndTrigonometryVariables = new List<variableMenuObject>();
        public GeometryAndTrigonometry() {
            GeometryAndTrigonometryVariables.Add(new variableMenuObject("area ---------- (A)", true, false));
            GeometryAndTrigonometryVariables.Add(new variableMenuObject("circumference - (C)", false, false));
            GeometryAndTrigonometryVariables.Add(new variableMenuObject("volume -------- (V)", false, false));
            GeometryAndTrigonometryVariables.Add(new variableMenuObject("surface area -- (S)", false, false));
            GeometryAndTrigonometryVariables.Add(new variableMenuObject("base ---------- (b)", false, false));
            GeometryAndTrigonometryVariables.Add(new variableMenuObject("height -------- (h)", false, false));
            GeometryAndTrigonometryVariables.Add(new variableMenuObject("length -------- (l)", false, false));
            GeometryAndTrigonometryVariables.Add(new variableMenuObject("width --------- (w)", false, false));
            GeometryAndTrigonometryVariables.Add(new variableMenuObject("radius -------- (r)", false, false));
        }
    }
}
