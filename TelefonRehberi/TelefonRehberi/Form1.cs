using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kisi> kisi = new List<Kisi>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == string.Empty || txtSoyad.Text == string.Empty || txtDogumYeri.Text == string.Empty
                || txtMeslek.Text == string.Empty)
            {
                MessageBox.Show("Kişi Bilgilerinizi eksik girdiniz lütfen kontrol edin..");
                return;
            }
            if (mskdTel1.MaskFull == false || mskdTel2.MaskFull == false || mskdEvTel.MaskFull == false
                || mskdIsTel.MaskFull == false)
            {
                MessageBox.Show("Lütfen telefon numaralarnızı eksiksiz girin..");
                return;
            }
            if (txtEvAdresi.Text == string.Empty || txtIsAdresi.Text == string.Empty)
            {
                MessageBox.Show("Lütfen adres bilgilerinizi tam girin..");
                return;
            }
            if (txtMail.Text == string.Empty || txtFacebook.Text == string.Empty || txtTwitter.Text == string.Empty ||
                txtWebSite.Text == string.Empty)
            {
                MessageBox.Show("Sosyal Medya hesaplarınızı tam doldurmalısınız..");
                return;
            }
            if (txtHakkinda.Text == string.Empty)
            {
                MessageBox.Show("Hakkında kısmı boş geçilemez..");
                return;
            }

            //Bir sonraki sayfada mail ve telefona göre arama yapılacağı için onların kontrolleri
            //yapıldı.

            foreach (Kisi item in kisi)
            {
                if (item.Telefon1 == mskdTel1.Text)
                {
                    MessageBox.Show("Bu telefon numarası zaten kayıtlı..");
                    return;
                }
                if (item.Mail== txtMail.Text)
                {
                    MessageBox.Show("Bu mail adresi zaten kayıtlı..");
                    return;
                }
                if(txtMail.Text.Contains('@')==false)
                {
                    MessageBox.Show("Hatalı mail adresi");
                    return;
                }

            }

            kisi.Add(new Kisi()
            {
                Adi = txtAd.Text,
                Soyadi = txtSoyad.Text,
                DogumTarihi = dateTimePicker1.Value,
                DogumYeri = txtDogumYeri.Text,
                Meslek = txtMeslek.Text,
                Telefon1 = mskdTel1.Text,
                Telefon2 = mskdTel2.Text,
                EvTelefonu = mskdEvTel.Text,
                IsTelefonu = mskdIsTel.Text,
                EvAdresi = txtEvAdresi.Text,
                IsAdresi = txtIsAdresi.Text,
                Mail = txtMail.Text,
                twitter = txtTwitter.Text,
                Facebook = txtFacebook.Text,
                WebSite = txtWebSite.Text,
                Hakkinda = txtHakkinda.Text
            });
            MessageBox.Show(txtAd.Text + "  " + txtSoyad.Text + "  Başarıyla eklendi..");
            Temizle();
        }

        private void Temizle()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtMeslek.Text = string.Empty;
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

        private void btnGec_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(kisi);
            f.Show();
        }
    }
}
