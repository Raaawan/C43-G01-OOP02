using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Rectangle
    {

        #region Attributes
        private double width;
        private double height;
        #endregion


        #region constructor
        public Rectangle(double width, double height)
        {
            this.width = width; 
            this.height = height;
        }
        #endregion

        #region properties
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Width can not be a negative value");
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Height can not be a negative value");
                }
            }
        }

        public double Area {
            get {
                return width * height;
            }
        }

        #endregion

        #region methods
        public string DisplayInfo()
        {
            return $"width is {Width}\nHeight is {Height}\nAnd Area is {Area} ";
        }
        #endregion
    }
}
