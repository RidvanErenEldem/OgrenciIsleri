using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Base
{
    [Serializable]
    public class NotlarBase
    {
        private int _Id;
        private int _OgrenciId;
        private int? _Vize;
        private int? _Final;
        private int? _Ortalama;
        private int _DersId;
        private bool _Aktif;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int OgrenciId
        {
            get { return _OgrenciId; }
            set { _OgrenciId = value; }
        }
        public int? Vize
        {
            get { return _Vize; }
            set { _Vize = value; }
        }
        public int? Final
        {
            get { return _Final; }
            set { _Final = value; }
        }
        public int? Ortalama
        {
            get { return _Ortalama; }
            set { _Ortalama = value; }
        }
        public int DersId
        {
            get { return _DersId; }
            set { _DersId = value; }
        }
        public bool Aktif
        {
            get { return _Aktif; }
            set { _Aktif = value; }
        }
    }
}
