using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysApplication.Objects;

namespace PhysApplication.Variables {
    class FluidMechanicsAndThermalPhysics {
        public List<menuObject> FluidMechanicsAndThermalPhysicsVariables = new List<menuObject>();
        public FluidMechanicsAndThermalPhysics() {
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("area -------------------------------------- (A)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("force ------------------------------------- (F)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("depth ------------------------------------- (h)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("thermal conductivity ---------------------- (k)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("kinetic energy ---------------------------- (K)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("thickness --------------------------------- (L)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("mass -------------------------------------- (m)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("number of moles --------------------------- (n)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("number of molecules ----------------------- (N)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("pressure ---------------------------------- (P)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("energy transferred to a system by heating - (Q)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("temperature ------------------------------- (T)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("time -------------------------------------- (t)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("internal energy --------------------------- (U)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("volume ------------------------------------ (V)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("speed ------------------------------------- (v)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("work done on a system --------------------- (W)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("height ------------------------------------ (y)", false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new menuObject("density ----------------------------------- (ρ)", false));
        }
    }
}
