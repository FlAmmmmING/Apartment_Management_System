namespace Apartment_Management_System
{
    partial class Activity
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
            this.viewact = new System.Windows.Forms.DataGridView();
            this.act_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.act_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.act_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.act_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.act_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelactivity = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.apartment_Management_SystemDataSet1 = new Apartment_Management_System.Apartment_Management_SystemDataSet();
            this.addact = new System.Windows.Forms.Button();
            this.delact = new System.Windows.Forms.Button();
            this.delactid = new System.Windows.Forms.TextBox();
            this.labeldelid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartment_Management_SystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewact
            // 
            this.viewact.AllowUserToAddRows = false;
            this.viewact.AllowUserToDeleteRows = false;
            this.viewact.AllowUserToResizeColumns = false;
            this.viewact.AllowUserToResizeRows = false;
            this.viewact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewact.ColumnHeadersHeight = 40;
            this.viewact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.act_id,
            this.act_name,
            this.act_time,
            this.act_site,
            this.stu_name,
            this.act_detail});
            this.viewact.Location = new System.Drawing.Point(16, 45);
            this.viewact.Margin = new System.Windows.Forms.Padding(2);
            this.viewact.Name = "viewact";
            this.viewact.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewact.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewact.RowHeadersVisible = false;
            this.viewact.RowHeadersWidth = 70;
            this.viewact.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewact.RowTemplate.Height = 30;
            this.viewact.Size = new System.Drawing.Size(996, 505);
            this.viewact.TabIndex = 36;
            // 
            // act_id
            // 
            this.act_id.HeaderText = "活动号";
            this.act_id.MinimumWidth = 8;
            this.act_id.Name = "act_id";
            this.act_id.ReadOnly = true;
            // 
            // act_name
            // 
            this.act_name.HeaderText = "活动名称";
            this.act_name.MinimumWidth = 8;
            this.act_name.Name = "act_name";
            this.act_name.ReadOnly = true;
            // 
            // act_time
            // 
            this.act_time.HeaderText = "活动时间";
            this.act_time.MinimumWidth = 8;
            this.act_time.Name = "act_time";
            this.act_time.ReadOnly = true;
            // 
            // act_site
            // 
            this.act_site.HeaderText = "活动地点";
            this.act_site.MinimumWidth = 8;
            this.act_site.Name = "act_site";
            this.act_site.ReadOnly = true;
            // 
            // stu_name
            // 
            this.stu_name.HeaderText = "举办人";
            this.stu_name.MinimumWidth = 8;
            this.stu_name.Name = "stu_name";
            this.stu_name.ReadOnly = true;
            // 
            // act_detail
            // 
            this.act_detail.HeaderText = "活动梗概";
            this.act_detail.MinimumWidth = 8;
            this.act_detail.Name = "act_detail";
            this.act_detail.ReadOnly = true;
            // 
            // labelactivity
            // 
            this.labelactivity.AutoSize = true;
            this.labelactivity.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelactivity.Location = new System.Drawing.Point(11, 9);
            this.labelactivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelactivity.Name = "labelactivity";
            this.labelactivity.Size = new System.Drawing.Size(101, 30);
            this.labelactivity.TabIndex = 37;
            this.labelactivity.Text = "活动列表";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancelbutton.Location = new System.Drawing.Point(1023, 517);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(150, 33);
            this.Cancelbutton.TabIndex = 38;
            this.Cancelbutton.Text = "返回";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // apartment_Management_SystemDataSet1
            // 
            this.apartment_Management_SystemDataSet1.DataSetName = "Apartment_Management_SystemDataSet";
            this.apartment_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addact
            // 
            this.addact.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addact.Location = new System.Drawing.Point(1023, 480);
            this.addact.Margin = new System.Windows.Forms.Padding(2);
            this.addact.Name = "addact";
            this.addact.Size = new System.Drawing.Size(150, 33);
            this.addact.TabIndex = 39;
            this.addact.Text = "添加活动";
            this.addact.UseVisualStyleBackColor = true;
            this.addact.Click += new System.EventHandler(this.addact_Click);
            // 
            // delact
            // 
            this.delact.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delact.Location = new System.Drawing.Point(1023, 105);
            this.delact.Margin = new System.Windows.Forms.Padding(2);
            this.delact.Name = "delact";
            this.delact.Size = new System.Drawing.Size(150, 33);
            this.delact.TabIndex = 40;
            this.delact.Text = "删除活动";
            this.delact.UseVisualStyleBackColor = true;
            this.delact.Click += new System.EventHandler(this.delact_Click);
            // 
            // delactid
            // 
            this.delactid.Location = new System.Drawing.Point(1023, 79);
            this.delactid.Name = "delactid";
            this.delactid.Size = new System.Drawing.Size(150, 21);
            this.delactid.TabIndex = 41;
            // 
            // labeldelid
            // 
            this.labeldelid.AutoSize = true;
            this.labeldelid.Cursor = System.Windows.Forms.Cursors.Default;
            this.labeldelid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeldelid.Location = new System.Drawing.Point(1019, 55);
            this.labeldelid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldelid.Name = "labeldelid";
            this.labeldelid.Size = new System.Drawing.Size(154, 21);
            this.labeldelid.TabIndex = 42;
            this.labeldelid.Text = "输入要删除的活动号";
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 557);
            this.ControlBox = false;
            this.Controls.Add(this.labeldelid);
            this.Controls.Add(this.delactid);
            this.Controls.Add(this.delact);
            this.Controls.Add(this.addact);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.labelactivity);
            this.Controls.Add(this.viewact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Activity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生公寓管理系统——活动管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.viewact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartment_Management_SystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewact;
        private System.Windows.Forms.Label labelactivity;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn act_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn act_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn act_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn act_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn act_detail;
        private Apartment_Management_SystemDataSet apartment_Management_SystemDataSet1;
        private System.Windows.Forms.Button addact;
        private System.Windows.Forms.Button delact;
        private System.Windows.Forms.TextBox delactid;
        private System.Windows.Forms.Label labeldelid;
    }
}