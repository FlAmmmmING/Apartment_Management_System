namespace Apartment_Management_System
{
    partial class SearchingStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.viewstudent = new System.Windows.Forms.DataGridView();
            this.searching = new System.Windows.Forms.Button();
            this.searchingstuid = new System.Windows.Forms.TextBox();
            this.searchingstuname = new System.Windows.Forms.TextBox();
            this.searchingstuclass = new System.Windows.Forms.TextBox();
            this.searchingstudorm = new System.Windows.Forms.TextBox();
            this.searchingstuphone = new System.Windows.Forms.TextBox();
            this.searchingstujob = new System.Windows.Forms.TextBox();
            this.labelstuid = new System.Windows.Forms.Label();
            this.labelstuname = new System.Windows.Forms.Label();
            this.labelstuclass = new System.Windows.Forms.Label();
            this.labelstudorm = new System.Windows.Forms.Label();
            this.labelstuphone = new System.Windows.Forms.Label();
            this.labelstujob = new System.Windows.Forms.Label();
            this.stu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dorm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selfrating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormrating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancelbutton.Location = new System.Drawing.Point(1073, 517);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(100, 33);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "退出";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // viewstudent
            // 
            this.viewstudent.AllowUserToAddRows = false;
            this.viewstudent.AllowUserToDeleteRows = false;
            this.viewstudent.AllowUserToResizeColumns = false;
            this.viewstudent.AllowUserToResizeRows = false;
            this.viewstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewstudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewstudent.ColumnHeadersHeight = 40;
            this.viewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stu_id,
            this.stu_name,
            this.stu_class,
            this.dorm_id,
            this.stu_phone,
            this.stu_job,
            this.selfrating,
            this.dormrating});
            this.viewstudent.Location = new System.Drawing.Point(11, 11);
            this.viewstudent.Margin = new System.Windows.Forms.Padding(2);
            this.viewstudent.Name = "viewstudent";
            this.viewstudent.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewstudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewstudent.RowHeadersVisible = false;
            this.viewstudent.RowHeadersWidth = 70;
            this.viewstudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewstudent.RowTemplate.Height = 30;
            this.viewstudent.Size = new System.Drawing.Size(954, 539);
            this.viewstudent.TabIndex = 8;
            // 
            // searching
            // 
            this.searching.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searching.Location = new System.Drawing.Point(969, 517);
            this.searching.Margin = new System.Windows.Forms.Padding(2);
            this.searching.Name = "searching";
            this.searching.Size = new System.Drawing.Size(100, 33);
            this.searching.TabIndex = 9;
            this.searching.Text = "检索";
            this.searching.UseVisualStyleBackColor = true;
            this.searching.Click += new System.EventHandler(this.searching_Click);
            // 
            // searchingstuid
            // 
            this.searchingstuid.Font = new System.Drawing.Font("宋体", 12F);
            this.searchingstuid.Location = new System.Drawing.Point(974, 48);
            this.searchingstuid.Margin = new System.Windows.Forms.Padding(2);
            this.searchingstuid.Name = "searchingstuid";
            this.searchingstuid.Size = new System.Drawing.Size(199, 26);
            this.searchingstuid.TabIndex = 19;
            // 
            // searchingstuname
            // 
            this.searchingstuname.Font = new System.Drawing.Font("宋体", 12F);
            this.searchingstuname.Location = new System.Drawing.Point(974, 118);
            this.searchingstuname.Margin = new System.Windows.Forms.Padding(2);
            this.searchingstuname.Name = "searchingstuname";
            this.searchingstuname.Size = new System.Drawing.Size(199, 26);
            this.searchingstuname.TabIndex = 20;
            // 
            // searchingstuclass
            // 
            this.searchingstuclass.Font = new System.Drawing.Font("宋体", 12F);
            this.searchingstuclass.Location = new System.Drawing.Point(974, 188);
            this.searchingstuclass.Margin = new System.Windows.Forms.Padding(2);
            this.searchingstuclass.Name = "searchingstuclass";
            this.searchingstuclass.Size = new System.Drawing.Size(199, 26);
            this.searchingstuclass.TabIndex = 21;
            // 
            // searchingstudorm
            // 
            this.searchingstudorm.Font = new System.Drawing.Font("宋体", 12F);
            this.searchingstudorm.Location = new System.Drawing.Point(974, 258);
            this.searchingstudorm.Margin = new System.Windows.Forms.Padding(2);
            this.searchingstudorm.Name = "searchingstudorm";
            this.searchingstudorm.Size = new System.Drawing.Size(199, 26);
            this.searchingstudorm.TabIndex = 22;
            // 
            // searchingstuphone
            // 
            this.searchingstuphone.Font = new System.Drawing.Font("宋体", 12F);
            this.searchingstuphone.Location = new System.Drawing.Point(974, 328);
            this.searchingstuphone.Margin = new System.Windows.Forms.Padding(2);
            this.searchingstuphone.Name = "searchingstuphone";
            this.searchingstuphone.Size = new System.Drawing.Size(199, 26);
            this.searchingstuphone.TabIndex = 23;
            // 
            // searchingstujob
            // 
            this.searchingstujob.Font = new System.Drawing.Font("宋体", 12F);
            this.searchingstujob.Location = new System.Drawing.Point(974, 398);
            this.searchingstujob.Margin = new System.Windows.Forms.Padding(2);
            this.searchingstujob.Name = "searchingstujob";
            this.searchingstujob.Size = new System.Drawing.Size(199, 26);
            this.searchingstujob.TabIndex = 24;
            // 
            // labelstuid
            // 
            this.labelstuid.AutoSize = true;
            this.labelstuid.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelstuid.Location = new System.Drawing.Point(969, 11);
            this.labelstuid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelstuid.Name = "labelstuid";
            this.labelstuid.Size = new System.Drawing.Size(57, 30);
            this.labelstuid.TabIndex = 25;
            this.labelstuid.Text = "学号";
            // 
            // labelstuname
            // 
            this.labelstuname.AutoSize = true;
            this.labelstuname.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelstuname.Location = new System.Drawing.Point(969, 81);
            this.labelstuname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelstuname.Name = "labelstuname";
            this.labelstuname.Size = new System.Drawing.Size(57, 30);
            this.labelstuname.TabIndex = 26;
            this.labelstuname.Text = "姓名";
            // 
            // labelstuclass
            // 
            this.labelstuclass.AutoSize = true;
            this.labelstuclass.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelstuclass.Location = new System.Drawing.Point(969, 151);
            this.labelstuclass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelstuclass.Name = "labelstuclass";
            this.labelstuclass.Size = new System.Drawing.Size(57, 30);
            this.labelstuclass.TabIndex = 27;
            this.labelstuclass.Text = "班级";
            // 
            // labelstudorm
            // 
            this.labelstudorm.AutoSize = true;
            this.labelstudorm.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelstudorm.Location = new System.Drawing.Point(969, 221);
            this.labelstudorm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelstudorm.Name = "labelstudorm";
            this.labelstudorm.Size = new System.Drawing.Size(57, 30);
            this.labelstudorm.TabIndex = 28;
            this.labelstudorm.Text = "寝室";
            // 
            // labelstuphone
            // 
            this.labelstuphone.AutoSize = true;
            this.labelstuphone.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelstuphone.Location = new System.Drawing.Point(969, 291);
            this.labelstuphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelstuphone.Name = "labelstuphone";
            this.labelstuphone.Size = new System.Drawing.Size(57, 30);
            this.labelstuphone.TabIndex = 29;
            this.labelstuphone.Text = "电话";
            // 
            // labelstujob
            // 
            this.labelstujob.AutoSize = true;
            this.labelstujob.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelstujob.Location = new System.Drawing.Point(969, 361);
            this.labelstujob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelstujob.Name = "labelstujob";
            this.labelstujob.Size = new System.Drawing.Size(57, 30);
            this.labelstujob.TabIndex = 30;
            this.labelstujob.Text = "职务";
            // 
            // stu_id
            // 
            this.stu_id.HeaderText = "学号";
            this.stu_id.MinimumWidth = 8;
            this.stu_id.Name = "stu_id";
            this.stu_id.ReadOnly = true;
            // 
            // stu_name
            // 
            this.stu_name.HeaderText = "姓名";
            this.stu_name.MinimumWidth = 8;
            this.stu_name.Name = "stu_name";
            this.stu_name.ReadOnly = true;
            // 
            // stu_class
            // 
            this.stu_class.HeaderText = "班级";
            this.stu_class.MinimumWidth = 8;
            this.stu_class.Name = "stu_class";
            this.stu_class.ReadOnly = true;
            // 
            // dorm_id
            // 
            this.dorm_id.HeaderText = "寝室";
            this.dorm_id.MinimumWidth = 8;
            this.dorm_id.Name = "dorm_id";
            this.dorm_id.ReadOnly = true;
            // 
            // stu_phone
            // 
            this.stu_phone.HeaderText = "电话";
            this.stu_phone.MinimumWidth = 8;
            this.stu_phone.Name = "stu_phone";
            this.stu_phone.ReadOnly = true;
            // 
            // stu_job
            // 
            this.stu_job.HeaderText = "职务";
            this.stu_job.MinimumWidth = 8;
            this.stu_job.Name = "stu_job";
            this.stu_job.ReadOnly = true;
            // 
            // selfrating
            // 
            this.selfrating.HeaderText = "个人纪律评分";
            this.selfrating.MinimumWidth = 8;
            this.selfrating.Name = "selfrating";
            this.selfrating.ReadOnly = true;
            // 
            // dormrating
            // 
            this.dormrating.HeaderText = "寝室纪律评分";
            this.dormrating.MinimumWidth = 8;
            this.dormrating.Name = "dormrating";
            this.dormrating.ReadOnly = true;
            // 
            // SearchingStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.ControlBox = false;
            this.Controls.Add(this.labelstujob);
            this.Controls.Add(this.labelstuphone);
            this.Controls.Add(this.labelstudorm);
            this.Controls.Add(this.labelstuclass);
            this.Controls.Add(this.labelstuname);
            this.Controls.Add(this.labelstuid);
            this.Controls.Add(this.searchingstujob);
            this.Controls.Add(this.searchingstuphone);
            this.Controls.Add(this.searchingstudorm);
            this.Controls.Add(this.searchingstuclass);
            this.Controls.Add(this.searchingstuname);
            this.Controls.Add(this.searchingstuid);
            this.Controls.Add(this.searching);
            this.Controls.Add(this.viewstudent);
            this.Controls.Add(this.Cancelbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchingStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生公寓管理系统——检索系统";
            ((System.ComponentModel.ISupportInitialize)(this.viewstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.DataGridView viewstudent;
        private System.Windows.Forms.Button searching;
        private System.Windows.Forms.TextBox searchingstuid;
        private System.Windows.Forms.TextBox searchingstuname;
        private System.Windows.Forms.TextBox searchingstuclass;
        private System.Windows.Forms.TextBox searchingstudorm;
        private System.Windows.Forms.TextBox searchingstuphone;
        private System.Windows.Forms.TextBox searchingstujob;
        private System.Windows.Forms.Label labelstuid;
        private System.Windows.Forms.Label labelstuname;
        private System.Windows.Forms.Label labelstuclass;
        private System.Windows.Forms.Label labelstudorm;
        private System.Windows.Forms.Label labelstuphone;
        private System.Windows.Forms.Label labelstujob;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn dorm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_job;
        private System.Windows.Forms.DataGridViewTextBoxColumn selfrating;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormrating;
    }
}