namespace Apartment_Management_System
{
    partial class VisitorFormEmp
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
            this.viewvisitor = new System.Windows.Forms.DataGridView();
            this.vis_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vis_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vis_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vis_start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vis_finish_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vis_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vis_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.labelempid = new System.Windows.Forms.Label();
            this.labelvisphone = new System.Windows.Forms.Label();
            this.labelvisdate = new System.Windows.Forms.Label();
            this.labelstuname = new System.Windows.Forms.Label();
            this.labelvisname = new System.Windows.Forms.Label();
            this.labelvisid = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.TextBox();
            this.visphone = new System.Windows.Forms.TextBox();
            this.visdate = new System.Windows.Forms.TextBox();
            this.stuname = new System.Windows.Forms.TextBox();
            this.visname = new System.Windows.Forms.TextBox();
            this.visid = new System.Windows.Forms.TextBox();
            this.searching = new System.Windows.Forms.Button();
            this.labelempname = new System.Windows.Forms.Label();
            this.empname = new System.Windows.Forms.TextBox();
            this.adding = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewvisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // viewvisitor
            // 
            this.viewvisitor.AllowUserToAddRows = false;
            this.viewvisitor.AllowUserToDeleteRows = false;
            this.viewvisitor.AllowUserToResizeColumns = false;
            this.viewvisitor.AllowUserToResizeRows = false;
            this.viewvisitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewvisitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewvisitor.ColumnHeadersHeight = 40;
            this.viewvisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewvisitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vis_id,
            this.vis_name,
            this.stu_name,
            this.vis_date,
            this.vis_start_time,
            this.vis_finish_time,
            this.vis_phone,
            this.vis_detail,
            this.emp_id,
            this.emp_name});
            this.viewvisitor.Location = new System.Drawing.Point(11, 11);
            this.viewvisitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewvisitor.Name = "viewvisitor";
            this.viewvisitor.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewvisitor.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewvisitor.RowHeadersVisible = false;
            this.viewvisitor.RowHeadersWidth = 70;
            this.viewvisitor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewvisitor.RowTemplate.Height = 30;
            this.viewvisitor.Size = new System.Drawing.Size(954, 539);
            this.viewvisitor.TabIndex = 9;
            // 
            // vis_id
            // 
            this.vis_id.HeaderText = "访问登记号";
            this.vis_id.MinimumWidth = 8;
            this.vis_id.Name = "vis_id";
            this.vis_id.ReadOnly = true;
            // 
            // vis_name
            // 
            this.vis_name.HeaderText = "访问者姓名";
            this.vis_name.MinimumWidth = 8;
            this.vis_name.Name = "vis_name";
            this.vis_name.ReadOnly = true;
            // 
            // stu_name
            // 
            this.stu_name.HeaderText = "被访者姓名";
            this.stu_name.MinimumWidth = 8;
            this.stu_name.Name = "stu_name";
            this.stu_name.ReadOnly = true;
            // 
            // vis_date
            // 
            this.vis_date.HeaderText = "访问日期";
            this.vis_date.MinimumWidth = 8;
            this.vis_date.Name = "vis_date";
            this.vis_date.ReadOnly = true;
            // 
            // vis_start_time
            // 
            this.vis_start_time.HeaderText = "开始时间";
            this.vis_start_time.MinimumWidth = 8;
            this.vis_start_time.Name = "vis_start_time";
            this.vis_start_time.ReadOnly = true;
            // 
            // vis_finish_time
            // 
            this.vis_finish_time.HeaderText = "结束时间";
            this.vis_finish_time.MinimumWidth = 8;
            this.vis_finish_time.Name = "vis_finish_time";
            this.vis_finish_time.ReadOnly = true;
            // 
            // vis_phone
            // 
            this.vis_phone.HeaderText = "访问者电话";
            this.vis_phone.MinimumWidth = 8;
            this.vis_phone.Name = "vis_phone";
            this.vis_phone.ReadOnly = true;
            // 
            // vis_detail
            // 
            this.vis_detail.HeaderText = "访问事宜";
            this.vis_detail.MinimumWidth = 8;
            this.vis_detail.Name = "vis_detail";
            this.vis_detail.ReadOnly = true;
            // 
            // emp_id
            // 
            this.emp_id.HeaderText = "处理职工工号";
            this.emp_id.MinimumWidth = 8;
            this.emp_id.Name = "emp_id";
            this.emp_id.ReadOnly = true;
            // 
            // emp_name
            // 
            this.emp_name.HeaderText = "处理职工姓名";
            this.emp_name.MinimumWidth = 8;
            this.emp_name.Name = "emp_name";
            this.emp_name.ReadOnly = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancelbutton.Location = new System.Drawing.Point(1113, 517);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(60, 33);
            this.Cancelbutton.TabIndex = 10;
            this.Cancelbutton.Text = "退出";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // labelempid
            // 
            this.labelempid.AutoSize = true;
            this.labelempid.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelempid.Location = new System.Drawing.Point(969, 361);
            this.labelempid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelempid.Name = "labelempid";
            this.labelempid.Size = new System.Drawing.Size(189, 30);
            this.labelempid.TabIndex = 43;
            this.labelempid.Text = "处理信息职工工号";
            // 
            // labelvisphone
            // 
            this.labelvisphone.AutoSize = true;
            this.labelvisphone.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelvisphone.Location = new System.Drawing.Point(969, 291);
            this.labelvisphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelvisphone.Name = "labelvisphone";
            this.labelvisphone.Size = new System.Drawing.Size(123, 30);
            this.labelvisphone.TabIndex = 42;
            this.labelvisphone.Text = "访问者电话";
            // 
            // labelvisdate
            // 
            this.labelvisdate.AutoSize = true;
            this.labelvisdate.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelvisdate.Location = new System.Drawing.Point(969, 221);
            this.labelvisdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelvisdate.Name = "labelvisdate";
            this.labelvisdate.Size = new System.Drawing.Size(101, 30);
            this.labelvisdate.TabIndex = 41;
            this.labelvisdate.Text = "访问日期";
            // 
            // labelstuname
            // 
            this.labelstuname.AutoSize = true;
            this.labelstuname.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelstuname.Location = new System.Drawing.Point(969, 151);
            this.labelstuname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelstuname.Name = "labelstuname";
            this.labelstuname.Size = new System.Drawing.Size(123, 30);
            this.labelstuname.TabIndex = 40;
            this.labelstuname.Text = "被访者姓名";
            // 
            // labelvisname
            // 
            this.labelvisname.AutoSize = true;
            this.labelvisname.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelvisname.Location = new System.Drawing.Point(969, 81);
            this.labelvisname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelvisname.Name = "labelvisname";
            this.labelvisname.Size = new System.Drawing.Size(123, 30);
            this.labelvisname.TabIndex = 39;
            this.labelvisname.Text = "访问者姓名";
            // 
            // labelvisid
            // 
            this.labelvisid.AutoSize = true;
            this.labelvisid.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelvisid.Location = new System.Drawing.Point(969, 11);
            this.labelvisid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelvisid.Name = "labelvisid";
            this.labelvisid.Size = new System.Drawing.Size(123, 30);
            this.labelvisid.TabIndex = 38;
            this.labelvisid.Text = "访问登记号";
            // 
            // empid
            // 
            this.empid.Font = new System.Drawing.Font("宋体", 12F);
            this.empid.Location = new System.Drawing.Point(974, 398);
            this.empid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(199, 26);
            this.empid.TabIndex = 37;
            // 
            // visphone
            // 
            this.visphone.Font = new System.Drawing.Font("宋体", 12F);
            this.visphone.Location = new System.Drawing.Point(974, 328);
            this.visphone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visphone.Name = "visphone";
            this.visphone.Size = new System.Drawing.Size(199, 26);
            this.visphone.TabIndex = 36;
            // 
            // visdate
            // 
            this.visdate.Font = new System.Drawing.Font("宋体", 12F);
            this.visdate.Location = new System.Drawing.Point(974, 258);
            this.visdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visdate.Name = "visdate";
            this.visdate.Size = new System.Drawing.Size(199, 26);
            this.visdate.TabIndex = 35;
            // 
            // stuname
            // 
            this.stuname.Font = new System.Drawing.Font("宋体", 12F);
            this.stuname.Location = new System.Drawing.Point(974, 188);
            this.stuname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stuname.Name = "stuname";
            this.stuname.Size = new System.Drawing.Size(199, 26);
            this.stuname.TabIndex = 34;
            // 
            // visname
            // 
            this.visname.Font = new System.Drawing.Font("宋体", 12F);
            this.visname.Location = new System.Drawing.Point(974, 118);
            this.visname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visname.Name = "visname";
            this.visname.Size = new System.Drawing.Size(199, 26);
            this.visname.TabIndex = 33;
            // 
            // visid
            // 
            this.visid.Font = new System.Drawing.Font("宋体", 12F);
            this.visid.Location = new System.Drawing.Point(974, 48);
            this.visid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visid.Name = "visid";
            this.visid.Size = new System.Drawing.Size(199, 26);
            this.visid.TabIndex = 32;
            // 
            // searching
            // 
            this.searching.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searching.Location = new System.Drawing.Point(1053, 517);
            this.searching.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searching.Name = "searching";
            this.searching.Size = new System.Drawing.Size(60, 33);
            this.searching.TabIndex = 31;
            this.searching.Text = "检索";
            this.searching.UseVisualStyleBackColor = true;
            this.searching.Click += new System.EventHandler(this.searching_Click);
            // 
            // labelempname
            // 
            this.labelempname.AutoSize = true;
            this.labelempname.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelempname.Location = new System.Drawing.Point(969, 431);
            this.labelempname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelempname.Name = "labelempname";
            this.labelempname.Size = new System.Drawing.Size(189, 30);
            this.labelempname.TabIndex = 44;
            this.labelempname.Text = "处理信息职工姓名";
            // 
            // empname
            // 
            this.empname.Font = new System.Drawing.Font("宋体", 12F);
            this.empname.Location = new System.Drawing.Point(974, 468);
            this.empname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(199, 26);
            this.empname.TabIndex = 45;
            // 
            // adding
            // 
            this.adding.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adding.Location = new System.Drawing.Point(974, 517);
            this.adding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(75, 33);
            this.adding.TabIndex = 46;
            this.adding.Text = "添加系统";
            this.adding.UseVisualStyleBackColor = true;
            this.adding.Click += new System.EventHandler(this.adding_Click);
            // 
            // VisitorFormEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.ControlBox = false;
            this.Controls.Add(this.adding);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.labelempname);
            this.Controls.Add(this.labelempid);
            this.Controls.Add(this.labelvisphone);
            this.Controls.Add(this.labelvisdate);
            this.Controls.Add(this.labelstuname);
            this.Controls.Add(this.labelvisname);
            this.Controls.Add(this.labelvisid);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.visphone);
            this.Controls.Add(this.visdate);
            this.Controls.Add(this.stuname);
            this.Controls.Add(this.visname);
            this.Controls.Add(this.visid);
            this.Controls.Add(this.searching);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.viewvisitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VisitorFormEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生公寓管理系统——外来人员访问系统";
            ((System.ComponentModel.ISupportInitialize)(this.viewvisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewvisitor;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Label labelempid;
        private System.Windows.Forms.Label labelvisphone;
        private System.Windows.Forms.Label labelvisdate;
        private System.Windows.Forms.Label labelstuname;
        private System.Windows.Forms.Label labelvisname;
        private System.Windows.Forms.Label labelvisid;
        private System.Windows.Forms.TextBox empid;
        private System.Windows.Forms.TextBox visphone;
        private System.Windows.Forms.TextBox visdate;
        private System.Windows.Forms.TextBox stuname;
        private System.Windows.Forms.TextBox visname;
        private System.Windows.Forms.TextBox visid;
        private System.Windows.Forms.Button searching;
        private System.Windows.Forms.Label labelempname;
        private System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn vis_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vis_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vis_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn vis_start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn vis_finish_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn vis_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn vis_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_name;
        private System.Windows.Forms.Button adding;
    }
}