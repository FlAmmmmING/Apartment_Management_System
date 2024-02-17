namespace Apartment_Management_System
{
    partial class StudentUnion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.viewstu = new System.Windows.Forms.DataGridView();
            this.labelmember = new System.Windows.Forms.Label();
            this.stu_job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dorm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intro1 = new System.Windows.Forms.Label();
            this.intro2 = new System.Windows.Forms.Label();
            this.intro3 = new System.Windows.Forms.Label();
            this.intro4 = new System.Windows.Forms.Label();
            this.intro5 = new System.Windows.Forms.Label();
            this.intro6 = new System.Windows.Forms.Label();
            this.intro7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewstu)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancelbutton.Location = new System.Drawing.Point(1069, 513);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(100, 33);
            this.Cancelbutton.TabIndex = 34;
            this.Cancelbutton.Text = "退出";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // viewstu
            // 
            this.viewstu.AllowUserToAddRows = false;
            this.viewstu.AllowUserToDeleteRows = false;
            this.viewstu.AllowUserToResizeColumns = false;
            this.viewstu.AllowUserToResizeRows = false;
            this.viewstu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewstu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.viewstu.ColumnHeadersHeight = 40;
            this.viewstu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewstu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stu_job,
            this.stu_name,
            this.stu_phone,
            this.dorm_id,
            this.stu_class});
            this.viewstu.Location = new System.Drawing.Point(11, 41);
            this.viewstu.Margin = new System.Windows.Forms.Padding(2);
            this.viewstu.Name = "viewstu";
            this.viewstu.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewstu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.viewstu.RowHeadersVisible = false;
            this.viewstu.RowHeadersWidth = 70;
            this.viewstu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewstu.RowTemplate.Height = 30;
            this.viewstu.Size = new System.Drawing.Size(748, 505);
            this.viewstu.TabIndex = 35;
            // 
            // labelmember
            // 
            this.labelmember.AutoSize = true;
            this.labelmember.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelmember.Location = new System.Drawing.Point(11, 9);
            this.labelmember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelmember.Name = "labelmember";
            this.labelmember.Size = new System.Drawing.Size(101, 30);
            this.labelmember.TabIndex = 36;
            this.labelmember.Text = "成员列表";
            // 
            // stu_job
            // 
            this.stu_job.HeaderText = "职位";
            this.stu_job.Name = "stu_job";
            this.stu_job.ReadOnly = true;
            // 
            // stu_name
            // 
            this.stu_name.HeaderText = "姓名";
            this.stu_name.Name = "stu_name";
            this.stu_name.ReadOnly = true;
            // 
            // stu_phone
            // 
            this.stu_phone.HeaderText = "联系方式";
            this.stu_phone.Name = "stu_phone";
            this.stu_phone.ReadOnly = true;
            // 
            // dorm_id
            // 
            this.dorm_id.HeaderText = "寝室号";
            this.dorm_id.Name = "dorm_id";
            this.dorm_id.ReadOnly = true;
            // 
            // stu_class
            // 
            this.stu_class.HeaderText = "班级";
            this.stu_class.Name = "stu_class";
            this.stu_class.ReadOnly = true;
            // 
            // intro1
            // 
            this.intro1.AutoSize = true;
            this.intro1.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro1.Location = new System.Drawing.Point(763, 41);
            this.intro1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro1.Name = "intro1";
            this.intro1.Size = new System.Drawing.Size(123, 30);
            this.intro1.TabIndex = 37;
            this.intro1.Text = "学生会介绍";
            // 
            // intro2
            // 
            this.intro2.AutoSize = true;
            this.intro2.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro2.Location = new System.Drawing.Point(763, 71);
            this.intro2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro2.Name = "intro2";
            this.intro2.Size = new System.Drawing.Size(343, 30);
            this.intro2.TabIndex = 38;
            this.intro2.Text = "我们的任务旨在丰富学生课余生活";
            // 
            // intro3
            // 
            this.intro3.AutoSize = true;
            this.intro3.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro3.Location = new System.Drawing.Point(763, 101);
            this.intro3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro3.Name = "intro3";
            this.intro3.Size = new System.Drawing.Size(233, 30);
            this.intro3.TabIndex = 39;
            this.intro3.Text = "增进学生公寓邻里关系";
            // 
            // intro4
            // 
            this.intro4.AutoSize = true;
            this.intro4.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro4.Location = new System.Drawing.Point(763, 131);
            this.intro4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro4.Name = "intro4";
            this.intro4.Size = new System.Drawing.Size(365, 30);
            this.intro4.TabIndex = 40;
            this.intro4.Text = "我们主要负责组织策划学生公寓活动";
            // 
            // intro5
            // 
            this.intro5.AutoSize = true;
            this.intro5.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro5.Location = new System.Drawing.Point(763, 161);
            this.intro5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro5.Name = "intro5";
            this.intro5.Size = new System.Drawing.Size(321, 30);
            this.intro5.TabIndex = 41;
            this.intro5.Text = "同时负责定期询问整理学生诉求";
            // 
            // intro6
            // 
            this.intro6.AutoSize = true;
            this.intro6.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro6.Location = new System.Drawing.Point(763, 191);
            this.intro6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro6.Name = "intro6";
            this.intro6.Size = new System.Drawing.Size(409, 30);
            this.intro6.TabIndex = 42;
            this.intro6.Text = "希望能够通过我们的努力让公寓越来越好";
            // 
            // intro7
            // 
            this.intro7.AutoSize = true;
            this.intro7.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro7.Location = new System.Drawing.Point(763, 221);
            this.intro7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro7.Name = "intro7";
            this.intro7.Size = new System.Drawing.Size(387, 30);
            this.intro7.TabIndex = 43;
            this.intro7.Text = "有意加入我们的同学请联系学生会会长";
            // 
            // StudentUnion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 557);
            this.ControlBox = false;
            this.Controls.Add(this.intro7);
            this.Controls.Add(this.intro6);
            this.Controls.Add(this.intro5);
            this.Controls.Add(this.intro4);
            this.Controls.Add(this.intro3);
            this.Controls.Add(this.intro2);
            this.Controls.Add(this.intro1);
            this.Controls.Add(this.labelmember);
            this.Controls.Add(this.viewstu);
            this.Controls.Add(this.Cancelbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StudentUnion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生公寓管理系统——学生会";
            ((System.ComponentModel.ISupportInitialize)(this.viewstu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.DataGridView viewstu;
        private System.Windows.Forms.Label labelmember;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_job;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dorm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_class;
        private System.Windows.Forms.Label intro1;
        private System.Windows.Forms.Label intro2;
        private System.Windows.Forms.Label intro3;
        private System.Windows.Forms.Label intro4;
        private System.Windows.Forms.Label intro5;
        private System.Windows.Forms.Label intro6;
        private System.Windows.Forms.Label intro7;
    }
}