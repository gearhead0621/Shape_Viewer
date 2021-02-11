using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeViewerLibrary
{
    public interface IDataConnection
    {
        ShapeModel CreateShape(ShapeModel model);
    }
}
