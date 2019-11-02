using Assignment_1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DrawApp
{
    class Square : Rectangle
    {
        private int size;

        public Square() : base()
        {

        }
        public Square(int x, int y, int size) : base(x, y, size, size)
        {
            this.size = size;
        }
    }
}