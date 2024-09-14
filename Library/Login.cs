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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            OrganizeEvent();
        }

        #region EVENT
        private void OrganizeEvent()
        {
            Close_Button.Click += Close_Button_Click;
            Username_Text.MouseEnter += Username_Text_MouseEnter;
            Password_Text.MouseEnter += Password_Text_MouseEnter;
            Login_Button.Click += Login_Button_Click;
            SignUp_Button.Click += SignUp_Button_Click;
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
             try
              {
                  // Membuat koneksi ke database
                  using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
                  {
                      conn.Open();

                      // Membuat perintah SQL dengan parameter
                      using (SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Username = @Username AND Pass = @Pass", conn))
                      {
                          // Menambahkan nilai parameter
                          cmd.Parameters.AddWithValue("@Username", Username_Text.Text);
                          cmd.Parameters.AddWithValue("@Pass", Password_Text.Text);

                          // Menggunakan SqlDataAdapter untuk mengisi DataSet
                          SqlDataAdapter da = new SqlDataAdapter(cmd);
                          DataSet ds = new DataSet();
                          da.Fill(ds);

                          // Memeriksa apakah ada data yang sesuai
                          if (ds.Tables[0].Rows.Count > 0)
                          {
                              Dashboard dasbor = new Dashboard();
                              dasbor.Show();
                          }
                          else
                          {
                              MessageBox.Show("Username or Password Incorrect.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                          }
                      }
                  }
                }
              catch (Exception ex)
              {
                  MessageBox.Show("Terjadi kesalahan: " + ex.Message);
              }
            

        }

        private void Password_Text_MouseEnter(object sender, EventArgs e)
        {
            if(Password_Text.Text == "Password")
            {
                Password_Text.Clear();
                Password_Text.PasswordChar = '*';
            }
        }

        private void Username_Text_MouseEnter(object sender, EventArgs e)
        {
            if (Username_Text.Text == "Username")
            {
                Username_Text.Clear();
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
