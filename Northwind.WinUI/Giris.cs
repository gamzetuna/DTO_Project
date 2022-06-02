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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this; // bu sayfada aç diyorum
            frm.FormBorderStyle = FormBorderStyle.None; // oynatama diye sabitledik
            panel2.Controls.Add(frm);
            frm.Show();

        }
        
        private void Categories_Click(object sender, EventArgs e)
        {
            FrmCategory frmcat = new FrmCategory();
          
            FormGetir(frmcat);
           
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            FrmCustomer frmcus = new FrmCustomer();
            FormGetir(frmcus);
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmp = new FrmEmployee();
            FormGetir(frmEmp);
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            FrmOrder frmOr = new FrmOrder();
            FormGetir(frmOr);
        }

        private void Order_Details_Click(object sender, EventArgs e)
        {
            FrmOrderDetail frmOrd = new FrmOrderDetail();
            FormGetir(frmOrd);
        }

        private void Products_Click(object sender, EventArgs e)
        {
            FrmProduct frmprd = new FrmProduct();
            FormGetir(frmprd);
        }

        private void Shippers_Click(object sender, EventArgs e)
        {
            FrmShipper frmshi = new FrmShipper();
            FormGetir(frmshi);
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            FrmSupplier frmsup = new FrmSupplier();
            FormGetir(frmsup);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
               
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
