using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysApplication.Objects;
using PhysApplication.Variables;

namespace PhysApplication.Menu
{
    class KnownValueCalc
    {
        string TSIUFASITCLOWITL30 = "woah";
        public static Mechanics MechList = new Mechanics();
        public static ElectricAndMagnetism ElecList = new ElectricAndMagnetism();
        public static FluidMechanicsAndThermalPhysics FluiList = new FluidMechanicsAndThermalPhysics();
        public static GeometryAndTrigonometry GeoList = new GeometryAndTrigonometry();
        public static ModernPhysics ModernList = new ModernPhysics();
        public static WavesAndOptics WaveList = new WavesAndOptics();
        public static List<menuObject> categ = FluiList.FluidMechanicsAndThermalPhysicsVariables;
        public void CreateMenu()
        {
            Console.Clear();
            foreach(menuObject a in categ) {
                Console.WriteLine(a.Marked ? $"(x) {a.Name}" : $"( ) {a.Name}");
            }
        }
        private void KeyAnalyze(string key) {
            if (key.ToUpper() == "DOWNARROW" || key.ToUpper() == "UPARROW") Move();
            if (key == "1") MechLoad();
            if (key == "2") ElecLoad();
            if (key == "3") FluiLoad();
            if (key == "4") GeoLoad();
            if (key == "5") ModLoad();
            if (key == "6") WaveLoad();
        }
        private void MechLoad() {

        }
        private void ElecLoad() {

        }
        private void FluiLoad() {

        }
        private void GeoLoad() {

        }
        private void ModLoad() {

        }
        private void WaveLoad() {

        }
        private void Move() {

        }
        public void MenuNav() {
            string key = null;
            do {
                KeyAnalyze(key = Console.ReadKey().Key.ToString());
                CreateMenu();
            } while (key.ToUpper() != "ENTER");
        }
    }
}
