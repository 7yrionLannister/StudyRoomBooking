namespace ui
{
    partial class UserInterface
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fromHour = new System.Windows.Forms.NumericUpDown();
            this.fromMinute = new System.Windows.Forms.NumericUpDown();
            this.toMinute = new System.Windows.Forms.NumericUpDown();
            this.toHour = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fromHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toHour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Study Room Booking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(83, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(83, 97);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(82, 138);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(100, 21);
            this.roomComboBox.TabIndex = 5;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(104, 179);
            this.datePicker.MaxDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2020, 1, 24, 10, 16, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 6;
            this.datePicker.Value = new System.DateTime(2020, 1, 24, 10, 16, 0, 0);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(51, 273);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(217, 273);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButtonPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time lapse";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "From";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "To";
            // 
            // fromHour
            // 
            this.fromHour.Location = new System.Drawing.Point(48, 231);
            this.fromHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.fromHour.Name = "fromHour";
            this.fromHour.Size = new System.Drawing.Size(38, 20);
            this.fromHour.TabIndex = 14;
            this.fromHour.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fromMinute
            // 
            this.fromMinute.Location = new System.Drawing.Point(92, 230);
            this.fromMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.fromMinute.Name = "fromMinute";
            this.fromMinute.Size = new System.Drawing.Size(38, 20);
            this.fromMinute.TabIndex = 15;
            // 
            // toMinute
            // 
            this.toMinute.Location = new System.Drawing.Point(256, 230);
            this.toMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.toMinute.Name = "toMinute";
            this.toMinute.Size = new System.Drawing.Size(38, 20);
            this.toMinute.TabIndex = 17;
            // 
            // toHour
            // 
            this.toHour.Location = new System.Drawing.Point(212, 231);
            this.toHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.toHour.Name = "toHour";
            this.toHour.Size = new System.Drawing.Size(38, 20);
            this.toHour.TabIndex = 16;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 305);
            this.Controls.Add(this.toMinute);
            this.Controls.Add(this.toHour);
            this.Controls.Add(this.fromMinute);
            this.Controls.Add(this.fromHour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "UserInterface";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fromHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown fromHour;
        private System.Windows.Forms.NumericUpDown fromMinute;
        private System.Windows.Forms.NumericUpDown toMinute;
        private System.Windows.Forms.NumericUpDown toHour;
    }
}

