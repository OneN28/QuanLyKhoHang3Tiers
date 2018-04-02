namespace Quản_lý_kho_hàng
{
    partial class Form1
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
            this.bntLogin = new System.Windows.Forms.Button();
            this.bntRegi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.bntClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntLogin
            // 
            this.bntLogin.BackColor = System.Drawing.Color.Honeydew;
            this.bntLogin.Location = new System.Drawing.Point(32, 89);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(220, 23);
            this.bntLogin.TabIndex = 0;
            this.bntLogin.Text = "Đăng nhập";
            this.bntLogin.UseVisualStyleBackColor = false;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // bntRegi
            // 
            this.bntRegi.BackColor = System.Drawing.Color.Honeydew;
            this.bntRegi.Location = new System.Drawing.Point(32, 131);
            this.bntRegi.Name = "bntRegi";
            this.bntRegi.Size = new System.Drawing.Size(220, 23);
            this.bntRegi.TabIndex = 1;
            this.bntRegi.Text = "Đăng ký";
            this.bntRegi.UseVisualStyleBackColor = false;
            this.bntRegi.Click += new System.EventHandler(this.bntRegi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(32, 42);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(101, 20);
            this.tbUser.TabIndex = 4;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(152, 42);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 5;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // bntClose
            // 
            this.bntClose.BackColor = System.Drawing.Color.Honeydew;
            this.bntClose.Location = new System.Drawing.Point(32, 170);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(220, 23);
            this.bntClose.TabIndex = 6;
            this.bntClose.Text = "Thoát";
            this.bntClose.UseVisualStyleBackColor = false;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(289, 208);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntRegi);
            this.Controls.Add(this.bntLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntLogin;
        private System.Windows.Forms.Button bntRegi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button bntClose;
    }
}

