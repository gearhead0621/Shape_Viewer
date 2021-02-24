using System.Collections.Generic;

namespace ShapeUI.ShapeModel
{
    public abstract class Shape
    {
        public abstract Shape CreateInstance(int id, string name, Point points);

        public int Id { get; set; }
        public string Name { get; set; }
        internal List<Point> Points;
        
        // TODO - Add color property
        
        public Shape()
        {
            Id = 0;
            Name = "";
            Points = new List<Point>();
        }

        protected Shape(int id, string name, Point points)
        {
            Id = id;
            Name = name;
            Points = new List<Point>();
            Points.Add(points);
        }

        public abstract double Area();
        public abstract double Perimeter();
        public abstract Shape GetAvailableShapes();
        public abstract void Draw();
    }

    
}
