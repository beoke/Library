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
