namespace Bai03
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 0;
            label1.Text = "Number 1:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(148, 38);
            label2.TabIndex = 1;
            label2.Text = "Number 2:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 126);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Operator";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.FormatString = "N2";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(185, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(205, 181);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Execute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 232);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Result:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(185, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 27);
            textBox3.TabIndex = 8;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private Label label4;
        private TextBox textBox3;
    }
}