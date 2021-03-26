using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Base
{
    [Serializable]
    public class OgrenciBase
    {
        private int _Id;
        private string _Ad;
        private string _Soyad;
        private string _Numara;
        private bool _Cinsiyet;
        private int _FakulteId;
        private int _BolumId;
        private string _AlinanDersler;
        private string _KullaniciAdi;
        private string _Sifre;
        private bool _Onay;
        private bool _Aktif;
        private Byte _Donem;
        private bool _OnceOnay;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Ad
        {
            get { return _Ad; }
            set { _Ad = value; }
        }
        public string Soyad
        {
            get { return _Soyad; }
            set { _Soyad = value; }
        }
        public string Numara
        {
            get { return _Numara; }
            set { _Numara = value; }
        }
        public bool Cinsiyet
        {
            get { return _Cinsiyet; }
            set { _Cinsiyet = value; }
        }
        public int FakulteId
        {
            get { return _FakulteId; }
            set { _FakulteId = value; }
        }
        public int BolumId
        {
            get { return _BolumId; }
            set { _BolumId = value; }
        }
        public string AlinanDersler
        {
            get { return _AlinanDersler; }
            set { _AlinanDersler = value; }
        }
        public string KullaniciAdi
        {
            get { return _KullaniciAdi; }
            set { _KullaniciAdi = value; }
        }
        public string Sifre
        {
            get { return _Sifre; }
            set { _Sifre = value; }
        }
        public bool Onay
        {
            get { return _Onay; }
            set { _Onay = value; }
        }
        public bool Aktif
        {
            get { return _Aktif; }
            set { _Aktif = value; }
        }
        public Byte Donem
        {
            get { return _Donem; }
            set { _Donem = value; }
        }
        public bool OnceOnay
        {
            get { return _OnceOnay; }
            set { _OnceOnay = value; }
        }
    }
}
