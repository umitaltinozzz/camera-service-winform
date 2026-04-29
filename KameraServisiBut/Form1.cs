using System.Data;
using Microsoft.Data.SqlClient;

namespace KameraServisiBut
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds;

        string sqlSunucusu = "server=.; Initial Catalog=Teknik_Servis;Integrated Security=SSPI;TrustServerCertificate = true";

        public Form1()
        {
            InitializeComponent();
        }

        public void PersonelDataAl()
        {
            con = new SqlConnection(sqlSunucusu);
            da = new SqlDataAdapter("Select * From Personeller", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personeller");
            PersonelData.DataSource = ds.Tables["Personeller"];
            con.Close();
        }
        public void MusteriDataAl()
        {
            con = new SqlConnection(sqlSunucusu);
            da = new SqlDataAdapter("Select * From Kullanicilar", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kullanicilar");
            MusteriData.DataSource = ds.Tables["Kullanicilar"];
            con.Close();
        }
        public void UrunDataAl()
        {
            con = new SqlConnection(sqlSunucusu);
            da = new SqlDataAdapter("Select * From Urunler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Urunler");
            UrunData.DataSource = ds.Tables["Urunler"];
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelDataAl();
            UrunDataAl();
            MusteriDataAl();

            this.Text = "Fotoðraf ve Kamera Servisi - User " + login.username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Personeller WHERE kullanici_adi=@kullanici_adi";

            con = new SqlConnection(sqlSunucusu);
            com = new SqlCommand(sorgu, con);

            com.Parameters.AddWithValue("@kullanici_adi", textBox1.Text);

            da = new SqlDataAdapter(com);
            ds = new DataSet();

            con.Open();
            da.Fill(ds, "Personeller");
            PersonelData.DataSource = ds.Tables["Personeller"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelDataAl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Personeller (kullanici_adi,sifre,ad_soyad) VALUES (@kullanici_adi,@sifre,@ad_soyad)";
            com = new SqlCommand(sorgu, con);
            com.Parameters.AddWithValue("@kullanici_adi", textBox3.Text);
            com.Parameters.AddWithValue("@sifre", textBox4.Text);
            com.Parameters.AddWithValue("@ad_soyad", textBox2.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            PersonelDataAl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Kullanicilar (tcno,ad_soyad,telefon_no,adres) VALUES (@tcno,@ad_soyad,@telefon_no,@adres)";

            com = new SqlCommand(sorgu, con);
            com.Parameters.AddWithValue("@ad_soyad", textBox6.Text);
            com.Parameters.AddWithValue("@adres", textBox8.Text);
            com.Parameters.AddWithValue("@tcno", Convert.ToInt64(textBox7.Text));
            com.Parameters.AddWithValue("@telefon_no", Convert.ToInt64(textBox5.Text));
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MusteriDataAl();

            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Urunler WHERE tcno=@tcno";

            con = new SqlConnection(sqlSunucusu);
            com = new SqlCommand(sorgu, con);

            com.Parameters.AddWithValue("@tcno", textBox9.Text);

            da = new SqlDataAdapter(com);
            ds = new DataSet();

            con.Open();
            da.Fill(ds, "Urunler");
            MusteriData2.DataSource = ds.Tables["Urunler"];
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Urunler (seri_no,teknisyen,tcno,tur,marka,model,onarim_tarihi,aciklama,durum) VALUES (@serino,@username,@tcno,@tur,@marka,@model,@onarim_tarihi,@ariza,@durum)";
            com = new SqlCommand(sorgu, con);
            com.Parameters.AddWithValue("@serino", textBox11.Text);
            com.Parameters.AddWithValue("@username", login.username);
            com.Parameters.AddWithValue("@tcno", Convert.ToInt64(textBox10.Text));
            com.Parameters.AddWithValue("@tur", comboBox2.Text);
            com.Parameters.AddWithValue("@marka", textBox13.Text);
            com.Parameters.AddWithValue("@model", textBox14.Text);
            com.Parameters.AddWithValue("@onarim_tarihi", dateTimePicker1.Value);
            com.Parameters.AddWithValue("@ariza", textBox15.Text);
            com.Parameters.AddWithValue("@durum", comboBox1.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            UrunDataAl();

            textBox10.Clear();
            textBox11.Clear();

            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Urunler WHERE seri_no=@seri_no";
            com = new SqlCommand(sorgu, con);
            com.Parameters.AddWithValue("@seri_no", textBox11.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            UrunDataAl();
        }

        private void UrunData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox11.Text = UrunData.CurrentRow.Cells[0].Value.ToString();

            textBox10.Text = UrunData.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = UrunData.CurrentRow.Cells[3].Value.ToString();
            textBox13.Text = UrunData.CurrentRow.Cells[4].Value.ToString();
            textBox14.Text = UrunData.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = UrunData.CurrentRow.Cells[6].Value.ToString();
            textBox15.Text = UrunData.CurrentRow.Cells[7].Value.ToString();
            comboBox1.Text = UrunData.CurrentRow.Cells[8].Value.ToString();
        }

        private void MusteriData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = MusteriData.CurrentRow.Cells[0].Value.ToString();
            textBox9.Text = MusteriData.CurrentRow.Cells[0].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Kullanicilar WHERE tcno=@tcno";
            com = new SqlCommand(sorgu, con);
            com.Parameters.AddWithValue("@tcno", textBox7.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MusteriDataAl();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Urunler SET tur=@tur,marka=@marka,model=@model,onarim_tarihi=@onarim_tarihi, aciklama=@ariza, durum=@durum WHERE seri_no=@serino";
            com = new SqlCommand(sorgu, con);
            com.Parameters.AddWithValue("@serino", textBox11.Text);
            com.Parameters.AddWithValue("@tur", comboBox2.Text);
            com.Parameters.AddWithValue("@marka", textBox13.Text);
            com.Parameters.AddWithValue("@model", textBox14.Text);
            com.Parameters.AddWithValue("@onarim_tarihi", dateTimePicker1.Value);
            com.Parameters.AddWithValue("@ariza", textBox15.Text);
            com.Parameters.AddWithValue("@durum", comboBox1.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            UrunDataAl();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}