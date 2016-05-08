using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public interface IVegetable
    {
         int PowerEffect { get; set; }
         int StaminaEffect { get; set; } 
         int Delay { get; set; }
    }
}
