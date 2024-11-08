﻿namespace Library
{
    partial class Form_ViewBook
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
            this.label2 = new System.Windows.Forms.Label();
            this.BookNameSearch_text = new System.Windows.Forms.TextBox();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Grid_viewBook = new System.Windows.Forms.DataGridView();
            this.PanelData = new System.Windows.Forms.Panel();
            this.Text_BookPurchaseDate = new System.Windows.Forms.TextBox();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Text_BookQuantity = new System.Windows.Forms.TextBox();
            this.Text_BookPrice = new System.Windows.Forms.TextBox();
            this.text_BookPublication = new System.Windows.Forms.TextBox();
            this.Text_BookAuthor = new System.Windows.Forms.TextBox();
            this.Text_BookName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_viewBook)).BeginInit();
            this.PanelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1270, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Judul Buku";
            // 
            // BookNameSearch_text
            // 
            this.BookNameSearch_text.Location = new System.Drawing.Point(142, 52);
            this.BookNameSearch_text.Name = "BookNameSearch_text";
            this.BookNameSearch_text.Size = new System.Drawing.Size(201, 20);
            this.BookNameSearch_text.TabIndex = 2;
            this.BookNameSearch_text.TextChanged += new System.EventHandler(this.BookNameSearch_text_TextChanged_1);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.Location = new System.Drawing.Point(709, 47);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(75, 30);
            this.Refresh_Button.TabIndex = 3;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            // 
            // Grid_viewBook
            // 
            this.Grid_viewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_viewBook.Location = new System.Drawing.Point(12, 83);
            this.Grid_viewBook.Name = "Grid_viewBook";
            this.Grid_viewBook.ReadOnly = true;
            this.Grid_viewBook.Size = new System.Drawing.Size(926, 395);
            this.Grid_viewBook.TabIndex = 4;
            // 
            // PanelData
            // 
            this.PanelData.BackColor = System.Drawing.Color.SandyBrown;
            this.PanelData.Controls.Add(this.Text_BookPurchaseDate);
            this.PanelData.Controls.Add(this.Update_Button);
            this.PanelData.Controls.Add(this.Delete_Button);
            this.PanelData.Controls.Add(this.Cancel_Button);
            this.PanelData.Controls.Add(this.Text_BookQuantity);
            this.PanelData.Controls.Add(this.Text_BookPrice);
            this.PanelData.Controls.Add(this.text_BookPublication);
            this.PanelData.Controls.Add(this.Text_BookAuthor);
            this.PanelData.Controls.Add(this.Text_BookName);
            this.PanelData.Controls.Add(this.label8);
            this.PanelData.Controls.Add(this.label7);
            this.PanelData.Controls.Add(this.label6);
            this.PanelData.Controls.Add(this.label5);
            this.PanelData.Controls.Add(this.label4);
            this.PanelData.Controls.Add(this.label3);
            this.PanelData.Location = new System.Drawing.Point(944, 83);
            this.PanelData.Name = "PanelData";
            this.PanelData.Size = new System.Drawing.Size(314, 395);
            this.PanelData.TabIndex = 5;
            this.PanelData.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelData_Paint);
            // 
            // Text_BookPurchaseDate
            // 
            this.Text_BookPurchaseDate.Location = new System.Drawing.Point(25, 181);
            this.Text_BookPurchaseDate.Name = "Text_BookPurchaseDate";
            this.Text_BookPurchaseDate.Size = new System.Drawing.Size(264, 20);
            this.Text_BookPurchaseDate.TabIndex = 15;
            // 
            // Update_Button
            // 
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.Location = new System.Drawing.Point(23, 342);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(75, 32);
            this.Update_Button.TabIndex = 14;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            // 
            // Delete_Button
            // 
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Location = new System.Drawing.Point(118, 342);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 32);
            this.Delete_Button.TabIndex = 13;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(214, 342);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 32);
            this.Cancel_Button.TabIndex = 12;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Text_BookQuantity
            // 
            this.Text_BookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_BookQuantity.Location = new System.Drawing.Point(25, 275);
            this.Text_BookQuantity.Name = "Text_BookQuantity";
            this.Text_BookQuantity.Size = new System.Drawing.Size(264, 22);
            this.Text_BookQuantity.TabIndex = 10;
            // 
            // Text_BookPrice
            // 
            this.Text_BookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_BookPrice.Location = new System.Drawing.Point(25, 227);
            this.Text_BookPrice.Name = "Text_BookPrice";
            this.Text_BookPrice.Size = new System.Drawing.Size(264, 22);
            this.Text_BookPrice.TabIndex = 9;
            // 
            // text_BookPublication
            // 
            this.text_BookPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_BookPublication.Location = new System.Drawing.Point(25, 133);
            this.text_BookPublication.Name = "text_BookPublication";
            this.text_BookPublication.Size = new System.Drawing.Size(264, 22);
            this.text_BookPublication.TabIndex = 8;
            // 
            // Text_BookAuthor
            // 
            this.Text_BookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_BookAuthor.Location = new System.Drawing.Point(23, 85);
            this.Text_BookAuthor.Name = "Text_BookAuthor";
            this.Text_BookAuthor.Size = new System.Drawing.Size(266, 22);
            this.Text_BookAuthor.TabIndex = 7;
            // 
            // Text_BookName
            // 
            this.Text_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_BookName.Location = new System.Drawing.Point(25, 37);
            this.Text_BookName.Name = "Text_BookName";
            this.Text_BookName.Size = new System.Drawing.Size(264, 22);
            this.Text_BookName.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Book Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Book Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Book Publication";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(461, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(362, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Kategori ";
            // 
            // Form_ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1270, 504);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelData);
            this.Controls.Add(this.Grid_viewBook);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.BookNameSearch_text);
            this.Controls.Add(this.label2);
            this.Name = "Form_ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ViewBook";
            this.Load += new System.EventHandler(this.Form_ViewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_viewBook)).EndInit();
            this.PanelData.ResumeLayout(false);
            this.PanelData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BookNameSearch_text;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.DataGridView Grid_viewBook;
        private System.Windows.Forms.Panel PanelData;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.TextBox Text_BookQuantity;
        private System.Windows.Forms.TextBox Text_BookPrice;
        private System.Windows.Forms.TextBox text_BookPublication;
        private System.Windows.Forms.TextBox Text_BookAuthor;
        private System.Windows.Forms.TextBox Text_BookName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_BookPurchaseDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}