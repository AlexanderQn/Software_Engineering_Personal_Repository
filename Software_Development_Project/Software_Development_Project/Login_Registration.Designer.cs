using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Software_Development_Project
{
    partial class Login_Registration
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
            this.LoginTC = new System.Windows.Forms.TabControl();
            this.regcompleteTab = new System.Windows.Forms.TabPage();
            this.completionText2 = new System.Windows.Forms.Label();
            this.completionText = new System.Windows.Forms.Label();
            this.completeBtn = new System.Windows.Forms.Button();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.usernameLogin = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.swapRegister = new System.Windows.Forms.Button();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwordRegC = new System.Windows.Forms.TextBox();
            this.passwordReg = new System.Windows.Forms.TextBox();
            this.emailReg = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.swapLogin = new System.Windows.Forms.Button();
            this.LoginTC.SuspendLayout();
            this.regcompleteTab.SuspendLayout();
            this.loginTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.registerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTC
            // 
            this.LoginTC.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.LoginTC.Controls.Add(this.loginTab);
            this.LoginTC.Controls.Add(this.registerTab);
            this.LoginTC.Controls.Add(this.regcompleteTab);
            this.LoginTC.ItemSize = new System.Drawing.Size(0, 1);
            this.LoginTC.Location = new System.Drawing.Point(0, 0);
            this.LoginTC.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTC.Multiline = true;
            this.LoginTC.Name = "LoginTC";
            this.LoginTC.SelectedIndex = 0;
            this.LoginTC.Size = new System.Drawing.Size(1202, 562);
            this.LoginTC.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.LoginTC.TabIndex = 0;
            this.LoginTC.TabStop = false;
            // 
            // regcompleteTab
            // 
            this.regcompleteTab.BackColor = System.Drawing.Color.Silver;
            this.regcompleteTab.Controls.Add(this.completionText2);
            this.regcompleteTab.Controls.Add(this.completionText);
            this.regcompleteTab.Controls.Add(this.completeBtn);
            this.regcompleteTab.Location = new System.Drawing.Point(4, 5);
            this.regcompleteTab.Margin = new System.Windows.Forms.Padding(4);
            this.regcompleteTab.Name = "regcompleteTab";
            this.regcompleteTab.Size = new System.Drawing.Size(1194, 553);
            this.regcompleteTab.TabIndex = 2;
            this.regcompleteTab.Text = "Registration";
            // 
            // completionText2
            // 
            this.completionText2.AutoSize = true;
            this.completionText2.Location = new System.Drawing.Point(446, 238);
            this.completionText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.completionText2.Name = "completionText2";
            this.completionText2.Size = new System.Drawing.Size(253, 25);
            this.completionText2.TabIndex = 2;
            this.completionText2.Text = "Press Button to continue.";
            // 
            // completionText
            // 
            this.completionText.AutoSize = true;
            this.completionText.Location = new System.Drawing.Point(446, 198);
            this.completionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.completionText.Name = "completionText";
            this.completionText.Size = new System.Drawing.Size(232, 25);
            this.completionText.TabIndex = 1;
            this.completionText.Text = "Registration complete. ";
            // 
            // completeBtn
            // 
            this.completeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            this.completeBtn.ForeColor = System.Drawing.Color.White;
            this.completeBtn.Location = new System.Drawing.Point(1036, 504);
            this.completeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(140, 37);
            this.completeBtn.TabIndex = 0;
            this.completeBtn.Text = "Continue";
            this.completeBtn.UseVisualStyleBackColor = false;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // loginTab
            // 
            this.loginTab.BackColor = System.Drawing.Color.Silver;
            this.loginTab.Controls.Add(this.pictureBox1);
            this.loginTab.Controls.Add(this.passwordLogin);
            this.loginTab.Controls.Add(this.usernameLogin);
            this.loginTab.Controls.Add(this.loginBtn);
            this.loginTab.Controls.Add(this.swapRegister);
            this.loginTab.Location = new System.Drawing.Point(4, 5);
            this.loginTab.Margin = new System.Windows.Forms.Padding(4);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(4);
            this.loginTab.Size = new System.Drawing.Size(1194, 553);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_Development_Project.Properties.Resources.citisoft;
            this.pictureBox1.Location = new System.Drawing.Point(372, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(492, 302);
            this.passwordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.PasswordChar = '*';
            this.passwordLogin.Size = new System.Drawing.Size(186, 31);
            this.passwordLogin.TabIndex = 3;
            // 
            // usernameLogin
            // 
            this.usernameLogin.Location = new System.Drawing.Point(492, 260);
            this.usernameLogin.Margin = new System.Windows.Forms.Padding(4);
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.Size = new System.Drawing.Size(186, 31);
            this.usernameLogin.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(514, 356);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(140, 42);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // swapRegister
            // 
            this.swapRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            this.swapRegister.ForeColor = System.Drawing.Color.White;
            this.swapRegister.Location = new System.Drawing.Point(1036, 498);
            this.swapRegister.Margin = new System.Windows.Forms.Padding(4);
            this.swapRegister.Name = "swapRegister";
            this.swapRegister.Size = new System.Drawing.Size(140, 42);
            this.swapRegister.TabIndex = 0;
            this.swapRegister.Text = "Register";
            this.swapRegister.UseVisualStyleBackColor = false;
            this.swapRegister.Click += new System.EventHandler(this.swapRegister_Click);
            // 
            // registerTab
            // 
            this.registerTab.BackColor = System.Drawing.Color.Silver;
            this.registerTab.Controls.Add(this.pictureBox2);
            this.registerTab.Controls.Add(this.passwordRegC);
            this.registerTab.Controls.Add(this.passwordReg);
            this.registerTab.Controls.Add(this.emailReg);
            this.registerTab.Controls.Add(this.registerBtn);
            this.registerTab.Controls.Add(this.swapLogin);
            this.registerTab.Location = new System.Drawing.Point(4, 5);
            this.registerTab.Margin = new System.Windows.Forms.Padding(4);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(4);
            this.registerTab.Size = new System.Drawing.Size(1194, 553);
            this.registerTab.TabIndex = 1;
            this.registerTab.Text = "Register";
            this.registerTab.Click += new System.EventHandler(this.registerTab_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software_Development_Project.Properties.Resources.citisoft;
            this.pictureBox2.Location = new System.Drawing.Point(7, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // passwordRegC
            // 
            this.passwordRegC.Location = new System.Drawing.Point(490, 274);
            this.passwordRegC.Margin = new System.Windows.Forms.Padding(4);
            this.passwordRegC.Name = "passwordRegC";
            this.passwordRegC.PasswordChar = '*';
            this.passwordRegC.Size = new System.Drawing.Size(186, 31);
            this.passwordRegC.TabIndex = 4;
            // 
            // passwordReg
            // 
            this.passwordReg.Location = new System.Drawing.Point(490, 233);
            this.passwordReg.Margin = new System.Windows.Forms.Padding(4);
            this.passwordReg.Name = "passwordReg";
            this.passwordReg.PasswordChar = '*';
            this.passwordReg.Size = new System.Drawing.Size(186, 31);
            this.passwordReg.TabIndex = 3;
            // 
            // emailReg
            // 
            this.emailReg.Location = new System.Drawing.Point(490, 193);
            this.emailReg.Margin = new System.Windows.Forms.Padding(4);
            this.emailReg.Name = "emailReg";
            this.emailReg.Size = new System.Drawing.Size(186, 31);
            this.emailReg.TabIndex = 2;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(512, 316);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(140, 40);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // swapLogin
            // 
            this.swapLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            this.swapLogin.ForeColor = System.Drawing.Color.White;
            this.swapLogin.Location = new System.Drawing.Point(1036, 502);
            this.swapLogin.Margin = new System.Windows.Forms.Padding(4);
            this.swapLogin.Name = "swapLogin";
            this.swapLogin.Size = new System.Drawing.Size(140, 40);
            this.swapLogin.TabIndex = 0;
            this.swapLogin.Text = "Login";
            this.swapLogin.UseVisualStyleBackColor = false;
            this.swapLogin.Click += new System.EventHandler(this.swapLogin_Click);
            // 
            // Login_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 562);
            this.Controls.Add(this.LoginTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.LoginTC.ResumeLayout(false);
            this.regcompleteTab.ResumeLayout(false);
            this.regcompleteTab.PerformLayout();
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.registerTab.ResumeLayout(false);
            this.registerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl LoginTC;
        private TabPage regcompleteTab;
        private Label completionText;
        private Button completeBtn;
        private Label completionText2;
        private TabPage loginTab;
        private TextBox passwordLogin;
        private TextBox usernameLogin;
        private Button loginBtn;
        private Button swapRegister;
        private TabPage registerTab;
        private TextBox passwordRegC;
        private TextBox passwordReg;
        private TextBox emailReg;
        private Button registerBtn;
        private Button swapLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

