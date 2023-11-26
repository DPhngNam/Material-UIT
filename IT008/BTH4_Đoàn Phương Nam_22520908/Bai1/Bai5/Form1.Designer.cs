namespace Bai5
{
    partial class f1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f1));
            ListViewItem listViewItem1 = new ListViewItem("");
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            ADD = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripTextBox();
            listView1 = new ListView();
            STT = new ColumnHeader();
            MSSV = new ColumnHeader();
            Name = new ColumnHeader();
            Khoa = new ColumnHeader();
            DiemTB = new ColumnHeader();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(816, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ADD, Exit });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // ADD
            // 
            ADD.Name = "ADD";
            ADD.Size = new Size(133, 26);
            ADD.Text = "Thêm ";
            // 
            // Exit
            // 
            Exit.Name = "Exit";
            Exit.Size = new Size(133, 26);
            Exit.Text = "Thoát";
            Exit.Click += Exit_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(816, 27);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(100, 24);
            toolStripButton1.Text = "Them moi";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(133, 24);
            toolStripButton2.Text = "Tim kiem theo ten";
            toolStripButton2.Click += toolStripButton2_Click_1;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(250, 27);
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.AllowDrop = true;
            listView1.Columns.AddRange(new ColumnHeader[] { STT, MSSV, Name, Khoa, DiemTB });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(94, 95);
            listView1.Name = "listView1";
            listView1.Scrollable = false;
            listView1.ShowItemToolTips = true;
            listView1.Size = new Size(658, 353);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // STT
            // 
            STT.Text = "STT";
            STT.Width = 100;
            // 
            // MSSV
            // 
            MSSV.Text = "MSSV";
            MSSV.Width = 100;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 150;
            // 
            // Khoa
            // 
            Khoa.Text = "Khoa";
            Khoa.Width = 200;
            // 
            // DiemTB
            // 
            DiemTB.Text = "DiemTB";
            DiemTB.Width = 150;
            // 
            // f1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(816, 509);
            Controls.Add(listView1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem ADD;
        private ToolStripMenuItem Exit;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ColumnHeader STT;
        private ColumnHeader MSSV;
        private ColumnHeader Name;
        private ColumnHeader Khoa;
        private ColumnHeader DiemTB;
        public ListView listView1;
        private ToolStripTextBox toolStripButton3;
    }
}
