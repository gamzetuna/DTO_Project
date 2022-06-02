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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {

        }
        CategoryRepository cr = new CategoryRepository();
        private void btn_Getir_Click(object sender, EventArgs e)
        {
            Kategorilerigetir();
        }
        private void Kategorilerigetir()
        {
        dataGridView1.DataSource = cr.GetAll();
         }
        
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan ekleme işlemi gerçekleştirilemez ! ");
                return;
            }
            cr.Insert(new Category_dto
            {
                KategoriAdi = textBox1.Text,
                Descriptions = textBox2.Text,
            });
            Kategorilerigetir();
            temizle();
        }
    
    private void temizle()
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
        Category_dto guncellenecek;
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan güncelleme işlemi yapılamaz ! ");
                return;
            }
            guncellenecek.KategoriAdi = textBox1.Text;
            guncellenecek.Descriptions = textBox2.Text;
            cr.Update(guncellenecek);
            temizle();
            Kategorilerigetir();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox4.Text);

                List<Category_dto> c = new List<Category_dto>();
                c.Add(cr.GetId(id));
                dataGridView1.DataSource = c;
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
                cr.Delete(id);
                Kategorilerigetir();
            }
            else
            {
                MessageBox.Show("Silinmesini istediğiniz bir veri seçiniz! Teşekkürler.");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                guncellenecek = cr.GetId(id);

                textBox1.Text = guncellenecek.KategoriAdi;
                textBox2.Text = guncellenecek.Descriptions;
            }
        }
    }
}
