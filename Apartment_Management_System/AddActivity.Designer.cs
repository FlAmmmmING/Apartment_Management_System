namespace Apartment_Management_System
{
    partial class AddActivity
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
            this.adding = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.labelactsite = new System.Windows.Forms.Label();
            this.actsite = new System.Windows.Forms.TextBox();
            this.labelacttime = new System.Windows.Forms.Label();
            this.labelactdetail = new System.Windows.Forms.Label();
            this.labelactname = new System.Windows.Forms.Label();
            this.acttime = new System.Windows.Forms.TextBox();
            this.actdetail = new System.Windows.Forms.TextBox();
            this.actname = new System.Windows.Forms.TextBox();
            this.apartment_Management_SystemDataSet1 = new Apartment_Management_System.Apartment_Management_SystemDataSet();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apartment_Management_SystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // adding
            // 
            this.adding.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adding.Location = new System.Drawing.Point(440, 255);
            this.adding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(100, 33);
            this.adding.TabIndex = 83;
            this.adding.Text = "添加";
            this.adding.UseVisualStyleBackColor = true;
            this.adding.Click += new System.EventHandler(this.adding_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancelbutton.Location = new System.Drawing.Point(544, 255);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(100, 33);
            this.Cancelbutton.TabIndex = 82;
            this.Cancelbutton.Text = "退出";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // labelactsite
            // 
            this.labelactsite.AutoSize = true;
            this.labelactsite.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelactsite.Location = new System.Drawing.Point(424, 13);
            this.labelactsite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelactsite.Name = "labelactsite";
            this.labelactsite.Size = new System.Drawing.Size(111, 30);
            this.labelactsite.TabIndex = 77;
            this.labelactsite.Text = "活动地点*";
            // 
            // actsite
            // 
            this.actsite.Font = new System.Drawing.Font("宋体", 12F);
            this.actsite.Location = new System.Drawing.Point(429, 50);
            this.actsite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actsite.Name = "actsite";
            this.actsite.Size = new System.Drawing.Size(199, 26);
            this.actsite.TabIndex = 76;
            // 
            // labelacttime
            // 
            this.labelacttime.AutoSize = true;
            this.labelacttime.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelacttime.Location = new System.Drawing.Point(216, 13);
            this.labelacttime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelacttime.Name = "labelacttime";
            this.labelacttime.Size = new System.Drawing.Size(111, 30);
            this.labelacttime.TabIndex = 75;
            this.labelacttime.Text = "活动时间*";
            // 
            // labelactdetail
            // 
            this.labelactdetail.AutoSize = true;
            this.labelactdetail.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelactdetail.Location = new System.Drawing.Point(9, 85);
            this.labelactdetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelactdetail.Name = "labelactdetail";
            this.labelactdetail.Size = new System.Drawing.Size(101, 30);
            this.labelactdetail.TabIndex = 74;
            this.labelactdetail.Text = "活动梗概";
            // 
            // labelactname
            // 
            this.labelactname.AutoSize = true;
            this.labelactname.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelactname.Location = new System.Drawing.Point(8, 13);
            this.labelactname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelactname.Name = "labelactname";
            this.labelactname.Size = new System.Drawing.Size(111, 30);
            this.labelactname.TabIndex = 72;
            this.labelactname.Text = "活动名称*";
            // 
            // acttime
            // 
            this.acttime.Font = new System.Drawing.Font("宋体", 12F);
            this.acttime.Location = new System.Drawing.Point(221, 50);
            this.acttime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acttime.Name = "acttime";
            this.acttime.Size = new System.Drawing.Size(199, 26);
            this.acttime.TabIndex = 71;
            // 
            // actdetail
            // 
            this.actdetail.Font = new System.Drawing.Font("宋体", 12F);
            this.actdetail.Location = new System.Drawing.Point(14, 123);
            this.actdetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actdetail.Multiline = true;
            this.actdetail.Name = "actdetail";
            this.actdetail.Size = new System.Drawing.Size(366, 112);
            this.actdetail.TabIndex = 70;
            // 
            // actname
            // 
            this.actname.Font = new System.Drawing.Font("宋体", 12F);
            this.actname.Location = new System.Drawing.Point(13, 50);
            this.actname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actname.Name = "actname";
            this.actname.Size = new System.Drawing.Size(199, 26);
            this.actname.TabIndex = 68;
            // 
            // apartment_Management_SystemDataSet1
            // 
            this.apartment_Management_SystemDataSet1.DataSetName = "Apartment_Management_SystemDataSet";
            this.apartment_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label1.Location = new System.Drawing.Point(9, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "请注意：若您填写了该活动，则代表您是举办人";
            // 
            // AddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 296);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adding);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.labelactsite);
            this.Controls.Add(this.actsite);
            this.Controls.Add(this.labelacttime);
            this.Controls.Add(this.labelactdetail);
            this.Controls.Add(this.labelactname);
            this.Controls.Add(this.acttime);
            this.Controls.Add(this.actdetail);
            this.Controls.Add(this.actname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生公寓管理系统——活动管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.apartment_Management_SystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adding;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Label labelactsite;
        private System.Windows.Forms.TextBox actsite;
        private System.Windows.Forms.Label labelacttime;
        private System.Windows.Forms.Label labelactdetail;
        private System.Windows.Forms.Label labelactname;
        private System.Windows.Forms.TextBox acttime;
        private System.Windows.Forms.TextBox actdetail;
        private System.Windows.Forms.TextBox actname;
        private Apartment_Management_SystemDataSet apartment_Management_SystemDataSet1;
        private System.Windows.Forms.Label label1;
    }
}