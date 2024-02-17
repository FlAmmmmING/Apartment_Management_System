namespace Apartment_Management_System
{
    partial class Login
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
            this.Title = new System.Windows.Forms.Label();
            this.IDTitle = new System.Windows.Forms.Label();
            this.PasswordTitle = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.StudentSelect = new System.Windows.Forms.RadioButton();
            this.EmployeeSelect = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("华文新魏", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(170, 60);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(659, 53);
            this.Title.TabIndex = 0;
            this.Title.Text = "欢迎使用学生公寓管理系统";
            // 
            // IDTitle
            // 
            this.IDTitle.AutoSize = true;
            this.IDTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDTitle.Location = new System.Drawing.Point(316, 153);
            this.IDTitle.Name = "IDTitle";
            this.IDTitle.Size = new System.Drawing.Size(82, 31);
            this.IDTitle.TabIndex = 1;
            this.IDTitle.Text = "账  号:";
            // 
            // PasswordTitle
            // 
            this.PasswordTitle.AutoSize = true;
            this.PasswordTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTitle.Location = new System.Drawing.Point(316, 205);
            this.PasswordTitle.Name = "PasswordTitle";
            this.PasswordTitle.Size = new System.Drawing.Size(82, 31);
            this.PasswordTitle.TabIndex = 2;
            this.PasswordTitle.Text = "密  码:";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("宋体", 12F);
            this.ID.Location = new System.Drawing.Point(404, 154);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(250, 35);
            this.ID.TabIndex = 3;
            // 
            // PassWord
            // 
            this.PassWord.Font = new System.Drawing.Font("宋体", 12F);
            this.PassWord.Location = new System.Drawing.Point(403, 205);
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(250, 35);
            this.PassWord.TabIndex = 4;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Loginbutton.Location = new System.Drawing.Point(321, 297);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(150, 50);
            this.Loginbutton.TabIndex = 5;
            this.Loginbutton.Text = "登录";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancelbutton.Location = new System.Drawing.Point(503, 297);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(150, 50);
            this.Cancelbutton.TabIndex = 6;
            this.Cancelbutton.Text = "取消";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // StudentSelect
            // 
            this.StudentSelect.AutoSize = true;
            this.StudentSelect.Checked = true;
            this.StudentSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentSelect.Location = new System.Drawing.Point(403, 256);
            this.StudentSelect.Name = "StudentSelect";
            this.StudentSelect.Size = new System.Drawing.Size(107, 28);
            this.StudentSelect.TabIndex = 7;
            this.StudentSelect.TabStop = true;
            this.StudentSelect.Text = "学生选项";
            this.StudentSelect.UseVisualStyleBackColor = true;
            // 
            // EmployeeSelect
            // 
            this.EmployeeSelect.AutoSize = true;
            this.EmployeeSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EmployeeSelect.Location = new System.Drawing.Point(547, 256);
            this.EmployeeSelect.Name = "EmployeeSelect";
            this.EmployeeSelect.Size = new System.Drawing.Size(107, 28);
            this.EmployeeSelect.TabIndex = 8;
            this.EmployeeSelect.Text = "职工选项";
            this.EmployeeSelect.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 444);
            this.ControlBox = false;
            this.Controls.Add(this.EmployeeSelect);
            this.Controls.Add(this.StudentSelect);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.PasswordTitle);
            this.Controls.Add(this.IDTitle);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生公寓管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label IDTitle;
        private System.Windows.Forms.Label PasswordTitle;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.RadioButton StudentSelect;
        private System.Windows.Forms.RadioButton EmployeeSelect;
    }
}