using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_Management_System {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void Cancelbutton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Loginbutton_Click(object sender, EventArgs e) {
            if (this.ID.Text == "" || this.PassWord.Text == "") {
                MessageBox.Show("用户名或者密码不能为空！\n"); 
            } else {
                if (StudentSelect.Checked) { // 如果是学生登录
                    Dao dao = new Dao(); // 创建一个数据库的连接
                    string sql = $"select * from Student where stu_id = '{this.ID.Text}' and stu_password = '{this.PassWord.Text}'";
                    // MessageBox.Show(sql);
                    IDataReader dc = dao.Reader(sql);
                    if(dc.Read()) { // 读到数据了
                        MessageBox.Show($"欢迎您！{dc[3].ToString()}！\n");
                        StudentForm stf = new StudentForm(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), 
                            dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
                        this.Hide();
                        stf.ShowDialog();
                        this.Show();    
                    } else { // 输入错误
                        MessageBox.Show("输入错误！请检查输入的用户名或者密码是否正确！\n");
                    }
                    dao.DaoClose();
                } else { // 如果是职工登录
                    Dao dao = new Dao(); // 创建一个数据库的连接
                    string sql = $"select * from Employee where emp_id = '{this.ID.Text}' and emp_password = '{this.PassWord.Text}'";
                    // MessageBox.Show(sql);
                    IDataReader dc = dao.Reader(sql);
                    if (dc.Read()) { // 读到数据了
                        MessageBox.Show($"欢迎您！{dc[1].ToString()}！\n");
                        EmployeeForm epf = new EmployeeForm(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), 
                            dc[3].ToString(), dc[4].ToString());
                        this.Hide();
                        epf.ShowDialog();
                        this.Show();
                    } else { // 输入错误
                        MessageBox.Show("输入错误！请检查输入的用户名或者密码是否正确！\n");
                    }
                    dao.DaoClose();
                }
            }
        }
    }
}
