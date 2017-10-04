using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysApplication.Objects;

namespace PhysApplication.Variables {
    class GeometryAndTrigonometry {
        public List<menuObject> GeometryAndTrigonometryVariables = new List<menuObject>();
        public GeometryAndTrigonometry() {
            GeometryAndTrigonometryVariables.Add(new menuObject("area ---------- (A)", true));
            GeometryAndTrigonometryVariables.Add(new menuObject("circumference - (C)", false));
            GeometryAndTrigonometryVariables.Add(new menuObject("volume -------- (V)", false));
            GeometryAndTrigonometryVariables.Add(new menuObject("surface area -- (S)", false));
            GeometryAndTrigonometryVariables.Add(new menuObject("base ---------- (b)", false));
            GeometryAndTrigonometryVariables.Add(new menuObject("height -------- (h)", false));
            GeometryAndTrigonometryVariables.Add(new menuObject("length -------- (l)", false));
            GeometryAndTrigonometryVariables.Add(new menuObject("width --------- (w)", false));
            GeometryAndTrigonometryVariables.Add(new menuObject("radius -------- (r)", false));
        }
    }
}
