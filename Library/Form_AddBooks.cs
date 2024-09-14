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
using System.Windows.Forms;

namespace Library
{
    public partial class Form_AddBooks : Form
    {
        public Form_AddBooks()
        {
            InitializeComponent();

            OrganizeEvent();
        }

        private void OrganizeEvent()
        {
            Save_Button.Click += Save_Button_Click;
            Cancel_Button.Click += Cancel_Button_Click;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Convinced not to store data?", "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                 
            {
                this.Close();
            }
           
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            // Mengecek apakah semua field telah diisi
            if (BookName_Text.Text != "" && BookAuthor_Text.Text != "" && BookPublication_Text.Text != "" && BookPurchase_Date.Text != "" && BookPrice_Text.Text != "" && BookQuantity_Text.Text != "")
            {
                // Menangkap data dari form
                string bname = BookName_Text.Text;
                string bauthor = BookAuthor_Text.Text;
                string publication = BookPublication_Text.Text;
                string pdate = BookPurchase_Date.Text;
                Int64 price = Int64.Parse(BookPrice_Text.Text);
                Int64 quan = Int64.Parse(BookQuantity_Text.Text);

                // Membuat koneksi ke database
                using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
                {
                    // Membuka koneksi
                    conn.Open();

                    // Membuat perintah SQL dengan parameter
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO NewBook (bName, bAuthor, bPublic, bPDate, bPrice, bQuan) VALUES (@bname, @bauthor, @bpublic, @bpdate, @bprice, @bquan)", conn))
                    {
                        // Menambahkan nilai parameter
                        cmd.Parameters.AddWithValue("@bname", bname);
                        cmd.Parameters.AddWithValue("@bauthor", bauthor);
                        cmd.Parameters.AddWithValue("@bpublic", publication);
                        cmd.Parameters.AddWithValue("@bpdate", pdate);
                        cmd.Parameters.AddWithValue("@bprice", price);
                        cmd.Parameters.AddWithValue("@bquan", quan);

                        // Menjalankan perintah
                        cmd.ExecuteNonQuery();
                    }
                }

                // Menampilkan pesan sukses
                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            else
            {
                // Menampilkan pesan error
                MessageBox.Show("Empety Field NOT Allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearData()
        {
            BookName_Text.Clear();
            BookAuthor_Text.Clear();
            BookPrice_Text.Clear();
            BookPublication_Text.Clear();
            BookQuantity_Text.Clear();
        }

    }
}
