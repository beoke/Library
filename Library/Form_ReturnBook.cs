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
            Button_search.Click += Button_search_Click;
            Grid_IssueBook.CellClick += Grid_IssueBook_CellClick;
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
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from PinjamBuku where std_enroll = '"+Text_Search.Text+"' and book_return_date IS NULL";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

               if(ds.Tables[0].Rows.Count != 0)
                {
                    Grid_IssueBook.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("invalid ID or No Book Issued","Eror",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
