using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos
{
    internal class macot
    {
       protected string Species {  get; set; }
         
        protected string Race { get; set; }

        protected string Name { get; set; }

        public macot(string Species, string Race,string Name)
        {
            this.Species = Species;
            this.Race = Race;
            this.Name = Name;
        }

        public override string ToString()
        {
            return "Species" + Species + "Race" + Race + "Name" + Name;
        }
    }
}
