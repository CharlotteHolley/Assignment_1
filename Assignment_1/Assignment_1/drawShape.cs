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

            Point[] TriPoints = new Point[3];

            TriPoints[0].X = Convert.ToInt16(scaleCmds[1].Trim()); //Example size: 150
            TriPoints[0].Y = Convert.ToInt16(scaleCmds[2].Trim()); //Example size: 150

            TriPoints[1].X = Convert.ToInt16(scaleCmds[3].Trim()); //Example size: 150
            TriPoints[1].Y = Convert.ToInt16(scaleCmds[4].Trim()); //Example size: 200

            TriPoints[2].X = Convert.ToInt16(scaleCmds[5].Trim()); //Example size: 50
            TriPoints[2].Y = Convert.ToInt16(scaleCmds[6].Trim()); //Example size: 120

            Pen pen = new Pen(Color.Black, 2);
            g.DrawPolygon(pen, TriPoints);
            
            return g;
        }
    }
}
