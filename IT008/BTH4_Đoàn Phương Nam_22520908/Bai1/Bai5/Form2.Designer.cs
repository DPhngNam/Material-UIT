namespace Bai5
{
    partial class Form2
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
            MSSV = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            DiemTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            Add = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 58);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // MSSV
            // 
            MSSV.Location = new Point(201, 55);
            MSSV.Name = "MSSV";
            MSSV.Size = new Size(225, 27);
            MSSV.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 113);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // DiemTB
            // 
            DiemTB.Location = new Point(201, 266);
            DiemTB.Name = "DiemTB";
            DiemTB.Size = new Size(225, 27);
            DiemTB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 197);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Khoa";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 273);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(62, 20);
            label4.TabIndex = 6;
            label4.Text = "DiemTB";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Công nghệ phần mềm", "Khoa học máy tính", "Hệ thống thông tin", "Kỹ thuật mấy tính", "Khoa học và Kỹ thuật thông tin", "Mạng máy tính và truyền thông" });
            comboBox1.Location = new Point(201, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 28);
            comboBox1.TabIndex = 7;
            // 
            // Add
            // 
            Add.DialogResult = DialogResult.OK;
            Add.Location = new Point(436, 353);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 8;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(612, 353);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AcceptButton = Add;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(Add);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(DiemTB);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(MSSV);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox MSSV;
        private TextBox textBox1;
        private Label label2;
        private TextBox DiemTB;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Button Add;
        private Button button2;
    }
}