using ShapeViewerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeUI
{
    public partial class ShapeSelectorForm : Form
    {
        public ShapeSelectorForm()
        {
            InitializeComponent();
        }

        private void ShapeSelectorForm_Load(object sender, EventArgs e)
        {
            shapeDropdownBox.Items.Add("Square");
            shapeDropdownBox.Items.Add("Ellipse");
            shapeDropdownBox.Items.Add("Circle");
            shapeDropdownBox.Items.Add("Equilateral Triangle");
            shapeDropdownBox.Items.Add("Polygon");

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

        private void shapeDropdownBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void choicesDropdownBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ShapeModel model = new ShapeModel();

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
