
using CK1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK1.BLL
{
    public class BLL_NguyenLieu : BLL
    {
        private static BLL_NguyenLieu _Instance;
        public static BLL_NguyenLieu Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_NguyenLieu();
                return _Instance;
            }

        }
        public NguyenLieu GetNLByName(string TenNL)
        {
            return (from c in db.nguyenLieus where c.TenNguyenLieu == TenNL select c).FirstOrDefault();
        }
        public List<NguyenLieu> GetNguyenLieus()
        {
            return db.nguyenLieus.ToList();
        }
    }
}

