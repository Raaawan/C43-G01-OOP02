using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    #region Question 2
    //2.Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points
    //as input from the user and calculates the distance between them.

    #endregion
    internal struct Point
    {
        #region
        private int X;
        private int Y;
        #endregion



        #region Properties
        public int xProperty { get; set; }
        public int yProperty { get; set; }

        #endregion

        #region constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }


        #endregion

        #region Methods
        public double getDistance(Point point)
        {
            return Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2));
        }

        public override string ToString() {
            return $"value of x is: {X} and value of y is {Y}";
        } 
        #endregion


    }
}
