using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeViewerLibrary
{
    /// <summary>
    /// Represents what the shape is and its dimensions.
    /// </summary>
    public class Shape
    {
       /// <summary>
       /// The unique identifier for each shape.
       /// </summary>
        public int Id { get; set; }

       public List<Shape> Shapes { get; set; }
    }

    public class Name
    {
        public string Name { get; set; }

    }

}
