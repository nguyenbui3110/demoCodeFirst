using CK1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK1.BLL
{
    public class BLL_MonAnNguyenLieu:BLL
    {
        private static BLL_MonAnNguyenLieu _Instance;
        public static BLL_MonAnNguyenLieu Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_MonAnNguyenLieu();
                return _Instance;
            }

        }
        public void add(MonAn_NguyenLieu monAn_NguyenLieu)
        {
            int lastID = Convert.ToInt32(db.monAnNguyenLieus.ToList().LastOrDefault().ID) + 1;
            monAn_NguyenLieu.ID=lastID.ToString();
            monAn_NguyenLieu.MonAn = null;
            monAn_NguyenLieu.MaMonAn = null;
            db.monAnNguyenLieus.Add(monAn_NguyenLieu);
            db.SaveChanges();
        }
        public void save()
        {
            db.SaveChanges();
        }
        public List<MonAn_NguyenLieu> getAll()
        {
            return db.monAnNguyenLieus.ToList();
        }
        public MonAn_NguyenLieu getByID(string ID)
        {
            return db.monAnNguyenLieus.Find(ID);
        }
        public List<MonAn_NguyenLieu> getBySearchbox(int MaMonAn,string TenNL)
        {
            var query= from c in db.monAnNguyenLieus where c.NguyenLieu.TenNguyenLieu.Contains(TenNL) select c;
            if(MaMonAn!=0)
            {
                query = from c in query where c.MaMonAn == MaMonAn select c;
            }    
            return query.ToList();
        }

        public void Del(string ID)
        { 

            var query = db.monAnNguyenLieus.Find(ID);
            db.monAnNguyenLieus.Remove(query);
            db.SaveChanges();
        }
    }
}
