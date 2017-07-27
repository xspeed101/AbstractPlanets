using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPlanetDemo
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //PRIVATE INSTANCE VARIABLES
        private string _type;

        //CONSTRUCTOR METHOD

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {

            this._type = type;
        }

        //PUBLIC METHODS

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
