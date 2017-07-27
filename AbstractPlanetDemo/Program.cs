using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPlanetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name: Sahal Mohamed
            //Student Number: 300895007
            //Date Last Modiefied: 2017/07/27.
            //Program Description: The following Driver Class displays and prints the contents of the TerrestrialPlanet and GiantPlanet classes.
            //Both classes display the stats of their respective planets.

            
            GiantPlanet G1 = new GiantPlanet("Jupiter", 139822, 1.898, "Gas");
            G1.MoonCount = 67;
            G1.RingCount = 0;
            G1.OrbitalPeriod = 12;
            G1.RotationPeriod = 9.8;
            Console.WriteLine("{0}*10^27 || MoonCount: {1}", G1, G1.MoonCount);
            Console.WriteLine("Planet has more than 0 moons? {0}.",G1.HasMoons());
            Console.WriteLine("Planet has more than 0 rings? {0}.",G1.HasRings());
            Console.WriteLine("Orbital Period = {0} Earth years", G1.OrbitalPeriod);
            Console.WriteLine("Rotation Period = {0} Earth years", G1.RotationPeriod);
            Console.WriteLine("====================================================================================\n");

            TerrestrialPlanet T1 = new TerrestrialPlanet("Earth", 12742, 5.972, true);
            T1.MoonCount = 1;
            T1.RotationPeriod = 23;
            T1.OrbitalPeriod = 365;
            Console.WriteLine("{0}*10^24", T1);
            Console.WriteLine("Planet is Habitable? {0}.", T1.Habitable());
            Console.WriteLine("Planet has more than 0 moons? {0}.", T1.HasMoons());
            Console.WriteLine("Orbital Period = {0} Earth days", T1.OrbitalPeriod);
            Console.WriteLine("Rotation Period = {0} hours and 54 minutes", T1.RotationPeriod);
            Console.WriteLine("====================================================================================\n");


        }
    }
}
