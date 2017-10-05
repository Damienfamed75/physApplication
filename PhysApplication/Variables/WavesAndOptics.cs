using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysApplication.Objects;

namespace PhysApplication.Variables {
    class WavesAndOptics {
        public List<variableMenuObject> WavesAndOpticsVariables = new List<variableMenuObject>();
        public WavesAndOptics() {
            WavesAndOpticsVariables.Add(new variableMenuObject("separation ---------------- (d)", true, false));
            WavesAndOpticsVariables.Add(new variableMenuObject("frequency or focal length - (f)", false, false));
            WavesAndOpticsVariables.Add(new variableMenuObject("height -------------------- (h)", false, false));
            WavesAndOpticsVariables.Add(new variableMenuObject("distance ------------------ (L)", false, false));
            WavesAndOpticsVariables.Add(new variableMenuObject("magnification ------------- (M)", false, false));
            WavesAndOpticsVariables.Add(new variableMenuObject("an integer ---------------- (m)", false, false));
            WavesAndOpticsVariables.Add(new variableMenuObject("index of refraction ------- (n)", false, false));
            WavesAndOpticsVariables.Add(new variableMenuObject("distance ------------------ (s)", false, false));
            WavesAndOpticsVariables.Add(new variableMenuObject("speed --------------------- (v)", false, false));
            WavesAndOpticsVariables.Add(new variableMenuObject("wavelength ---------------- (λ)", false, false));
            WavesAndOpticsVariables.Add(new variableMenuObject("angle --------------------- (θ)", false, false));
        }
    }
}
