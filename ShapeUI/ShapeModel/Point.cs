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

        public Point()
        {

        }
    }
}
