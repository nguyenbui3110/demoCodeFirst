using CK1.BLL;
using CK1.DTO;
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
    public partial class Main : Form
    {
        public Main()
        {            
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            cbbMonAn.Items.Add(new CBBMonAn { value = 0,name="all" });
            foreach (MonAn monAn in BLL_MonAn.Instance.GetMonAns())
            {
                cbbMonAn.Items.Add(new CBBMonAn { value = monAn.MaMonAn, name = monAn.TenMonAn });
            }
            cbbMonAn.SelectedIndex = 0;
            loadDGV();
        }
        public void loadDGV()
        {
            var query = BLL_MonAnNguyenLieu.Instance.getBySearchbox(((CBBMonAn)cbbMonAn.SelectedItem).value, txtSearch.Text);
            dataGridView1.DataSource = query.Select(p => new
            {
                p.ID,
                p.NguyenLieu.TenNguyenLieu,
                p.SoLuong,
                p.DonViTinh,
                p.NguyenLieu.TinhTrang,
            }).ToList();
            SetNameDGV();
        }
        public void SetNameDGV()
        {
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Tên Nguyên Liệu";
            dataGridView1.Columns[2].HeaderText = "Số Lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn vị tính";
            dataGridView1.Columns[4].HeaderText = "Tình Trạng";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void cbbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                Detail detail = new Detail(BLL_MonAnNguyenLieu.Instance.getByID(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                detail.Show();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    if (Convert.ToBoolean(i.Cells["TinhTrang"].Value.ToString()) == false)
                    {
                        BLL_MonAnNguyenLieu.Instance.Del(i.Cells[0].Value.ToString());
                    }
                }
            }
        }
    }
}
