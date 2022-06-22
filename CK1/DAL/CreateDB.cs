using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CK1.DTO;

namespace CK1.DAL
{
    internal class CreateDB:CreateDatabaseIfNotExists<NhaKho>
    {
        protected override void Seed(NhaKho context)
        {
            context.monAns.AddRange(new MonAn[]
            {
                new MonAn {TenMonAn="gà rán"},
                new MonAn {TenMonAn="hamburger"},
                new MonAn {TenMonAn="pizza"},
                new MonAn {TenMonAn="hotdog"}
            });
            context.nguyenLieus.AddRange(new NguyenLieu[]
            {
                new NguyenLieu {TenNguyenLieu="thịt gà",TinhTrang=false},
                new NguyenLieu {TenNguyenLieu="bánh mỳ",TinhTrang= true},
                new NguyenLieu {TenNguyenLieu="thịt bò",TinhTrang = false},
                new NguyenLieu {TenNguyenLieu="bột bánh", TinhTrang= true},
                new NguyenLieu {TenNguyenLieu="xúc xích", TinhTrang =true}
            });
            context.SaveChanges();
            context.monAnNguyenLieus.AddRange(new MonAn_NguyenLieu[]
            {
                new MonAn_NguyenLieu {MaMonAn=1,ID="1",MaNguyenLieu=1,SoLuong=3,DonViTinh="cái"},
                new MonAn_NguyenLieu {MaMonAn=2,ID="2",MaNguyenLieu=2,SoLuong=2,DonViTinh="cái"},
                new MonAn_NguyenLieu {MaMonAn=2,ID="3",MaNguyenLieu=3,SoLuong=30,DonViTinh="gram"},
                new MonAn_NguyenLieu {MaMonAn=3,ID="4",MaNguyenLieu=4,SoLuong=50,DonViTinh="gram"},
                new MonAn_NguyenLieu {MaMonAn=3,ID="5",MaNguyenLieu=5,SoLuong=1,DonViTinh="cái"},
                new MonAn_NguyenLieu {MaMonAn=4,ID="6",MaNguyenLieu=5,SoLuong=1,DonViTinh="cái"},
                new MonAn_NguyenLieu {MaMonAn=4,ID="7",MaNguyenLieu=2,SoLuong=1,DonViTinh="cái"}

            });
            context.SaveChanges();
        }
    }
}
