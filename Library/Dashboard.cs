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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            OrganizeEvent();
        }
        #region PENGATURAN EVENT
        private void OrganizeEvent()
        {
            Exit_Tools.Click += Exit_Tools_Click;
            AddBook_Tool.Click += AddBook_Tool_Click;
            ViewBook_Tool.Click += ViewBook_Tool_Click;
            AddStudent_Tool.Click += AddStudent_Tool_Click;
            ViewStudent_Tool.Click += ViewStudent_Tool_Click; ;
        }

        private void ViewStudent_Tool_Click(object sender, EventArgs e)
        {
            Form_ViewStudent student = new Form_ViewStudent();
            student.Show(); ;
        }

        private void AddStudent_Tool_Click(object sender, EventArgs e)
        {
            Form_AddStudent ads = new Form_AddStudent();
            ads.Show();
        }

        private void ViewBook_Tool_Click(object sender, EventArgs e)
        {
            Form_ViewBook vb = new Form_ViewBook();
            vb.Show();
        }

        private void AddBook_Tool_Click(object sender, EventArgs e)
        {
            Form_AddBooks anb = new Form_AddBooks();
            anb.Show();
        }

        private void Exit_Tools_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure You Wanr Exit.?","Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
         
        }

        #endregion

    }
}
