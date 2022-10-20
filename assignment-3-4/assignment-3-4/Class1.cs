using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Point2D
    {
        public float x,y; //declaring cordinates x and y data members
        public int ccx, ccy; //declaring cartesian cordinates x and y data members
        public double alpha, beta;  //declaring angles
        public double r,q;      //declaring r and q
        public Point2D()            //declaring constructor to determine random values to cordinates in order to prevent empty cordinates
        {
            Random rnd = new Random();      
            int clone_x = rnd.Next(1, 100);     //random x is arranged between 1 and 100
            int clone_y = rnd.Next(1, 100);     //random y is arranged between 1 and 100
            x = Convert.ToSingle(clone_x);      //clone random value come up to main x cordinate      
            y = Convert.ToSingle(clone_y);      //clone random value come up to main x cordinate   
        }
        public void printCordinates()      //declaring print cordinates method
        {
            System.Console.WriteLine("X COORDINATE IS : " + x);     //printing x cordinate
            System.Console.WriteLine("Y COORDINATE IS : " + y);     //printing y cordinate
        }
        public void calculatePolarCordinates()       //declaring calculate polar cordinates method
        {
            r = (x * x + y * y);                //according to intermediate math r and q are calculated
            r = Math.Sqrt(r);
            q = Math.Atan(y / x) * 57.295;
        }
        public void CalculateCartesianCoordinates()     //declaring calculate cartesian cordinates method
        {
            ccx = Convert.ToInt32(r * Math.Cos(q));   
            ccy = Convert.ToInt32(r * Math.Sin(q));
        }
        public void PrintSphericalCordinates()      //declaring print spherical cordinates method
        {
            alpha = 90 - q;
            beta = 90;
            System.Console.WriteLine("( " + r + " , " + alpha + " , " + beta + " )");
        }
    }
}
