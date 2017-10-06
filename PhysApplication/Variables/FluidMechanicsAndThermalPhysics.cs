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
    class FluidMechanicsAndThermalPhysics {
        public List<variableMenuObject> FluidMechanicsAndThermalPhysicsVariables = new List<variableMenuObject>();
        public FluidMechanicsAndThermalPhysics() {
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("area -------------------------------------- (A)", true, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("force ------------------------------------- (F)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("depth ------------------------------------- (h)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("thermal conductivity ---------------------- (k)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("kinetic energy ---------------------------- (K)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("thickness --------------------------------- (L)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("mass -------------------------------------- (m)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("number of moles --------------------------- (n)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("number of molecules ----------------------- (N)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("pressure ---------------------------------- (P)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("energy transferred to a system by heating - (Q)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("temperature ------------------------------- (T)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("time -------------------------------------- (t)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("internal energy --------------------------- (U)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("volume ------------------------------------ (V)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("speed ------------------------------------- (v)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("work done on a system --------------------- (W)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("height ------------------------------------ (y)", false, false));
            FluidMechanicsAndThermalPhysicsVariables.Add(new variableMenuObject("density ----------------------------------- (ρ)", false, false));
        }
    }
}
