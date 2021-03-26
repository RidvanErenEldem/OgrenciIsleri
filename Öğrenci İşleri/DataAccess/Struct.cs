using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Struct
    {
        public struct ComboBoxDbItem
        {
            public string Ad;
            public int Id;
            public override string ToString()
            {
                return Ad;
            }
        }
    }
}
