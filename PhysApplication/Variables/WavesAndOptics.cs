using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysApplication.Objects;

namespace PhysApplication.Variables {
    class WavesAndOptics {
        public List<menuObject> WavesAndOpticsVariables = new List<menuObject>();
        public WavesAndOptics() {
            WavesAndOpticsVariables.Add(new menuObject("separation ---------------- (d)", true));
            WavesAndOpticsVariables.Add(new menuObject("frequency or focal length - (f)", false));
            WavesAndOpticsVariables.Add(new menuObject("height -------------------- (h)", false));
            WavesAndOpticsVariables.Add(new menuObject("distance ------------------ (L)", false));
            WavesAndOpticsVariables.Add(new menuObject("magnification ------------- (M)", false));
            WavesAndOpticsVariables.Add(new menuObject("an integer ---------------- (m)", false));
            WavesAndOpticsVariables.Add(new menuObject("index of refraction ------- (n)", false));
            WavesAndOpticsVariables.Add(new menuObject("distance ------------------ (s)", false));
            WavesAndOpticsVariables.Add(new menuObject("speed --------------------- (v)", false));
            WavesAndOpticsVariables.Add(new menuObject("wavelength ---------------- (λ)", false));
            WavesAndOpticsVariables.Add(new menuObject("angle --------------------- (θ)", false));
        }
    }
}
