using Library.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form_ReturnBook : Form
    {
        public Form_ReturnBook()
        {
            InitializeComponent();

            OrganizeEvent();
        }
        string bname;
        string bdate;
        Int64 rowid;
        public void OrganizeEvent()
        {
            Button_Exit.Click += Button_Exit_Click;
            Button_Cancel.Click += Button_Cancel_Click;
            Button_Refresh.Click += Button_Refresh_Click;
            Button_Return.Click += Button_Return_Click;
            Button_search.Click += Button_search_Click;
            Grid_IssueBook.CellClick += Grid_IssueBook_CellClick;
            Text_Search.TextChanged += Text_Search_TextChanged;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            Text_Search.Clear();
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            if (Text_Search.Text == "")
            {
                panel1.Visible = false;
                Grid_IssueBook.DataSource = null;
            }
        }

        private void Button_Return_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    // Convert the date from the DateTimePicker to a format recognized by SQL Server
                    DateTime returnDate;
                    if (!DateTime.TryParse(Date_ReturnDate.Text, out returnDate))
                    {
                        MessageBox.Show("Invalid date format. Please use a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cmd.CommandText = "UPDATE IRBookk SET book_return_date = @returndate WHERE std_enroll = @enroll AND id = @rowid";

                    // Use parameterized queries to prevent SQL injection
                    cmd.Parameters.AddWithValue("@returndate", returnDate);
                    cmd.Parameters.AddWithValue("@enroll", Text_Search.Text);
                    cmd.Parameters.AddWithValue("@rowid", rowid);

                    conn.Open();
                    int rowsUpdated = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Book return date updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_ReturnBook_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or no such book issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // kurang update datanya di grid

                }
            }


        }

        private void Grid_IssueBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;

            if (Grid_IssueBook.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(Grid_IssueBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = Grid_IssueBook.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = Grid_IssueBook.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            Text_BookName.Text = bname;
            Text_IssueDate.Text = bdate;
        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    // Use parameterized queries to prevent SQL injection
                    cmd.CommandText = "SELECT * FROM IRBookk WHERE std_enroll = @enroll AND book_return_date IS NULL";
                    cmd.Parameters.AddWithValue("@enroll", Text_Search.Text);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables[0].Rows.Count != 0)
                        {
                            Grid_IssueBook.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Form_ReturnBook_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Text_Search.Clear();
        }
    }
}
