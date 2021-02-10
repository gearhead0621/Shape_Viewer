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
    public class ShapeModel
    {
       /// <summary>
       /// The unique identifier for each shape.
       /// </summary>
        public int Id { get; set; }
        
        public List<Shape> Shapes { get; set; } = new List<Shape>();
        // Might not need the pub string
        public string ShapeName { get; set; }
    }

    public class Shape
    {
    }
}
