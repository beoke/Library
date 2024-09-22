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

                cmd.CommandText = "select * from IRBookk where book_return_date is not null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);
                Grid_Return.DataSource = ds1.Tables[0] ;
            }
        }
   }
}
