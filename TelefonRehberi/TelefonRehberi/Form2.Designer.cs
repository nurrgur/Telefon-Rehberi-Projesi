
namespace TelefonRehberi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHakkinda = new System.Windows.Forms.TextBox();
            this.gboxSosyalMedya = new System.Windows.Forms.GroupBox();
            this.txtWebSite = new System.Windows.Forms.TextBox();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gboxIletisim = new System.Windows.Forms.GroupBox();
            this.mskdIsTel = new System.Windows.Forms.MaskedTextBox();
            this.mskdEvTel = new System.Windows.Forms.MaskedTextBox();
            this.mskdTel2 = new System.Windows.Forms.MaskedTextBox();
            this.mskdTel1 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIsAdresi = new System.Windows.Forms.TextBox();
            this.txtEvAdresi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gboxKisiBilgileri = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAraMail = new System.Windows.Forms.TextBox();
            this.mskdAraTel = new System.Windows.Forms.MaskedTextBox();
            this.dtpAraDG = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAraDG = new System.Windows.Forms.Button();
            this.btnAraMail = new System.Windows.Forms.Button();
            this.btnAraTel = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.gboxSosyalMedya.SuspendLayout();
            this.gboxIletisim.SuspendLayout();
            this.gboxKisiBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 20;
            this.lstKisiler.Location = new System.Drawing.Point(36, 59);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(415, 224);
            this.lstKisiler.TabIndex = 0;
            this.lstKisiler.SelectedIndexChanged += new System.EventHandler(this.lstKisiler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(914, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hakkında";
            // 
            // txtHakkinda
            // 
            this.txtHakkinda.Location = new System.Drawing.Point(930, 389);
            this.txtHakkinda.Multiline = true;
            this.txtHakkinda.Name = "txtHakkinda";
            this.txtHakkinda.Size = new System.Drawing.Size(385, 201);
            this.txtHakkinda.TabIndex = 8;
            // 
            // gboxSosyalMedya
            // 
            this.gboxSosyalMedya.Controls.Add(this.txtWebSite);
            this.gboxSosyalMedya.Controls.Add(this.txtTwitter);
            this.gboxSosyalMedya.Controls.Add(this.txtFacebook);
            this.gboxSosyalMedya.Controls.Add(this.txtMail);
            this.gboxSosyalMedya.Controls.Add(this.label13);
            this.gboxSosyalMedya.Controls.Add(this.label14);
            this.gboxSosyalMedya.Controls.Add(this.label15);
            this.gboxSosyalMedya.Controls.Add(this.label16);
            this.gboxSosyalMedya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxSosyalMedya.Location = new System.Drawing.Point(930, 123);
            this.gboxSosyalMedya.Name = "gboxSosyalMedya";
            this.gboxSosyalMedya.Size = new System.Drawing.Size(385, 196);
            this.gboxSosyalMedya.TabIndex = 7;
            this.gboxSosyalMedya.TabStop = false;
            this.gboxSosyalMedya.Text = "Sosyal Medya Hesapları";
            // 
            // txtWebSite
            // 
            this.txtWebSite.Location = new System.Drawing.Point(131, 140);
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.Size = new System.Drawing.Size(227, 30);
            this.txtWebSite.TabIndex = 26;
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(131, 102);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(227, 30);
            this.txtTwitter.TabIndex = 25;
            // 
            // txtFacebook
            // 
            this.txtFacebook.Location = new System.Drawing.Point(131, 66);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(227, 30);
            this.txtFacebook.TabIndex = 24;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(131, 29);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(227, 30);
            this.txtMail.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Web Site:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 21;
            this.label14.Text = "Twitter:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "Facebook:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 25);
            this.label16.TabIndex = 19;
            this.label16.Text = "E- Mail:";
            // 
            // gboxIletisim
            // 
            this.gboxIletisim.Controls.Add(this.mskdIsTel);
            this.gboxIletisim.Controls.Add(this.mskdEvTel);
            this.gboxIletisim.Controls.Add(this.mskdTel2);
            this.gboxIletisim.Controls.Add(this.mskdTel1);
            this.gboxIletisim.Controls.Add(this.label12);
            this.gboxIletisim.Controls.Add(this.label7);
            this.gboxIletisim.Controls.Add(this.txtIsAdresi);
            this.gboxIletisim.Controls.Add(this.txtEvAdresi);
            this.gboxIletisim.Controls.Add(this.label8);
            this.gboxIletisim.Controls.Add(this.label9);
            this.gboxIletisim.Controls.Add(this.label10);
            this.gboxIletisim.Controls.Add(this.label11);
            this.gboxIletisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxIletisim.Location = new System.Drawing.Point(472, 132);
            this.gboxIletisim.Name = "gboxIletisim";
            this.gboxIletisim.Size = new System.Drawing.Size(429, 477);
            this.gboxIletisim.TabIndex = 6;
            this.gboxIletisim.TabStop = false;
            this.gboxIletisim.Text = "İletişim Bilgileri";
            // 
            // mskdIsTel
            // 
            this.mskdIsTel.Location = new System.Drawing.Point(232, 154);
            this.mskdIsTel.Mask = "000-0000";
            this.mskdIsTel.Name = "mskdIsTel";
            this.mskdIsTel.Size = new System.Drawing.Size(100, 30);
            this.mskdIsTel.TabIndex = 26;
            // 
            // mskdEvTel
            // 
            this.mskdEvTel.Location = new System.Drawing.Point(232, 112);
            this.mskdEvTel.Mask = "000-0000";
            this.mskdEvTel.Name = "mskdEvTel";
            this.mskdEvTel.Size = new System.Drawing.Size(100, 30);
            this.mskdEvTel.TabIndex = 25;
            // 
            // mskdTel2
            // 
            this.mskdTel2.Location = new System.Drawing.Point(232, 76);
            this.mskdTel2.Mask = "(999) 000-0000";
            this.mskdTel2.Name = "mskdTel2";
            this.mskdTel2.Size = new System.Drawing.Size(171, 30);
            this.mskdTel2.TabIndex = 24;
            // 
            // mskdTel1
            // 
            this.mskdTel1.Location = new System.Drawing.Point(232, 37);
            this.mskdTel1.Mask = "(999) 000-0000";
            this.mskdTel1.Name = "mskdTel1";
            this.mskdTel1.Size = new System.Drawing.Size(171, 30);
            this.mskdTel1.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "İş Adresi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ev Adresi:";
            // 
            // txtIsAdresi
            // 
            this.txtIsAdresi.Location = new System.Drawing.Point(145, 346);
            this.txtIsAdresi.Multiline = true;
            this.txtIsAdresi.Name = "txtIsAdresi";
            this.txtIsAdresi.Size = new System.Drawing.Size(258, 112);
            this.txtIsAdresi.TabIndex = 20;
            // 
            // txtEvAdresi
            // 
            this.txtEvAdresi.Location = new System.Drawing.Point(145, 202);
            this.txtEvAdresi.Multiline = true;
            this.txtEvAdresi.Name = "txtEvAdresi";
            this.txtEvAdresi.Size = new System.Drawing.Size(258, 112);
            this.txtEvAdresi.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "İş Telefonu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ev Telefonu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Telefon Numarası 2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Telefon Numarası:";
            // 
            // gboxKisiBilgileri
            // 
            this.gboxKisiBilgileri.Controls.Add(this.dateTimePicker1);
            this.gboxKisiBilgileri.Controls.Add(this.txtMeslek);
            this.gboxKisiBilgileri.Controls.Add(this.txtDogumYeri);
            this.gboxKisiBilgileri.Controls.Add(this.txtSoyad);
            this.gboxKisiBilgileri.Controls.Add(this.txtAd);
            this.gboxKisiBilgileri.Controls.Add(this.label6);
            this.gboxKisiBilgileri.Controls.Add(this.label5);
            this.gboxKisiBilgileri.Controls.Add(this.label4);
            this.gboxKisiBilgileri.Controls.Add(this.label3);
            this.gboxKisiBilgileri.Controls.Add(this.label2);
            this.gboxKisiBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxKisiBilgileri.Location = new System.Drawing.Point(12, 361);
            this.gboxKisiBilgileri.Name = "gboxKisiBilgileri";
            this.gboxKisiBilgileri.Size = new System.Drawing.Size(439, 248);
            this.gboxKisiBilgileri.TabIndex = 5;
            this.gboxKisiBilgileri.TabStop = false;
            this.gboxKisiBilgileri.Text = "Kisi Bilgileri";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 115);
            this.dateTimePicker1.MaxDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 30);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(182, 193);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(227, 30);
            this.txtMeslek.TabIndex = 9;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(182, 151);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(227, 30);
            this.txtDogumYeri.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(182, 74);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(227, 30);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(182, 37);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(227, 30);
            this.txtAd.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Meslek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Doğum Yeri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Location = new System.Drawing.Point(177, 294);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(114, 34);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSil.Location = new System.Drawing.Point(46, 294);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 34);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtAraMail
            // 
            this.txtAraMail.Location = new System.Drawing.Point(801, 37);
            this.txtAraMail.Name = "txtAraMail";
            this.txtAraMail.Size = new System.Drawing.Size(158, 26);
            this.txtAraMail.TabIndex = 12;
            // 
            // mskdAraTel
            // 
            this.mskdAraTel.Location = new System.Drawing.Point(548, 40);
            this.mskdAraTel.Mask = "(999) 000-0000";
            this.mskdAraTel.Name = "mskdAraTel";
            this.mskdAraTel.Size = new System.Drawing.Size(143, 26);
            this.mskdAraTel.TabIndex = 13;
            // 
            // dtpAraDG
            // 
            this.dtpAraDG.Location = new System.Drawing.Point(1128, 37);
            this.dtpAraDG.Name = "dtpAraDG";
            this.dtpAraDG.Size = new System.Drawing.Size(200, 26);
            this.dtpAraDG.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(457, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 25);
            this.label17.TabIndex = 15;
            this.label17.Text = "Telefon";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(718, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 25);
            this.label18.TabIndex = 16;
            this.label18.Text = "Mail";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(972, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 25);
            this.label19.TabIndex = 17;
            this.label19.Text = "Dogum Tarihi";
            // 
            // btnAraDG
            // 
            this.btnAraDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAraDG.Location = new System.Drawing.Point(1251, 79);
            this.btnAraDG.Name = "btnAraDG";
            this.btnAraDG.Size = new System.Drawing.Size(77, 36);
            this.btnAraDG.TabIndex = 18;
            this.btnAraDG.Text = "Ara";
            this.btnAraDG.UseVisualStyleBackColor = false;
            this.btnAraDG.Click += new System.EventHandler(this.btnAraDG_Click);
            // 
            // btnAraMail
            // 
            this.btnAraMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAraMail.Location = new System.Drawing.Point(882, 77);
            this.btnAraMail.Name = "btnAraMail";
            this.btnAraMail.Size = new System.Drawing.Size(77, 36);
            this.btnAraMail.TabIndex = 19;
            this.btnAraMail.Text = "Ara";
            this.btnAraMail.UseVisualStyleBackColor = false;
            this.btnAraMail.Click += new System.EventHandler(this.btnAraMail_Click);
            // 
            // btnAraTel
            // 
            this.btnAraTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAraTel.Location = new System.Drawing.Point(614, 79);
            this.btnAraTel.Name = "btnAraTel";
            this.btnAraTel.Size = new System.Drawing.Size(77, 36);
            this.btnAraTel.TabIndex = 20;
            this.btnAraTel.Text = "Ara";
            this.btnAraTel.UseVisualStyleBackColor = false;
            this.btnAraTel.Click += new System.EventHandler(this.btnAraTel_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnListele.Location = new System.Drawing.Point(307, 294);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(114, 34);
            this.btnListele.TabIndex = 21;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 644);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnAraTel);
            this.Controls.Add(this.btnAraMail);
            this.Controls.Add(this.btnAraDG);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dtpAraDG);
            this.Controls.Add(this.mskdAraTel);
            this.Controls.Add(this.txtAraMail);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHakkinda);
            this.Controls.Add(this.gboxSosyalMedya);
            this.Controls.Add(this.gboxIletisim);
            this.Controls.Add(this.gboxKisiBilgileri);
            this.Controls.Add(this.lstKisiler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gboxSosyalMedya.ResumeLayout(false);
            this.gboxSosyalMedya.PerformLayout();
            this.gboxIletisim.ResumeLayout(false);
            this.gboxIletisim.PerformLayout();
            this.gboxKisiBilgileri.ResumeLayout(false);
            this.gboxKisiBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHakkinda;
        private System.Windows.Forms.GroupBox gboxSosyalMedya;
        private System.Windows.Forms.TextBox txtWebSite;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gboxIletisim;
        private System.Windows.Forms.MaskedTextBox mskdIsTel;
        private System.Windows.Forms.MaskedTextBox mskdEvTel;
        private System.Windows.Forms.MaskedTextBox mskdTel2;
        private System.Windows.Forms.MaskedTextBox mskdTel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIsAdresi;
        private System.Windows.Forms.TextBox txtEvAdresi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gboxKisiBilgileri;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtAraMail;
        private System.Windows.Forms.MaskedTextBox mskdAraTel;
        private System.Windows.Forms.DateTimePicker dtpAraDG;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAraDG;
        private System.Windows.Forms.Button btnAraMail;
        private System.Windows.Forms.Button btnAraTel;
        private System.Windows.Forms.Button btnListele;
    }
}