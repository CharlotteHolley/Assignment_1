using Assignment_1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Rectangle : Shape
    {
        location location = new location();
        int width, height;
        
        public Rectangle() : base()
        {
            width = 0; // default
            height = 0;
        }
        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            location.x = x;
            location.y = y;
            this.width = width;
            this.height = height;
        }

        public override void set(params int[] list)
        {
            //base.set(list[0] /* x */, list[1] /* y */);
            location.x = list[0];
            location.y = list[1];
            this.width = list[2];
            this.height = list[3];

        }

        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, location.x, location.y, width, height);
        }
    }
}
