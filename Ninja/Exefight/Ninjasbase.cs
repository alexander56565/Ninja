using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public class Ninjasbase
    {
        public int current;
        //private int switched;
        private const int COUNTNINJAS = 2;
        public Ninjasbase()
        {
            //this.switched = 0;
            this.current = 0;
            Ninjago = new List<Ninja>();   
        }
        public List<Ninja> Ninjago { private set; get; }

        public void switchcurrent()
        { current = (current + 1) % COUNTNINJAS;  }

        public Ninja getCurrentNinja()
        {
            
            return Ninjago[current]; }
        public Ninja getOtherNinja()
        { return Ninjago[(current+1)%2]; }

        public string battle()
        {
            if (Ninjago[0].X == Ninjago[1].X && Ninjago[0].Y == Ninjago[1].Y)
            {
                if (getCurrentNinja().Power >= getOtherNinja().Power)
                { return getCurrentNinja().ToString(); }
                else
                {
                    return getOtherNinja().ToString();
                }
            }
            else
            {
                return null;
            }


        }




    }
}
