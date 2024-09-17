using Library.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            Enrollment_Text.TextChanged += Enrollment_Text_TextChanged; ;
            Refresh_Button.Click += Refresh_Button_Click;
            Grid_ViewStudent.CellClick += Grid_ViewStudent_CellClick;
            Update_Button.Click += Update_Button_Click;
            Delete_Button.Click += Delete_Button_Click;
            Cancel_Button.Click += Cancel_Button_Click;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            PanelData.Visible = false;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will Deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "delete from Student where StuID=" + rowid + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
                CustomGrid();
                RefreshData();
                ClearData();
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be UPDATE. Confirm?", "Sucsess", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string stuname = Text_StudentName.Text;
                string stuenrol = Text_Enrollement.Text;
                string studep = Text_Departement.Text;
                string stusem = Text_StudentSemester.Text;
                string stucontact = Text_ContactStudent.Text;
                string stuemail = Text_EmailStudent.Text;

                using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "update Student set StuName = '" + stuname + "',StuEnrol = '" + stuenrol + "',StuDep = '" + studep + "',StuSem = '" + stusem + "',StuContact = " + stucontact + ",StuEmail = '" + stuemail + "' where StuId=" + rowid + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    Form_ViewStudent_Load(this, null);
                }
                CustomGrid();
                RefreshData();
                ClearData();
            }
        }

        private void Enrollment_Text_TextChanged(object sender, EventArgs e)
        {
            string query = string.IsNullOrEmpty(Enrollment_Text.Text) ? "select * from Student" : "select * from Student where StuEnrol LIKE @stuenrol + '%'";

            using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(Enrollment_Text.Text))
                {
                    cmd.Parameters.AddWithValue("@StuEnrol", Enrollment_Text.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Grid_ViewStudent.DataSource = ds.Tables[0];
                CustomGrid();
            }

            if (Enrollment_Text.Text != "")
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

        int StuId = 0;
        Int64 rowid;
        private void Grid_ViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Grid_ViewStudent.Rows[e.RowIndex].Cells[0].Value != null)
            {
                StuId = int.Parse(Grid_ViewStudent.Rows[e.RowIndex].Cells[0].Value.ToString());
                //   MessageBox.Show(Grid_viewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            PanelData.Visible = true;
            using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from Student where StuID=" + StuId + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                Text_StudentName.Text = ds.Tables[0].Rows[0][1].ToString();
                Text_Enrollement.Text = ds.Tables[0].Rows[0][2].ToString();
                Text_Departement.Text = ds.Tables[0].Rows[0][3].ToString();
                Text_StudentSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                Text_ContactStudent.Text = ds.Tables[0].Rows[0][5].ToString();
                Text_EmailStudent.Text = ds.Tables[0].Rows[0][6].ToString();
                CustomGrid();
            }
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CustomGrid()
        {
            // Mengatur nama kolom
            Grid_ViewStudent.Columns[0].HeaderText = "Student ID";
            Grid_ViewStudent.Columns[1].HeaderText = "Student Name";
            Grid_ViewStudent.Columns[2].HeaderText = "Enrollment";
            Grid_ViewStudent.Columns[3].HeaderText = "Departement"; 
            Grid_ViewStudent.Columns[4].HeaderText = "Semester";
            Grid_ViewStudent.Columns[5].HeaderText = "Contact";
            Grid_ViewStudent.Columns[6].HeaderText = "Email";
        }
        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from Student";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Grid_ViewStudent.DataSource = ds.Tables[0];
                CustomGrid();
            }
        }
        private void ClearData()
        {
            Text_StudentName.Clear();
            Text_Enrollement.Clear();
            Text_Departement.Clear();
            Text_StudentSemester.Clear();
            Text_ContactStudent.Clear();
            Text_EmailStudent.Clear();
        }
    

        private void Form_ViewStudent_Load(object sender, EventArgs e)
        {
            PanelData.Visible = false;
            RefreshData();
        }
    }
}
