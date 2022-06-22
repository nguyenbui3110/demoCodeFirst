using CK1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK1.BLL
{
    public class BLL
    {
        protected static NhaKho db;
        protected BLL()
        {
            db = new NhaKho();
        }
    }
}
