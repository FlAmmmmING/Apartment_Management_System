using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_Management_System
{
    public partial class AddingVisitor : Form
    {
        public AddingVisitor(string emp_id, string emp_name)
        {
            InitializeComponent();
            this.emp_id = emp_id;
            this.vis_id = get_vis_id();
            this.emp_name = emp_name;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int get_vis_id()
        {
            Dao dao = new Dao();
            string sql = "select max(vis_id) from Visitor";
            IDataReader dc = dao.Reader(sql);
            dc.Read();
            string s = dc[0].ToString();
            try { return Convert.ToInt32(s) + 1; }
            catch { return 1; }
        }

        private void adding_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string[] s = new string[6];
            for (int i = 0; i < 6; i++) s[i] = null;
            if (visname.Text != "") s[0] = visname.Text;
            if (stuid.Text != "") s[1] = stuid.Text;
            if (visdate.Text != "") s[2] = visdate.Text;
            if (visit_start_time.Text != "") s[3] = visit_start_time.Text;
            if (visit_finish_time.Text != "") s[4] = visit_finish_time.Text;
            if (visphone.Text.Length == 11) s[5] = visphone.Text;
            for (int i = 0; i < 6; i++)
            {
                if (s[i] == null)
                {
                    MessageBox.Show("打*的必须填写！\n");
                    return;
                }
            }
            string sql0 = $"select * from Student where stu_id = '{s[1]}'";
            IDataReader dc = dao.Reader(sql0);
            if (!dc.Read())
            {
                MessageBox.Show("插入失败！原因：被访者学号未找到！\n");
                dao.DaoClose();
                return;
            }
            string sql1 = $"insert into Visitor(vis_id, emp_id, vis_name, vis_phone, vis_detail) " +
                $"values ({this.vis_id}, '{emp_id}', '{s[0]}', '{s[5]}', '{visit_detail.Text}')";
            try{
                dc = dao.Reader(sql1);
                dc.Read();
            }
            catch
            {
                MessageBox.Show("插入失败！请检查插入的数据是否有误！\n" +
                    "(打*的必须填写，注意日期填写规范:yyyy/mm/dd，注意时间填写规范:hh:mm:ss，注意电话号码格式是否正确)");
                dao.DaoClose();
                return;
            }
            string sql2 = $"insert into Visit(stu_id, vis_id, vis_start_time, vis_finish_time, vis_date) " +
                $"values ('{s[1]}', {this.vis_id}, '{s[3]}', '{s[4]}', '{s[2]}')";
            try
            {
                dc = dao.Reader(sql2);
                dc.Read();
            }
            catch
            {
                MessageBox.Show("插入失败！请检查插入的数据是否有误！\n" +
                    "(打*的必须填写，注意日期填写规范:yyyy/mm/dd，注意时间填写规范:hh:mm:ss，注意电话号码格式是否正确)");
                // 前端实现rollback
                string sql3 = $"delete from Visitor where vis_id = {vis_id}";
                dc = dao.Reader(sql3);
                dc.Read();
                dao.DaoClose();
                return;
            }
            MessageBox.Show("添加成功！");
            dao.DaoClose();

        }

        private string emp_id, emp_name;
        private int vis_id;

    }
}
