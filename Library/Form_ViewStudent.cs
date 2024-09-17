using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form_ViewStudent : Form
    {
        public Form_ViewStudent()
        {
            InitializeComponent();

            OrganizeEvent();
        }
        private void OrganizeEvent()
        {
            NIS_Text.TextChanged += NIS_Text_TextChanged;
        }

        private void NIS_Text_TextChanged(object sender, EventArgs e)
        {
            if (NIS_Text.Text != "")
            {
                label1.Visible = false;
                Image image = Image.FromFile("D:/Simpanan/Liberay Management System/search1.gif");
                pictureBox1.Image = image;
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("D:/Simpanan/Liberay Management System/search.gif");
                pictureBox1.Image = image;
            }
        }
    }
}
