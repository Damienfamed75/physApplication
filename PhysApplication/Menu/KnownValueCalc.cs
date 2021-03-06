﻿///////////////////////////////////////
///         PhysApplication         ///
///        by Damien Stamates       ///
///              Menu               ///
///////////////////////////////////////
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
        public static Mechanics MechList = new Mechanics();
        public static ElectricAndMagnetism ElecList = new ElectricAndMagnetism();
        public static FluidMechanicsAndThermalPhysics FluiList = new FluidMechanicsAndThermalPhysics();
        public static GeometryAndTrigonometry GeoList = new GeometryAndTrigonometry();
        public static ModernPhysics ModernList = new ModernPhysics();
        public static WavesAndOptics WaveList = new WavesAndOptics();
        public static List<variableMenuObject> categ = MechList.MechanicsVariables;
        public static int ScreenNum = 1;
        public void CreateMenu()
        {
            Console.Clear(); // Refreshes the console
            foreach(variableMenuObject a in categ) {
                Console.WriteLine((a.Checked?"(x)":a.Selected?"(-)":"( )")+a.Name+(a.Selected?" <-":"")); // Prints out each individual item on the list.
            }
            // Setting up the footer of each page.
            Console.Write(ScreenNum==1?"":ScreenNum==2?"\n\n\n\n\n\n\n\n":ScreenNum==3?"\n\n\n\n\n\n\n\n\n\n":ScreenNum==4?"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n":ScreenNum==5?"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n":ScreenNum==6?"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n":"");
            Console.Write("------(Spacebar to Select)------(Enter to Proceed)------(Pages {1,2,3,4,5,6})------(Current Page: " + (ScreenNum == 1 ? "Mechanics" : ScreenNum == 2 ? "Electric/Magnetism" : ScreenNum == 3 ? "Fluid/Thermal" : ScreenNum == 4 ? "Geometry/Trig" : ScreenNum == 5 ? "Modern" : "Waves/Optics") + ")------");
        }
        private void KeyAnalyze(string key) {
            if (key.ToUpper() == "DOWNARROW") Move(false); // Calls for Move and sets the bool (upMove) to false
            if (key.ToUpper() == "UPARROW") Move(true);    // Calls for Move and sets the bool (upMove) to true 
            if (key.ToUpper() == "SPACEBAR") Select();     // Selects object
            if (key == "D1") { if (ScreenNum != 1) categ = MechList.MechanicsVariables; ScreenNum = 1; }                       // Checks if same screen. If not then it sets the list to list #1
            if (key == "D2") { if (ScreenNum != 2) categ = ElecList.ElectricAndMagnetismVariables; ScreenNum = 2; }            // Ditto
            if (key == "D3") { if (ScreenNum != 3) categ = FluiList.FluidMechanicsAndThermalPhysicsVariables; ScreenNum = 3; } // Ditto
            if (key == "D4") { if (ScreenNum != 4) categ = GeoList.GeometryAndTrigonometryVariables; ScreenNum = 4; }          // Ditto
            if (key == "D5") { if (ScreenNum != 5) categ = ModernList.ModernPhysicsVariables; ScreenNum = 5; }                 // Ditto
            if (key == "D6") { if (ScreenNum != 6) categ = WaveList.WavesAndOpticsVariables; ScreenNum = 6; }                  // Ditto
        }
        private void Select() {
            for(int i = 0; i < categ.Count(); i++) { // For every item in this list
                if(categ[i].Selected) { // If that item is selected
                    categ[i] = new variableMenuObject(categ[i].Name, true, !categ[i].Checked); // toggle checked status
                }
            }
        }
        private void Move(bool upMove) {
            int j = 1;
            for (int i = 0; i < categ.Count(); i++) {
                if (categ[i].Selected) {
                    j = i;
                    categ[i] = new variableMenuObject(categ[i].Name, false, categ[i].Checked); // Deselects current selection.
                }
            }
            if (j == 0 && upMove) categ[categ.Count() - 1] = new variableMenuObject(categ[categ.Count() - 1].Name, true, categ[categ.Count() - 1].Checked);
            else if (j == categ.Count - 1 && !upMove) categ[0] = new variableMenuObject(categ[0].Name, true, categ[0].Checked);
            else if (upMove) categ[j - 1] = new variableMenuObject(categ[j - 1].Name, true, categ[j - 1].Checked);
            else if (!upMove) categ[j + 1] = new variableMenuObject(categ[j + 1].Name, true, categ[j + 1].Checked);
            else throw new ArgumentException("invalid value for bool upMove");
        }
        public void MenuNav() {
            string key = null;
            do {
                KeyAnalyze(key = Console.ReadKey().Key.ToString());
                CreateMenu();
            } while (key.ToUpper() != "ESCAPE");
            System.Environment.Exit(1);
        }
    }
}
