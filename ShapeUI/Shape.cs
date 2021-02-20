using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeUI
{
    public class Point
    {
        public string Type { get; set; }
        public double Value { get; set; }

        public Point()
        {
            this.Type = $"t";
                .Value = $"v";
        }
    }
    
    public class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Points { get; set; } // Not sure if this is correct
        
        // TODO - Add color property

        public Shape()
        {
            this.Id = { }
                .Name = "";
                .Points = null;
        }

        Shape(int id, string name, string[] points)
        {
            // Add something here...
        }

        // virtual Draw() method
        // virtual Area() method
        // virtual Perimeter() method
        // GetAvailableShapes()
    }

    public class Polygon : Shape
    {
        public void Draw
        {
            // Implement Draw()
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

    }
}
