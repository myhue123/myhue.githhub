namespace example01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 56);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(446, 49);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(175, 113);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(446, 113);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(175, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(357, 28);
            comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(175, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(357, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I" });
            listBox1.Location = new Point(175, 274);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(255, 104);
            listBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(438, 395);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(569, 395);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}