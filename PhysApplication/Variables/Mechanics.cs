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
    class Mechanics {
        public List<variableMenuObject> MechanicsVariables = new List<variableMenuObject>();
        public Mechanics() {
            MechanicsVariables.Add(new variableMenuObject("acceleration ------------ (a)", true, false));
            MechanicsVariables.Add(new variableMenuObject("amplitude --------------- (A)", false, false));
            MechanicsVariables.Add(new variableMenuObject("distance ---------------- (d)", false, false));
            MechanicsVariables.Add(new variableMenuObject("energy ------------------ (E)", false, false));
            MechanicsVariables.Add(new variableMenuObject("frequency --------------- (f)", false, false));
            MechanicsVariables.Add(new variableMenuObject("force ------------------- (F)", false, false));
            MechanicsVariables.Add(new variableMenuObject("rotational inertia ------ (I)", false, false));
            MechanicsVariables.Add(new variableMenuObject("kinetic energy ---------- (K)", false, false));
            MechanicsVariables.Add(new variableMenuObject("spring constant --------- (k)", false, false));
            MechanicsVariables.Add(new variableMenuObject("angular momentum -------- (L)", false, false));
            MechanicsVariables.Add(new variableMenuObject("length ------------------ (l)", false, false));
            MechanicsVariables.Add(new variableMenuObject("mass -------------------- (m)", false, false));
            MechanicsVariables.Add(new variableMenuObject("power ------------------- (P)", false, false));
            MechanicsVariables.Add(new variableMenuObject("momentum ---------------- (p)", false, false));
            MechanicsVariables.Add(new variableMenuObject("radius ------------------ (r)", false, false));
            MechanicsVariables.Add(new variableMenuObject("period ------------------ (T)", false, false));
            MechanicsVariables.Add(new variableMenuObject("time -------------------- (t)", false, false));
            MechanicsVariables.Add(new variableMenuObject("potential energy -------- (U)", false, false));
            MechanicsVariables.Add(new variableMenuObject("volume ------------------ (V)", false, false));
            MechanicsVariables.Add(new variableMenuObject("speed ------------------- (v)", false, false));
            MechanicsVariables.Add(new variableMenuObject("work -------------------- (W)", false, false));
            MechanicsVariables.Add(new variableMenuObject("position ---------------- (x)", false, false));
            MechanicsVariables.Add(new variableMenuObject("height ------------------ (y)", false, false));
            MechanicsVariables.Add(new variableMenuObject("angular acceleration ---- (α)", false, false));
            MechanicsVariables.Add(new variableMenuObject("coefficient of friction - (μ)", false, false));
            MechanicsVariables.Add(new variableMenuObject("angle ------------------- (θ)", false, false));
            MechanicsVariables.Add(new variableMenuObject("density ----------------- (ρ)", false, false));
            MechanicsVariables.Add(new variableMenuObject("torque ------------------ (τ)", false, false));
            MechanicsVariables.Add(new variableMenuObject("angular speed ----------- (ω)", false, false));
        }
    }
}
