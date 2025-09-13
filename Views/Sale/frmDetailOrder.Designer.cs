namespace CuaHangMayTinh.Views.Sale
{
    partial class frmDetailOrder
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
            this.tabDetailOrder = new System.Windows.Forms.TabControl();
            this.tabdetail = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbProductInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.danhMucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuaHangMayTinhDataSet2 = new CuaHangMayTinh.CuaHangMayTinhDataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImportPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbProductList = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDetailOrder = new System.Windows.Forms.DataGridView();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.danhMucTableAdapter = new CuaHangMayTinh.CuaHangMayTinhDataSet2TableAdapters.DanhMucTableAdapter();
            this.tabDetailOrder.SuspendLayout();
            this.tabdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbProductInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayTinhDataSet2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.grbProductList.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDetailOrder
            // 
            this.tabDetailOrder.Controls.Add(this.tabdetail);
            this.tabDetailOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetailOrder.Location = new System.Drawing.Point(0, 0);
            this.tabDetailOrder.Name = "tabDetailOrder";
            this.tabDetailOrder.SelectedIndex = 0;
            this.tabDetailOrder.Size = new System.Drawing.Size(965, 457);
            this.tabDetailOrder.TabIndex = 4;
            // 
            // tabdetail
            // 
            this.tabdetail.Controls.Add(this.splitContainer1);
            this.tabdetail.Location = new System.Drawing.Point(4, 22);
            this.tabdetail.Name = "tabdetail";
            this.tabdetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabdetail.Size = new System.Drawing.Size(957, 431);
            this.tabdetail.TabIndex = 0;
            this.tabdetail.Text = "Chi tiết đơn hàng";
            this.tabdetail.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbProductInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbProductList);
            this.splitContainer1.Size = new System.Drawing.Size(951, 425);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbProductInfo
            // 
            this.grbProductInfo.Controls.Add(this.tableLayoutPanel1);
            this.grbProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbProductInfo.Location = new System.Drawing.Point(0, 0);
            this.grbProductInfo.Name = "grbProductInfo";
            this.grbProductInfo.Size = new System.Drawing.Size(284, 425);
            this.grbProductInfo.TabIndex = 0;
            this.grbProductInfo.TabStop = false;
            this.grbProductInfo.Text = "Thông tin sản phẩm";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66013F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.33987F));
            this.tableLayoutPanel1.Controls.Add(this.buttonExcel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbSupplier, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtProductId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtProductName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtImportPrice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSalePrice, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtStockQuantity, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.4806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.4806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.4806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.4806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.4806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.4806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.4806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.6358F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(96, 269);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(85, 33);
            this.buttonExcel.TabIndex = 17;
            this.buttonExcel.Text = "In đơn hàng";
            this.buttonExcel.UseVisualStyleBackColor = true;
            // 
            // cbSupplier
            // 
            this.cbSupplier.DisplayMember = "TenNCC";
            this.cbSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(96, 117);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(179, 21);
            this.cbSupplier.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtProductId
            // 
            this.txtProductId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductId.Location = new System.Drawing.Point(96, 3);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(179, 20);
            this.txtProductId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtProductName
            // 
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductName.Location = new System.Drawing.Point(96, 41);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(179, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // cbCategory
            // 
            this.cbCategory.DataSource = this.danhMucBindingSource;
            this.cbCategory.DisplayMember = "TenDanhMuc";
            this.cbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(96, 79);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(179, 21);
            this.cbCategory.TabIndex = 5;
            // 
            // danhMucBindingSource
            // 
            this.danhMucBindingSource.DataMember = "DanhMuc";
            this.danhMucBindingSource.DataSource = this.cuaHangMayTinhDataSet2;
            // 
            // cuaHangMayTinhDataSet2
            // 
            this.cuaHangMayTinhDataSet2.DataSetName = "CuaHangMayTinhDataSet2";
            this.cuaHangMayTinhDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hãng sản xuất:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá nhập:";
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtImportPrice.Location = new System.Drawing.Point(96, 155);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Size = new System.Drawing.Size(179, 20);
            this.txtImportPrice.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giá bán:";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSalePrice.Location = new System.Drawing.Point(96, 193);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(179, 20);
            this.txtSalePrice.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số lượng tồn:";
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStockQuantity.Location = new System.Drawing.Point(96, 231);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(179, 20);
            this.txtStockQuantity.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddNew);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 269);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(87, 134);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(3, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(80, 30);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grbProductList
            // 
            this.grbProductList.Controls.Add(this.tableLayoutPanel2);
            this.grbProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbProductList.Location = new System.Drawing.Point(0, 0);
            this.grbProductList.Name = "grbProductList";
            this.grbProductList.Size = new System.Drawing.Size(663, 425);
            this.grbProductList.TabIndex = 0;
            this.grbProductList.TabStop = false;
            this.grbProductList.Text = "Danh sách sản phẩm";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(657, 406);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtSearchProduct);
            this.flowLayoutPanel2.Controls.Add(this.btnSearch);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(651, 34);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(3, 3);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(200, 20);
            this.txtSearchProduct.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(209, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm sản phẩm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dgvDetailOrder, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvProductList, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(651, 360);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dgvDetailOrder
            // 
            this.dgvDetailOrder.AllowUserToAddRows = false;
            this.dgvDetailOrder.AllowUserToDeleteRows = false;
            this.dgvDetailOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetailOrder.Location = new System.Drawing.Point(3, 3);
            this.dgvDetailOrder.Name = "dgvDetailOrder";
            this.dgvDetailOrder.ReadOnly = true;
            this.dgvDetailOrder.Size = new System.Drawing.Size(645, 174);
            this.dgvDetailOrder.TabIndex = 0;
            this.dgvDetailOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailOrder_CellClick);
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductList.Location = new System.Drawing.Point(3, 183);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.Size = new System.Drawing.Size(645, 174);
            this.dgvProductList.TabIndex = 1;
            // 
            // danhMucTableAdapter
            // 
            this.danhMucTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 457);
            this.Controls.Add(this.tabDetailOrder);
            this.Name = "frmDetailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đơn hàng";
            this.Load += new System.EventHandler(this.frmDetailOrder_Load);
            this.tabDetailOrder.ResumeLayout(false);
            this.tabdetail.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbProductInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayTinhDataSet2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grbProductList.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDetailOrder;
        private System.Windows.Forms.TabPage tabdetail;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbProductInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.BindingSource danhMucBindingSource;
        private CuaHangMayTinhDataSet2 cuaHangMayTinhDataSet2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbProductList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSearch;
        private CuaHangMayTinhDataSet2TableAdapters.DanhMucTableAdapter danhMucTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvDetailOrder;
        private System.Windows.Forms.DataGridView dgvProductList;
    }
}