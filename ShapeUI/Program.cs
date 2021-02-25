using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeUI;

namespace ShapeUI
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string path = "ShapeList.csv";

            /*List<string> lines = File.ReadAllLines(path).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();*/

            //Console.WriteLine(string.Join("",readRecord("Circle","ShapeList.csv",2)));
            //Console.ReadLine();

    /*        var ShapeFactory = new ShapeFactory(path);
            var shapes = ShapeFactory.GetShapes();

            foreach (var Shape in shapes)
            {
                Shape.GetAvailableShapes();
            }*/
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form test = new ShapeSelectorForm();
            Application.Run(test);
        }
        /*public static string[] readRecord(string searchTerm, string filepath, int positionOfSearchTerm)
        {
            positionOfSearchTerm--;
            string[] recordNotFound = {"Record not found"};

            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (recordMatches(searchTerm, fields, positionOfSearchTerm))
                    {
                        Console.WriteLine("Record found");
                        return fields;
                    }
                }

                return recordNotFound;
            }
            catch (Exception ex)
            {
                Console.WriteLine("This program did an oopsie");
                return recordNotFound;
                throw new ApplicationException("This program did an oopsie :", ex);
            }
        }

        public static bool recordMatches(string searchTerm, string[] record, int positionOfSearchTerm)
        {
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
        }*/
    }
}
