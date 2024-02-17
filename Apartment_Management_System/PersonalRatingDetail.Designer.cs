namespace Apartment_Management_System
{
    partial class PersonalRatingDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewrating = new System.Windows.Forms.DataGridView();
            this.rateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratesanitary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratebedtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratebehavior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.intro1 = new System.Windows.Forms.Label();
            this.intro2 = new System.Windows.Forms.Label();
            this.intro3 = new System.Windows.Forms.Label();
            this.intro4 = new System.Windows.Forms.Label();
            this.intro5 = new System.Windows.Forms.Label();
            this.intro6 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewrating.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewrating.ColumnHeadersHeight = 40;
            this.viewrating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewrating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rateid,
            this.ratesanitary,
            this.ratebedtime,
            this.ratebehavior,
            this.empname,
            this.ratedate,
            this.detail});
            this.viewrating.Location = new System.Drawing.Point(11, 11);
            this.viewrating.Margin = new System.Windows.Forms.Padding(2);
            this.viewrating.Name = "viewrating";
            this.viewrating.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewrating.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.viewrating.RowHeadersVisible = false;
            this.viewrating.RowHeadersWidth = 70;
            this.viewrating.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewrating.RowTemplate.Height = 30;
            this.viewrating.Size = new System.Drawing.Size(1158, 420);
            this.viewrating.TabIndex = 10;
            // 
            // rateid
            // 
            this.rateid.HeaderText = "评分单号";
            this.rateid.MinimumWidth = 8;
            this.rateid.Name = "rateid";
            this.rateid.ReadOnly = true;
            // 
            // ratesanitary
            // 
            this.ratesanitary.HeaderText = "卫生分";
            this.ratesanitary.MinimumWidth = 8;
            this.ratesanitary.Name = "ratesanitary";
            this.ratesanitary.ReadOnly = true;
            // 
            // ratebedtime
            // 
            this.ratebedtime.HeaderText = "就寝分";
            this.ratebedtime.MinimumWidth = 8;
            this.ratebedtime.Name = "ratebedtime";
            this.ratebedtime.ReadOnly = true;
            // 
            // ratebehavior
            // 
            this.ratebehavior.HeaderText = "行为分";
            this.ratebehavior.MinimumWidth = 8;
            this.ratebehavior.Name = "ratebehavior";
            this.ratebehavior.ReadOnly = true;
            // 
            // empname
            // 
            this.empname.HeaderText = "评分职工";
            this.empname.MinimumWidth = 8;
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            // 
            // ratedate
            // 
            this.ratedate.HeaderText = "评分日期";
            this.ratedate.MinimumWidth = 8;
            this.ratedate.Name = "ratedate";
            this.ratedate.ReadOnly = true;
            // 
            // detail
            // 
            this.detail.HeaderText = "备注";
            this.detail.MinimumWidth = 8;
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancelbutton.Location = new System.Drawing.Point(1069, 513);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(100, 33);
            this.Cancelbutton.TabIndex = 11;
            this.Cancelbutton.Text = "返回";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // intro1
            // 
            this.intro1.AutoSize = true;
            this.intro1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro1.Location = new System.Drawing.Point(11, 433);
            this.intro1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro1.Name = "intro1";
            this.intro1.Size = new System.Drawing.Size(107, 20);
            this.intro1.TabIndex = 57;
            this.intro1.Text = "总分计算方式：";
            // 
            // intro2
            // 
            this.intro2.AutoSize = true;
            this.intro2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro2.Location = new System.Drawing.Point(11, 453);
            this.intro2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro2.Name = "intro2";
            this.intro2.Size = new System.Drawing.Size(375, 20);
            this.intro2.TabIndex = 58;
            this.intro2.Text = "总分 = (卫生分平均分 + 就寝分平均分 + 行为分平均分) / 3";
            // 
            // intro3
            // 
            this.intro3.AutoSize = true;
            this.intro3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro3.Location = new System.Drawing.Point(11, 473);
            this.intro3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro3.Name = "intro3";
            this.intro3.Size = new System.Drawing.Size(278, 20);
            this.intro3.TabIndex = 59;
            this.intro3.Text = "个人评价分期末将折算成综测，折算方式为:";
            // 
            // intro4
            // 
            this.intro4.AutoSize = true;
            this.intro4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro4.Location = new System.Drawing.Point(11, 493);
            this.intro4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro4.Name = "intro4";
            this.intro4.Size = new System.Drawing.Size(397, 20);
            this.intro4.TabIndex = 60;
            this.intro4.Text = "score >= 90 4.0, 85 <= score < 90 3.7, 80 <= score < 85 3.3";
            // 
            // intro5
            // 
            this.intro5.AutoSize = true;
            this.intro5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro5.Location = new System.Drawing.Point(11, 513);
            this.intro5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro5.Name = "intro5";
            this.intro5.Size = new System.Drawing.Size(431, 20);
            this.intro5.TabIndex = 61;
            this.intro5.Text = "75 <= score < 80 3.0, 70 <= score < 75 2.7, 65 <= score < 70 2.3";
            // 
            // intro6
            // 
            this.intro6.AutoSize = true;
            this.intro6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro6.Location = new System.Drawing.Point(11, 530);
            this.intro6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intro6.Name = "intro6";
            this.intro6.Size = new System.Drawing.Size(233, 20);
            this.intro6.TabIndex = 62;
            this.intro6.Text = "60 <= score < 65 1.5, score < 60 0";
            // 
            // PersonalRatingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 557);
            this.ControlBox = false;
            this.Controls.Add(this.intro6);
            this.Controls.Add(this.intro5);
            this.Controls.Add(this.intro4);
            this.Controls.Add(this.intro3);
            this.Controls.Add(this.intro2);
            this.Controls.Add(this.intro1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.viewrating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PersonalRatingDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生公寓管理系统——评分评价系统";
            ((System.ComponentModel.ISupportInitialize)(this.viewrating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewrating;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratesanitary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratebedtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratebehavior;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Label intro1;
        private System.Windows.Forms.Label intro2;
        private System.Windows.Forms.Label intro3;
        private System.Windows.Forms.Label intro4;
        private System.Windows.Forms.Label intro5;
        private System.Windows.Forms.Label intro6;
    }
}