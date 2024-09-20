using Library.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Library
{
    public partial class Form_IssueBook : Form
    {
        public Form_IssueBook()
        {
            InitializeComponent();

            OrganizeEvent();
        }
        private void OrganizeEvent()
        {
            
            Text_Search.TextChanged += Text_Search_TextChanged;
            Button_Search.Click += Button_Search_Click;
            Button_Issue.Click += Button_Issue_Click;
            Button_Refresh.Click += Button_Refresh_Click;
            Button_Exit.Click += Button_Exit_Click;
            
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            ClearData();
            Text_Search.Clear();
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Button_Issue_Click(object sender, EventArgs e)
        {
            if (Text_StudentName.Text != "")
            {
                if(Combo_BookName.SelectedIndex != -1 && count <=2)
                {
                    string enroll = Text_Search.Text;
                    string sname = Text_StudentName.Text;
                    string sdep = Text_Departement.Text;
                    string sem = Text_StudentSemester.Text;
                    Int64 contact = Int64.Parse(Text_StudentContact.Text);
                    string email = Text_StudentEmail.Text;
                    string bookname = Combo_BookName.Text;
                    DateTime bookIssueDate = DateTime.Parse(Date_BookIssue.Text);

                    using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "INSERT INTO IRBookk (std_enroll, std_name, std_dep, std_sem, std_contact, std_email, book_name, book_issue_date) " +
                                          "VALUES (@enroll, @sname, @sdep, @sem, @contact, @email, @bookname, @bookissuedate)";

                        cmd.Parameters.AddWithValue("@enroll", enroll);
                        cmd.Parameters.AddWithValue("@sname", sname);
                        cmd.Parameters.AddWithValue("@sdep", sdep);
                        cmd.Parameters.AddWithValue("@sem", sem);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@bookname", bookname);
                        cmd.Parameters.AddWithValue("@bookissuedate", bookIssueDate);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Book Issued.","Sucses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("select Book, Or Maximum number of Book has been Issued.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment No", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int count;
        private void Button_Search_Click(object sender, EventArgs e)                                                                    // ketika button search
        {
            if(Text_Search.Text != "")
            {
                string SearchId = Text_Search.Text;
                using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "select * from Student where StuEnrol = '"+SearchId+"'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);


                    //--------------------------------------------------------------------------------------------------------------
                    // code to count how many book has been issued on this enrollment number
                    cmd.CommandText = "select count(std_enroll) from IRBookk where std_enroll = '" + SearchId + "'and book_return_date is null";
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    da.Fill(ds1);

                    count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                    //--------------------------------------------------------------------------------------------------------------
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        Text_StudentName.Text = ds.Tables[0].Rows[0][1].ToString();
                        Text_Departement.Text = ds.Tables[0].Rows[0][3].ToString();
                        Text_StudentSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                        Text_StudentContact.Text = ds.Tables[0].Rows[0][5].ToString();
                        Text_StudentEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                    }
                    else
                    { 
                        Text_StudentName.Clear();
                        Text_Departement.Clear();
                        Text_StudentSemester.Clear();
                        Text_StudentContact.Clear();
                        Text_StudentEmail.Clear();
                        MessageBox.Show("Invalid Enrolment No","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment No", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetDataBook()
        {
            using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();

                cmd = new SqlCommand("select bName from NewBook", conn);
                SqlDataReader Sdr = cmd.ExecuteReader();

                while (Sdr.Read())
                {
                    for (int i = 0; i < Sdr.FieldCount; i++)
                    {
                        Combo_BookName.Items.Add(Sdr.GetString(i));
                    }
                }
                Sdr.Close();
                conn.Close();
            }
        }

        private void Form_IssueBook_Load(object sender, EventArgs e)
        {
            GetDataBook();
        }
        private void ClearData()
        {
            
            Text_StudentName.Clear();
            Text_Departement.Clear();
            Text_StudentSemester.Clear();
            Text_StudentContact.Clear();
            Text_StudentEmail.Clear();
            Combo_BookName.SelectedIndex = -1;
        }
    }
}
