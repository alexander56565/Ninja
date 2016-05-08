using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public class Ninja
    {
        private string name;
        private int power;
        private int stamina;
        public int accPower;
        public int accStamina;
        public int x;
        public int y;

        public Ninja(string name)
        {
            this.Name = name;
            this.Power = 1;
            this.Stamina = 1;
            this.accPower = 0;
            this.accStamina = 0;
            this.X = 0;
            this.Y = 0;
        }
        public int X
        {
            set
            {
                this.x = value;

            }
            get { return this.x; }
        }
        public int Y
        {
            set
            {
                this.y = value;

            }
            get { return this.y; }
        }
        public int Power
        {
            set
            {
                this.power =value;

            }
            get {return this.power; }
        }
        public int Stamina
        {
            set
            {
                this.stamina = value;

            }
            get { return this.stamina; }
        }

        public int AccPower
        {
            set
            {
                this.accPower = value;

            }
            get { return this.accPower; }
        }
        public int AccStamina
        {
            set
            {
                this.accStamina = value;

            }
            get { return this.accStamina; }
        }
        public string Name
        {
            set
            {
                this.name = value;

            }
            get { return this.name; }
        }

       public void updateNinja()
        {
            this.Power += this.AccPower;
            this.AccPower = 0;
            this.Stamina += this.AccStamina;
            this.AccStamina = 0;
        }

        public override string ToString()
        {
            return String.Format("Winner: {0}\nPower: {1}\nStamina: {2}",this.Name,this.Power,this.Stamina);
        }

    }
}
