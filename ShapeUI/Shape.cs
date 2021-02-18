using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeUI
{
    public class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Point1Type { get; set; }
        public int Point1Value { get; set; }
        public string Point2Type { get; set; }
        public int Point2Value { get; set; }
        public string Point3Type { get; set; }
        public int Point3Value { get; set; }
        public string Point4Type { get; set; }
        
        public string Point5Type { get; set; }
        
        public string Point6Type { get; set; }
        
        public string Point7Type { get; set; }


        public static Shape ParseFromCsv<TResult>(string line)
        {
            var columns = line.Split(',');

            return new Shape
            {
                Id = int.Parse(columns[0]),
                Name = columns[1],
                Point1Type = columns[2],
                Point1Value = int.Parse(columns[3]),
                Point2Type = columns[4],
            };
        }
    }
}
