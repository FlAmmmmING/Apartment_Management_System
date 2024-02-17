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
    public partial class VisitorFormEmp : Form
    {
        public VisitorFormEmp(string emp_id, string emp_name)
        {
            InitializeComponent();
            initGrid();
            this.eid = emp_id;
            this.ename = emp_name;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searching_Click(object sender, EventArgs e)
        {
            string s1, s2, s3, s4, s5, s6, s7;
            if (visid.Text == "") s1 = "!= \'\'";
            else s1 = $"= '{visid.Text}'";
            if (visname.Text == "") s2 = "!= \'\'";
            else s2 = $"= '{visname.Text}'";
            if (stuname.Text == "") s3 = "!= \'\'";
            else s3 = $"= '{stuname.Text}'";
            if (visdate.Text == "") s4 = "!= \'\'";
            else s4 = $"= '{visdate.Text}'";
            if (visphone.Text == "") s5 = "!= \'\'";
            else s5 = $"= '{visphone.Text}'";
            if (empid.Text == "") s6 = "!= \'\'";
            else s6 = $"= '{empid.Text}'";
            if (empname.Text == "") s7 = "!= \'\'";
            else s7 = $"= '{empname.Text}'";
            Dao dao = new Dao();
            string sql = $"select Visitor.vis_id, Visitor.vis_name, Student.stu_name, Visit.vis_date, Visit.vis_start_time, Visit.vis_finish_time, Visitor.vis_phone, Visitor.vis_detail, Employee.emp_id,  Employee.emp_name\r\n" +
                $"from Visitor, visit, Student, Employee \r\n" +
                $"where Visitor.vis_id = Visit.vis_id and Student.stu_id = Visit.stu_id and Employee.emp_id = Visitor.emp_id\r\n" +
                $"and Visitor.vis_id {s1} and Visitor.vis_name {s2} and Student.stu_name {s3} and Visit.vis_date {s4} and Visitor.vis_phone {s5} and Employee.emp_id {s6} and Employee.emp_name {s7}";
            IDataReader dc = dao.Reader(sql);
            viewvisitor.Rows.Clear();
            while (dc.Read())
            {
                viewvisitor.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(), dc[8].ToString(), dc[9].ToString());
            }
            dao.DaoClose();
        }

        private void initGrid()
        {
            Dao dao = new Dao();
            string sql = "select Visitor.vis_id, Visitor.vis_name, Student.stu_name, Visit.vis_date, Visit.vis_start_time, Visit.vis_finish_time, Visitor.vis_phone, Visitor.vis_detail, Employee.emp_id,  Employee.emp_name" +
                "\r\nfrom Visitor, visit, Student, Employee " +
                "\r\nwhere Visitor.vis_id = Visit.vis_id and Student.stu_id = Visit.stu_id and Employee.emp_id = Visitor.emp_id";
            IDataReader dc = dao.Reader(sql);
            while (dc.Read())
            {
                viewvisitor.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(), dc[8].ToString(), dc[9].ToString());
            }
            dao.DaoClose();
        }

        private void adding_Click(object sender, EventArgs e)
        {
            AddingVisitor visitor = new AddingVisitor(eid, ename);
            this.Hide();
            visitor.ShowDialog();
            viewvisitor.Rows.Clear();
            initGrid();
            this.Show();
        }

        private string eid, ename;
    }
}
