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
    public partial class CompleteBook : Form
    {
        public CompleteBook()
        {
            InitializeComponent();
        }
        private void CustomGrid()                                                                       // custom grid ada di sini
        {
            Grid_Issue.Columns[0].HeaderText = "ID";
            Grid_Issue.Columns[1].HeaderText = "NIS Siswa";
            Grid_Issue.Columns[2].HeaderText = "Nama Siswa";
            Grid_Issue.Columns[3].HeaderText = "Sekolah";
            Grid_Issue.Columns[4].HeaderText = "Semester";
            Grid_Issue.Columns[5].HeaderText = "Kontak Siswa";
            Grid_Issue.Columns[6].HeaderText = "Email Siswa";
            Grid_Issue.Columns[7].HeaderText = "Nama Buku";
            Grid_Issue.Columns[8].HeaderText = "Tanggal Peminjaman";
            Grid_Issue.Columns[9].HeaderText = "Tanggal Pengembalian";


            Grid_Issue.Columns[0].Width = 50;
            Grid_Issue.Columns[2].Width = 150;
            Grid_Issue.Columns[4].Width = 70;
            Grid_Issue.Columns[8].Width = 100;
            Grid_Issue.Columns[9].Width = 100;

            Grid_Issue.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void CompleteBook_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from IRBookk where book_return_date is null";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Grid_Issue.DataSource = ds.Tables[0] ;
                CustomGrid();

                cmd.CommandText = "select * from IRBookk where book_return_date is not null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);
                Grid_Return.DataSource = ds1.Tables[0] ;
            }
        }
   }
}
