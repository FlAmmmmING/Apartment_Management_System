namespace Apartment_Management_System
{
    partial class RatingForm
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
            this.viewrating = new System.Windows.Forms.DataGridView();
            this.labeldate = new System.Windows.Forms.Label();
            this.labelratingid = new System.Windows.Forms.Label();
            this.ratingid = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.rule1 = new System.Windows.Forms.Label();
            this.rule2 = new System.Windows.Forms.Label();
            this.stu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dorm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_sanitary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_bedtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_behavior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewrating)).BeginInit();
            this.SuspendLayout();
            // 
            // viewrating
            // 
            this.viewrating.AllowUserToAddRows = false;
            this.viewrating.AllowUserToDeleteRows = false;
            this.viewrating.AllowUserToResizeColumns = false;
            this.viewrating.AllowUserToResizeRows = false;
            this.viewrating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewrating.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewrating.ColumnHeadersHeight = 40;
            this.viewrating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewrating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stu_id,
            this.stu_name,
            this.dorm_id,
            this.rate_sanitary,
            this.rate_bedtime,
            this.rate_behavior,
            this.detail});
            this.viewrating.Location = new System.Drawing.Point(11, 11);
            this.viewrating.Margin = new System.Windows.Forms.Padding(2);
            this.viewrating.Name = "viewrating";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewrating.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewrating.RowHeadersVisible = false;
            this.viewrating.RowHeadersWidth = 70;
            this.viewrating.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewrating.RowTemplate.Height = 30;
            this.viewrating.Size = new System.Drawing.Size(1158, 455);
            this.viewrating.TabIndex = 14;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labeldate.Location = new System.Drawing.Point(11, 488);
            this.labeldate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(40, 20);
            this.labeldate.TabIndex = 29;
            this.labeldate.Text = "日期:";
            // 
            // labelratingid
            // 
            this.labelratingid.AutoSize = true;
            this.labelratingid.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelratingid.Location = new System.Drawing.Point(11, 468);
            this.labelratingid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelratingid.Name = "labelratingid";
            this.labelratingid.Size = new System.Drawing.Size(40, 20);
            this.labelratingid.TabIndex = 30;
            this.labelratingid.Text = "单号:";
            // 
            // ratingid
            // 
            this.ratingid.AutoSize = true;
            this.ratingid.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.ratingid.Location = new System.Drawing.Point(55, 468);
            this.ratingid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ratingid.Name = "ratingid";
            this.ratingid.Size = new System.Drawing.Size(42, 20);
            this.ratingid.TabIndex = 31;
            this.ratingid.Text = "label";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.date.Location = new System.Drawing.Point(55, 488);
            this.date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 20);
            this.date.TabIndex = 32;
            this.date.Text = "label";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancelbutton.Location = new System.Drawing.Point(1069, 513);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(100, 33);
            this.Cancelbutton.TabIndex = 33;
            this.Cancelbutton.Text = "取消";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit.Location = new System.Drawing.Point(965, 513);
            this.submit.Margin = new System.Windows.Forms.Padding(2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 33);
            this.submit.TabIndex = 34;
            this.submit.Text = "提交评分单";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // rule1
            // 
            this.rule1.AutoSize = true;
            this.rule1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.rule1.Location = new System.Drawing.Point(11, 508);
            this.rule1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rule1.Name = "rule1";
            this.rule1.Size = new System.Drawing.Size(363, 20);
            this.rule1.TabIndex = 35;
            this.rule1.Text = "卫生分，就寝分，行为分请填写对应整数分数(0 ~ 100分)";
            // 
            // rule2
            // 
            this.rule2.AutoSize = true;
            this.rule2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.rule2.Location = new System.Drawing.Point(11, 528);
            this.rule2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rule2.Name = "rule2";
            this.rule2.Size = new System.Drawing.Size(93, 20);
            this.rule2.TabIndex = 37;
            this.rule2.Text = "请谨慎评价！";
            // 
            // stu_id
            // 
            this.stu_id.HeaderText = "学生学号";
            this.stu_id.Name = "stu_id";
            this.stu_id.ReadOnly = true;
            // 
            // stu_name
            // 
            this.stu_name.HeaderText = "学生姓名";
            this.stu_name.Name = "stu_name";
            this.stu_name.ReadOnly = true;
            // 
            // dorm_id
            // 
            this.dorm_id.HeaderText = "寝室号";
            this.dorm_id.Name = "dorm_id";
            this.dorm_id.ReadOnly = true;
            // 
            // rate_sanitary
            // 
            this.rate_sanitary.HeaderText = "卫生分";
            this.rate_sanitary.Name = "rate_sanitary";
            this.rate_sanitary.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // rate_bedtime
            // 
            this.rate_bedtime.HeaderText = "就寝分";
            this.rate_bedtime.Name = "rate_bedtime";
            // 
            // rate_behavior
            // 
            this.rate_behavior.HeaderText = "行为分";
            this.rate_behavior.Name = "rate_behavior";
            // 
            // detail
            // 
            this.detail.HeaderText = "备注";
            this.detail.Name = "detail";
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 557);
            this.ControlBox = false;
            this.Controls.Add(this.rule2);
            this.Controls.Add(this.rule1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ratingid);
            this.Controls.Add(this.labelratingid);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.viewrating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生公寓管理系统——评分评价系统";
            ((System.ComponentModel.ISupportInitialize)(this.viewrating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewrating;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labelratingid;
        private System.Windows.Forms.Label ratingid;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label rule1;
        private System.Windows.Forms.Label rule2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dorm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_sanitary;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_bedtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_behavior;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
    }
}