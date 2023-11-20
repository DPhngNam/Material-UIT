namespace Bai05
{
    partial class form1
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            textBox5 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(1141, 84);
            label1.TabIndex = 0;
            label1.Text = "Quản lý tài khoản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 104);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Số tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 158);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 214);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 274);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 4;
            label5.Text = "Số tiền trong tài khoản";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(432, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 27);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(432, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(329, 27);
            textBox2.TabIndex = 6;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(432, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(329, 27);
            textBox3.TabIndex = 7;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(432, 274);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(329, 27);
            textBox4.TabIndex = 8;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(468, 344);
            button1.Name = "button1";
            button1.Size = new Size(125, 30);
            button1.TabIndex = 9;
            button1.Text = "Thêm/Cập nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(667, 344);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(852, 345);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4 });
            dataGridView1.ImeMode = ImeMode.On;
            dataGridView1.Location = new Point(57, 401);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1039, 293);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.Enter += dataGridView1_Enter;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "MTK";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ten";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Dia Chi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tien";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(822, 729);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(274, 27);
            textBox5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(720, 732);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 14;
            label6.Text = "Tổng tiền:";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 783);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "form1";
            Text = "Bài 5";
            Load += button1_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}