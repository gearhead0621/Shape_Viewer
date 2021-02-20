using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace ShapeUI
{
    public partial class ShapeSelectorForm : Form
    {
        public ShapeSelectorForm()
        {
            InitializeComponent();
            shapeDropdownBox.Items.Add("Square");
            shapeDropdownBox.Items.Add("Ellipse");
            shapeDropdownBox.Items.Add("Circle");
            shapeDropdownBox.Items.Add("Equilateral Triangle");
            shapeDropdownBox.Items.Add("Polygon");
        }

        private void ShapeSelectorForm_Load(object sender, EventArgs e)
        {
           
        }

        private void shapeDropdownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shapeChoicesBox.ClearSelected();
            
            if ((string)shapeDropdownBox.SelectedItem == ("Square"))
            {
                using (TextFieldParser parser = new TextFieldParser(@"C:\Github Repo\Shape_Viewer\ShapeUI\ShapeList.csv"))
                {
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        foreach (string field in fields)
                        {
                            shapeChoicesBox.Show();
                        }
                    }
                }
            }

            if ((string) shapeDropdownBox.SelectedItem == ("Ellipse"))
            {
                MessageBox.Show("This is an ellipse.");
            }

            if ((string)shapeDropdownBox.SelectedItem == ("Circle"))
            {
                MessageBox.Show("This is a circle.");
            }

            if ((string)shapeDropdownBox.SelectedItem == ("Equilateral Triangle"))
            {
                MessageBox.Show("This is an equilateral triangle.");
            }

            if ((string)shapeDropdownBox.SelectedItem == ("Polygon"))
            {
                MessageBox.Show("This is a polygon.");
            }
        }

        private void shapeChoicesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {

        }

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //ShapeModel model = new ShapeModel();

                //GlobalConfig.Connection.CreateShape(model);
            }
        }

        // May not be applicable for what I'm doing...
        /// <summary>
        /// Used to validate the entries that the user submits into the form.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            bool output = true;

            return output;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
