﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class callShape
    {
        public Shape getShape(String shapeType)
        {
            shapeType = shapeType.ToUpper().Trim();


            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();

            }
            else if (shapeType.Equals("TRIANGLE"))
            {
                return new Triangle();

            }
            else
            {

                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
                throw argEx;
            }

        }

    }
}
