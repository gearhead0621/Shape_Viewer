namespace ShapeUI.ShapeModel
{
    public class Triangle : Shape
    {
        public Triangle(int id, string name, Point points) : base(id, name, points)
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
