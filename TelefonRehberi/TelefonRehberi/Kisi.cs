using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Kisi
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public string Meslek { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string EvTelefonu { get; set; }
        public string IsTelefonu { get; set; }
        public string EvAdresi { get; set; }
        public string IsAdresi { get; set; }
        public string Mail { get; set; }
        public string twitter { get; set; }
        public string Facebook { get; set; }
        public string WebSite { get; set; }
        public string Hakkinda { get; set; }

        public override string ToString()
        {
            return Adi + "  " + Soyadi + "  "+Telefon1 + "  " + Mail;
        }
    }
}
