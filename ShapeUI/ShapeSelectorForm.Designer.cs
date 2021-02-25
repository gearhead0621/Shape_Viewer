
namespace ShapeUI
{
    partial class ShapeSelectorForm 
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
            this.shapeDropdownBox = new System.Windows.Forms.ComboBox();
            this.choicesLabel = new System.Windows.Forms.Label();
            this.shapeListBox = new System.Windows.Forms.ListBox();
            this.totalShapeAreaLabel = new System.Windows.Forms.Label();
            this.totalShapePerimeterLabel = new System.Windows.Forms.Label();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.shapeDisplayBox = new System.Windows.Forms.PictureBox();
            this.currentShapeAreaLabel = new System.Windows.Forms.Label();
            this.currentShapePerimeterLabel = new System.Windows.Forms.Label();
            this.currentShapeAreaValue = new System.Windows.Forms.Label();
            this.currentShapePerimeterValue = new System.Windows.Forms.Label();
            this.totalShapeAreaValue = new System.Windows.Forms.Label();
            this.totalShapePerimeterValue = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.shapeChoicesBox = new System.Windows.Forms.ListBox();
            this.shapeAddSelectedButton = new System.Windows.Forms.Button();
            this.shapeCollectionLabel = new System.Windows.Forms.Label();
            this.shapeColorLabel = new System.Windows.Forms.Label();
            this.shapeColorComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeLabel.Location = new System.Drawing.Point(62, 62);
            this.shapeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(70, 24);
            this.shapeLabel.TabIndex = 0;
            this.shapeLabel.Text = "Shape:";
            // 
            // shapeDropdownBox
            // 
            this.shapeDropdownBox.FormattingEnabled = true;
            this.shapeDropdownBox.Location = new System.Drawing.Point(165, 59);
            this.shapeDropdownBox.Margin = new System.Windows.Forms.Padding(6);
            this.shapeDropdownBox.Name = "shapeDropdownBox";
            this.shapeDropdownBox.Size = new System.Drawing.Size(219, 32);
            this.shapeDropdownBox.TabIndex = 1;
            this.shapeDropdownBox.SelectedIndexChanged += new System.EventHandler(this.shapeDropdownBox_SelectedIndexChanged);
            // 
            // choicesLabel
            // 
            this.choicesLabel.AutoSize = true;
            this.choicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choicesLabel.Location = new System.Drawing.Point(61, 108);
            this.choicesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.choicesLabel.Name = "choicesLabel";
            this.choicesLabel.Size = new System.Drawing.Size(96, 25);
            this.choicesLabel.TabIndex = 2;
            this.choicesLabel.Text = "Choices:";
            // 
            // shapeListBox
            // 
            this.shapeListBox.FormattingEnabled = true;
            this.shapeListBox.ItemHeight = 24;
            this.shapeListBox.Location = new System.Drawing.Point(165, 263);
            this.shapeListBox.Margin = new System.Windows.Forms.Padding(6);
            this.shapeListBox.Name = "shapeListBox";
            this.shapeListBox.Size = new System.Drawing.Size(219, 172);
            this.shapeListBox.TabIndex = 4;
            // 
            // totalShapeAreaLabel
            // 
            this.totalShapeAreaLabel.AutoSize = true;
            this.totalShapeAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalShapeAreaLabel.Location = new System.Drawing.Point(61, 452);
            this.totalShapeAreaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalShapeAreaLabel.Name = "totalShapeAreaLabel";
            this.totalShapeAreaLabel.Size = new System.Drawing.Size(185, 25);
            this.totalShapeAreaLabel.TabIndex = 5;
            this.totalShapeAreaLabel.Text = "Total Shape Area:";
            this.totalShapeAreaLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // totalShapePerimeterLabel
            // 
            this.totalShapePerimeterLabel.AutoSize = true;
            this.totalShapePerimeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalShapePerimeterLabel.Location = new System.Drawing.Point(61, 477);
            this.totalShapePerimeterLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalShapePerimeterLabel.Name = "totalShapePerimeterLabel";
            this.totalShapePerimeterLabel.Size = new System.Drawing.Size(232, 25);
            this.totalShapePerimeterLabel.TabIndex = 6;
            this.totalShapePerimeterLabel.Text = "Total Shape Perimeter:";
            this.totalShapePerimeterLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.Location = new System.Drawing.Point(396, 288);
            this.removeSelectedButton.Margin = new System.Windows.Forms.Padding(6);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(138, 58);
            this.removeSelectedButton.TabIndex = 7;
            this.removeSelectedButton.Text = "Remove Selected";
            this.removeSelectedButton.UseVisualStyleBackColor = true;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // shapeDisplayBox
            // 
            this.shapeDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapeDisplayBox.Location = new System.Drawing.Point(719, 33);
            this.shapeDisplayBox.Margin = new System.Windows.Forms.Padding(6);
            this.shapeDisplayBox.Name = "shapeDisplayBox";
            this.shapeDisplayBox.Size = new System.Drawing.Size(493, 276);
            this.shapeDisplayBox.TabIndex = 8;
            this.shapeDisplayBox.TabStop = false;
            // 
            // currentShapeAreaLabel
            // 
            this.currentShapeAreaLabel.AutoSize = true;
            this.currentShapeAreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentShapeAreaLabel.Location = new System.Drawing.Point(714, 334);
            this.currentShapeAreaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentShapeAreaLabel.Name = "currentShapeAreaLabel";
            this.currentShapeAreaLabel.Size = new System.Drawing.Size(182, 24);
            this.currentShapeAreaLabel.TabIndex = 9;
            this.currentShapeAreaLabel.Text = "Current Shape Area:";
            // 
            // currentShapePerimeterLabel
            // 
            this.currentShapePerimeterLabel.AutoSize = true;
            this.currentShapePerimeterLabel.Location = new System.Drawing.Point(714, 358);
            this.currentShapePerimeterLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentShapePerimeterLabel.Name = "currentShapePerimeterLabel";
            this.currentShapePerimeterLabel.Size = new System.Drawing.Size(223, 24);
            this.currentShapePerimeterLabel.TabIndex = 10;
            this.currentShapePerimeterLabel.Text = "Current Shape Perimeter:";
            // 
            // currentShapeAreaValue
            // 
            this.currentShapeAreaValue.AutoSize = true;
            this.currentShapeAreaValue.Location = new System.Drawing.Point(952, 334);
            this.currentShapeAreaValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentShapeAreaValue.Name = "currentShapeAreaValue";
            this.currentShapeAreaValue.Size = new System.Drawing.Size(190, 24);
            this.currentShapeAreaValue.TabIndex = 11;
            this.currentShapeAreaValue.Text = "<current shape area>";
            // 
            // currentShapePerimeterValue
            // 
            this.currentShapePerimeterValue.AutoSize = true;
            this.currentShapePerimeterValue.Location = new System.Drawing.Point(952, 358);
            this.currentShapePerimeterValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentShapePerimeterValue.Name = "currentShapePerimeterValue";
            this.currentShapePerimeterValue.Size = new System.Drawing.Size(233, 24);
            this.currentShapePerimeterValue.TabIndex = 12;
            this.currentShapePerimeterValue.Text = "<current shape perimeter>";
            // 
            // totalShapeAreaValue
            // 
            this.totalShapeAreaValue.AutoSize = true;
            this.totalShapeAreaValue.Location = new System.Drawing.Point(305, 453);
            this.totalShapeAreaValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalShapeAreaValue.Name = "totalShapeAreaValue";
            this.totalShapeAreaValue.Size = new System.Drawing.Size(164, 24);
            this.totalShapeAreaValue.TabIndex = 13;
            this.totalShapeAreaValue.Text = "<total shape area>";
            // 
            // totalShapePerimeterValue
            // 
            this.totalShapePerimeterValue.AutoSize = true;
            this.totalShapePerimeterValue.Location = new System.Drawing.Point(305, 478);
            this.totalShapePerimeterValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalShapePerimeterValue.Name = "totalShapePerimeterValue";
            this.totalShapePerimeterValue.Size = new System.Drawing.Size(207, 24);
            this.totalShapePerimeterValue.TabIndex = 14;
            this.totalShapePerimeterValue.Text = "<total shape perimeter>";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(567, 49);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 37);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(486, 49);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 37);
            this.loadButton.TabIndex = 16;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(1176, 567);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 44);
            this.quitButton.TabIndex = 17;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // shapeChoicesBox
            // 
            this.shapeChoicesBox.FormattingEnabled = true;
            this.shapeChoicesBox.ItemHeight = 24;
            this.shapeChoicesBox.Location = new System.Drawing.Point(166, 108);
            this.shapeChoicesBox.Name = "shapeChoicesBox";
            this.shapeChoicesBox.Size = new System.Drawing.Size(218, 100);
            this.shapeChoicesBox.TabIndex = 18;
            this.shapeChoicesBox.SelectedIndexChanged += new System.EventHandler(this.shapeChoicesBox_SelectedIndexChanged);
            // 
            // shapeAddSelectedButton
            // 
            this.shapeAddSelectedButton.Location = new System.Drawing.Point(390, 127);
            this.shapeAddSelectedButton.Name = "shapeAddSelectedButton";
            this.shapeAddSelectedButton.Size = new System.Drawing.Size(102, 59);
            this.shapeAddSelectedButton.TabIndex = 19;
            this.shapeAddSelectedButton.Text = "Add Selected";
            this.shapeAddSelectedButton.UseVisualStyleBackColor = true;
            // 
            // shapeCollectionLabel
            // 
            this.shapeCollectionLabel.AutoSize = true;
            this.shapeCollectionLabel.Location = new System.Drawing.Point(191, 233);
            this.shapeCollectionLabel.Name = "shapeCollectionLabel";
            this.shapeCollectionLabel.Size = new System.Drawing.Size(153, 24);
            this.shapeCollectionLabel.TabIndex = 20;
            this.shapeCollectionLabel.Text = "Shape Collection";
            // 
            // shapeColorLabel
            // 
            this.shapeColorLabel.AutoSize = true;
            this.shapeColorLabel.Location = new System.Drawing.Point(715, 411);
            this.shapeColorLabel.Name = "shapeColorLabel";
            this.shapeColorLabel.Size = new System.Drawing.Size(120, 24);
            this.shapeColorLabel.TabIndex = 21;
            this.shapeColorLabel.Text = "Shape Color:";
            // 
            // shapeColorComboBox
            // 
            this.shapeColorComboBox.FormattingEnabled = true;
            this.shapeColorComboBox.Location = new System.Drawing.Point(841, 408);
            this.shapeColorComboBox.Name = "shapeColorComboBox";
            this.shapeColorComboBox.Size = new System.Drawing.Size(184, 32);
            this.shapeColorComboBox.TabIndex = 22;
            // 
            // ShapeSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 623);
            this.Controls.Add(this.shapeColorComboBox);
            this.Controls.Add(this.shapeColorLabel);
            this.Controls.Add(this.shapeCollectionLabel);
            this.Controls.Add(this.shapeAddSelectedButton);
            this.Controls.Add(this.shapeChoicesBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalShapePerimeterValue);
            this.Controls.Add(this.totalShapeAreaValue);
            this.Controls.Add(this.currentShapePerimeterValue);
            this.Controls.Add(this.currentShapeAreaValue);
            this.Controls.Add(this.currentShapePerimeterLabel);
            this.Controls.Add(this.currentShapeAreaLabel);
            this.Controls.Add(this.shapeDisplayBox);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.totalShapePerimeterLabel);
            this.Controls.Add(this.totalShapeAreaLabel);
            this.Controls.Add(this.shapeListBox);
            this.Controls.Add(this.choicesLabel);
            this.Controls.Add(this.shapeDropdownBox);
            this.Controls.Add(this.shapeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ShapeSelectorForm";
            this.Text = "Shape Selector";
            this.Load += new System.EventHandler(this.ShapeSelectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shapeDisplayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.ComboBox shapeDropdownBox;
        private System.Windows.Forms.Label choicesLabel;
        private System.Windows.Forms.ListBox shapeListBox;
        private System.Windows.Forms.Label totalShapeAreaLabel;
        private System.Windows.Forms.Label totalShapePerimeterLabel;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.PictureBox shapeDisplayBox;
        private System.Windows.Forms.Label currentShapeAreaLabel;
        private System.Windows.Forms.Label currentShapePerimeterLabel;
        private System.Windows.Forms.Label currentShapeAreaValue;
        private System.Windows.Forms.Label currentShapePerimeterValue;
        private System.Windows.Forms.Label totalShapeAreaValue;
        private System.Windows.Forms.Label totalShapePerimeterValue;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.ListBox shapeChoicesBox;
        private System.Windows.Forms.Button shapeAddSelectedButton;
        private System.Windows.Forms.Label shapeCollectionLabel;
        private System.Windows.Forms.Label shapeColorLabel;
        private System.Windows.Forms.ComboBox shapeColorComboBox;
    }
}