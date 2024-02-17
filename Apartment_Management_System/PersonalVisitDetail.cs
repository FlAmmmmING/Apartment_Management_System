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
    public partial class PersonalVisitDetail : Form
    {
        public PersonalVisitDetail(string stu_id)
        {
            this.stu_id = stu_id;
            InitializeComponent();
            initGrid();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initGrid()
        {
            Dao dao = new Dao();
            string sql = $"select Visit.vis_id, Visitor.vis_name, Visit.vis_date, Visit.vis_start_time, Visit.vis_finish_time, Visitor.vis_phone, vis_detail, Employee.emp_name from Visit, Visitor, Employee where Visit.vis_id = Visitor.vis_id and Employee.emp_id = Visitor.emp_id and Visit.stu_id = '{this.stu_id}'";
            IDataReader dc = dao.Reader(sql);
            while(dc.Read()) {
                viewrating.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private string stu_id;
    }
}
