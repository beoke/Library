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
using System.Web;
using System.Windows.Forms;

namespace Library
{
    public partial class Form_AddStudent : Form
    {
        public Form_AddStudent()
        {
            InitializeComponent();

            OrganizeEvent();
        }
        private void OrganizeEvent()
        {
            ClearData();
            Btn_Exit.Click += Btn_Exit_Click;
            Btn_Save.Click += Btn_Save_Click;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void ClearData()
        {
            Txt_StudentName.Clear();
            Txt_Enrollment.Clear();
            Txt_Departement.Clear();
            Txt_Semester.Clear();
            Txt_Contact.Clear();
            Txt_Email.Text = "";
        }
        private void SaveData()
        {
            // Mengecek apakah semua field telah diisi
            if (Txt_StudentName.Text != "" && Txt_Enrollment.Text != "" && Txt_Departement.Text != "" && Txt_Semester .Text != "" && Txt_Semester.Text != "" && Txt_Contact.Text != "" && Txt_Email.Text != "")
            {
                // Menangkap data dari form
                String name = Txt_StudentName.Text;
                String enroll = Txt_Enrollment.Text;
                String dep = Txt_Departement.Text;
                String sem = Txt_Semester.Text;
                Int64 contact = Int64.Parse(Txt_Contact.Text);
                String email = Txt_Email.Text;

                // Membuat koneksi ke database
                using (SqlConnection conn = new SqlConnection(ConStringHelper.Get()))
                {
                    // Membuka koneksi
                    conn.Open();

                    // Membuat perintah SQL dengan parameter
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO NewStudent (StuName, StuEnrol, StuDep, StuSem, StuContact, StuEmail) VALUES (@stuname, @stuenrol, @studep, @stusem, @stucontact, @stuemail)", conn))
                    {
                        // Menambahkan nilai parameter
                        cmd.Parameters.AddWithValue("@stuname", name);
                        cmd.Parameters.AddWithValue("@stuenrol", enroll);
                        cmd.Parameters.AddWithValue("@studep", dep);
                        cmd.Parameters.AddWithValue("@stusem", sem);
                        cmd.Parameters.AddWithValue("@stucontact", contact);
                        cmd.Parameters.AddWithValue("@stuemail", email);

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
    }
}
