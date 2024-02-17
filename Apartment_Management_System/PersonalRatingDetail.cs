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
    public partial class PersonalRatingDetail : Form
    {
        public PersonalRatingDetail(string stu_id)
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
            string sql = $"select Rating.rate_id, rate_sanitary, rate_bedtime, rate_behavior, emp_name, rate_date, rate_detail from Rating, RatingList, Employee where Rating.rate_id = RatingList.rate_id and Employee.emp_id = RatingList.emp_id  and stu_id = '{this.stu_id}'";
            IDataReader dc = dao.Reader(sql);
            viewrating.Rows.Clear();
            while (dc.Read())
            {
                viewrating.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private string stu_id;
    }

}
