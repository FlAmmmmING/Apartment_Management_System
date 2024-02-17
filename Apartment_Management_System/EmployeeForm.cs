using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_Management_System
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm(string emp_id, string emp_name, string emp_password, string emp_type, string emp_phone)
        {
            InitializeComponent();
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.emp_password = emp_password;
            this.emp_type = emp_type;
            this.emp_phone = emp_phone;
            showinformation();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showinformation()
        {
            this.name.Text = this.emp_name;
            this.id.Text = this.emp_id;
            this.type.Text = this.emp_type;
            this.phone.Text = this.emp_phone;
        }


        private void visitor_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisitorFormEmp vfp = new VisitorFormEmp(emp_id, emp_name);
            vfp.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void searchingstudent_Click(object sender, EventArgs e)
        {
            SearchingStudentForm ssf = new SearchingStudentForm();
            this.Hide();
            ssf.ShowDialog();
            this.Show();
        }

        private void modifypassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPassword mp = new ModifyPassword(emp_id, emp_password, true);
            mp.ShowDialog();
            this.Show();
        }

        private void ratingsystem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RatingForm rf = new RatingForm(this.emp_id);
            rf.ShowDialog();
            this.Show();
        }
        
        private string emp_id, emp_name, emp_password, emp_type, emp_phone;

        private void recentactivity_Click(object sender, EventArgs e)
        {
            Activity act = new Activity(false, "");
            this.Hide();
            act.ShowDialog();
            this.Show();
        }

        private void StudentUnion_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentUnion su = new StudentUnion();
            su.ShowDialog();
            this.Show();
        }
    }
}
