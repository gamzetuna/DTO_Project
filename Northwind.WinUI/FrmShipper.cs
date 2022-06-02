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
    public partial class FrmShipper : Form
    {
        public FrmShipper()
        {
            InitializeComponent();
        }

        ShipperRepository sr = new ShipperRepository();
        private void btn_Getir_Click(object sender, EventArgs e)
        {
            NakliyecileriGetir();
        }
        private void NakliyecileriGetir()
        {
            dataGridView1.DataSource = sr.GetAll();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan ekleme işlemi gerçekleştirilemez ! ");
                return;
            }
            sr.Insert(new Shipper_dto
            {
                CompanyName = textBox1.Text,

                Phone = textBox2.Text,
            });
            NakliyecileriGetir();
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
        Shipper_dto guncellenecek;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                guncellenecek = sr.GetId(id);

                textBox1.Text = guncellenecek.CompanyName;
                textBox2.Text = guncellenecek.Phone;
            }
        }
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan güncelleme işlemi yapılamaz ! ");
                return;
            }

            guncellenecek.CompanyName = textBox1.Text;
            guncellenecek.Phone = textBox2.Text;
            sr.Update(guncellenecek);
            Temizle();
            NakliyecileriGetir();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox4.Text);

                List<Shipper_dto> p = new List<Shipper_dto>();
                p.Add(sr.GetId(id));
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
                sr.Delete(id);
                NakliyecileriGetir();
            }
            else
            {
                MessageBox.Show("Silinmesini istediğiniz bir veri seçiniz! Teşekkürler.");
            }
        }

        private void FrmShipper_Load(object sender, EventArgs e)
        {

        }
    }
}
