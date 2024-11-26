using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMmployees
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {

            InitializeComponent();

        }

       

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dhasboardBtn_Click(object sender, EventArgs e)
        {
            dhachy1.Visible = true;
            addEmployee1.Visible=false;
            salarycs1.Visible = false;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
         

         DialogResult check =   MessageBox.Show("Are tou sure to logOut ?","Comfirmation Message ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login login = new Login();

                login.Show();
                this.Hide();
            }
        }

        private void AddEmployeesBtn_Click(object sender, EventArgs e)
        {
            dhachy1.Visible = false;
            addEmployee1.Visible = true;
            salarycs1.Visible = false;
        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {
            dhachy1.Visible = false;
            addEmployee1.Visible = false;
            salarycs1.Visible = true;
        }
    }
}
