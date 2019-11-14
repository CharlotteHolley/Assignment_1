using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class location
    {
        private int _x;
        private int _y;

        public int x
        {
            get
            {
                return _x; // gets the x value on the bitmap
            }
            set
            {
                _x = value; //sets the new x value from the user input
            }
        }

        public int y
        {
            get
            {
                return _y; // gets the y value on the bitmap
            }
            set
            {
                _y = value; //sets the new y value from the user input
            }
        }
    }

}
