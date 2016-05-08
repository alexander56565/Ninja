using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public class Royal : Vegetable
    {
        public Royal()
        {
            this.Delay = 10;
            this.PowerEffect = 20;
            this.StaminaEffect = 10;
        }
    }
}
