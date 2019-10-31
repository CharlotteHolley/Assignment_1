using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        bool mouseDown = false;
        Bitmap myBitmap;

        public Form1()
        {
            myBitmap = new Bitmap(Size.Width, Size.Height);
            Graphics g = Graphics.FromImage(myBitmap);

            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string command = textCommand.Text;
            string[] scaleCmds = command.Split(',');
            shapeCommands(scaleCmds);

            textCommand.Clear();

        }

        public void shapeCommands(string [] scaleCmds)
        {
            Graphics g = Graphics.FromImage(myBitmap);
            g = Graphics.FromImage(myBitmap);

            if (scaleCmds[0] == "Circle" || scaleCmds[0] == "circle")
            {
                g.DrawEllipse(new Pen(Color.Black, 2), Convert.ToInt16(scaleCmds[1].Trim()), Convert.ToInt16(scaleCmds[2].Trim()), Convert.ToInt16(scaleCmds[3].Trim()), Convert.ToInt16(scaleCmds[4].Trim()));
            }
            else if (scaleCmds[0] == "Square" || scaleCmds[0] == "square")
            {
                g.DrawRectangle(new Pen(Color.Black, 2), Convert.ToInt16(scaleCmds[1].Trim()), Convert.ToInt16(scaleCmds[2].Trim()), Convert.ToInt16(scaleCmds[3].Trim()), Convert.ToInt16(scaleCmds[4].Trim()));
            }
            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(myBitmap, 0, 0);
        }
        
        private void textCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit_Click(this, new EventArgs());
            }
        }
    }
}
