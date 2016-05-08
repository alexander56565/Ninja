using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public class Engine:IEngine
    {

        private IUserInt userInt;
       


        public Engine()
        {
            this.userInt = new UserInt();
            
        }


        public void Run()
        {
            string firstNinja = userInt.ReadLine();
            string secondNinja = userInt.ReadLine();
            int[] dimensions = userInt.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = dimensions[0];
            int column = dimensions[1];
            char[,] matrix = new char[row,column];
            Ninja A = new Ninja(firstNinja);
            Ninja B = new Ninja(secondNinja);
            
            int playercount = 0;
            for (int i=0; i<row; i++)
            {
                string line = userInt.ReadLine();
                for(int j = 0; j < column; j++)
                {
                    if (firstNinja[0] == line[j]) { A.X = i; A.Y = j; }
                    if (secondNinja[0] == line[j]) { B.X = i; B.Y = j; }
                    matrix[i, j] = line[j];

                };
            }

            Ninjasbase ninjasbase = new Ninjasbase();
            ninjasbase.Ninjago.Add(A);
            ninjasbase.Ninjago.Add(B);
            Field gamefield = new Field(matrix);

            
            while (true)
            {
                bool breakt = false;
                string line = userInt.ReadLine();
                for (int k=0; k<line.Length; k++)
                {
                    char INPUT = line[k];
                    Ninja current = ninjasbase.getCurrentNinja();
                    Ninja other = ninjasbase.getOtherNinja();
                    current.X = updateycor(current.X, INPUT, row);
                    current.Y = updatexcor(current.Y, INPUT, column);
                    current.Stamina--;

                    if (current.Stamina == -1) { current.Stamina++; }
                    Vegetable stepped = gamefield.stepOnField(current, other);
                    if (stepped != null)
                    {
                        current.accPower += stepped.PowerEffect;
                        current.AccStamina += stepped.StaminaEffect;
                    }
                    int gg = 0;
                    if (current.Stamina == 0) { current.updateNinja(); gg = 1; }
                    string output = ninjasbase.battle();
                    
                    if(output != null) { userInt.WriteLine(output);breakt = true; break;  }
                    
                    
                    
                    if (gg==1) {  ninjasbase.switchcurrent(); }
                    gamefield.updateField();
                    


                }
                if(breakt) { break; }
            }
        }

        private int updatexcor(int x, char a, int columns)
        {
            switch (a)
            {
                case 'L': x--; if(x<0) {x++;} break;
                case 'R': x++; if (x >=columns) { x--; } break;
            }
            return x;
        }
        private int updateycor(int y, char a, int rows)
        {
            switch (a)
            {
                case 'U': y--; if (y < 0) { y++; } break;
                case 'D': y++; if (y >= rows) { y--; } break;
            }
            return y;
        }
       

        


    }
}
