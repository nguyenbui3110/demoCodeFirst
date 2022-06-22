using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK1.DTO
{
    public class MonAn
    {
        [Key][Required][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public virtual ICollection<MonAn_NguyenLieu> MonAn_NguyenLieus { get; set; }
    }
}
