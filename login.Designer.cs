namespace GMS
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usericon = new PictureBox();
            adminicon = new PictureBox();
            lbluser = new Label();
            label2 = new Label();
            lbladmin = new Label();
            lblusername = new Label();
            lblpass = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            closeicon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)usericon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeicon).BeginInit();
            SuspendLayout();
            // 
            // usericon
            // 
            usericon.BackColor = Color.Transparent;
            usericon.Image = Properties.Resources.download_removebg_preview;
            usericon.Location = new Point(32, 191);
            usericon.Name = "usericon";
            usericon.Size = new Size(228, 214);
            usericon.TabIndex = 0;
            usericon.TabStop = false;
            usericon.Click += usericon_Click;
            // 
            // adminicon
            // 
            adminicon.BackColor = Color.Transparent;
            adminicon.Image = Properties.Resources.download2_removebg_preview;
            adminicon.Location = new Point(343, 191);
            adminicon.Name = "adminicon";
            adminicon.Size = new Size(222, 214);
            adminicon.TabIndex = 1;
            adminicon.TabStop = false;
            adminicon.Click += adminicon_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.BackColor = Color.Transparent;
            lbluser.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluser.Location = new Point(106, 167);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(75, 30);
            lbluser.TabIndex = 2;
            lbluser.Text = "USER";
            lbluser.Click += lbluser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 27);
            label2.Name = "label2";
            label2.Size = new Size(426, 59);
            label2.TabIndex = 3;
            label2.Text = "GROCERY SHOP";
            // 
            // lbladmin
            // 
            lbladmin.AutoSize = true;
            lbladmin.BackColor = Color.Transparent;
            lbladmin.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladmin.Location = new Point(403, 167);
            lbladmin.Name = "lbladmin";
            lbladmin.Size = new Size(94, 30);
            lbladmin.TabIndex = 4;
            lbladmin.Text = "ADMIN";
            lbladmin.Click += lbladmin_Click;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(333, 417);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(116, 24);
            lblusername.TabIndex = 5;
            lblusername.Text = "Username";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.BackColor = Color.Transparent;
            lblpass.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpass.Location = new Point(334, 452);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(115, 24);
            lblpass.TabIndex = 6;
            lblpass.Text = "Password";
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.IndianRed;
            txtuser.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.Location = new Point(455, 414);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(119, 32);
            txtuser.TabIndex = 7;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.IndianRed;
            txtpass.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(455, 449);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(119, 32);
            txtpass.TabIndex = 8;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.IndianRed;
            btnlogin.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(392, 487);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(105, 34);
            btnlogin.TabIndex = 9;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // closeicon
            // 
            closeicon.BackColor = Color.Transparent;
            closeicon.Image = Properties.Resources.close_new;
            closeicon.Location = new Point(556, -13);
            closeicon.Name = "closeicon";
            closeicon.Size = new Size(69, 63);
            closeicon.SizeMode = PictureBoxSizeMode.Zoom;
            closeicon.TabIndex = 11;
            closeicon.TabStop = false;
            closeicon.Click += closeicon_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__3_;
            ClientSize = new Size(609, 534);
            Controls.Add(closeicon);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(lblpass);
            Controls.Add(lblusername);
            Controls.Add(lbladmin);
            Controls.Add(label2);
            Controls.Add(lbluser);
            Controls.Add(adminicon);
            Controls.Add(usericon);
            Name = "login";
            Text = "Form1";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)usericon).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox usericon;
        private PictureBox adminicon;
        private Label lbluser;
        private Label label2;
        private Label lbladmin;
        private Label lblusername;
        private Label lblpass;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button btnlogin;
        private PictureBox closeicon;
    }
}
