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
    public partial class StudentUnion : Form
    {
        public StudentUnion()
        {
            InitializeComponent();
            initGrid();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initGrid()
        {
            string sql = "select * from Student where Student.stu_job like '学生会%'";
            Dao dao = new Dao();
            IDataReader dc = dao.Reader(sql);
            while (dc.Read())
            {
                viewstu.Rows.Add(dc[6].ToString(), dc[3].ToString(), dc[4].ToString(), dc[1].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.DaoClose(); ;
        }
    }
}
