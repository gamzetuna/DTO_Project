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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        CustomerRepository cr = new CustomerRepository();
        private void btn_Getir_Click(object sender, EventArgs e)
        {
            MusterileriGetir();
        }
        private void MusterileriGetir()
        {
            dataGridView1.DataSource = cr.GetAll();
        }


        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan ekleme işlemi gerçekleştirilemez ! ");
                return;
            }
            cr.Insert(new Customer_dto
            {
                CompanyName = textBox1.Text,
                ContactName = textBox2.Text,
                CustomerID = textBox3.Text


            });
            MusterileriGetir();
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
        Customer_dto guncellenecek;
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)|| string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan güncelleme işlemi yapılamaz ! ");
                return;
            }

            guncellenecek.CompanyName = textBox1.Text;
            guncellenecek.ContactName = textBox2.Text;
            cr.Update(guncellenecek);
            Temizle();
            MusterileriGetir();
        }
    

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString(textBox4.Text);

                List<Customer_dto> c = new List<Customer_dto>();
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
                string id = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                cr.Delete(id);
                MusterileriGetir();
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
                string id = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);

                guncellenecek = cr.GetId(id);

                textBox1.Text = guncellenecek.CompanyName;
                textBox2.Text = guncellenecek.ContactName;
                textBox3.Text = guncellenecek.CustomerID;
            }
        }
    }
}
