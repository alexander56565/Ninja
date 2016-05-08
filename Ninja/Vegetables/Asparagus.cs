using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
     public class Asparagus : Vegetable
    {
        public Asparagus()
        {
            this.Delay = 2;
            this.PowerEffect = 5;
            this.StaminaEffect = -5; 
        }
    }
}
