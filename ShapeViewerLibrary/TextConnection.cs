using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeViewerLibrary
{
    public class TextConnection : IDataConnection

    {
        // TODO - Wire up the CreateShape for text files.
        public ShapeModel CreateShape(ShapeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
