namespace CollegeInformationSystem
{
    partial class register_form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.register_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.RichTextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.password = new System.Windows.Forms.TextBox();
            this.confirm_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CollegeInformationSystem.Properties.Resources.svgviewer_png_output;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Sans Serif Collection", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.register_label.Location = new System.Drawing.Point(165, 131);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(163, 56);
            this.register_label.TabIndex = 1;
            this.register_label.Text = "Register";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_label.Location = new System.Drawing.Point(90, 194);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(153, 32);
            this.email_label.TabIndex = 2;
            this.email_label.Text = "  Email address";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(103, 229);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(292, 33);
            this.email.TabIndex = 1;
            this.email.Text = "";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_label.Location = new System.Drawing.Point(90, 275);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(114, 32);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "  Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "  Confirm Password";
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.register_btn.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.register_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(183, 441);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(122, 45);
            this.register_btn.TabIndex = 4;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(303, 63);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(172, 24);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "I already have an account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(100, 312);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(292, 34);
            this.password.TabIndex = 2;
            // 
            // confirm_password
            // 
            this.confirm_password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_password.Location = new System.Drawing.Point(100, 390);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.PasswordChar = '•';
            this.confirm_password.Size = new System.Drawing.Size(292, 34);
            this.confirm_password.TabIndex = 3;
            // 
            // register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 552);
            this.Controls.Add(this.confirm_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "register_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label register_label;
        private Label email_label;
        private RichTextBox email;
        private Label password_label;
        private Label label2;
        private Button register_btn;
        private LinkLabel linkLabel1;
        private TextBox password;
        private TextBox confirm_password;
    }
}