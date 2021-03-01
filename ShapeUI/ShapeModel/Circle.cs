using System.Runtime.Remoting.Messaging;
using ShapeUI.ShapeModel;

namespace ShapeUI
{
    public class Circle : IShape {

        private double _centerX;
        private double _centerY;
        private double _radius;


        public double Perimeter => 2 * System.Math.PI * _radius;


        public double CalculateArea() {
            return System.Math.PI * _radius * _radius;

        }
    }
}
