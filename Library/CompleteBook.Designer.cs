namespace Library
{
    partial class CompleteBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_Issue = new System.Windows.Forms.DataGridView();
            this.Grid_Return = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Issue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issued Book";
            // 
            // Grid_Issue
            // 
            this.Grid_Issue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Issue.Location = new System.Drawing.Point(13, 37);
            this.Grid_Issue.Name = "Grid_Issue";
            this.Grid_Issue.Size = new System.Drawing.Size(1035, 212);
            this.Grid_Issue.TabIndex = 1;
            // 
            // Grid_Return
            // 
            this.Grid_Return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Return.Location = new System.Drawing.Point(13, 289);
            this.Grid_Return.Name = "Grid_Return";
            this.Grid_Return.Size = new System.Drawing.Size(1035, 211);
            this.Grid_Return.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return Book";
            // 
            // CompleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1060, 512);
            this.Controls.Add(this.Grid_Return);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid_Issue);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CompleteBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteBook";
            this.Load += new System.EventHandler(this.CompleteBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Issue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_Issue;
        private System.Windows.Forms.DataGridView Grid_Return;
        private System.Windows.Forms.Label label2;
    }
}