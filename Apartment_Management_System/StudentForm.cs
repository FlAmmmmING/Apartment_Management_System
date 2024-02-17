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
    public partial class StudentForm : Form
    {
        public StudentForm(string stu_id, string dorm_id, string stu_password, 
            string stu_name, string stu_phone, string stu_class, string stu_job) // 构造函数
        {
            InitializeComponent();
            this.stu_id = stu_id;
            this.dorm_id = dorm_id;
            this.stu_password = stu_password;   
            this.stu_name = stu_name;
            this.stu_phone = stu_phone;
            this.stu_class = stu_class;
            this.stu_job = stu_job;
            showinformation();
        }
        private void modifypassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPassword mp = new ModifyPassword(stu_id, stu_password, false);
            mp.ShowDialog();
            this.Show();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("退出成功！\n");
            this.Close();
        }
        private void showinformation()
        {
            this.name.Text = this.stu_name;
            this.id.Text = this.stu_id;
            this.classes.Text = this.stu_class;
            this.dorm.Text = this.dorm_id;
            this.job.Text = this.stu_job;
            this.phone.Text = this.stu_phone;
            Dao dao = new Dao();
            string sql1 = $"select (avg(rate_sanitary) + avg(rate_bedtime) + avg(rate_behavior)) " +
                $"/ 3 from Rating where stu_id = '{this.stu_id}'";
            IDataReader dc = dao.Reader(sql1);
            dc.Read();
            this.personalscore.Text = dc[0].ToString();
            string sql2 = $"select dorm_score from Dorm where dorm_id = '{this.dorm_id}'";
            dc = dao.Reader(sql2);
            dc.Read();
            this.dormscore.Text = dc[0].ToString();
            dao.DaoClose();
            dc.Close();
        }

        private void ratingdetailpersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalRatingDetail prd = new PersonalRatingDetail(this.stu_id);
            prd.ShowDialog();
            this.Show();
        }


        private void visitor_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalVisitDetail pvd = new PersonalVisitDetail(this.stu_id);
            pvd.ShowDialog();
            this.Show();
        }

        private string stu_id, dorm_id, stu_password, stu_name, stu_phone, stu_class, stu_job;

        private void recentactivity_Click(object sender, EventArgs e)
        {
            bool limit;
            if (this.stu_job != "无") limit = true;
            else limit = false;
            Activity act = new Activity(limit, stu_id);
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
