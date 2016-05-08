using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public class UserInt : IUserInt
    {
        static string s = @"Pesho
Ivo
3 3
PRA
B-B
RCI
LRRU
RD";
        StringReader Console = new StringReader(s);

        public string ReadLine()
        {
            return Consol.ReadLine();
        }

        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }

    }
}
