﻿namespace Library
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBook_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBook_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStudent_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewStudent_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueBook_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnBook_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.CompleteBook_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.IssueBook_Tool,
            this.ReturnBook_Tool,
            this.CompleteBook_Tool,
            this.Exit_Tools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBook_Tool,
            this.ViewBook_Tool});
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(101, 54);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // AddBook_Tool
            // 
            this.AddBook_Tool.Image = ((System.Drawing.Image)(resources.GetObject("AddBook_Tool.Image")));
            this.AddBook_Tool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBook_Tool.Name = "AddBook_Tool";
            this.AddBook_Tool.Size = new System.Drawing.Size(187, 56);
            this.AddBook_Tool.Text = "Add New Book";
            // 
            // ViewBook_Tool
            // 
            this.ViewBook_Tool.Image = ((System.Drawing.Image)(resources.GetObject("ViewBook_Tool.Image")));
            this.ViewBook_Tool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewBook_Tool.Name = "ViewBook_Tool";
            this.ViewBook_Tool.Size = new System.Drawing.Size(187, 56);
            this.ViewBook_Tool.Text = "View Books";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudent_Tool,
            this.ViewStudent_Tool});
            this.studentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsToolStripMenuItem.Image")));
            this.studentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(110, 54);
            this.studentsToolStripMenuItem.Text = "Student";
            // 
            // AddStudent_Tool
            // 
            this.AddStudent_Tool.Image = ((System.Drawing.Image)(resources.GetObject("AddStudent_Tool.Image")));
            this.AddStudent_Tool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddStudent_Tool.Name = "AddStudent_Tool";
            this.AddStudent_Tool.Size = new System.Drawing.Size(201, 56);
            this.AddStudent_Tool.Text = "Add Student";
            // 
            // ViewStudent_Tool
            // 
            this.ViewStudent_Tool.Image = ((System.Drawing.Image)(resources.GetObject("ViewStudent_Tool.Image")));
            this.ViewStudent_Tool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ViewStudent_Tool.Name = "ViewStudent_Tool";
            this.ViewStudent_Tool.Size = new System.Drawing.Size(201, 56);
            this.ViewStudent_Tool.Text = "View Student Info";
            // 
            // IssueBook_Tool
            // 
            this.IssueBook_Tool.Image = ((System.Drawing.Image)(resources.GetObject("IssueBook_Tool.Image")));
            this.IssueBook_Tool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IssueBook_Tool.Name = "IssueBook_Tool";
            this.IssueBook_Tool.Size = new System.Drawing.Size(130, 54);
            this.IssueBook_Tool.Text = "Issue Books";
            // 
            // ReturnBook_Tool
            // 
            this.ReturnBook_Tool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ReturnBook_Tool.Image = ((System.Drawing.Image)(resources.GetObject("ReturnBook_Tool.Image")));
            this.ReturnBook_Tool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReturnBook_Tool.Name = "ReturnBook_Tool";
            this.ReturnBook_Tool.Size = new System.Drawing.Size(139, 54);
            this.ReturnBook_Tool.Text = "Return Books";
            // 
            // CompleteBook_Tool
            // 
            this.CompleteBook_Tool.Image = ((System.Drawing.Image)(resources.GetObject("CompleteBook_Tool.Image")));
            this.CompleteBook_Tool.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CompleteBook_Tool.Name = "CompleteBook_Tool";
            this.CompleteBook_Tool.Size = new System.Drawing.Size(189, 54);
            this.CompleteBook_Tool.Text = "Complete Book Details";
            // 
            // Exit_Tools
            // 
            this.Exit_Tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Exit_Tools.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Tools.Image")));
            this.Exit_Tools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Exit_Tools.Name = "Exit_Tools";
            this.Exit_Tools.Size = new System.Drawing.Size(88, 54);
            this.Exit_Tools.Text = "Exit";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 609);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddBook_Tool;
        private System.Windows.Forms.ToolStripMenuItem ViewBook_Tool;
        private System.Windows.Forms.ToolStripMenuItem AddStudent_Tool;
        private System.Windows.Forms.ToolStripMenuItem ViewStudent_Tool;
        private System.Windows.Forms.ToolStripMenuItem IssueBook_Tool;
        private System.Windows.Forms.ToolStripMenuItem ReturnBook_Tool;
        private System.Windows.Forms.ToolStripMenuItem CompleteBook_Tool;
        private System.Windows.Forms.ToolStripMenuItem Exit_Tools;
    }
}