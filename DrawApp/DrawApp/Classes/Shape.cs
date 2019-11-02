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
        location location = new location();

        public Shape()
        {
            location.x = location.y = 100;
        }

        public Shape(int x, int y)
        {
            location.x = x;
            location.y = y;

        }

        public abstract void draw(Graphics g);
     
        public virtual void set(params int[] list)
        {
            location.x = list[0];
            location.y = list[1];
        }
    }
}