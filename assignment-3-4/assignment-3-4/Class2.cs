using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace deneme
{
    internal class Polygon
    {
        private Point2D _center;  //declaring center data member generate of point class
        private int _radius;        //declaring radius field   
        private int _length;        //declaring length field 
        private int _edges;         //declaring edges field 



        public Point2D center { set => _center = value; get => _center; }        //defining related properties 
        public int edges { set => _edges = value; get => _edges; }
        public int length { set => _length = value; get => _length; }
        

        public Polygon()                 //declaring constructor to determine random values to radius edges length and center in order to prevent empty cordinates
        {
            center = new Point2D();
            Random rand2 = new Random();
            _radius = rand2.Next(1, 100);
            edges = rand2.Next(3, 100);

            center.x = rand2.Next(1, 100);
            center.y = rand2.Next(1, 100);
            length = rand2.Next(3, 30);
        }

        public PointF[] calculateEdgeCordinate()       //declaring caldulate edge cordinates to draw the polygon
        {
            PointF[] p = new PointF[edges];         //declaring a pointf to keep edge cordinates of polygon 
            float p_x, p_y;
            double delta = 360.0 / edges;           //delta is the angle between each of the decimals of the center point to the vertices

            for (int i = 0; i < edges; i++)         // to keep cordinates of every edge "for" loop is used
            {
                p_x = Convert.ToSingle(center.x + length * Math.Cos(delta * i * Math.PI / 180));
                p_y = Convert.ToSingle(center.y + length * Math.Sin(delta * i * Math.PI / 180));
                p[i] = new PointF(p_x, p_y);
            }
            return p;
        }
    }
}

