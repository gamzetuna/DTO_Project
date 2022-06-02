
namespace Northwind.WinUI
{
    partial class Giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Categories = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Suppliers = new System.Windows.Forms.Button();
            this.Shippers = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.Order_Details = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.Employees = new System.Windows.Forms.Button();
            this.Customers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.Categories);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Suppliers);
            this.panel1.Controls.Add(this.Shippers);
            this.panel1.Controls.Add(this.Products);
            this.panel1.Controls.Add(this.Order_Details);
            this.panel1.Controls.Add(this.Orders);
            this.panel1.Controls.Add(this.Employees);
            this.panel1.Controls.Add(this.Customers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 440);
            this.panel1.TabIndex = 1;
            this.panel1.UseWaitCursor = true;
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Categories.Location = new System.Drawing.Point(0, 339);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(149, 49);
            this.Categories.TabIndex = 0;
            this.Categories.Text = "Categories";
            this.Categories.UseVisualStyleBackColor = false;
            this.Categories.UseWaitCursor = true;
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(0, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Suppliers
            // 
            this.Suppliers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Suppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppliers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Suppliers.Location = new System.Drawing.Point(0, 291);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(149, 49);
            this.Suppliers.TabIndex = 7;
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.UseVisualStyleBackColor = false;
            this.Suppliers.UseWaitCursor = true;
            this.Suppliers.Click += new System.EventHandler(this.Suppliers_Click);
            // 
            // Shippers
            // 
            this.Shippers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Shippers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shippers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Shippers.Location = new System.Drawing.Point(0, 243);
            this.Shippers.Name = "Shippers";
            this.Shippers.Size = new System.Drawing.Size(149, 49);
            this.Shippers.TabIndex = 6;
            this.Shippers.Text = "Shippers";
            this.Shippers.UseVisualStyleBackColor = false;
            this.Shippers.UseWaitCursor = true;
            this.Shippers.Click += new System.EventHandler(this.Shippers_Click);
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Products.Location = new System.Drawing.Point(3, 195);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(149, 49);
            this.Products.TabIndex = 5;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = false;
            this.Products.UseWaitCursor = true;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Order_Details
            // 
            this.Order_Details.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Order_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Details.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Order_Details.Location = new System.Drawing.Point(3, 147);
            this.Order_Details.Name = "Order_Details";
            this.Order_Details.Size = new System.Drawing.Size(149, 49);
            this.Order_Details.TabIndex = 4;
            this.Order_Details.Text = "Order Details";
            this.Order_Details.UseVisualStyleBackColor = false;
            this.Order_Details.UseWaitCursor = true;
            this.Order_Details.Click += new System.EventHandler(this.Order_Details_Click);
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Orders.Location = new System.Drawing.Point(3, 100);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(149, 49);
            this.Orders.TabIndex = 3;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = false;
            this.Orders.UseWaitCursor = true;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Employees
            // 
            this.Employees.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employees.Location = new System.Drawing.Point(3, 53);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(149, 49);
            this.Employees.TabIndex = 2;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = false;
            this.Employees.UseWaitCursor = true;
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Customers.Location = new System.Drawing.Point(3, 3);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(149, 49);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = false;
            this.Customers.UseWaitCursor = true;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1079, 440);
            this.panel2.TabIndex = 2;
            this.panel2.UseWaitCursor = true;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Suppliers;
        private System.Windows.Forms.Button Shippers;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Order_Details;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Employees;
        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Button Categories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}