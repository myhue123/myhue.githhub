namespace example01
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 114);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 168);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(255, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(55, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Lưu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 27);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(166, 324);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(409, 324);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}