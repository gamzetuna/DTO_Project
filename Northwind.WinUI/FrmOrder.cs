using Northwind.BLL.Repositories;
using Northwind.DTOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }
        OrderRepository or = new OrderRepository();
        private void FrmOrder_Load(object sender, EventArgs e)
        {

        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            SiparisleriGetir();
        }
        private void SiparisleriGetir()
        {
            dataGridView1.DataSource = or.GetAll();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan ekleme işlemi gerçekleştirilemez ! ");
                return;
            }
            or.Insert(new Order_dto
            {
                ShipName = textBox1.Text,

                ShipAddress = textBox2.Text,
            });
            SiparisleriGetir();
            Temizle();
        }
        private void Temizle()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }
        Order_dto guncellenecek;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                guncellenecek = or.GetId(id);

                textBox1.Text = guncellenecek.ShipName;
                textBox2.Text = guncellenecek.ShipAddress;
            }
        }
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan güncelleme işlemi yapılamaz ! ");
                return;
            }

            guncellenecek.ShipName = textBox1.Text;
            guncellenecek.ShipAddress = textBox2.Text;
            or.Update(guncellenecek);
            Temizle();
            SiparisleriGetir();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox4.Text);

                List<Order_dto> p = new List<Order_dto>();
                p.Add(or.GetId(id));
                dataGridView1.DataSource = p;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen aramak istediğiniz veriyi giriniz! ");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                or.Delete(id);
                SiparisleriGetir();
            }
            else
            {
                MessageBox.Show("Silinmesini istediğiniz bir veri seçiniz! Teşekkürler.");
            }
        }

        
    }
}
