using System.Collections.Generic;
using System.IO;
using NReco.Csv;

namespace ShapeUI.ShapeModel
{
    public class ShapeFactory
    {
        public List<Shape> Shapes;
        public List<Shape> Triangles;
        public List<Shape> Squares;
        public List<Shape> Circles;
        public List<Shape> Ellipses;
        public List<Shape> Polygons;
        public string path;

        ShapeFactory(string path)
        {
            using (var streamReader = new StreamReader(path))
            {
                var csvReader = new CsvReader(streamReader, ",");
                while (csvReader.Read())
                {
                    // i = 0, id
                    // i = 1, name
                    // i = 2+, points
                    double pointValue = 0.0;
                    string pointType = "";
                    int tmpId = 0;
                    string tmpName = "";

                    for (int i = 0; i < csvReader.FieldsCount; i++)
                    {
                        if (i == 0)
                        {
                            tmpId = int.Parse(csvReader[i]);
                        }
                        if (i == 1)
                        {
                            tmpName = csvReader[i];
                        }
                        else
                        {
                            pointType = csvReader[i];
                            pointValue = double.Parse(csvReader[i]);

                        }
                        Point point = new Point(pointType, pointValue);
                        Shape shape = null;
                        if (tmpName == "Polygon")
                        {
                            //Create a polygon
                            shape = new Polygon(tmpId, tmpName, point);
                        }
                        if (tmpName == "Ellipse")
                        {
                            //Create an ellipse
                            shape = new Ellipse(tmpId, tmpName, point);
                        }
                        if (tmpName == "Equilateral Triangle")
                        {
                            shape = new Triangle(tmpId, tmpName, point);
                        }

                        if (tmpName == "Circle")
                        {
                            shape = new Circle(tmpId, tmpName, point);
                        }

                        if (tmpName == "Square")
                        {
                            shape = new Square(tmpId, tmpName, point);
                        }
                        Shapes.Add(shape);
                    }
                }
            }
        }
    }
}
