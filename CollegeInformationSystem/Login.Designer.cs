namespace CollegeInformationSystem
{
    partial class login_form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picturebox_wave = new System.Windows.Forms.PictureBox();
            this.login_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.RichTextBox();
            this.password = new System.Windows.Forms.RichTextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.reset_password_link = new System.Windows.Forms.LinkLabel();
            this.register_link = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_wave)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CollegeInformationSystem.Properties.Resources.svgviewer_png_output;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // picturebox_wave
            // 
            this.picturebox_wave.Image = global::CollegeInformationSystem.Properties.Resources.svgviewer_png_output;
            this.picturebox_wave.Location = new System.Drawing.Point(-4, -14);
            this.picturebox_wave.Name = "picturebox_wave";
            this.picturebox_wave.Size = new System.Drawing.Size(502, 90);
            this.picturebox_wave.TabIndex = 0;
            this.picturebox_wave.TabStop = false;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Sans Serif Collection", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_label.Location = new System.Drawing.Point(191, 115);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(116, 56);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Login";
            this.login_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_label.Location = new System.Drawing.Point(90, 205);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(153, 32);
            this.email_label.TabIndex = 2;
            this.email_label.Text = "  Email address";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_label.Location = new System.Drawing.Point(90, 282);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(114, 32);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "  Password";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(103, 238);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(292, 33);
            this.email.TabIndex = 6;
            this.email.Text = "";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(103, 312);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(292, 32);
            this.password.TabIndex = 7;
            this.password.Text = "";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.login_btn.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(185, 424);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(122, 45);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "LOGIN";
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // reset_password_link
            // 
            this.reset_password_link.ActiveLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.reset_password_link.AutoSize = true;
            this.reset_password_link.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reset_password_link.LinkColor = System.Drawing.Color.Black;
            this.reset_password_link.Location = new System.Drawing.Point(101, 353);
            this.reset_password_link.Name = "reset_password_link";
            this.reset_password_link.Size = new System.Drawing.Size(124, 24);
            this.reset_password_link.TabIndex = 9;
            this.reset_password_link.TabStop = true;
            this.reset_password_link.Text = "Forgot Password";
            this.reset_password_link.VisitedLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.reset_password_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reset_password_link_LinkClicked);
            // 
            // register_link
            // 
            this.register_link.ActiveLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.register_link.AutoSize = true;
            this.register_link.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.register_link.LinkColor = System.Drawing.Color.Black;
            this.register_link.Location = new System.Drawing.Point(306, 63);
            this.register_link.Name = "register_link";
            this.register_link.Size = new System.Drawing.Size(156, 24);
            this.register_link.TabIndex = 11;
            this.register_link.TabStop = true;
            this.register_link.Text = "I don\'t have an account";
            this.register_link.VisitedLinkColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // login_form
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 552);
            this.Controls.Add(this.register_link);
            this.Controls.Add(this.reset_password_link);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.picturebox_wave);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_wave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox picturebox_wave;
        private Label login_label;
        private Label email_label;
        private Label password_label;
        private RichTextBox email;
        private RichTextBox password;
        private Button login_btn;
        private LinkLabel reset_password_link;
        private LinkLabel register_link;
    }
}