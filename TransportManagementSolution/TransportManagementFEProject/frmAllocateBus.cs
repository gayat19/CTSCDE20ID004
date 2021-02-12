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
    public partial class frmAllocateBus : Form
    {
        int step = 10;
        public frmAllocateBus()
        {
            InitializeComponent();
        }
        int GetEmployeeId()
        {
            int eid = 0;
            if (!Int32.TryParse(txtEmployeeId.Text, out eid))
            {
                txtEmployeeId.Clear();
                MessageBox.Show("Invalid Employee Id");
                txtEmployeeId.Focus();
            }
            return eid;
        }
        private void btnFetchBus_Click(object sender, EventArgs e)
        {
            int eid = GetEmployeeId();
            if(eid != 0)
            {
                Booking booking = new Booking();
                List<string> busNumbers = booking.GetBusForEmployee(eid);
                if (busNumbers.Count > 0)
                {
                    foreach (string item in busNumbers)
                    {
                        ddlBusNumbers.Items.Add(item);
                    }
                    ddlBusNumbers.Visible = true;
                }
                else
                {
                    MessageBox.Show("No bus available now. Sorry......");
                    ddlBusNumbers.Visible = false;
                }
                    
            }
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            int eid = GetEmployeeId();
            string busNumber = ddlBusNumbers.SelectedItem.ToString();
            if (booking.AllocateBusForEmployee(eid, busNumber))
                MessageBox.Show("Success!!!! Employee is now allocated a bus. Tada....");
        }

        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            step += 10;
            if(step == 50)
                MessageBox.Show("Hey Look we did it...");
        }
    }
}
