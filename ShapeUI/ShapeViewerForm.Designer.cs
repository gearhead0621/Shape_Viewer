
namespace ShapeUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeLabel = new System.Windows.Forms.Label();
            this.shapeDropdownbox = new System.Windows.Forms.ComboBox();
            this.choicesLabel = new System.Windows.Forms.Label();
            this.choicesDropdownBox = new System.Windows.Forms.ComboBox();
            this.shapeListBox = new System.Windows.Forms.ListBox();
            this.shapeImageBox = new System.Windows.Forms.PictureBox();
            this.removeSelectedShapeButton = new System.Windows.Forms.Button();
            this.currentShapeArea = new System.Windows.Forms.Label();
            this.currentShapePerimeter = new System.Windows.Forms.Label();
            this.collectionTotalArea = new System.Windows.Forms.Label();
            this.collectionTotalPerimeter = new System.Windows.Forms.Label();
            this.currentShapeAreaText = new System.Windows.Forms.Label();
            this.currentShapePerimeterText = new System.Windows.Forms.Label();
            this.totalShapePerimeterText = new System.Windows.Forms.Label();
            this.totalShapeAreaText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shapeImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(34, 47);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(75, 30);
            this.shapeLabel.TabIndex = 0;
            this.shapeLabel.Text = "Shape:";
            this.shapeLabel.Click += new System.EventHandler(this.shapeLabel_Click);
            // 
            // shapeDropdownbox
            // 
            this.shapeDropdownbox.FormattingEnabled = true;
            this.shapeDropdownbox.Location = new System.Drawing.Point(130, 44);
            this.shapeDropdownbox.Name = "shapeDropdownbox";
            this.shapeDropdownbox.Size = new System.Drawing.Size(163, 38);
            this.shapeDropdownbox.TabIndex = 1;
            // 
            // choicesLabel
            // 
            this.choicesLabel.AutoSize = true;
            this.choicesLabel.Location = new System.Drawing.Point(34, 108);
            this.choicesLabel.Name = "choicesLabel";
            this.choicesLabel.Size = new System.Drawing.Size(90, 30);
            this.choicesLabel.TabIndex = 2;
            this.choicesLabel.Text = "Choices:";
            // 
            // choicesDropdownBox
            // 
            this.choicesDropdownBox.FormattingEnabled = true;
            this.choicesDropdownBox.Location = new System.Drawing.Point(130, 105);
            this.choicesDropdownBox.Name = "choicesDropdownBox";
            this.choicesDropdownBox.Size = new System.Drawing.Size(163, 38);
            this.choicesDropdownBox.TabIndex = 3;
            // 
            // shapeListBox
            // 
            this.shapeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapeListBox.FormattingEnabled = true;
            this.shapeListBox.ItemHeight = 30;
            this.shapeListBox.Location = new System.Drawing.Point(39, 201);
            this.shapeListBox.Name = "shapeListBox";
            this.shapeListBox.Size = new System.Drawing.Size(254, 152);
            this.shapeListBox.TabIndex = 4;
            // 
            // shapeImageBox
            // 
            this.shapeImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapeImageBox.Location = new System.Drawing.Point(519, 44);
            this.shapeImageBox.Name = "shapeImageBox";
            this.shapeImageBox.Size = new System.Drawing.Size(410, 210);
            this.shapeImageBox.TabIndex = 5;
            this.shapeImageBox.TabStop = false;
            // 
            // removeSelectedShapeButton
            // 
            this.removeSelectedShapeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedShapeButton.Location = new System.Drawing.Point(313, 249);
            this.removeSelectedShapeButton.Name = "removeSelectedShapeButton";
            this.removeSelectedShapeButton.Size = new System.Drawing.Size(79, 55);
            this.removeSelectedShapeButton.TabIndex = 6;
            this.removeSelectedShapeButton.Text = "Remove Selected";
            this.removeSelectedShapeButton.UseVisualStyleBackColor = true;
            // 
            // currentShapeArea
            // 
            this.currentShapeArea.AutoSize = true;
            this.currentShapeArea.Location = new System.Drawing.Point(514, 274);
            this.currentShapeArea.Name = "currentShapeArea";
            this.currentShapeArea.Size = new System.Drawing.Size(124, 30);
            this.currentShapeArea.TabIndex = 7;
            this.currentShapeArea.Text = "Shape Area:";
            // 
            // currentShapePerimeter
            // 
            this.currentShapePerimeter.AutoSize = true;
            this.currentShapePerimeter.Location = new System.Drawing.Point(514, 313);
            this.currentShapePerimeter.Name = "currentShapePerimeter";
            this.currentShapePerimeter.Size = new System.Drawing.Size(169, 30);
            this.currentShapePerimeter.TabIndex = 8;
            this.currentShapePerimeter.Text = "Shape Perimeter:";
            // 
            // collectionTotalArea
            // 
            this.collectionTotalArea.AutoSize = true;
            this.collectionTotalArea.Location = new System.Drawing.Point(34, 381);
            this.collectionTotalArea.Name = "collectionTotalArea";
            this.collectionTotalArea.Size = new System.Drawing.Size(174, 30);
            this.collectionTotalArea.TabIndex = 9;
            this.collectionTotalArea.Text = "Total Shape Area:";
            // 
            // collectionTotalPerimeter
            // 
            this.collectionTotalPerimeter.AutoSize = true;
            this.collectionTotalPerimeter.Location = new System.Drawing.Point(34, 425);
            this.collectionTotalPerimeter.Name = "collectionTotalPerimeter";
            this.collectionTotalPerimeter.Size = new System.Drawing.Size(219, 30);
            this.collectionTotalPerimeter.TabIndex = 10;
            this.collectionTotalPerimeter.Text = "Total Shape Perimeter:";
            // 
            // currentShapeAreaText
            // 
            this.currentShapeAreaText.AutoSize = true;
            this.currentShapeAreaText.Location = new System.Drawing.Point(713, 274);
            this.currentShapeAreaText.Name = "currentShapeAreaText";
            this.currentShapeAreaText.Size = new System.Drawing.Size(214, 30);
            this.currentShapeAreaText.TabIndex = 11;
            this.currentShapeAreaText.Text = "<current shape area>";
            // 
            // currentShapePerimeterText
            // 
            this.currentShapePerimeterText.AutoSize = true;
            this.currentShapePerimeterText.Location = new System.Drawing.Point(713, 313);
            this.currentShapePerimeterText.Name = "currentShapePerimeterText";
            this.currentShapePerimeterText.Size = new System.Drawing.Size(263, 30);
            this.currentShapePerimeterText.TabIndex = 12;
            this.currentShapePerimeterText.Text = "<current shape perimeter>";
            // 
            // totalShapePerimeterText
            // 
            this.totalShapePerimeterText.AutoSize = true;
            this.totalShapePerimeterText.Location = new System.Drawing.Point(265, 425);
            this.totalShapePerimeterText.Name = "totalShapePerimeterText";
            this.totalShapePerimeterText.Size = new System.Drawing.Size(239, 30);
            this.totalShapePerimeterText.TabIndex = 13;
            this.totalShapePerimeterText.Text = "<total shape perimeter>";
            // 
            // totalShapeAreaText
            // 
            this.totalShapeAreaText.AutoSize = true;
            this.totalShapeAreaText.Location = new System.Drawing.Point(265, 381);
            this.totalShapeAreaText.Name = "totalShapeAreaText";
            this.totalShapeAreaText.Size = new System.Drawing.Size(190, 30);
            this.totalShapeAreaText.TabIndex = 14;
            this.totalShapeAreaText.Text = "<total shape area>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 541);
            this.Controls.Add(this.totalShapeAreaText);
            this.Controls.Add(this.totalShapePerimeterText);
            this.Controls.Add(this.currentShapePerimeterText);
            this.Controls.Add(this.currentShapeAreaText);
            this.Controls.Add(this.collectionTotalPerimeter);
            this.Controls.Add(this.collectionTotalArea);
            this.Controls.Add(this.currentShapePerimeter);
            this.Controls.Add(this.currentShapeArea);
            this.Controls.Add(this.removeSelectedShapeButton);
            this.Controls.Add(this.shapeImageBox);
            this.Controls.Add(this.shapeListBox);
            this.Controls.Add(this.choicesDropdownBox);
            this.Controls.Add(this.choicesLabel);
            this.Controls.Add(this.shapeDropdownbox);
            this.Controls.Add(this.shapeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Shape Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.shapeImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.ComboBox shapeDropdownbox;
        private System.Windows.Forms.Label choicesLabel;
        private System.Windows.Forms.ComboBox choicesDropdownBox;
        private System.Windows.Forms.ListBox shapeListBox;
        private System.Windows.Forms.PictureBox shapeImageBox;
        private System.Windows.Forms.Button removeSelectedShapeButton;
        private System.Windows.Forms.Label currentShapeArea;
        private System.Windows.Forms.Label currentShapePerimeter;
        private System.Windows.Forms.Label collectionTotalArea;
        private System.Windows.Forms.Label collectionTotalPerimeter;
        private System.Windows.Forms.Label currentShapeAreaText;
        private System.Windows.Forms.Label currentShapePerimeterText;
        private System.Windows.Forms.Label totalShapePerimeterText;
        private System.Windows.Forms.Label totalShapeAreaText;
    }
}

