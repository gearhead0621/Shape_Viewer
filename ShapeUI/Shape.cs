using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

    public class ShapeFactory
    {
        public Shape[] Shapes();

        ShapeFactory()
        {

            // Fetch the raw data
            public string Path = "PSScriptRoot" + "\\ShapeList.csv";
            public string RawData = import - csv @"C:\Github Repo\Shape_Viewer\ShapeUI\ShapeList.csv";

            // RawData format: ID | Name | Points[X]
            // Points[X] = (pointXType,pointXValue)

            //public string tmpShapes = foreach (var object in public string RawData1 => RawData)
            //{
                //public string tmp = [PSCustomObject]::new()
                //string properties = object | Get-Member -MemberTypes Properties | Select -ExpandProperty Name // Pulls just the header names
                //foreach (var property in string Properties)
                //{
                    //if (string object.property.length != 0)
                        //{
                            //tmp | Add-Member -NotePropertyName string property -NotePropertyValue string object.property
                        //}
                //}


            //}

        }

    }
}
