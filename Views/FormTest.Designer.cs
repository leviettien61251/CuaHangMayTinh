namespace CuaHangMayTinh.Views
{
    partial class FormTest
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
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCheckIDCategory = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxGiaBan = new System.Windows.Forms.TextBox();
            this.textBoxGiaNhap = new System.Windows.Forms.TextBox();
            this.textBoxNCC = new System.Windows.Forms.TextBox();
            this.textBoxTenSP = new System.Windows.Forms.TextBox();
            this.labelMaSP = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelGiaBan = new System.Windows.Forms.Label();
            this.labelGiaNhap = new System.Windows.Forms.Label();
            this.labelNCC = new System.Windows.Forms.Label();
            this.labelTenSP = new System.Windows.Forms.Label();
            this.labelLoaiSP = new System.Windows.Forms.Label();
            this.textBoxMaSP = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.danhMucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuaHangMayTinhDataSet = new CuaHangMayTinh.CuaHangMayTinhDataSet();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.danhMucTableAdapter = new CuaHangMayTinh.CuaHangMayTinhDataSetTableAdapters.DanhMucTableAdapter();
            this.comboBoxMaNCC = new System.Windows.Forms.ComboBox();
            this.cuaHangMayTinhDataSet1 = new CuaHangMayTinh.CuaHangMayTinhDataSet1();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new CuaHangMayTinh.CuaHangMayTinhDataSet1TableAdapters.NhaCungCapTableAdapter();
            this.cuaHangMayTinhDataSet2 = new CuaHangMayTinh.CuaHangMayTinhDataSet2();
            this.nhaCungCapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter1 = new CuaHangMayTinh.CuaHangMayTinhDataSet2TableAdapters.NhaCungCapTableAdapter();
            this.labelCheckIDNCC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayTinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayTinhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayTinhDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(365, 227);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.Size = new System.Drawing.Size(432, 208);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            this.dataGridViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewCategory);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridViewProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 450);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AllowUserToAddRows = false;
            this.dataGridViewCategory.AllowUserToDeleteRows = false;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(365, 16);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.ReadOnly = true;
            this.dataGridViewCategory.Size = new System.Drawing.Size(432, 208);
            this.dataGridViewCategory.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCheckIDNCC);
            this.panel2.Controls.Add(this.labelCheckIDCategory);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.buttonDel);
            this.panel2.Controls.Add(this.textBoxNCC);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.buttonChange);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 426);
            this.panel2.TabIndex = 4;
            // 
            // labelCheckIDCategory
            // 
            this.labelCheckIDCategory.AutoSize = true;
            this.labelCheckIDCategory.Location = new System.Drawing.Point(137, 391);
            this.labelCheckIDCategory.Name = "labelCheckIDCategory";
            this.labelCheckIDCategory.Size = new System.Drawing.Size(75, 13);
            this.labelCheckIDCategory.TabIndex = 4;
            this.labelCheckIDCategory.Text = "Mã danh mục:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.39535F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.60465F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxMaNCC, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSoLuong, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGiaBan, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGiaNhap, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTenSP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelMaSP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSoLuong, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelGiaBan, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelGiaNhap, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelNCC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTenSP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLoaiSP, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMaSP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCategory, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 356);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxSoLuong.Location = new System.Drawing.Point(111, 303);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(230, 23);
            this.textBoxSoLuong.TabIndex = 13;
            // 
            // textBoxGiaBan
            // 
            this.textBoxGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxGiaBan.Location = new System.Drawing.Point(111, 253);
            this.textBoxGiaBan.Name = "textBoxGiaBan";
            this.textBoxGiaBan.Size = new System.Drawing.Size(230, 23);
            this.textBoxGiaBan.TabIndex = 12;
            // 
            // textBoxGiaNhap
            // 
            this.textBoxGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxGiaNhap.Location = new System.Drawing.Point(111, 203);
            this.textBoxGiaNhap.Name = "textBoxGiaNhap";
            this.textBoxGiaNhap.Size = new System.Drawing.Size(230, 23);
            this.textBoxGiaNhap.TabIndex = 11;
            // 
            // textBoxNCC
            // 
            this.textBoxNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxNCC.Location = new System.Drawing.Point(117, 365);
            this.textBoxNCC.Name = "textBoxNCC";
            this.textBoxNCC.Size = new System.Drawing.Size(230, 23);
            this.textBoxNCC.TabIndex = 10;
            // 
            // textBoxTenSP
            // 
            this.textBoxTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxTenSP.Location = new System.Drawing.Point(111, 53);
            this.textBoxTenSP.Name = "textBoxTenSP";
            this.textBoxTenSP.Size = new System.Drawing.Size(230, 23);
            this.textBoxTenSP.TabIndex = 8;
            // 
            // labelMaSP
            // 
            this.labelMaSP.AutoSize = true;
            this.labelMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelMaSP.Location = new System.Drawing.Point(3, 0);
            this.labelMaSP.Name = "labelMaSP";
            this.labelMaSP.Size = new System.Drawing.Size(102, 50);
            this.labelMaSP.TabIndex = 0;
            this.labelMaSP.Text = "Mã sản phẩm:";
            this.labelMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelSoLuong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSoLuong.Location = new System.Drawing.Point(3, 300);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(102, 56);
            this.labelSoLuong.TabIndex = 6;
            this.labelSoLuong.Text = "Số lượng:";
            this.labelSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGiaBan
            // 
            this.labelGiaBan.AutoSize = true;
            this.labelGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelGiaBan.Location = new System.Drawing.Point(3, 250);
            this.labelGiaBan.Name = "labelGiaBan";
            this.labelGiaBan.Size = new System.Drawing.Size(102, 50);
            this.labelGiaBan.TabIndex = 5;
            this.labelGiaBan.Text = "Giá bán:";
            this.labelGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGiaNhap
            // 
            this.labelGiaNhap.AutoSize = true;
            this.labelGiaNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelGiaNhap.Location = new System.Drawing.Point(3, 200);
            this.labelGiaNhap.Name = "labelGiaNhap";
            this.labelGiaNhap.Size = new System.Drawing.Size(102, 50);
            this.labelGiaNhap.TabIndex = 4;
            this.labelGiaNhap.Text = "Giá nhập:";
            this.labelGiaNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNCC
            // 
            this.labelNCC.AutoSize = true;
            this.labelNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelNCC.Location = new System.Drawing.Point(3, 150);
            this.labelNCC.Name = "labelNCC";
            this.labelNCC.Size = new System.Drawing.Size(102, 50);
            this.labelNCC.TabIndex = 3;
            this.labelNCC.Text = "Hãng sản xuất:";
            this.labelNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTenSP
            // 
            this.labelTenSP.AutoSize = true;
            this.labelTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelTenSP.Location = new System.Drawing.Point(3, 50);
            this.labelTenSP.Name = "labelTenSP";
            this.labelTenSP.Size = new System.Drawing.Size(102, 50);
            this.labelTenSP.TabIndex = 1;
            this.labelTenSP.Text = "Tên sản phẩm:";
            this.labelTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoaiSP
            // 
            this.labelLoaiSP.AutoSize = true;
            this.labelLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelLoaiSP.Location = new System.Drawing.Point(3, 100);
            this.labelLoaiSP.Name = "labelLoaiSP";
            this.labelLoaiSP.Size = new System.Drawing.Size(102, 50);
            this.labelLoaiSP.TabIndex = 2;
            this.labelLoaiSP.Text = "Loại sản phẩm:";
            this.labelLoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMaSP
            // 
            this.textBoxMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxMaSP.Location = new System.Drawing.Point(111, 3);
            this.textBoxMaSP.Name = "textBoxMaSP";
            this.textBoxMaSP.Size = new System.Drawing.Size(230, 23);
            this.textBoxMaSP.TabIndex = 7;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataSource = this.danhMucBindingSource;
            this.comboBoxCategory.DisplayMember = "TenDanhMuc";
            this.comboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(111, 103);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(230, 21);
            this.comboBoxCategory.TabIndex = 14;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiSP_SelectedIndexChanged);
            // 
            // danhMucBindingSource
            // 
            this.danhMucBindingSource.DataMember = "DanhMuc";
            this.danhMucBindingSource.DataSource = this.cuaHangMayTinhDataSet;
            // 
            // cuaHangMayTinhDataSet
            // 
            this.cuaHangMayTinhDataSet.DataSetName = "CuaHangMayTinhDataSet";
            this.cuaHangMayTinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(70, 394);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(61, 29);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Xóa";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(3, 365);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(61, 29);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(3, 394);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(61, 29);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Lưu";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // danhMucTableAdapter
            // 
            this.danhMucTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxMaNCC
            // 
            this.comboBoxMaNCC.DataSource = this.nhaCungCapBindingSource1;
            this.comboBoxMaNCC.DisplayMember = "TenNCC";
            this.comboBoxMaNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMaNCC.FormattingEnabled = true;
            this.comboBoxMaNCC.Location = new System.Drawing.Point(111, 153);
            this.comboBoxMaNCC.Name = "comboBoxMaNCC";
            this.comboBoxMaNCC.Size = new System.Drawing.Size(230, 21);
            this.comboBoxMaNCC.TabIndex = 15;
            this.comboBoxMaNCC.ValueMember = "MaNCC";
            this.comboBoxMaNCC.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaNCC_SelectedIndexChanged);
            // 
            // cuaHangMayTinhDataSet1
            // 
            this.cuaHangMayTinhDataSet1.DataSetName = "CuaHangMayTinhDataSet1";
            this.cuaHangMayTinhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.cuaHangMayTinhDataSet1;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // cuaHangMayTinhDataSet2
            // 
            this.cuaHangMayTinhDataSet2.DataSetName = "CuaHangMayTinhDataSet2";
            this.cuaHangMayTinhDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapBindingSource1
            // 
            this.nhaCungCapBindingSource1.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource1.DataSource = this.cuaHangMayTinhDataSet2;
            // 
            // nhaCungCapTableAdapter1
            // 
            this.nhaCungCapTableAdapter1.ClearBeforeFill = true;
            // 
            // labelCheckIDNCC
            // 
            this.labelCheckIDNCC.AutoSize = true;
            this.labelCheckIDNCC.Location = new System.Drawing.Point(137, 410);
            this.labelCheckIDNCC.Name = "labelCheckIDNCC";
            this.labelCheckIDNCC.Size = new System.Drawing.Size(46, 13);
            this.labelCheckIDNCC.TabIndex = 11;
            this.labelCheckIDNCC.Text = "Mã ncc:";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayTinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayTinhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayTinhDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelGiaNhap;
        private System.Windows.Forms.Label labelNCC;
        private System.Windows.Forms.Label labelLoaiSP;
        private System.Windows.Forms.Label labelTenSP;
        private System.Windows.Forms.Label labelMaSP;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelGiaBan;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxGiaBan;
        private System.Windows.Forms.TextBox textBoxGiaNhap;
        private System.Windows.Forms.TextBox textBoxNCC;
        private System.Windows.Forms.TextBox textBoxTenSP;
        private System.Windows.Forms.TextBox textBoxMaSP;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Label labelCheckIDCategory;
        private CuaHangMayTinhDataSet cuaHangMayTinhDataSet;
        private System.Windows.Forms.BindingSource danhMucBindingSource;
        private CuaHangMayTinhDataSetTableAdapters.DanhMucTableAdapter danhMucTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxMaNCC;
        private CuaHangMayTinhDataSet1 cuaHangMayTinhDataSet1;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private CuaHangMayTinhDataSet1TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private CuaHangMayTinhDataSet2 cuaHangMayTinhDataSet2;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource1;
        private CuaHangMayTinhDataSet2TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter1;
        private System.Windows.Forms.Label labelCheckIDNCC;
    }
}