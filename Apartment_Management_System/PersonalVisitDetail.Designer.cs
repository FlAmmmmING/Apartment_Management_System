namespace Apartment_Management_System
{
    partial class PersonalVisitDetail
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
            this.viewrating = new System.Windows.Forms.DataGridView();
            this.visid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visstarttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visfinishtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewrating)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancelbutton.Location = new System.Drawing.Point(1069, 513);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(100, 33);
            this.Cancelbutton.TabIndex = 12;
            this.Cancelbutton.Text = "返回";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
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
            this.visid,
            this.visitname,
            this.visdate,
            this.visstarttime,
            this.visfinishtime,
            this.visitorphone,
            this.detail,
            this.empname});
            this.viewrating.Location = new System.Drawing.Point(11, 11);
            this.viewrating.Margin = new System.Windows.Forms.Padding(2);
            this.viewrating.Name = "viewrating";
            this.viewrating.ReadOnly = true;
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
            this.viewrating.Size = new System.Drawing.Size(1158, 420);
            this.viewrating.TabIndex = 13;
            // 
            // visid
            // 
            this.visid.HeaderText = "访问单号";
            this.visid.Name = "visid";
            this.visid.ReadOnly = true;
            // 
            // visitname
            // 
            this.visitname.HeaderText = "访问者姓名";
            this.visitname.Name = "visitname";
            this.visitname.ReadOnly = true;
            // 
            // visdate
            // 
            this.visdate.HeaderText = "访问日期";
            this.visdate.Name = "visdate";
            this.visdate.ReadOnly = true;
            // 
            // visstarttime
            // 
            this.visstarttime.HeaderText = "访问开始时间";
            this.visstarttime.Name = "visstarttime";
            this.visstarttime.ReadOnly = true;
            // 
            // visfinishtime
            // 
            this.visfinishtime.HeaderText = "访问结束时间";
            this.visfinishtime.Name = "visfinishtime";
            this.visfinishtime.ReadOnly = true;
            // 
            // visitorphone
            // 
            this.visitorphone.HeaderText = "访问者电话";
            this.visitorphone.Name = "visitorphone";
            this.visitorphone.ReadOnly = true;
            // 
            // detail
            // 
            this.detail.HeaderText = "备注";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            // 
            // empname
            // 
            this.empname.HeaderText = "批准职工";
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            // 
            // PersonalVisitDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 557);
            this.ControlBox = false;
            this.Controls.Add(this.viewrating);
            this.Controls.Add(this.Cancelbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PersonalVisitDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生公寓管理系统——外来人员访问系统";
            ((System.ComponentModel.ISupportInitialize)(this.viewrating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.DataGridView viewrating;
        private System.Windows.Forms.DataGridViewTextBoxColumn visid;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitname;
        private System.Windows.Forms.DataGridViewTextBoxColumn visdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn visstarttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn visfinishtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
    }
}