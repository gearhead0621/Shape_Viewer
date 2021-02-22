using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Drawing;

namespace ShapeUI
{
    public class Point
    {
        public string Type { get; set; }
        public double Value { get; set; }

        public Point(string type, double value)
        {
            this.Type = type;
            this.Value = value;
        }
    }
    
    public class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Point Points { get; set; } // Not sure if this is correct struct to use
        
        // TODO - Add color property


        public Shape()
        {

        }
        
        public Shape(int id, string name, Point points)
        {
            this.Id = id;
            this.Name = name;
            this.Points = points;
        }

        public virtual double Area()
        {
            return x * y;
        }

        // virtual Draw() method
        // virtual Perimeter() method
        // GetAvailableShapes()
    }

    public class Polygon : Shape
    {
        public void DrawPolygonPoint(PaintEventArgs e)
        {
            // Create pen
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define polygon
            Point point1 = new Point(50, 50);
            Point point2 = new Point(100, 25);
            Point point3 = new Point(200, 5);
            Point point4 = new Point(250, 50);
            Point point5 = new Point(300, 100);
            Point point6 = new Point(350, 200);
            Point point7 = new Point(250, 250);
            Point[] curvePoints =
            {
                point1,
                point2,
                point3,
                point4,
                point5,
                point6,
                point7
            };

            // Draw polygon to screen
            e.Graphics.DrawPolygon(blackPen, curvePoints);
        }

        public float GetArea()
        {
            // Implement GetArea()
            return 0;
        }

        public float GetPerimeter()
        {
            // Implement GetPerimeter()
            return 0;
        }
    }

    public class Ellipse : Shape
    {
        public void DrawEllipse(PaintEventArgs e)
        {
            e.Graphics.DrawEllipse();
        }

        public float GetArea()
        {
            // Implement GetArea()
            return 0;
        }

        public float GetPerimeter()
        {
            // Implement GetPerimeter()
            return 0;
        }
    }

    public class ShapeFactory
    {
        public Shape[] Shapes();

        ShapeFactory()
        {
            
        }

    }
}
