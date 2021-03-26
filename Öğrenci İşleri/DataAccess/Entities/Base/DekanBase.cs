using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Base
{
    [Serializable]
    public class DekanBase
    {
        private int _Id;
        private string _KullaniciAdi;
        private string _Sifre;
        private string _Ad;
        private string _Soyad;
        private bool _Aktif;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string KullaniciAdi
        {
            get { return _KullaniciAdi; }
            set { _KullaniciAdi = value; }
        }
        public string Ad
        {
            get { return _Ad; }
            set { _Ad = value; }
        }
        public string Sifre
        {
            get { return _Sifre; }
            set { _Sifre = value; }
        }
        public string Soyad
        {
            get { return _Soyad; }
            set { _Soyad = value; }
        }
        public bool Aktif
        {
            get { return _Aktif; }
            set { _Aktif = value; }
        }
    }
}
