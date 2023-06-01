using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_Trang63
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightPink;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtTenNgoaiNgu.Text == "")
            {
                MessageBox.Show("Nhập tên ngoại ngữ");
                txtTenNgoaiNgu.Focus();
                return;
            }

            string str = txtTenNgoaiNgu.Text;

            foreach (var item in lstKetQua.Items)
            {
                if (str == item.ToString())
                {
                    MessageBox.Show(str + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtTenNgoaiNgu.Text = "";
                    txtTenNgoaiNgu.Focus();
                    return;
                }
            }

            lstKetQua.Items.Add(str);
            txtTenNgoaiNgu.Text = "";
            txtTenNgoaiNgu.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTenNgoaiNgu.Text == "")
            {
                MessageBox.Show("Nhập tên ngoại ngữ");
                txtTenNgoaiNgu.Focus();
                return;
            }

            string str = txtTenNgoaiNgu.Text;

            foreach (var item in lstKetQua.Items)
            {
                if (str == item.ToString())
                {
                    MessageBox.Show(str + " đã tồn tại", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtTenNgoaiNgu.Text = "";
                    txtTenNgoaiNgu.Focus();
                    return;
                }
            }
            MessageBox.Show(str + " KHÔNG tồn tại", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.None);
            txtTenNgoaiNgu.Text = "";
            txtTenNgoaiNgu.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtTenNgoaiNgu.Text == "")
            {
                MessageBox.Show("Nhập tên ngoại ngữ");
                txtTenNgoaiNgu.Focus();
                return;
            }

            string str = txtTenNgoaiNgu.Text;

            for (int i = 0; i < lstKetQua.Items.Count; i++)
            {
                if (str == lstKetQua.Items[i].ToString())
                {
                    if (MessageBox.Show("Bạn muốn tiếp tục xóa không? Thao tác này không thể hoàn tác", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {   // OK xóa
                        lstKetQua.Items.Remove(lstKetQua.Items[i]); // Xóa
                        MessageBox.Show("Xóa " + str + " thành công", "Remove", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtTenNgoaiNgu.Text = "";
                        txtTenNgoaiNgu.Focus();
                        return;
                    }
                    else return;
                }
            }

            MessageBox.Show(str + " KHÔNG tồn tại", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.None);
            txtTenNgoaiNgu.Text = "";
            txtTenNgoaiNgu.Focus();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstKetQua.Items.Count - 1; i++)
            {
                for (int j = i + 1; j < lstKetQua.Items.Count; j++)
                {
                    // StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                    if (SoSanhChuoi.SoSanh(lstKetQua.Items[i].ToString(), lstKetQua.Items[j].ToString()) == 1)
                    {
                        var tam = lstKetQua.Items[i];
                        lstKetQua.Items[i] = lstKetQua.Items[j];
                        lstKetQua.Items[j] = tam;
                    }
                }
            }
        }
    }
}
