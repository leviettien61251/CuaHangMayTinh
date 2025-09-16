﻿namespace ComputerStoreManagement
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Management = new System.Windows.Forms.ToolStripMenuItem();
            this.Product = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.Supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.Sale = new System.Windows.Forms.ToolStripMenuItem();
            this.Order = new System.Windows.Forms.ToolStripMenuItem();
            this.Report = new System.Windows.Forms.ToolStripMenuItem();
            this.Revenue = new System.Windows.Forms.ToolStripMenuItem();
            this.Inventory = new System.Windows.Forms.ToolStripMenuItem();
            this.BestSeller = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.Management,
            this.Sale,
            this.Report});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.toolStripSeparator1});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Management
            // 
            this.Management.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Product,
            this.Customer,
            this.Employee,
            this.Supplier});
            this.Management.Name = "Management";
            this.Management.Size = new System.Drawing.Size(60, 20);
            this.Management.Text = "Quản lý";
            this.Management.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Management_DropDownItemClicked);
            // 
            // Product
            // 
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(148, 22);
            this.Product.Text = "Sản phẩm";
            // 
            // Customer
            // 
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(148, 22);
            this.Customer.Text = "Khách hàng";
            // 
            // Employee
            // 
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(148, 22);
            this.Employee.Text = "Nhân viên";
            // 
            // Supplier
            // 
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(148, 22);
            this.Supplier.Text = "Nhà cung cấp";
            // 
            // Sale
            // 
            this.Sale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Order});
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(69, 20);
            this.Sale.Text = "Bán hàng";
            this.Sale.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Sale_DropDownItemClicked);
            // 
            // Order
            // 
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(148, 22);
            this.Order.Text = "Tạo đơn hàng";
            // 
            // Report
            // 
            this.Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Revenue,
            this.Inventory,
            this.BestSeller});
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(69, 20);
            this.Report.Text = "Thống kê";
            this.Report.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Report_DropDownItemClicked);
            // 
            // Revenue
            // 
            this.Revenue.Name = "Revenue";
            this.Revenue.Size = new System.Drawing.Size(178, 22);
            this.Revenue.Text = "Doanh thu";
            // 
            // Inventory
            // 
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(178, 22);
            this.Inventory.Text = "Tồn kho";
            // 
            // BestSeller
            // 
            this.BestSeller.Name = "BestSeller";
            this.BestSeller.Size = new System.Drawing.Size(178, 22);
            this.BestSeller.Text = "Sản phẩm bán chạy";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý bán máy tính";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Management;
        private System.Windows.Forms.ToolStripMenuItem Product;
        private System.Windows.Forms.ToolStripMenuItem Customer;
        private System.Windows.Forms.ToolStripMenuItem Employee;
        private System.Windows.Forms.ToolStripMenuItem Supplier;
        private System.Windows.Forms.ToolStripMenuItem Sale;
        private System.Windows.Forms.ToolStripMenuItem Report;
        private System.Windows.Forms.ToolStripMenuItem Revenue;
        private System.Windows.Forms.ToolStripMenuItem Inventory;
        private System.Windows.Forms.ToolStripMenuItem BestSeller;
        private System.Windows.Forms.ToolStripMenuItem Order;
    }
}