using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK1.DTO
{
    internal class CBBNguyenLieu
    {
        public int value { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
