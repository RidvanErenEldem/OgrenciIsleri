using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Base
{
    [Serializable]
    public class AkademisyenBase
    {
        private int _Id;
        private string _Ad;
        private string _Soyad;
        private string _Tcno;
        private bool _Cinsiyet;
        private int _FakulteId;
        private int _BolumId;
        private string _KullaniciAdi;
        private string _Sifre;
        private int _Yetki;
        private bool _Aktif;

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
        public string Tcno
        {
            get { return _Tcno; }
            set { _Tcno = value; }
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
        public int Yetki
        {
            get { return _Yetki; }
            set { _Yetki = value; }
        }
        public bool Aktif
        {
            get { return _Aktif; }
            set { _Aktif = value; }
        }
    }
}
