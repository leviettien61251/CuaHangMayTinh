using CuaHangMayTinh.Controllers;
using DocumentFormat.OpenXml.ExtendedProperties;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Views.Manager
{
    public partial class frmEmployeeManagement : Form
    {
        public frmEmployeeManagement()
        {
            InitializeComponent();
        }

        readonly Regex regexOnlyNum = new Regex(@"^\d+$");// validate number

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuaHangMayTinhDataSet.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.cuaHangMayTinhDataSet.ChucVu);
            LoadEmployee();
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadEmployee()
        {
            try
            {
                EmployeeController.Instance.LoadEmployee(dgvEmployees);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void ClearTextBox()
        {
            txtEmployeeId.Clear();
            txtEmployeeName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtSalary.Clear();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeId.Text = dgvEmployees.CurrentRow.Cells[0].Value.ToString();
            txtEmployeeName.Text = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
            txtSalary.Text = dgvEmployees.CurrentRow.Cells[6].Value.ToString();
        }

        private void AddEmployee_(string hoTen, string soDienThoai, string email, string diaChi, float luongCoBan)
        {
            try
            {
                bool result;

                result = EmployeeController.Instance.AddEmployee(hoTen, soDienThoai, email, diaChi, luongCoBan);

                if (result)
                {
                    MessageBox.Show("Thêm mới nhân viên thành công!");
                    ClearTextBox();
                    LoadEmployee();
                }
                else
                {
                    MessageBox.Show("Thêm mới nhân viên không thành công!");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void UpdateEmployee_(int maNV, string hoTen, string soDienThoai, string email, string diaChi, float luongCoBan)
        {
            try
            {
                bool result;

                result = EmployeeController.Instance.UpdateEmployee(maNV, hoTen, soDienThoai, email, diaChi, luongCoBan);

                if (result)
                {
                    MessageBox.Show("Sửa mới nhân viên thành công!");
                    ClearTextBox();
                    LoadEmployee();
                }
                else
                {
                    MessageBox.Show("Sửa mới nhân viên không thành công!");
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string hoTen = txtEmployeeName.Text;
            string email = txtEmail.Text;
            string diaChi = txtAddress.Text;
            string soDienThoai = txtPhone.Text;
            if (txtPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            else
            {

                if (regexOnlyNum.IsMatch(txtPhone.Text) && regexOnlyNum.IsMatch(txtSalary.Text))
                {
                    float luongCoBan = (float)Convert.ToDouble(txtSalary.Text);

                    if (CheckValidate.Instance.IsEmail(email))
                    {
                        AddEmployee_(hoTen, soDienThoai, email, diaChi, luongCoBan);
                    }
                    else
                    {
                        MessageBox.Show("Sai định dạng Email");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại và lương cơ bản chỉ được điền số");
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int maNV = (int)Convert.ToDouble(txtEmployeeId.Text);
            string hoTen = txtEmployeeName.Text;
            string email = txtEmail.Text;
            string diaChi = txtAddress.Text;
            string soDienThoai = txtPhone.Text;

            if (txtPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtPhone.Text) && regexOnlyNum.IsMatch(txtSalary.Text))
                {
                    float luongCoBan = (float)Convert.ToDouble(txtSalary.Text);

                    if (CheckValidate.Instance.IsEmail(email))
                    {
                        UpdateEmployee_(maNV, hoTen, soDienThoai, email, diaChi, luongCoBan);
                    }
                    else
                    {
                        MessageBox.Show("Sai định dạng Email");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại và lương cơ bản chỉ được điền số");
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maNCC = (int)Convert.ToDouble(txtEmployeeId.Text);
            try
            {
                bool result;

                result = EmployeeController.Instance.DeleteEmployee(maNCC);

                if (result)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    ClearTextBox();
                    LoadEmployee();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công!");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearchEmployee.Text.ToLower();
            EmployeeController.Instance.SearchEmployee(search, dgvEmployees);
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelController.Instance.SaveExcel(dgvEmployees, "Employee List", "Employee");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
