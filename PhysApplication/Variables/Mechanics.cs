using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysApplication.Objects;

namespace PhysApplication.Variables {
    class Mechanics {
        public List<menuObject> MechanicsVariables = new List<menuObject>();
        public Mechanics() {
            MechanicsVariables.Add(new menuObject("acceleration ------------ (a)", true));
            MechanicsVariables.Add(new menuObject("amplitude --------------- (A)", false));
            MechanicsVariables.Add(new menuObject("distance ---------------- (d)", false));
            MechanicsVariables.Add(new menuObject("energy ------------------ (E)", false));
            MechanicsVariables.Add(new menuObject("frequency --------------- (f)", false));
            MechanicsVariables.Add(new menuObject("force ------------------- (F)", false));
            MechanicsVariables.Add(new menuObject("rotational inertia ------ (I)", false));
            MechanicsVariables.Add(new menuObject("kinetic energy ---------- (K)", false));
            MechanicsVariables.Add(new menuObject("spring constant --------- (k)", false));
            MechanicsVariables.Add(new menuObject("angular momentum -------- (L)", false));
            MechanicsVariables.Add(new menuObject("length ------------------ (l)", false));
            MechanicsVariables.Add(new menuObject("mass -------------------- (m)", false));
            MechanicsVariables.Add(new menuObject("power ------------------- (P)", false));
            MechanicsVariables.Add(new menuObject("momentum ---------------- (p)", false));
            MechanicsVariables.Add(new menuObject("radius ------------------ (r)", false));
            MechanicsVariables.Add(new menuObject("period ------------------ (T)", false));
            MechanicsVariables.Add(new menuObject("time -------------------- (t)", false));
            MechanicsVariables.Add(new menuObject("potential energy -------- (U)", false));
            MechanicsVariables.Add(new menuObject("volume ------------------ (V)", false));
            MechanicsVariables.Add(new menuObject("speed ------------------- (v)", false));
            MechanicsVariables.Add(new menuObject("work -------------------- (W)", false));
            MechanicsVariables.Add(new menuObject("position ---------------- (x)", false));
            MechanicsVariables.Add(new menuObject("height ------------------ (y)", false));
            MechanicsVariables.Add(new menuObject("angular acceleration ---- (α)", false));
            MechanicsVariables.Add(new menuObject("coefficient of friction - (μ)", false));
            MechanicsVariables.Add(new menuObject("angle ------------------- (θ)", false));
            MechanicsVariables.Add(new menuObject("density ----------------- (ρ)", false));
            MechanicsVariables.Add(new menuObject("torque ------------------ (τ)", false));
            MechanicsVariables.Add(new menuObject("angular speed ----------- (ω)", false));
        }
    }
}
