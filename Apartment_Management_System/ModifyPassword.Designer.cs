namespace Apartment_Management_System
{
    partial class ModifyPassword
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
            this.exit = new System.Windows.Forms.Button();
            this.labelempname = new System.Windows.Forms.Label();
            this.labelmodify = new System.Windows.Forms.Label();
            this.labelconform = new System.Windows.Forms.Label();
            this.originalpassword = new System.Windows.Forms.TextBox();
            this.modifiedpassword = new System.Windows.Forms.TextBox();
            this.conformpassword = new System.Windows.Forms.TextBox();
            this.buttonconform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.exit.Location = new System.Drawing.Point(509, 308);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(200, 50);
            this.exit.TabIndex = 14;
            this.exit.Text = "返回";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // labelempname
            // 
            this.labelempname.AutoSize = true;
            this.labelempname.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelempname.Location = new System.Drawing.Point(275, 61);
            this.labelempname.Name = "labelempname";
            this.labelempname.Size = new System.Drawing.Size(178, 41);
            this.labelempname.TabIndex = 15;
            this.labelempname.Text = "当前密码：";
            // 
            // labelmodify
            // 
            this.labelmodify.AutoSize = true;
            this.labelmodify.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelmodify.Location = new System.Drawing.Point(275, 121);
            this.labelmodify.Name = "labelmodify";
            this.labelmodify.Size = new System.Drawing.Size(178, 41);
            this.labelmodify.TabIndex = 16;
            this.labelmodify.Text = "修改密码：";
            // 
            // labelconform
            // 
            this.labelconform.AutoSize = true;
            this.labelconform.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelconform.Location = new System.Drawing.Point(275, 181);
            this.labelconform.Name = "labelconform";
            this.labelconform.Size = new System.Drawing.Size(178, 41);
            this.labelconform.TabIndex = 17;
            this.labelconform.Text = "再次确认：";
            // 
            // originalpassword
            // 
            this.originalpassword.Font = new System.Drawing.Font("宋体", 12F);
            this.originalpassword.Location = new System.Drawing.Point(459, 67);
            this.originalpassword.Name = "originalpassword";
            this.originalpassword.PasswordChar = '*';
            this.originalpassword.Size = new System.Drawing.Size(250, 35);
            this.originalpassword.TabIndex = 18;
            // 
            // modifiedpassword
            // 
            this.modifiedpassword.Font = new System.Drawing.Font("宋体", 12F);
            this.modifiedpassword.Location = new System.Drawing.Point(459, 127);
            this.modifiedpassword.Name = "modifiedpassword";
            this.modifiedpassword.PasswordChar = '*';
            this.modifiedpassword.Size = new System.Drawing.Size(250, 35);
            this.modifiedpassword.TabIndex = 19;
            // 
            // conformpassword
            // 
            this.conformpassword.Font = new System.Drawing.Font("宋体", 12F);
            this.conformpassword.Location = new System.Drawing.Point(459, 190);
            this.conformpassword.Name = "conformpassword";
            this.conformpassword.PasswordChar = '*';
            this.conformpassword.Size = new System.Drawing.Size(250, 35);
            this.conformpassword.TabIndex = 20;
            // 
            // buttonconform
            // 
            this.buttonconform.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.buttonconform.Location = new System.Drawing.Point(282, 308);
            this.buttonconform.Name = "buttonconform";
            this.buttonconform.Size = new System.Drawing.Size(200, 50);
            this.buttonconform.TabIndex = 21;
            this.buttonconform.Text = "确定";
            this.buttonconform.UseVisualStyleBackColor = true;
            this.buttonconform.Click += new System.EventHandler(this.buttonconform_Click);
            // 
            // ModifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 444);
            this.ControlBox = false;
            this.Controls.Add(this.buttonconform);
            this.Controls.Add(this.conformpassword);
            this.Controls.Add(this.modifiedpassword);
            this.Controls.Add(this.originalpassword);
            this.Controls.Add(this.labelconform);
            this.Controls.Add(this.labelmodify);
            this.Controls.Add(this.labelempname);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModifyPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label labelempname;
        private System.Windows.Forms.Label labelmodify;
        private System.Windows.Forms.Label labelconform;
        private System.Windows.Forms.TextBox originalpassword;
        private System.Windows.Forms.TextBox modifiedpassword;
        private System.Windows.Forms.TextBox conformpassword;
        private System.Windows.Forms.Button buttonconform;
    }
}