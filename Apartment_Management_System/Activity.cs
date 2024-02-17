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
    public partial class Activity : Form
    {
        public Activity(bool limit, string stu_id)
        {
            this.limit = limit;
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
            viewact.Columns[5].FillWeight = viewact.Width / 2;
            viewact.Columns[0].FillWeight = viewact.Width / 15;
            viewact.Columns[1].FillWeight = viewact.Height / 4; 
            Dao dao = new Dao();
            string sql = $"select Activity.act_number, act_name, act_time, act_site, stu_name, act_detail from Activity, Organization, Student " +
                $"where Activity.act_number = Organization.act_number and Student.stu_id = Organization.stu_id";
            IDataReader dc = dao.Reader(sql);
            while (dc.Read())
            {
                viewact.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }


        private void addact_Click(object sender, EventArgs e)
        {
            if (limit == false)
            {
                MessageBox.Show("没有权限！\n");
            }
            else
            {
                this.Hide();
                AddActivity aa = new AddActivity(this.stu_id);
                aa.ShowDialog();
                viewact.Rows.Clear();
                initGrid();
                this.Show();
            }
        }

        private void delact_Click(object sender, EventArgs e)
        {
            if (limit == false)
            {
                MessageBox.Show("没有权限！\n");
            }
            else
            {
                if (delactid.Text=="")
                {
                    MessageBox.Show("请输入活动号！\n");
                    return;
                }
                Dao dao = new Dao();
                string check = $"select * from Organization where act_number = {delactid.Text}";
                IDataReader dc = dao.Reader(check);
                if (!dc.Read())
                {
                    MessageBox.Show("活动号不存在!\n");
                    return;
                }
                string sql = $"delete from Organization where act_number = {delactid.Text}\r\ndelete from Activity where act_number = {delactid.Text}";
                viewact.Rows.Clear();
                dao.Reader(sql);
                dc.Read();
                initGrid();
                dc.Close();
                dao.DaoClose();
                MessageBox.Show("删除成功!\n");
            }
        }

        private bool limit;
        private string stu_id;
    }
}
