using IntertechProject.IntertechProjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IntertechProject
{
   
    public partial class IntertechProject : Form
    {
        int i = 0;
        public IntertechProject()
        {
            InitializeComponent();
        }

        Project c = new Project();


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            c.MainBranchCode = Convert.ToInt16(cmbMainBranchCode.Text);
            c.Name = txtboxName.Text;
            c.MiddleName = txtMiddleName.Text;
            c.Surname = txtSurname.Text;
            c.CitizenshipNumber = Convert.ToInt64(txtCitizenshipNumber.Text);
           
            
            bool success = c.Insert(c);
          

            if (success == true)
            {
                MessageBox.Show("New Customer Succesfully Added.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Add");
            }

            //Load data on Grid View
            DataTable dt = c.SelectCust();
            i = 1;
            dgvCustomerList.DataSource = dt;
        }


      


        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            //Load data on Grid View
            Clear();
        }


        public void Clear()
        {
            txtId.Text = "";
            txtClientNo.Text = "";
            txtCitizenshipNumber.Text = " ";
            txtSurname.Text = " ";
            txtMiddleName.Text = "";
            txtboxName.Text = "";
            cmbMainBranchCode.Text = "";

        }


        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            //Get data from textboxes
            c.Id = int.Parse(txtId.Text);
            c.ClientNo = int.Parse(txtClientNo.Text);
            c.Name = txtboxName.Text;
            c.MiddleName = txtMiddleName.Text;
            c.Surname = txtSurname.Text;
            c.CitizenshipNumber = long.Parse(txtCitizenshipNumber.Text);
            c.MainBranchCode = int.Parse(cmbMainBranchCode.Text);

            //Updating
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Customer Info successfully updated.");
                DataTable dt = c.SelectCust();
                i = 1;
                dgvCustomerList.DataSource = dt;
                //AND CLEAR
                Clear();
            }
            else
            {
                MessageBox.Show("Customer Info Update Failed");
            }
        }


        private void dgvCustomerList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data to the textboxes
            if (i == 1)
            {
                int rowIndex = e.RowIndex;
                txtId.Text = dgvCustomerList.Rows[rowIndex].Cells[0].Value.ToString();
                txtClientNo.Text = dgvCustomerList.Rows[rowIndex].Cells[1].Value.ToString();
                cmbMainBranchCode.Text = dgvCustomerList.Rows[rowIndex].Cells[2].Value.ToString();
                txtboxName.Text = dgvCustomerList.Rows[rowIndex].Cells[3].Value.ToString();
                txtMiddleName.Text = dgvCustomerList.Rows[rowIndex].Cells[4].Value.ToString();
                txtSurname.Text = dgvCustomerList.Rows[rowIndex].Cells[5].Value.ToString();
                txtCitizenshipNumber.Text = dgvCustomerList.Rows[rowIndex].Cells[6].Value.ToString();
                cmbCustomerType.Text = dgvCustomerList.Rows[rowIndex].Cells[9].Value.ToString();
                cmbUnitStatus.Text = dgvCustomerList.Rows[rowIndex].Cells[10].Value.ToString();
            }
            else
            {
                int rowIndex = e.RowIndex; 
                cmbMainBranchCode.Text = dgvCustomerList.Rows[rowIndex].Cells[0].Value.ToString();
                txtClientNo.Text = dgvCustomerList.Rows[rowIndex].Cells[1].Value.ToString();
                txtboxName.Text = dgvCustomerList.Rows[rowIndex].Cells[2].Value.ToString();       
                txtMiddleName.Text = dgvCustomerList.Rows[rowIndex].Cells[3].Value.ToString();
                txtSurname.Text = dgvCustomerList.Rows[rowIndex].Cells[4].Value.ToString();
                txtCitizenshipNumber.Text = "";
                txtBalance.Text = dgvCustomerList.Rows[rowIndex].Cells[5].Value.ToString();

            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            
            c.Id = Convert.ToInt32(txtId.Text);
            bool success = c.DeleteCust(c);
            if (success == true)
            {
                MessageBox.Show("The selected customer deleted.");
                DataTable dt = c.SelectCust();
                dgvCustomerList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Delete operation failed.");
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            DataTable dt = c.SelectCust();
            dgvCustomerList.DataSource = dt;
            i = 1;
            btnDeleteCustomer.Visible = true;
            btnDeleteAccount.Visible = false;
            btnAddAccount.Visible = false;
            txtboxName.Enabled = true;
            txtCitizenshipNumber.Enabled = true;
            txtSurname.Enabled = true;
            txtMiddleName.Enabled = true;
            btnUpdateRecord.Visible = true;
            txtSearch.Visible = true;
            textSearch2.Visible = false;
            lblCustomerType.Visible = true;
            lblUnitStatus.Visible = true;
            cmbCustomerType.Visible = true;
            cmbUnitStatus.Visible = true;
            btnUpdateExtra.Visible = true;
            lblBalance.Visible = false;
            btnUpdateBalance.Visible = false;
            txtBalance.Visible = false;


        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            DataTable dt = c.SelectAcc();
            dgvCustomerList.DataSource = dt;
            i = 2;
            btnDeleteCustomer.Visible = false;
            btnUpdateRecord.Visible = false;
            btnDeleteAccount.Visible = true;
            btnAddAccount.Visible = true;
            txtboxName.Enabled = false;
            txtCitizenshipNumber.Enabled = false;
            txtSurname.Enabled = false;
            txtMiddleName.Enabled = false;
            txtSearch.Visible = false;
            textSearch2.Visible = true;
            lblCustomerType.Visible = false;
            lblUnitStatus.Visible = false;
            cmbCustomerType.Visible = false;
            cmbUnitStatus.Visible= false;
            btnUpdateExtra.Visible = false;
            lblBalance.Visible = true;
            btnUpdateBalance.Visible = true;
            txtBalance.Visible = true;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            c.ClientNo = Convert.ToInt32(txtClientNo.Text);
            bool success = c.DeleteAccount(c);
            if (success == true)
            {
                MessageBox.Show("The selected account deleted.");
                DataTable dt = c.SelectAcc();
                dgvCustomerList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Delete operation failed.");
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            c.MainBranchCode = Convert.ToInt16(cmbMainBranchCode.Text);
            c.Name = txtboxName.Text;
            c.MiddleName = txtMiddleName.Text;
            c.Surname = txtSurname.Text;
            c.ClientNo = Convert.ToInt32(txtClientNo.Text);


            bool success = c.InsertAcc(c);


            if (success == true)
            {
                MessageBox.Show("New Account Succesfully Added.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Add");
            }

            //Load data on Grid View
            DataTable dt = c.SelectAcc();
            i = 2;
            dgvCustomerList.DataSource = dt;
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
       

        private void txtSearch_TextChanged(object sender, EventArgs e)
         {
         string keyword = txtSearch.Text;
         SqlConnection conn = new SqlConnection(myconnstring);
         SqlDataAdapter sda = new SqlDataAdapter("Select * FROM customers WHERE Name LIKE '%"+keyword+"%' OR MiddleName LIKE '%"+keyword+"%' OR Surname LIKE '%"+keyword+"%' OR CitizenshipNumber LIKE '%"+keyword+"%'", conn);
         DataTable dt = new DataTable();
         sda.Fill(dt);
         dgvCustomerList.DataSource = dt;
         }

        private void textSearch2_TextChanged(object sender, EventArgs e)
        {
            string keyword = textSearch2.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("Select * FROM accounts WHERE Name LIKE '%" + keyword + "%' OR MiddleName LIKE '%" + keyword + "%' OR Surname LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvCustomerList.DataSource = dt;
        }

        private void btnUpdateExtra_Click(object sender, EventArgs e)
        {
            c.Id = int.Parse(txtId.Text);
            c.UnitStatus = short.Parse(cmbUnitStatus.Text);
            c.CustomerType = short.Parse(cmbCustomerType.Text);

            //Updating
            bool success = c.InsertExtra(c);
            if (success == true)
            {
                MessageBox.Show("Customer Info successfully updated.");
                DataTable dt = c.SelectCust();
                i = 1;
                dgvCustomerList.DataSource = dt;
                //AND CLEAR
                Clear();
            }
            else
            {
                MessageBox.Show("Customer Info Update Failed");
            }
        }

        private void btnUpdateBalance_Click(object sender, EventArgs e)
        {
            c.ClientNo = int.Parse(txtClientNo.Text);
            c.Balance = long.Parse(txtBalance.Text);

            //Updating
            bool success = c.UpdateBalance(c);
            if (success == true)
            {
                MessageBox.Show("Account Info successfully updated.");
                DataTable dt = c.SelectAcc();
                i = 2;
                dgvCustomerList.DataSource = dt;
                //AND CLEAR
                Clear();
            }
            else
            {
                MessageBox.Show("Account Info Update Failed");
            }
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            if (cmbReports.Text == "Report 1")
            {
                DataTable dt = c.SelectReport1();
                dgvCustomerList.DataSource = dt;
                i = 1;
            }
        }
    }

}
