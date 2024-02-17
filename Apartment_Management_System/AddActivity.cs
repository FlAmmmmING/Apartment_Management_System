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
    public partial class AddActivity : Form
    {
        public AddActivity(string stu_id)
        {
            this.stu_id = stu_id;
            InitializeComponent();
        }

        private void adding_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string[] s = new string[3];
            for (int i = 0; i < 3; i++) s[i] = null;
            if (this.actname.Text != "") s[0] = this.actname.Text; 
            if (this.acttime.Text != "") s[1] = this.acttime.Text; 
            if (this.actsite.Text != "") s[2] = this.actsite.Text; 
            for (int i = 0; i < 3; i++) {
                if (s[i] == null) {
                    MessageBox.Show("打*的必须填写！\n");
                    return;
                }
            }
            int id = get_act_id();
            string sql = $"insert into Activity values({id}, '{actname.Text}', " +
                $"'{actsite.Text}', '{actdetail.Text}')\r\n" +
                $"insert into Organization values('{stu_id}', {id}, '{acttime.Text}')";
            try {
                IDataReader dc = dao.Reader(sql);
                dc.Read();
                MessageBox.Show("添加成功!\n");
                this.Close();
            }
            catch {
                MessageBox.Show("添加失败！输入格式有误!\n");
            }
        }

        private int get_act_id()
        {
            Dao dao = new Dao();
            string sql = "select max(act_number) from Activity";
            IDataReader dc = dao.Reader(sql);
            dc.Read();
            string s = dc[0].ToString();
            try { return Convert.ToInt32(s) + 1; }
            catch { return 1; }
        }

        private string stu_id;

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
