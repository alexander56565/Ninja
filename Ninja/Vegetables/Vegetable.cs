using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public abstract class Vegetable
    {
        
        private int powerEffect;
        private int staminaEffect;
        private int delay;

        public Vegetable()
        {

        }
        public int PowerEffect
        {
            get { return this.powerEffect; }
            protected set { this.powerEffect = value; }
        }
        public int StaminaEffect
        {
            get { return this.staminaEffect; }
            protected set { this.staminaEffect = value; }
        }
        public int Delay
        {
            get { return this.delay; }
            protected set { this.delay = value; }
        }
    }
}
