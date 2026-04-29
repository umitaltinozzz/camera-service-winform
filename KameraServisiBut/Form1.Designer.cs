namespace KameraServisiBut
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            PersonelData = new DataGridView();
            tabPage2 = new TabPage();
            groupBox5 = new GroupBox();
            button5 = new Button();
            label9 = new Label();
            textBox9 = new TextBox();
            MusteriData2 = new DataGridView();
            groupBox4 = new GroupBox();
            button7 = new Button();
            button4 = new Button();
            textBox8 = new TextBox();
            MusteriData = new DataGridView();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tabPage3 = new TabPage();
            UrunData = new DataGridView();
            groupBox6 = new GroupBox();
            comboBox2 = new ComboBox();
            button9 = new Button();
            label17 = new Label();
            comboBox1 = new ComboBox();
            button8 = new Button();
            button6 = new Button();
            textBox15 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox11 = new TextBox();
            label16 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox12 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PersonelData).BeginInit();
            tabPage2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MusteriData2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MusteriData).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UrunData).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(943, 481);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(935, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Personeller";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(539, 133);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(388, 314);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personel Ekle";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(16, 136);
            button2.Name = "button2";
            button2.Size = new Size(366, 39);
            button2.TabIndex = 6;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(103, 96);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(272, 25);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 64);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 25);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 25);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 99);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 2;
            label4.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 36);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 1;
            label3.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 68);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı Adı:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(539, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 112);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Arama";
            // 
            // button3
            // 
            button3.Location = new Point(16, 61);
            button3.Name = "button3";
            button3.Size = new Size(359, 28);
            button3.TabIndex = 7;
            button3.Text = "Aramayı Sıfırla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(297, 30);
            button1.Name = "button1";
            button1.Size = new Size(78, 25);
            button1.TabIndex = 2;
            button1.Text = "ARA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 25);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PersonelData);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 443);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Listesi";
            // 
            // PersonelData
            // 
            PersonelData.AllowUserToAddRows = false;
            PersonelData.AllowUserToDeleteRows = false;
            PersonelData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonelData.Location = new Point(6, 24);
            PersonelData.Name = "PersonelData";
            PersonelData.ReadOnly = true;
            PersonelData.RowTemplate.Height = 25;
            PersonelData.Size = new Size(515, 413);
            PersonelData.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(935, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Müşteri Listesi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button5);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(textBox9);
            groupBox5.Controls.Add(MusteriData2);
            groupBox5.Location = new Point(336, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(593, 441);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Müşterinin Ürünleri";
            // 
            // button5
            // 
            button5.Location = new Point(292, 28);
            button5.Name = "button5";
            button5.Size = new Size(80, 30);
            button5.TabIndex = 16;
            button5.Text = "ARA";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 35);
            label9.Name = "label9";
            label9.Size = new Size(52, 17);
            label9.TabIndex = 11;
            label9.Text = "TC NO.:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(70, 32);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(216, 25);
            textBox9.TabIndex = 12;
            // 
            // MusteriData2
            // 
            MusteriData2.AllowUserToAddRows = false;
            MusteriData2.AllowUserToDeleteRows = false;
            MusteriData2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MusteriData2.Location = new Point(6, 64);
            MusteriData2.Name = "MusteriData2";
            MusteriData2.ReadOnly = true;
            MusteriData2.RowTemplate.Height = 25;
            MusteriData2.Size = new Size(581, 371);
            MusteriData2.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button7);
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(MusteriData);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(textBox6);
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(6, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(324, 441);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Müşteriler";
            // 
            // button7
            // 
            button7.Location = new Point(194, 226);
            button7.Name = "button7";
            button7.Size = new Size(121, 30);
            button7.TabIndex = 16;
            button7.Text = "SİL";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 226);
            button4.Name = "button4";
            button4.Size = new Size(182, 30);
            button4.TabIndex = 13;
            button4.Text = "EKLE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(99, 134);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(216, 86);
            textBox8.TabIndex = 15;
            // 
            // MusteriData
            // 
            MusteriData.AllowUserToAddRows = false;
            MusteriData.AllowUserToDeleteRows = false;
            MusteriData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MusteriData.Location = new Point(6, 262);
            MusteriData.Name = "MusteriData";
            MusteriData.ReadOnly = true;
            MusteriData.RowTemplate.Height = 25;
            MusteriData.Size = new Size(312, 173);
            MusteriData.TabIndex = 0;
            MusteriData.CellContentClick += MusteriData_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 137);
            label8.Name = "label8";
            label8.Size = new Size(45, 17);
            label8.TabIndex = 14;
            label8.Text = "Adres:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(99, 103);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(216, 25);
            textBox5.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 40);
            label7.Name = "label7";
            label7.Size = new Size(52, 17);
            label7.TabIndex = 7;
            label7.Text = "TC NO.:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(99, 70);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(216, 25);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(99, 37);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(216, 25);
            textBox7.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 73);
            label6.Name = "label6";
            label6.Size = new Size(67, 17);
            label6.TabIndex = 8;
            label6.Text = "Ad Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 106);
            label5.Name = "label5";
            label5.Size = new Size(87, 17);
            label5.TabIndex = 9;
            label5.Text = "Cep Telefonu:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(UrunData);
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Controls.Add(textBox12);
            tabPage3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(935, 453);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ürün Listesi";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // UrunData
            // 
            UrunData.AllowUserToAddRows = false;
            UrunData.AllowUserToDeleteRows = false;
            UrunData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UrunData.Location = new Point(338, 12);
            UrunData.Name = "UrunData";
            UrunData.ReadOnly = true;
            UrunData.RowTemplate.Height = 25;
            UrunData.Size = new Size(592, 435);
            UrunData.TabIndex = 8;
            UrunData.CellContentClick += UrunData_CellContentClick;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.White;
            groupBox6.Controls.Add(comboBox2);
            groupBox6.Controls.Add(button9);
            groupBox6.Controls.Add(label17);
            groupBox6.Controls.Add(comboBox1);
            groupBox6.Controls.Add(button8);
            groupBox6.Controls.Add(button6);
            groupBox6.Controls.Add(textBox15);
            groupBox6.Controls.Add(dateTimePicker1);
            groupBox6.Controls.Add(textBox14);
            groupBox6.Controls.Add(textBox13);
            groupBox6.Controls.Add(textBox11);
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(textBox10);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(label15);
            groupBox6.Location = new Point(5, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(327, 447);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "ÜRÜN EKLE";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Kompakt Fotoğraf Makinesi", "DSLR Fotoğraf Makinesi", "Aynasız Sistemler", "Orta format Fotoğraf Makinesi", "Lens", "Diğer" });
            comboBox2.Location = new Point(112, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 25);
            comboBox2.TabIndex = 9;
            // 
            // button9
            // 
            button9.Location = new Point(218, 396);
            button9.Name = "button9";
            button9.Size = new Size(100, 36);
            button9.TabIndex = 23;
            button9.Text = "GÜNCELLE";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(53, 238);
            label17.Name = "label17";
            label17.Size = new Size(53, 17);
            label17.TabIndex = 22;
            label17.Text = "Durum:";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Beklemede", "Kargoya Verildi", "Parça Bekleniyor", "Tamamlandı" });
            comboBox1.Location = new Point(112, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 25);
            comboBox1.TabIndex = 21;
            // 
            // button8
            // 
            button8.Location = new Point(112, 396);
            button8.Name = "button8";
            button8.Size = new Size(100, 36);
            button8.TabIndex = 20;
            button8.Text = "SİL";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Location = new Point(6, 396);
            button6.Name = "button6";
            button6.Size = new Size(100, 36);
            button6.TabIndex = 18;
            button6.Text = "EKLE";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(112, 266);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(200, 124);
            textBox15.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(112, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 16;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(112, 152);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(200, 25);
            textBox14.TabIndex = 15;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(112, 121);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(200, 25);
            textBox13.TabIndex = 14;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(112, 59);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(200, 25);
            textBox11.TabIndex = 12;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(6, 31);
            label16.Name = "label16";
            label16.Size = new Size(100, 17);
            label16.TabIndex = 10;
            label16.Text = "Müşteri TC No.:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(112, 28);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(200, 25);
            textBox10.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(65, 269);
            label10.Name = "label10";
            label10.Size = new Size(41, 17);
            label10.TabIndex = 9;
            label10.Text = "Arıza:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(36, 183);
            label11.Name = "label11";
            label11.Size = new Size(70, 34);
            label11.TabIndex = 6;
            label11.Text = "Onarım\r\nBaşlangıcı:";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(57, 155);
            label12.Name = "label12";
            label12.Size = new Size(49, 17);
            label12.TabIndex = 4;
            label12.Text = "Model:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(51, 62);
            label13.Name = "label13";
            label13.Size = new Size(55, 17);
            label13.TabIndex = 1;
            label13.Text = "Seri No:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(57, 124);
            label14.Name = "label14";
            label14.Size = new Size(49, 17);
            label14.TabIndex = 3;
            label14.Text = "Marka:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(75, 93);
            label15.Name = "label15";
            label15.Size = new Size(31, 17);
            label15.TabIndex = 2;
            label15.Text = "Tür:";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(371, 65);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(200, 25);
            textBox12.TabIndex = 13;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 486);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teknik Servis - User: Admin";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PersonelData).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MusteriData2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MusteriData).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UrunData).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private DataGridView PersonelData;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private DataGridView MusteriData;
        private GroupBox groupBox5;
        private DataGridView MusteriData2;
        private Button button4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button5;
        private Label label9;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label8;
        private GroupBox groupBox6;
        private Label label16;
        private TextBox textBox10;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button button8;
        private Button button6;
        private TextBox textBox15;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private DataGridView UrunData;
        private ComboBox comboBox1;
        private Label label17;
        private Button button7;
        private Button button9;
        private ComboBox comboBox2;
    }
}