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
    class ElectricAndMagnetism {
        public List<variableMenuObject> ElectricAndMagnetismVariables = new List<variableMenuObject>();
        public ElectricAndMagnetism() {
            ElectricAndMagnetismVariables.Add(new variableMenuObject("area --------------- (A)", true, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("magnetic field ----- (B)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("capacitance -------- (C)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("distance ----------- (d)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("electric field ----- (E)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("emf ---------------- (ε)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("force -------------- (F)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("current ------------ (I)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("length ------------- (l)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("power -------------- (P)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("charge ------------- (Q)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("point charge ------- (q)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("resistence --------- (R)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("time --------------- (t)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("potential energy --- (U)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("electric potential - (V)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("speed -------------- (v)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("dielectic constant - (κ)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("resistivity -------- (ρ)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("angle -------------- (θ)", false, false));
            ElectricAndMagnetismVariables.Add(new variableMenuObject("flux --------------- (Φ)", false, false));
        }
    }
}
