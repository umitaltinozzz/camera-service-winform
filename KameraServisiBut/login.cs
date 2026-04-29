using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace KameraServisiBut
{
    public partial class login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public static string username;
        string sqlSunucusu = "server=.; Initial Catalog=Teknik_Servis;Integrated Security=SSPI;TrustServerCertificate = true";

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Personeller WHERE kullanici_adi = @user AND sifre = @sifre";
            con = new SqlConnection(sqlSunucusu);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                username = textBox1.Text;
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını veya şifreniz yanlış.");
            }
            con.Close();
        }
    }
}
