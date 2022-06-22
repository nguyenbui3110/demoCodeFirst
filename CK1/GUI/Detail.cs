using CK1.DTO;
using CK1.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK1.GUI
{
    public partial class Detail : Form
    {
        MonAn_NguyenLieu TempNguyenLieu;
        bool add = true;
        public Detail(MonAn_NguyenLieu temp=null)
        {
            TempNguyenLieu = temp;
            InitializeComponent();
            loadData();
            if (temp != null)
            {
                add = false;
                CBBDonVi.Text = TempNguyenLieu.DonViTinh;
                txtSoLuong.Text = TempNguyenLieu.SoLuong.ToString();
                CBBNguyenLieu.Text = TempNguyenLieu.NguyenLieu.TenNguyenLieu;
                if (TempNguyenLieu.NguyenLieu.TinhTrang)
                {
                    cbbTinhTrang.SelectedIndex = 0;
                }
                else
                {
                    cbbTinhTrang.SelectedIndex = 1;
                }
            }
            else
            {
                TempNguyenLieu= new MonAn_NguyenLieu();
            }
        }
        public void loadData()
        {
            foreach (NguyenLieu nguyenLieu in BLL_NguyenLieu.Instance.GetNguyenLieus())
            {
                CBBNguyenLieu.Items.Add(nguyenLieu.TenNguyenLieu);
            }
            foreach (MonAn_NguyenLieu item in BLL_MonAnNguyenLieu.Instance.getAll())
            {
                if(!CBBDonVi.Items.Contains(item.DonViTinh))
                CBBDonVi.Items.Add(item.DonViTinh);
            }            
            cbbTinhTrang.Items.Add(new CBBTinhTrang { value = true });
            cbbTinhTrang.Items.Add(new CBBTinhTrang { value = false });


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            {
                TempNguyenLieu.DonViTinh = CBBDonVi.SelectedItem.ToString();
                TempNguyenLieu.NguyenLieu = BLL_NguyenLieu.Instance.GetNLByName(CBBNguyenLieu.SelectedItem.ToString());
                TempNguyenLieu.NguyenLieu.TinhTrang = ((CBBTinhTrang)cbbTinhTrang.SelectedItem).value;
                if (Int32.TryParse(txtSoLuong.Text, out int k))
                {
                    TempNguyenLieu.SoLuong = k;
                }
                if (add)
                {
                    BLL_MonAnNguyenLieu.Instance.add(TempNguyenLieu);
                }
                else
                {
                    BLL_MonAnNguyenLieu.Instance.save();
                }
                this.Close();
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
