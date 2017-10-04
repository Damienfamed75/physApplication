using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysApplication.Objects;

namespace PhysApplication.Variables {
    class ElectricAndMagnetism {
        public List<menuObject> ElectricAndMagnetismVariables = new List<menuObject>();
        public ElectricAndMagnetism() {
            ElectricAndMagnetismVariables.Add(new menuObject("area --------------- (A)", true));
            ElectricAndMagnetismVariables.Add(new menuObject("magnetic field ----- (B)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("capacitance -------- (C)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("distance ----------- (d)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("electric field ----- (E)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("emf ---------------- (ε)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("force -------------- (F)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("current ------------ (I)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("length ------------- (l)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("power -------------- (P)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("charge ------------- (Q)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("point charge ------- (q)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("resistence --------- (R)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("time --------------- (t)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("potential energy --- (U)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("electric potential - (V)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("speed -------------- (v)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("dielectic constant - (κ)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("resistivity -------- (ρ)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("angle -------------- (θ)", false));
            ElectricAndMagnetismVariables.Add(new menuObject("flux --------------- (Φ)", false));
        }
    }
}
