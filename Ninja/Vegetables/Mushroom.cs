using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public class Mushroom : Vegetable
    {
        public Mushroom()
        {
            this.Delay = 5;
            this.PowerEffect = -10;
            this.StaminaEffect = -10;
        }
    }
}
