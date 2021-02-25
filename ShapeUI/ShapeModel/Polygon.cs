namespace ShapeUI
{
    public class Polygon : Shape
    {
        public Polygon(int id, string name, Point points) : base(id, name, points)
        {

        }

        public override Shape CreateInstance(int id, string name, Point points)
        {
            throw new System.NotImplementedException();
        }

        public override double Area()
        {
            throw new System.NotImplementedException();
        }
        
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }

        public override Shape GetAvailableShapes()
        {
            throw new System.NotImplementedException();
        }


        public override double Perimeter()
        {
            throw new System.NotImplementedException();
        }
    }
}

/*
 *        public void DrawPolygonPoint(PaintEventArgs e)
        {

 *      // Create pen
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
 */