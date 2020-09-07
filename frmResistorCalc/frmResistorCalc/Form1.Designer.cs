namespace frmResistorCalc
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblBandOne = new System.Windows.Forms.Label();
            this.lblBandTwo = new System.Windows.Forms.Label();
            this.lblBandThree = new System.Windows.Forms.Label();
            this.lblBandFour = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.minValue = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Gray",
            "Green",
            "Orange",
            "Red",
            "Violet",
            "White",
            "Yellow"});
            this.comboBox1.Location = new System.Drawing.Point(24, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Gray",
            "Green",
            "Orange",
            "Red",
            "VIolet",
            "White",
            "Yellow"});
            this.comboBox2.Location = new System.Drawing.Point(169, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Gold",
            "Gray",
            "Green",
            "Orange",
            "Red",
            "Silver",
            "Violet",
            "White",
            "Yellow"});
            this.comboBox3.Location = new System.Drawing.Point(317, 94);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Blue",
            "Brown",
            "Gray",
            "Green",
            "Orange",
            "Red",
            "Silver",
            "Violet",
            "Yellow"});
            this.comboBox4.Location = new System.Drawing.Point(473, 94);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // lblBandOne
            // 
            this.lblBandOne.BackColor = System.Drawing.Color.Black;
            this.lblBandOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBandOne.Location = new System.Drawing.Point(117, 218);
            this.lblBandOne.Name = "lblBandOne";
            this.lblBandOne.Size = new System.Drawing.Size(18, 74);
            this.lblBandOne.TabIndex = 4;
            this.lblBandOne.Text = "label1";
            // 
            // lblBandTwo
            // 
            this.lblBandTwo.BackColor = System.Drawing.Color.Black;
            this.lblBandTwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBandTwo.Location = new System.Drawing.Point(232, 218);
            this.lblBandTwo.Name = "lblBandTwo";
            this.lblBandTwo.Size = new System.Drawing.Size(18, 74);
            this.lblBandTwo.TabIndex = 6;
            this.lblBandTwo.Text = ".";
            // 
            // lblBandThree
            // 
            this.lblBandThree.BackColor = System.Drawing.Color.Black;
            this.lblBandThree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBandThree.Location = new System.Drawing.Point(368, 218);
            this.lblBandThree.Name = "lblBandThree";
            this.lblBandThree.Size = new System.Drawing.Size(18, 74);
            this.lblBandThree.TabIndex = 7;
            this.lblBandThree.Text = "label1";
            // 
            // lblBandFour
            // 
            this.lblBandFour.BackColor = System.Drawing.Color.Black;
            this.lblBandFour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBandFour.Location = new System.Drawing.Point(517, 218);
            this.lblBandFour.Name = "lblBandFour";
            this.lblBandFour.Size = new System.Drawing.Size(18, 74);
            this.lblBandFour.TabIndex = 8;
            this.lblBandFour.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "First Band";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Second Band";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(317, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Third Band";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(473, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Fourth Band";
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.Menu;
            this.txtValue.Location = new System.Drawing.Point(235, 333);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 14;
            // 
            // maxValue
            // 
            this.maxValue.BackColor = System.Drawing.SystemColors.Menu;
            this.maxValue.Location = new System.Drawing.Point(570, 324);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(100, 20);
            this.maxValue.TabIndex = 15;
            // 
            // minValue
            // 
            this.minValue.BackColor = System.Drawing.SystemColors.Menu;
            this.minValue.Location = new System.Drawing.Point(570, 396);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(100, 20);
            this.minValue.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(45, 333);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "Resistor Value";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(435, 396);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 18;
            this.textBox6.Text = "Max tolerance";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(435, 324);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 19;
            this.textBox7.Text = "Min Tolerance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBandFour);
            this.Controls.Add(this.lblBandThree);
            this.Controls.Add(this.lblBandTwo);
            this.Controls.Add(this.lblBandOne);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblBandOne;
        private System.Windows.Forms.Label lblBandTwo;
        private System.Windows.Forms.Label lblBandThree;
        private System.Windows.Forms.Label lblBandFour;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.TextBox minValue;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}

