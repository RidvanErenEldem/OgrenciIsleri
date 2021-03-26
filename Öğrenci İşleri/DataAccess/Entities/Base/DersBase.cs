using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Base
{
    [Serializable]
    public class DersBase
    {
        private int _Id;
        private string _Ad;
        private int _FakulteId;
        private int _BolumId;
        private int _AkademisyenId;
        private Byte _Kredi;
        private bool _Aktif;
        private Byte _Donem;

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
        public int AkademisyenId
        {
            get { return _AkademisyenId; }
            set { _AkademisyenId = value; }

        }
        public Byte Kredi
        {
            get { return _Kredi; }
            set { _Kredi = value; }
        }
        public bool Aktif
        {
            get { return _Aktif; }
            set { _Aktif = value; }

        }
        public Byte Donem
        {
            get { return _Donem; }
            set { _Donem = value;}
        }

    }
}
