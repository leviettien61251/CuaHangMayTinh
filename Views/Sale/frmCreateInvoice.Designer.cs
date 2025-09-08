using System;
using System.Windows.Forms;

namespace CuaHangMayTinh.Views.Report
{
    public partial class frmCreateInvoice : Form
    {
        public frmCreateInvoice()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbInvoiceInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.grbInvoiceDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.grbTotal = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbInvoiceInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbInvoiceDetails.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.grbTotal.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInvoiceInfo
            // 
            this.grbInvoiceInfo.Controls.Add(this.tableLayoutPanel1);
            this.grbInvoiceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInvoiceInfo.Location = new System.Drawing.Point(0, 0);
            this.grbInvoiceInfo.Name = "grbInvoiceInfo";
            this.grbInvoiceInfo.Size = new System.Drawing.Size(800, 150);
            this.grbInvoiceInfo.TabIndex = 0;
            this.grbInvoiceInfo.TabStop = false;
            this.grbInvoiceInfo.Text = "Thông tin hóa đơn";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInvoiceId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpInvoiceDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerPhone, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerAddress, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 131);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInvoiceId.Location = new System.Drawing.Point(103, 3);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.ReadOnly = true;
            this.txtInvoiceId.Size = new System.Drawing.Size(191, 20);
            this.txtInvoiceId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày bán:";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(400, 3);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(391, 20);
            this.dtpInvoiceDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách hàng:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerName.Location = new System.Drawing.Point(103, 46);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(191, 20);
            this.txtCustomerName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerPhone.Location = new System.Drawing.Point(400, 46);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(391, 20);
            this.txtCustomerPhone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtCustomerAddress
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCustomerAddress, 3);
            this.txtCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerAddress.Location = new System.Drawing.Point(103, 89);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(688, 20);
            this.txtCustomerAddress.TabIndex = 9;
            // 
            // grbInvoiceDetails
            // 
            this.grbInvoiceDetails.Controls.Add(this.tableLayoutPanel2);
            this.grbInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbInvoiceDetails.Location = new System.Drawing.Point(0, 150);
            this.grbInvoiceDetails.Name = "grbInvoiceDetails";
            this.grbInvoiceDetails.Size = new System.Drawing.Size(800, 250);
            this.grbInvoiceDetails.TabIndex = 1;
            this.grbInvoiceDetails.TabStop = false;
            this.grbInvoiceDetails.Text = "Chi tiết hóa đơn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvInvoiceItems, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 231);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(3, 43);
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.Size = new System.Drawing.Size(788, 185);
            this.dgvInvoiceItems.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddProduct);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveProduct);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 30);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm sản phẩm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(129, 3);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveProduct.TabIndex = 1;
            this.btnRemoveProduct.Text = "Xóa sản phẩm";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // grbTotal
            // 
            this.grbTotal.Controls.Add(this.tableLayoutPanel3);
            this.grbTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbTotal.Location = new System.Drawing.Point(0, 400);
            this.grbTotal.Name = "grbTotal";
            this.grbTotal.Size = new System.Drawing.Size(800, 100);
            this.grbTotal.TabIndex = 2;
            this.grbTotal.TabStop = false;
            this.grbTotal.Text = "Tổng cộng";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSubTotal, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblTax, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblTotalAmount, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 3, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 81);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tạm tính:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(400, 7);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(23, 13);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "0 đ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "VAT:";
            // 
            // lblTax
            // 
            this.lblTax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(400, 34);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(23, 13);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "0 đ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(329, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tổng tiền:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(400, 61);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(26, 13);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "0 đ";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnSaveInvoice);
            this.flowLayoutPanel2.Controls.Add(this.btnPrintInvoice);
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(500, 57);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(291, 21);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSaveInvoice.Location = new System.Drawing.Point(3, 3);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(100, 25);
            this.btnSaveInvoice.TabIndex = 0;
            this.btnSaveInvoice.Text = "Lưu hóa đơn";
            this.btnSaveInvoice.UseVisualStyleBackColor = false;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnPrintInvoice.Location = new System.Drawing.Point(109, 3);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(100, 25);
            this.btnPrintInvoice.TabIndex = 1;
            this.btnPrintInvoice.Text = "In hóa đơn";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.Location = new System.Drawing.Point(3, 34);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(113, 17);
            this.lblStatus.Text = "Trạng thái: Sẵn sàng";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmCreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.grbInvoiceDetails);
            this.Controls.Add(this.grbTotal);
            this.Controls.Add(this.grbInvoiceInfo);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCreateInvoice";
            this.Text = "Tạo hóa đơn";
            this.grbInvoiceInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grbInvoiceDetails.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grbTotal.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.GroupBox grbInvoiceInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.GroupBox grbInvoiceDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.GroupBox grbTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}