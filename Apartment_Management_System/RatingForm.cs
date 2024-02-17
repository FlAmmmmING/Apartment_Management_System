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
    public partial class RatingForm : Form
    {
        public RatingForm(string emp_id)
        {
            InitializeComponent();
            this.date.Text = System.DateTime.Now.ToString("d");
            this.emp_id = emp_id;
            this.rating_id = get_id();
            this.ratingid.Text = this.rating_id.ToString();
            initGrid();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int get_id()
        {
            Dao dao = new Dao();
            string sql = "select max(rate_id) from RatingList";
            IDataReader dc = dao.Reader(sql);
            dc.Read();
            string s = dc[0].ToString();
            dc.Close(); 
            dao.DaoClose();
            try { return Convert.ToInt32(s) + 1; }
            catch { return 1; }
        }

        private void initGrid() {
            Dao dao = new Dao();
            string sql = "select stu_id, stu_name, dorm_id from Student";
            IDataReader dc = dao.Reader(sql);
            while(dc.Read()) {
                viewrating.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), "100", "100", "100", "无");
            }
            dc.Close();
            dao.DaoClose();
        }

        private void submit_Click(object sender, EventArgs e) {  // 先检查数据是否合法
            for (int i = 0; i < viewrating.RowCount; i++) {
                for (int j = 3; j <= 5; j++) {
                    int tep = 0;
                    try {
                        tep = Convert.ToInt32(viewrating.Rows[i].Cells[j].Value.ToString());
                    }
                    catch  {
                        MessageBox.Show("请检查分数是否输入正确！\n");
                        return;
                    }
                    if (tep < 0 || tep > 100) {
                        MessageBox.Show("输入数字超出范围！\n");
                        return;
                    }
                }
            }
            for (int i = 0; i < viewrating.RowCount; i++) {
                if (viewrating.Rows[i].Cells[6].Value.ToString() == "") viewrating.Rows[i].Cells[6].Value = "无";
            }
            // 再次确认
            DialogResult dr = MessageBox.Show("确认提交？", "来自学生公寓管理系统——评分评价系统提示", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK) {
                Dao dao = new Dao();
                string sql1 = $"insert RatingList values({rating_id}, '{emp_id}', '{this.date.Text}')";
                IDataReader dc = dao.Reader(sql1);
                dc.Read();
                for (int i = 0; i < viewrating.RowCount; i++) {
                    string sql2 = $"insert Rating values('{viewrating.Rows[i].Cells[0].Value}', {rating_id}, " +
                        $"{viewrating.Rows[i].Cells[3].Value}, {viewrating.Rows[i].Cells[4].Value}, " +
                        $"{viewrating.Rows[i].Cells[5].Value}, '{viewrating.Rows[i].Cells[6].Value}')";
                    dc = dao.Reader(sql2);
                    dc.Read();
                }
                MessageBox.Show("评价成功！即将退出！\n");
                this.Close();
            }
            else {
                return;
            }
        }


        private string emp_id;
        private int rating_id;
    }
}
