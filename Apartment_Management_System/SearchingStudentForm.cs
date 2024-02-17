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
    public partial class SearchingStudentForm : Form
    {
        public SearchingStudentForm()
        {
            InitializeComponent();
            initGrid();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searching_Click(object sender, EventArgs e)
        {
            string s1, s2, s3, s4, s5, s6;
            if (searchingstuid.Text == "") s1 = "!= \'\'";
            else s1 = $"= '{searchingstuid.Text}'";
            if (searchingstuname.Text == "") s2 = "!= \'\'";
            else s2 = $"= '{searchingstuname.Text}'";
            if (searchingstuclass.Text == "") s3 = "!= \'\'";
            else s3 = $"= '{searchingstuclass.Text}'";
            if (searchingstudorm.Text == "") s4 = "!= \'\'";
            else s4 = $"= '{searchingstudorm.Text}'";
            if (searchingstuphone.Text == "") s5 = "!= \'\'";
            else s5 = $"= '{searchingstuphone.Text}'";
            if (searchingstujob.Text == "") s6 = "!= \'\'";
            else s6 = $"= '{searchingstujob.Text}'";
            Dao dao = new Dao();
            string sql = $"select Student.stu_id, Student.stu_name, Student.stu_class, Student.dorm_id, Student.stu_phone, " +
                $"Student.stu_job, (avg(Rating.rate_behavior) + avg(Rating.rate_sanitary) + avg(Rating.rate_bedtime)) / 3 , " +
                $"Dorm.dorm_score from Student \r\n" +
                $"left join Rating on Student.stu_id = Rating.stu_id\r\nleft join Dorm on Student.dorm_id = Dorm.dorm_id\r\n" +
                $"where Student.stu_id {s1} and Student.stu_name {s2} and Student.stu_class {s3} " +
                $"and Student.dorm_id {s4} and Student.stu_password {s5} " +
                $"and Student.stu_job {s6}\r\n" +
                $"group by Student.stu_id, Student.stu_name, Student.stu_class, Student.dorm_id, Student.stu_phone, " +
                $"Student.stu_job, Dorm.dorm_score";
            IDataReader dc = dao.Reader(sql);
            viewstudent.Rows.Clear();
            while (dc.Read()) {
                viewstudent.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), 
                    dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dao.DaoClose();
        }
        
        private void initGrid()
        {
            Dao dao = new Dao();
            string sql = "select Student.stu_id, Student.stu_name, Student.stu_class, Student.dorm_id, Student.stu_phone, Student.stu_job, (avg(Rating.rate_behavior) + avg(Rating.rate_sanitary) + avg(Rating.rate_bedtime)) / 3 , Dorm.dorm_score from Student \r\nleft join Rating on Student.stu_id = Rating.stu_id\r\nleft join Dorm on Student.dorm_id = Dorm.dorm_id\r\ngroup by Student.stu_id, Student.stu_name, Student.stu_class, Student.dorm_id, Student.stu_phone, Student.stu_job, Dorm.dorm_score";
            IDataReader dc = dao.Reader(sql);
            while (dc.Read())
            {
                viewstudent.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dao.DaoClose();
        }

    }
}
