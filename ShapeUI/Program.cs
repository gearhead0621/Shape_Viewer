using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShapeUI.Shape;

namespace ShapeUI
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the database connections
            ShapeViewerLibrary.GlobalConfig.InitializeConnections(false, true);

            //var shapes = ProcessFile("ShapeList.csv");

            Application.Run(new ShapeSelectorForm());
        }

        //private static List<Shape> ProcessFile(string path)
    }
}
