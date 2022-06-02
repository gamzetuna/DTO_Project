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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {

        }

        EmployeeRepository cr = new EmployeeRepository();

        

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            CalisanlariGetir();
        }
        private void CalisanlariGetir()
        {
            dataGridView1.DataSource = cr.GetAll();
        }


        private void btn_Ara_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox4.Text);

                List<Employee_dto> p = new List<Employee_dto>();
                p.Add(cr.GetId(id));
                dataGridView1.DataSource = p;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen aramak istediğiniz veriyi giriniz! ");
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || dateTimePicker1.Value == DateTime.Now)
            {
                MessageBox.Show("Tüm bilgileri doldurmadan ekleme işlemi gerçekleştirilemez ! ");
                return;
            }
            cr.Insert(new Employee_dto
            {
                LastName = textBox1.Text,
                FirstName = textBox2.Text,
                BirthDate = Convert.ToDateTime(dateTimePicker1.Value)
            });
            CalisanlariGetir();
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
        Employee_dto guncellenecek;
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tüm bilgileri doldurmadan guncelleme işlemi gerçekleştirilemez ! ");
                return;
            }

            guncellenecek.LastName = textBox1.Text;
            guncellenecek.FirstName = textBox2.Text;
            dateTimePicker1.Value = Convert.ToDateTime(guncellenecek.BirthDate);
            cr.Update(guncellenecek);
            Temizle();
            CalisanlariGetir();

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                guncellenecek = cr.GetId(id);

                textBox1.Text = guncellenecek.LastName;
                textBox2.Text = guncellenecek.FirstName;
                dateTimePicker1.Value = Convert.ToDateTime(guncellenecek.BirthDate);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                cr.Delete(id);
                CalisanlariGetir();
            }
            else
            {
                MessageBox.Show("Silinmesini istediğiniz bir veri seçiniz! Teşekkürler.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
