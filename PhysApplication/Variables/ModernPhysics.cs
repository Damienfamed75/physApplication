using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysApplication.Objects;

namespace PhysApplication.Variables {
    class ModernPhysics {
        public List<menuObject> ModernPhysicsVariables = new List<menuObject>();
        public ModernPhysics() {
            ModernPhysicsVariables.Add(new menuObject("energy --------- (E)", true));
            ModernPhysicsVariables.Add(new menuObject("frequency ------ (f)", false));
            ModernPhysicsVariables.Add(new menuObject("kinetic energy - (K)", false));
            ModernPhysicsVariables.Add(new menuObject("mass ----------- (m)", false));
            ModernPhysicsVariables.Add(new menuObject("momentum ------- (p)", false));
            ModernPhysicsVariables.Add(new menuObject("wavelength ----- (λ)", false));
            ModernPhysicsVariables.Add(new menuObject("work function -- (φ)", false));
        }
    }
}
