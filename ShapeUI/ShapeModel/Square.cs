using ShapeUI.ShapeModel;

namespace ShapeUI
{
    public class Square : IShape {


        private double _sideLength;
        private double _orientation;
        private double _centerX;
        private double _centerY;
        

        public Square(double sideLength, double orientation, double centerX, double centerY) {
            _sideLength  = sideLength;
            _orientation = orientation;
            _centerX     = centerX;
            _centerY     = centerY;
        }


        public double Perimeter       { get; set; }
        public double CalculateArea() {
            throw new System.NotImplementedException();
        }
    }
}
