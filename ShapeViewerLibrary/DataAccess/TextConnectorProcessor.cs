using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Load the text file
// Convert the text to List<ShapeModel>
// Find the max ID
// Add the new record with the new ID (max + 1)
// Convert the shapes to list<string>
// Save the list<string> to the text file

namespace ShapeViewerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) // ShapeModels.csv
        {
            // C:\data\ShapeModelViewer\ShapeModels.csv
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<ShapeModel> ConvertToShapeModels(this List<string> lines)
        {
            List<ShapeModel> output = new List<ShapeModel>();

            foreach (string line in lines)
            {
                String[] cols = line.Split(',');

                ShapeModel p = new ShapeModel();
                p.Id = int.Parse(cols[0]);
                output.Add(p);
                // TODO - Add other parameters for shape model csv file
            }

            return output;
        }
    }
}
