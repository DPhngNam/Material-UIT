namespace Bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rbt = new RichTextBox();
            menuStrip1 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            New = new ToolStripMenuItem();
            Open = new ToolStripMenuItem();
            Save = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            Fontfamil = new ToolStripComboBox();
            fontsize = new ToolStripComboBox();
            Bold = new ToolStripButton();
            Italic = new ToolStripButton();
            Underline = new ToolStripButton();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rbt
            // 
            rbt.Location = new Point(12, 118);
            rbt.Name = "rbt";
            rbt.Size = new Size(1113, 544);
            rbt.TabIndex = 0;
            rbt.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1154, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { New, Open, Save, Exit });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(70, 24);
            systemToolStripMenuItem.Text = "System";
            // 
            // New
            // 
            New.Image = (Image)resources.GetObject("New.Image");
            New.Name = "New";
            New.Size = new Size(224, 26);
            New.Text = "New";
            New.Click += New_Click;
            // 
            // Open
            // 
            Open.Image = (Image)resources.GetObject("Open.Image");
            Open.Name = "Open";
            Open.Size = new Size(224, 26);
            Open.Text = "Open";
            Open.Click += Open_Click;
            // 
            // Save
            // 
            Save.Image = (Image)resources.GetObject("Save.Image");
            Save.Name = "Save";
            Save.Size = new Size(224, 26);
            Save.Text = "Save";
            Save.Click += Save_Click;
            // 
            // Exit
            // 
            Exit.Name = "Exit";
            Exit.Size = new Size(224, 26);
            Exit.Text = "Exit";
            Exit.Click += Exit_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "Format";
            formatToolStripMenuItem.Click += formatToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, Fontfamil, fontsize, Bold, Italic, Underline });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1154, 28);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 25);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 25);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // Fontfamil
            // 
            Fontfamil.Name = "Fontfamil";
            Fontfamil.Size = new Size(200, 28);
            Fontfamil.Sorted = true;
            Fontfamil.SelectedIndexChanged += Fontfamil_SelectedIndexChanged;
            // 
            // fontsize
            // 
            fontsize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            fontsize.Name = "fontsize";
            fontsize.Size = new Size(75, 28);
            fontsize.SelectedIndexChanged += fontsize_SelectedIndexChanged;
            fontsize.Click += fontsize_Click;
            // 
            // Bold
            // 
            Bold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Bold.Image = (Image)resources.GetObject("Bold.Image");
            Bold.ImageTransparentColor = Color.Magenta;
            Bold.Name = "Bold";
            Bold.Size = new Size(29, 25);
            Bold.Click += Bold_Click;
            // 
            // Italic
            // 
            Italic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Italic.Image = (Image)resources.GetObject("Italic.Image");
            Italic.ImageTransparentColor = Color.Magenta;
            Italic.Name = "Italic";
            Italic.Size = new Size(29, 25);
            Italic.Click += Italic_Click;
            // 
            // Underline
            // 
            Underline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Underline.Image = (Image)resources.GetObject("Underline.Image");
            Underline.ImageTransparentColor = Color.Magenta;
            Underline.Name = "Underline";
            Underline.Size = new Size(29, 25);
            Underline.Click += Underline_Click;
            // 
            // fontDialog1
            // 
            fontDialog1.ShowColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 709);
            Controls.Add(toolStrip1);
            Controls.Add(rbt);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
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

        private RichTextBox rbt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem New;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem Open;
        private ToolStripMenuItem Save;
        private ToolStripMenuItem Exit;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripComboBox Fontfamil;
        private ToolStripComboBox fontsize;
        private ToolStripButton Bold;
        private ToolStripButton Italic;
        private ToolStripButton Underline;
        private FontDialog fontDialog1;
    }
}
