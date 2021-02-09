using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeViewerLibrary
{
    public class ShapeModel
    {
        public List<Shape> Shapes { get; set; } = new List<Shape>();
        // Might not need the pub string
        public string ShapeName { get; set; }
    }
}
