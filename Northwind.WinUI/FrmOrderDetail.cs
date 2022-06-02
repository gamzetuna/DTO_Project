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
    public partial class FrmOrderDetail : Form
    {
        public FrmOrderDetail()
        {
            InitializeComponent();
        }
        OrderDetailRepository odr = new OrderDetailRepository();
        private void FrmOrderDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet1.Products);
            // TODO: This line of code loads data into the 'northwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);

        }
        private void btn_Getir_Click(object sender, EventArgs e)
        {
            SiparisDetaylariniGetir();
        }
        private void SiparisDetaylariniGetir()
        {
            dataGridView1.DataSource = odr.GetAll();
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(comboBox1.Text) && string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan ekleme işlemi gerçekleştirilemez ! ");
                return;
            }
            try
            {
                odr.Insert(new Order_Details_dto
                {
                    OrderID = Convert.ToInt32(comboBox1.SelectedValue),
                    ProductID = Convert.ToInt32(comboBox2.SelectedValue),
                    Quantity = Convert.ToInt16(textBox1.Text)
                });

            }
            catch (Exception)
            {

                MessageBox.Show("Tüm Bilgilerin doğruluğundan Emin olunuz ");
            }
            SiparisDetaylariniGetir();
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
                else if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.Text = " ";
                }
            }
        }
        Order_Details_dto guncellenecek;
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(comboBox1.Text) && string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan güncelleme işlemi yapılamaz ! ");
                return;
            }

            guncellenecek.Quantity = Convert.ToInt16(textBox1.Text);
            guncellenecek.OrderID = Convert.ToInt32(comboBox1.SelectedValue);
            guncellenecek.ProductID = Convert.ToInt32(comboBox2.SelectedValue);
            odr.Update(guncellenecek);
            Temizle();
            SiparisDetaylariniGetir();
        }
    

        private void btn_Sil_Click(object sender, EventArgs e)
        {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            int id2 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            odr.Delete(id, id2);
            SiparisDetaylariniGetir();
        }
            else
            {
                MessageBox.Show("Silinmesini istediğiniz bir veri seçiniz! Teşekkürler.");
            }
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox2.Text); 
                int id2 = Convert.ToInt32(textBox4.Text); 

                List<Order_Details_dto> p = new List<Order_Details_dto>();
                p.Add(odr.GetId(id,id2));
                dataGridView1.DataSource = p;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen aramak istediğiniz veriyi giriniz! ");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                int id2 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);

                guncellenecek = odr.GetId(id,id2);

                textBox1.Text = Convert.ToString(guncellenecek.Quantity);
                comboBox1.SelectedValue = guncellenecek.OrderID;
                comboBox2.SelectedValue = guncellenecek.ProductID;
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
