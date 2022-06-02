using Northwind.BLL.Repositories;
using Northwind.DTOS.DTOS;
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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        ProductRepository pr = new ProductRepository();
        private void btn_Getir_Click(object sender, EventArgs e)
        {
            UrunleriGetir();
        }
        private void UrunleriGetir()
        {
            dataGridView1.DataSource = pr.GetAll();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || numericUpDown1.Value == 0 || numericUpDown2.Value == 0)) 
            {
                MessageBox.Show("Tüm bilgileri doldurmadan ekleme işlemi gerçekleştirilemez ! ");
                return;
            }
            pr.Insert(new Product_dto
            {
                ProductName = textBox1.Text,
                QuantityPerUnit = textBox2.Text,
                UnitPrice = Convert.ToDecimal(numericUpDown1.Value),
                UnitsInStock = Convert.ToInt16(numericUpDown2.Value)
            });
            UrunleriGetir();
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
                else if (item is NumericUpDown)
                {
                    NumericUpDown nup = (NumericUpDown)item;
                    nup.Value = 0;
                }
            }
        }
        Product_dto guncellenecek;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                guncellenecek = pr.GetId(id);

                textBox1.Text = guncellenecek.ProductName;
                textBox2.Text = guncellenecek.QuantityPerUnit;
                numericUpDown1.Value = Convert.ToDecimal(guncellenecek.UnitPrice);
                numericUpDown2.Value = Convert.ToInt16(guncellenecek.UnitsInStock);

            }
        }
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || numericUpDown1.Value == 0 || numericUpDown2.Value == 0))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan güncelleme işlemi yapılamaz ! ");
                return;
            }

            guncellenecek.ProductName = textBox1.Text;
            guncellenecek.QuantityPerUnit = textBox2.Text;
            guncellenecek.UnitPrice = Convert.ToDecimal(numericUpDown1.Value);
            guncellenecek.UnitsInStock = Convert.ToInt16(numericUpDown2.Value);
            pr.Update(guncellenecek);
            Temizle();
            UrunleriGetir();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox4.Text);

                List<Product_dto> p = new List<Product_dto>();
                p.Add(pr.GetId(id));
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
                pr.Delete(id);
                UrunleriGetir();
            }
            else
            {
                MessageBox.Show("Silinmesini istediğiniz bir veri seçiniz! Teşekkürler.");
            }
        }

        //private void FrmProduct_Load(object sender, EventArgs e)
        //{

        //}

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //}
    }
}
