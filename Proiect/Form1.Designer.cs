namespace Proiect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginmenu = new System.Windows.Forms.Button();
            this.rentmenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panellogin = new System.Windows.Forms.Panel();
            this.Btnregister = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.passwordlogin = new System.Windows.Forms.TextBox();
            this.usernamelogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelregister = new System.Windows.Forms.Panel();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.passwordregister = new System.Windows.Forms.TextBox();
            this.usernameregister = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registermenu = new System.Windows.Forms.Button();
            this.panelmanagefields = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panellogin.SuspendLayout();
            this.panelregister.SuspendLayout();
            this.panelmanagefields.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.registermenu);
            this.panel1.Controls.Add(this.loginmenu);
            this.panel1.Controls.Add(this.rentmenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 661);
            this.panel1.TabIndex = 0;
            // 
            // loginmenu
            // 
            this.loginmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginmenu.Font = new System.Drawing.Font("Optima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginmenu.Location = new System.Drawing.Point(9, 235);
            this.loginmenu.Name = "loginmenu";
            this.loginmenu.Size = new System.Drawing.Size(157, 59);
            this.loginmenu.TabIndex = 2;
            this.loginmenu.Text = "Login";
            this.loginmenu.UseVisualStyleBackColor = true;
            this.loginmenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // rentmenu
            // 
            this.rentmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentmenu.Font = new System.Drawing.Font("Optima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentmenu.Location = new System.Drawing.Point(9, 161);
            this.rentmenu.Name = "rentmenu";
            this.rentmenu.Size = new System.Drawing.Size(157, 59);
            this.rentmenu.TabIndex = 1;
            this.rentmenu.Text = "Rent";
            this.rentmenu.UseVisualStyleBackColor = true;
            this.rentmenu.Click += new System.EventHandler(this.rent_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panellogin
            // 
            this.panellogin.Controls.Add(this.Btnregister);
            this.panellogin.Controls.Add(this.BtnLogin);
            this.panellogin.Controls.Add(this.passwordlogin);
            this.panellogin.Controls.Add(this.usernamelogin);
            this.panellogin.Controls.Add(this.label2);
            this.panellogin.Controls.Add(this.label1);
            this.panellogin.Location = new System.Drawing.Point(430, 150);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(460, 370);
            this.panellogin.TabIndex = 1;
            this.panellogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panellogin_Paint);
            // 
            // Btnregister
            // 
            this.Btnregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnregister.Font = new System.Drawing.Font("Optima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnregister.Location = new System.Drawing.Point(113, 245);
            this.Btnregister.Name = "Btnregister";
            this.Btnregister.Size = new System.Drawing.Size(240, 46);
            this.Btnregister.TabIndex = 5;
            this.Btnregister.Text = "Don\'t Have Account? Create";
            this.Btnregister.UseVisualStyleBackColor = true;
            this.Btnregister.Click += new System.EventHandler(this.Btnregister_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Optima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(179, 195);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(118, 34);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login Now";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // passwordlogin
            // 
            this.passwordlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.passwordlogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordlogin.Location = new System.Drawing.Point(179, 158);
            this.passwordlogin.Name = "passwordlogin";
            this.passwordlogin.PasswordChar = '*';
            this.passwordlogin.Size = new System.Drawing.Size(200, 20);
            this.passwordlogin.TabIndex = 3;
            // 
            // usernamelogin
            // 
            this.usernamelogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.usernamelogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernamelogin.Location = new System.Drawing.Point(179, 120);
            this.usernamelogin.Name = "usernamelogin";
            this.usernamelogin.Size = new System.Drawing.Size(200, 20);
            this.usernamelogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Optima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Optima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelregister
            // 
            this.panelregister.Controls.Add(this.confirmpassword);
            this.panelregister.Controls.Add(this.label5);
            this.panelregister.Controls.Add(this.button1);
            this.panelregister.Controls.Add(this.button2);
            this.panelregister.Controls.Add(this.passwordregister);
            this.panelregister.Controls.Add(this.usernameregister);
            this.panelregister.Controls.Add(this.label3);
            this.panelregister.Controls.Add(this.label4);
            this.panelregister.Location = new System.Drawing.Point(430, 150);
            this.panelregister.Name = "panelregister";
            this.panelregister.Size = new System.Drawing.Size(460, 370);
            this.panelregister.TabIndex = 2;
            this.panelregister.Paint += new System.Windows.Forms.PaintEventHandler(this.panelregister_Paint);
            // 
            // confirmpassword
            // 
            this.confirmpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.confirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpassword.Location = new System.Drawing.Point(208, 143);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.PasswordChar = '*';
            this.confirmpassword.Size = new System.Drawing.Size(200, 20);
            this.confirmpassword.TabIndex = 13;
            this.confirmpassword.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Optima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirm Password: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Optima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(175, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Register Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Optima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(122, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Have Account? Login Now";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwordregister
            // 
            this.passwordregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.passwordregister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordregister.Location = new System.Drawing.Point(208, 106);
            this.passwordregister.Name = "passwordregister";
            this.passwordregister.PasswordChar = '*';
            this.passwordregister.Size = new System.Drawing.Size(200, 20);
            this.passwordregister.TabIndex = 9;
            // 
            // usernameregister
            // 
            this.usernameregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.usernameregister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameregister.Location = new System.Drawing.Point(208, 68);
            this.usernameregister.Name = "usernameregister";
            this.usernameregister.Size = new System.Drawing.Size(200, 20);
            this.usernameregister.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Optima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Optima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Username: ";
            // 
            // registermenu
            // 
            this.registermenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registermenu.Font = new System.Drawing.Font("Optima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registermenu.Location = new System.Drawing.Point(9, 312);
            this.registermenu.Name = "registermenu";
            this.registermenu.Size = new System.Drawing.Size(157, 59);
            this.registermenu.TabIndex = 3;
            this.registermenu.Text = "Register";
            this.registermenu.UseVisualStyleBackColor = true;
            this.registermenu.Click += new System.EventHandler(this.registermenu_Click);
            // 
            // panelmanagefields
            // 
            this.panelmanagefields.Controls.Add(this.listBox1);
            this.panelmanagefields.Location = new System.Drawing.Point(170, 10);
            this.panelmanagefields.Name = "panelmanagefields";
            this.panelmanagefields.Size = new System.Drawing.Size(1010, 640);
            this.panelmanagefields.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(17, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 214);
            this.listBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1192, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(172)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(1217, 659);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelmanagefields);
            this.Controls.Add(this.panelregister);
            this.Controls.Add(this.panellogin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Optima", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.panelregister.ResumeLayout(false);
            this.panelregister.PerformLayout();
            this.panelmanagefields.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginmenu;
        private System.Windows.Forms.Button rentmenu;
        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelregister;
        private System.Windows.Forms.Button Btnregister;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox passwordlogin;
        private System.Windows.Forms.TextBox usernamelogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox passwordregister;
        private System.Windows.Forms.TextBox usernameregister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registermenu;
        private System.Windows.Forms.Panel panelmanagefields;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
    }
}

