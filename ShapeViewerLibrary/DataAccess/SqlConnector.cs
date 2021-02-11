using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeViewerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreateShape method actually save to the database
        /// <summary>
        /// Saves a new shape to the database.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ShapeModel CreateShape(ShapeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
