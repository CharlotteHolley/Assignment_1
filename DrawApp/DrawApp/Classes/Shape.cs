using Assignment_1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DrawApp
{
    abstract class Shape:Shapes
    {
        protected int x, y;

        public Shape()
        {
            x = y = 100;
        }

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public abstract void draw(Graphics g);
     
        public virtual void set(params int[] list)
        {
            x = list[0];
            y = list[1];
        }
    }
}