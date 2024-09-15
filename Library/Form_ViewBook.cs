using Library.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Library
{
    public partial class Form_ViewBook : Form
    {
        public Form_ViewBook()
        {
            InitializeComponent();

            OrganizeEvent();
        }
        private void OrganizeEvent()
        {
            Grid_viewBook.CellClick += Grid_viewBook_CellClick;
            Cancel_Button.Click += Cancel_Button_Click;
            Delete_Button.Click += Delete_Button_Click;
            Update_Button.Click += Update_Button_Click;
            Refresh_Button.Click += Refresh_Button_Click;
           
        }


        #region EVENT 
        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            BookNameSearch_text.Clear();
            PanelData.Visible = false;
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be UPDATE. Confirm?", "Sucsess", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bname = Text_BookName.Text;
                string bauthor = Text_BookAuthor.Text;
                string publication = text_BookPublication.Text;
                string pdate = Text_BookPurchaseDate.Text;
                Int64 price = Int64.Parse(Text_BookPrice.Text);
                Int64 quan = Int64.Parse(Text_BookQuantity.Text);

                using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "update NewBook set bName = '" + bname + "',bAuthor = '" + bauthor + "',bPublic = '" + publication + "',bPDate = '" + pdate + "',bPrice = " + price + ",bQuan = " + quan + " where bid=" + rowid + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will Deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "delete from NewBook where bid="+rowid+"";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            PanelData.Visible = false;
        }
        #endregion

        #region GRID
        int bid = 0;
        Int64 rowid; 
        private void Grid_viewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_viewBook.Rows[e.RowIndex].Cells[0].Value != null)
            {
                bid = int.Parse(Grid_viewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
             //   MessageBox.Show(Grid_viewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            PanelData.Visible = true;
            using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewBook where bid="+bid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                Text_BookName.Text = ds.Tables[0].Rows[0][1].ToString();
                Text_BookAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
                text_BookPublication.Text = ds.Tables[0].Rows[0][3].ToString();
                Text_BookPurchaseDate.Text = ds.Tables[0].Rows[0][4].ToString();
                Text_BookPrice.Text = ds.Tables[0].Rows[0][5].ToString();
                Text_BookQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
            }
        }

        private void Form_ViewBook_Load(object sender, EventArgs e)
        {
            PanelData.Visible = false;
            using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Grid_viewBook.DataSource = ds.Tables[0];
            }
            
        }
        #endregion

        private void BookNameSearch_text_TextChanged_1(object sender, EventArgs e)
        {
            string query = string.IsNullOrEmpty(BookNameSearch_text.Text) ? "select * from NewBook" : "select * from NewBook where bName LIKE @bname + '%'";

            using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(BookNameSearch_text.Text))
                {
                    cmd.Parameters.AddWithValue("@bName", BookNameSearch_text.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Grid_viewBook.DataSource = ds.Tables[0];
            }
        }
    }
}
