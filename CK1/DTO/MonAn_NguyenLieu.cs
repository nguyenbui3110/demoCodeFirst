using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK1.DTO
{
    public class MonAn_NguyenLieu
    {
        [Key][Required][MaxLength(5)]
        public string ID { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        [ForeignKey("MonAn")]
        public int? MaMonAn { get; set; }
        [ForeignKey("NguyenLieu")]
        public int MaNguyenLieu { get; set; }
        public virtual MonAn MonAn { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }



    }
}
