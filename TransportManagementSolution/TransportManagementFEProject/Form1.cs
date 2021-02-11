using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranportManagementBLLibrary;

namespace TransportManagementFEProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Name = txtName.Text;
            employee.Address = txtAddress.Text;
            employee.Email = txtEmail.Text;
            employee.Phone = txtPhone.Text;
            employee.Location = txtLocation.Text;
            employee.Age = Convert.ToInt32(txtAge.Text);
            EmployeeBL bl = new EmployeeBL();
            if (bl.CreateEmployee(employee))
                MessageBox.Show("Employee Created");
            else
                MessageBox.Show("Something went wrong");
        }
    }
}
