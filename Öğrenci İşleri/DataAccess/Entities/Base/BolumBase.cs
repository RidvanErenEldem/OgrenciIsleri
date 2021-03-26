using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Base
{
    [Serializable]
    public class BolumBase
    {
        private int _Id;
        private string _Ad;
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
        public bool Aktif
        {
            get { return _Aktif; }
            set { _Aktif = value; }
        }
    }
}
