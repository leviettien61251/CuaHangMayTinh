namespace CuaHangMayTinh.Views.Sale
{
    partial class frmInvoiceHistory
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
            this.components = new System.ComponentModel.Container();
            this.lblRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.xóaHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inLạiHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbInvoiceList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExport = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.grbInvoiceList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(109, 19);
            this.lblRecordCount.Text = "Tổng số: 0 bản ghi";
            // 
            // xóaHóaĐơnToolStripMenuItem
            // 
            this.xóaHóaĐơnToolStripMenuItem.Name = "xóaHóaĐơnToolStripMenuItem";
            this.xóaHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.xóaHóaĐơnToolStripMenuItem.Text = "Xóa hóa đơn";
            // 
            // inLạiHóaĐơnToolStripMenuItem
            // 
            this.inLạiHóaĐơnToolStripMenuItem.Name = "inLạiHóaĐơnToolStripMenuItem";
            this.inLạiHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.inLạiHóaĐơnToolStripMenuItem.Text = "In lại hóa đơn";
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            this.xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            this.xemChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.xemChiTiếtToolStripMenuItem.Text = "Xem chi tiết";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTiếtToolStripMenuItem,
            this.inLạiHóaĐơnToolStripMenuItem,
            this.xóaHóaĐơnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 70);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.Location = new System.Drawing.Point(3, 16);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.Size = new System.Drawing.Size(794, 327);
            this.dgvInvoices.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(113, 19);
            this.lblStatus.Text = "Trạng thái: Sẵn sàng";
            // 
            // grbInvoiceList
            // 
            this.grbInvoiceList.Controls.Add(this.dgvInvoices);
            this.grbInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbInvoiceList.Location = new System.Drawing.Point(0, 80);
            this.grbInvoiceList.Name = "grbInvoiceList";
            this.grbInvoiceList.Size = new System.Drawing.Size(800, 346);
            this.grbInvoiceList.TabIndex = 4;
            this.grbInvoiceList.TabStop = false;
            this.grbInvoiceList.Text = "Danh sách hóa đơn";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFromDate.Location = new System.Drawing.Point(103, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(144, 20);
            this.dtpFromDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpToDate.Location = new System.Drawing.Point(353, 3);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(144, 20);
            this.dtpToDate.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(503, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(288, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFromDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpToDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(503, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(288, 25);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblRecordCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.tableLayoutPanel1);
            this.grbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFilter.Location = new System.Drawing.Point(0, 0);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(800, 80);
            this.grbFilter.TabIndex = 3;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Tìm kiếm";
            // 
            // frmInvoiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbInvoiceList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grbFilter);
            this.Name = "frmInvoiceHistory";
            this.Text = "frmInvoiceHistory";
            this.Load += new System.EventHandler(this.frmInvoiceHistory_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.grbInvoiceList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grbFilter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel lblRecordCount;
        private System.Windows.Forms.ToolStripMenuItem xóaHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inLạiHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox grbInvoiceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grbFilter;
    }
}