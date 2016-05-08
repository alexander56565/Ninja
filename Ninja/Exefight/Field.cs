using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public class Field
    {
        public char[,] Wmatrix{get; set;}
        public int[,] Nmatrix { get; set; }
        private int rows;
        private int columns;
        private int ax;
        private int ay;
        private int bx;
        private int by;
        public Field(char[,] wmatrix)
        {
            

            this.rows = wmatrix.GetLength(0);
            this.columns = wmatrix.GetLength(1);
            this.Nmatrix = new int[wmatrix.GetLength(0), wmatrix.GetLength(1)];
            this.Wmatrix = new char[wmatrix.GetLength(0), wmatrix.GetLength(1)];
           // Wmatrix = wmatrix;
            for (int i = 0; i < wmatrix.GetLength(0); i++)
            {

                for (int j = 0; j < wmatrix.GetLength(1); j++)
                {
                    this.Wmatrix[i, j] = wmatrix[i, j];
                    this.Nmatrix[i, j] = 0;
                };
            }
            
        }
        public int Ax
        {
            get;set;
        }
        public int Ay
        {
            get; set;
        }
        public int Bx
        {
            get; set;
        }
        public int By
        {
            get; set;
        }
        //public int setNmatrix(char a)
        //{
        //    Vegetable output = createvegetable(a);
        //    return output.Delay;
       // }

        public Vegetable createvegetable(char a,int blank)
        {
            Vegetable output;
            if (blank != 0) { output = new BlankSpace(); return output; }
            switch (a)
            {
                case 'A':  output = new Asparagus(); return output; break;
                case 'B': output = new Broccoli(); return output; break;
                case 'C': output = new CherryBerry(); return output; break;
                case 'M': output = new Mushroom(); return output; break;
                case 'R': output = new Royal(); return output; break;
                case '-': output = new BlankSpace(); return output; break;
                default: output = new BlankSpace(); return output;
            }
            output = null;
            return output;
            
        }

        public Vegetable stepOnField(Ninja current, Ninja Other)
        {
            Vegetable output = createvegetable(this.Wmatrix[current.X, current.Y], this.Nmatrix[current.X, current.Y]);
            
            this.Ax = current.X;
            this.Ay = current.Y;
            this.Bx = Other.X;
            this.By = Other.Y;

            
            if (Nmatrix[current.X, current.Y]==0)
            {
                Nmatrix[current.X, current.Y] -= output.Delay;
                return output;
            }
            return null;

        }

       

        public void updateField()
        {
            for(int i=0; i< rows; i++)
            {
                for(int j=0; j< columns; j++)
                {
                    Vegetable A = this.createvegetable(Wmatrix[i,j],0);
                    if (!((i == Ax && j == Ay) || (i == Bx && j == By)))
                    { Nmatrix[i, j]++; if (Nmatrix[i, j] > 0) { Nmatrix[i, j]=0; } }
                } 
            }

        }







       
    }
}
