using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_Management_System {
    public partial class ModifyPassword : Form {
        public ModifyPassword(string id, string originpassword, bool is_emp) {
            InitializeComponent();
            this.id = id;   
            this.originpassword = originpassword;
            this.is_emp = is_emp;
        }
        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void buttonconform_Click(object sender, EventArgs e) {
            if (originpassword != originalpassword.Text) {
                MessageBox.Show("修改失败！初始密码错误！\n");
            } else {
                if (modifiedpassword.Text != conformpassword.Text) {
                    MessageBox.Show("确认密码与修改密码不一致！\n");
                } else {
                    if (is_emp) { // 如果是职工要修改密码
                        Dao dao = new Dao();
                        string sql = $"update Employee set emp_password = '{modifiedpassword.Text}' where emp_id = '{id}'";
                        IDataReader dc = dao.Reader(sql);
                        dc.Read();
                        MessageBox.Show("修改成功！\n");
                        dao.DaoClose();
                        this.Close();
                    } else { // 如果是学生要修改密码
                        Dao dao = new Dao();
                        string sql = $"update Student set stu_password = '{modifiedpassword.Text}' where stu_id = '{id}'";
                        IDataReader dc = dao.Reader(sql);
                        dc.Read();
                        MessageBox.Show("修改成功！\n");
                        dao.DaoClose();
                        this.Close();
                    }
                }
            }
        }

        private string id, originpassword;
        private bool is_emp;
    }
}
