using Assignment_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        Graphics g;
        location location = new location();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Bitmap myBitmap;
        public Form1()
        {
            InitializeComponent();
            //entry point
            // myBitmap = new Bitmap(Size.Width, Size.Height);
            myBitmap = new Bitmap(584, 667);
            g = Graphics.FromImage(myBitmap);
        }
        private void drawSpace_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(myBitmap, 0, 0);
        }
        
        public void clear()
        {
            g.Clear(Color.Transparent);
            commandBox.Clear();
            Refresh();
        }
        
        public void reset()
        {
            location.x = 0;
            location.y = 0;
        }
        public void submit()
        {
             if (textCommand.Text.ToLower() == "run")
            {
                foreach (var line in commandBox.Lines) // runs each line of the Command Box through the Text Command textbox
                {
                    String[] scaleCmds = line.ToLower().Split(','); // splits lines when , is used
                    g = ShapeCommand(scaleCmds);

                }
            }
            else
            {
                String[] scaleCmds = textCommand.Text.ToLower().Split(',');
                g = ShapeCommand(scaleCmds);
            }

            Refresh();
            textCommand.Clear();
        }

        private void SaveFile()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("F:\\Year_3\\Advanced_Software_engineering\\DrawApp\\Save\\save.txt");

                foreach (var line in commandBox.Lines)
                {
                    sw.WriteLine(line);
                }

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private string LoadFile()
        {
            string saveRead = null;
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("F:\\Year_3\\Advanced_Software_engineering\\DrawApp\\Save\\save.txt"))
                {
                    while (true)
                    {
                        string lines = sr.ReadLine();
                        if (lines == null)
                        {
                            break;
                        }
                        else
                        {
                            saveRead += lines + Environment.NewLine;
                        }
           
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return saveRead;
        }

        private Graphics ShapeCommand(String[] scaleCmds)
        {
            callShape Call = new callShape(); // inherits from the classes through the callshape class
            Shape s;

            if (scaleCmds[0] == "rectangle")
            {
                s = Call.getShape("RECTANGLE");
                s.set(location.x, location.y, Convert.ToInt16(scaleCmds[1].Trim()) /* width */, Convert.ToInt16(scaleCmds[2].Trim())/* height */);
                s.draw(g);
            }
            else if(scaleCmds[0] == "circle")
            {
                s = Call.getShape("CIRCLE");
                s.set(location.x, location.y, Convert.ToInt16(scaleCmds[1].Trim()) /* radius */);
                s.draw(g);
            }
            else if (scaleCmds[0] == "square")
            {
                s = Call.getShape("SQUARE");
                s.set(location.x, location.y, Convert.ToInt16(scaleCmds[1].Trim()) /* width */, Convert.ToInt16(scaleCmds[2].Trim())/* height */);
                s.draw(g);
            }
            else if (scaleCmds[0] == "triangle")
            {
                s = Call.getShape("TRIANGLE");
                s.set(location.x, location.y, Convert.ToInt16(scaleCmds[1].Trim()) /* x */, Convert.ToInt16(scaleCmds[2].Trim())/* y */,
                    Convert.ToInt16(scaleCmds[3].Trim())/* x */, Convert.ToInt16(scaleCmds[4].Trim())/* y */);
                s.draw(g);
            }
            else if (scaleCmds[0] == "drawto")
            {
                Pen pen = new Pen(Color.Black, 2);
                g.DrawLine(pen, location.x, location.y, /* Gets locations from location.cs */
                    Convert.ToInt16(scaleCmds[1].Trim()), Convert.ToInt16(scaleCmds[2].Trim()));

                location.x = Convert.ToInt16(scaleCmds[1].Trim()); // sets new locations, x and y
                location.y = Convert.ToInt16(scaleCmds[2].Trim());
            }
            else if (scaleCmds[0] == "moveto")
            {
                location.x = Convert.ToInt16(scaleCmds[1].Trim()); // sets new x and y
                location.y = Convert.ToInt16(scaleCmds[2].Trim());
            }
            else if (scaleCmds[0] == "clear")
            {
                clear();
            }
            else if (scaleCmds[0] == "reset")
            {
                reset();
            }
            else if (scaleCmds[0] == "save")
            {
                SaveFile();
            }
            else if (scaleCmds[0] == "load")
            {
                commandBox.Text = LoadFile();
            }

            else {
                MessageBox.Show("Please type in a valid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return g;
        }

        private void textCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) // triggers if enter key is pressed
            {
                submit();
            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            submit();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandBox.Text = LoadFile();
        }
    }

}
