using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class drawShape
    {
        public drawShape()
        {

        }

        public Graphics drawCircle(string[] scaleCmds, Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Black, 2), Convert.ToInt16(scaleCmds[1].Trim()) /* x */, Convert.ToInt16(scaleCmds[2].Trim()) /* y */,
                    Convert.ToInt16(scaleCmds[3].Trim()) /* width */, Convert.ToInt16(scaleCmds[4].Trim())/* height */);

            return g;
        }

        public Graphics drawSquare(string[] scaleCmds, Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black, 2), Convert.ToInt16(scaleCmds[1].Trim()) /* x */, Convert.ToInt16(scaleCmds[2].Trim()) /* y */,
                    Convert.ToInt16(scaleCmds[3].Trim()) /* width */, Convert.ToInt16(scaleCmds[4].Trim())/* height */);
            return g;
        }

        public Graphics drawTriangle(string[] scaleCmds, Graphics g)
        {

            Point[] pnt = new Point[3];

            pnt[0].X = Convert.ToInt16(scaleCmds[1].Trim()); //Example size: 150
            pnt[0].Y = Convert.ToInt16(scaleCmds[2].Trim()); //Example size: 150

            pnt[1].X = Convert.ToInt16(scaleCmds[3].Trim()); //Example size: 150
            pnt[1].Y = Convert.ToInt16(scaleCmds[4].Trim()); //Example size: 200

            pnt[2].X = Convert.ToInt16(scaleCmds[5].Trim()); //Example size: 50
            pnt[2].Y = Convert.ToInt16(scaleCmds[6].Trim()); //Example size: 120

            Pen pen = new Pen(Color.Black, 2);
            g.DrawPolygon(pen, pnt);
            
            return g;
        }
    }
}
