using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class Form2 : Form
    {
        private List<Kisi> kisi;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Kisi> kisi) : this()
        {
            this.kisi = kisi;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Kisi item in kisi)
            {
                lstKisiler.Items.Add(item);
            }
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            Kisi secilenKisi = new Kisi();
            secilenKisi = lstKisiler.SelectedItem as Kisi;

            txtAd.Text = secilenKisi.Adi;
            txtSoyad.Text = secilenKisi.Soyadi;
            txtMeslek.Text = secilenKisi.Meslek;
            dateTimePicker1.Value = secilenKisi.DogumTarihi;
            txtDogumYeri.Text = secilenKisi.DogumYeri;
            mskdTel1.Text = secilenKisi.Telefon1;
            mskdTel2.Text = secilenKisi.Telefon2;
            mskdEvTel.Text = secilenKisi.EvTelefonu;
            mskdIsTel.Text = secilenKisi.IsTelefonu;
            txtEvAdresi.Text = secilenKisi.EvAdresi;
            txtIsAdresi.Text = secilenKisi.IsAdresi;
            txtFacebook.Text = secilenKisi.Facebook;
            txtTwitter.Text = secilenKisi.twitter;
            txtMail.Text = secilenKisi.Mail;
            txtWebSite.Text = secilenKisi.WebSite;
            txtHakkinda.Text = secilenKisi.Hakkinda;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            lstKisiler.Items.RemoveAt(lstKisiler.SelectedIndex);
            Temizle();
        }

        private void Temizle()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtMeslek.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Today;
            txtDogumYeri.Text = string.Empty;
            mskdTel1.Text = string.Empty;
            mskdTel2.Text = string.Empty;
            mskdEvTel.Text = string.Empty;
            mskdIsTel.Text = string.Empty;
            txtEvAdresi.Text = string.Empty;
            txtIsAdresi.Text = string.Empty;
            txtFacebook.Text = string.Empty;
            txtTwitter.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtWebSite.Text = string.Empty;
            txtHakkinda.Text = string.Empty;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            Kisi guncellenenKisi = new Kisi();

            guncellenenKisi = lstKisiler.SelectedItem as Kisi;

            guncellenenKisi.Adi = txtAd.Text;
            guncellenenKisi.Soyadi = txtSoyad.Text;
            guncellenenKisi.DogumTarihi = dateTimePicker1.Value;
            guncellenenKisi.DogumYeri = txtDogumYeri.Text;
            guncellenenKisi.Meslek = txtMeslek.Text;
            guncellenenKisi.Telefon1 = mskdTel1.Text;
            guncellenenKisi.Telefon2 = mskdTel2.Text;
            guncellenenKisi.EvTelefonu = mskdEvTel.Text;
            guncellenenKisi.IsTelefonu = mskdIsTel.Text;
            guncellenenKisi.EvAdresi = txtEvAdresi.Text;
            guncellenenKisi.IsAdresi = txtIsAdresi.Text;
            guncellenenKisi.Mail = txtMail.Text;
            guncellenenKisi.twitter = txtTwitter.Text;
            guncellenenKisi.Facebook = txtFacebook.Text;
            guncellenenKisi.WebSite = txtWebSite.Text;
            guncellenenKisi.Hakkinda = txtHakkinda.Text;
            lstKisiler.Items.Add(guncellenenKisi);
            lstKisiler.Items.RemoveAt(lstKisiler.SelectedIndex);
            Temizle();

        }

        private void btnAraTel_Click(object sender, EventArgs e)
        {
            if (mskdAraTel.MaskFull == false) return;
            lstKisiler.Items.Clear();

            foreach (Kisi item in kisi)
            {
                if (item.Telefon1 == mskdAraTel.Text)
                {
                    lstKisiler.Items.Add(item);
                }
            }
        }

        private void btnAraMail_Click(object sender, EventArgs e)
        {
            if (txtAraMail.Text == string.Empty) return;
            lstKisiler.Items.Clear();

            foreach (Kisi item in kisi)
            {
                if (item.Mail == txtAraMail.Text)
                {
                    lstKisiler.Items.Add(item);
                }
            }
        }

        private void btnAraDG_Click(object sender, EventArgs e)
        {
            lstKisiler.Items.Clear();

            foreach (Kisi item in kisi)
            {
                if (item.DogumTarihi == dtpAraDG.Value)
                {
                    lstKisiler.Items.Add(item);
                }
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstKisiler.Items.Clear();

            foreach (Kisi item in kisi)
            {
                lstKisiler.Items.Add(item);
            }
        }

    }
}
