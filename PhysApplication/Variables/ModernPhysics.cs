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
    class ModernPhysics {
        public List<variableMenuObject> ModernPhysicsVariables = new List<variableMenuObject>();
        public ModernPhysics() {
            ModernPhysicsVariables.Add(new variableMenuObject("energy --------- (E)", true, false));
            ModernPhysicsVariables.Add(new variableMenuObject("frequency ------ (f)", false, false));
            ModernPhysicsVariables.Add(new variableMenuObject("kinetic energy - (K)", false, false));
            ModernPhysicsVariables.Add(new variableMenuObject("mass ----------- (m)", false, false));
            ModernPhysicsVariables.Add(new variableMenuObject("momentum ------- (p)", false, false));
            ModernPhysicsVariables.Add(new variableMenuObject("wavelength ----- (λ)", false, false));
            ModernPhysicsVariables.Add(new variableMenuObject("work function -- (φ)", false, false));
        }
    }
}
