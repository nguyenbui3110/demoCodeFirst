using CK1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK1.BLL
{
    public class BLL_MonAn:BLL
    {
        private static BLL_MonAn _Instance;
        public static BLL_MonAn Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_MonAn();
                return _Instance;
            }

        }
        public List<MonAn> GetMonAns()
        {
            return db.monAns.ToList();
        }
    }
}
