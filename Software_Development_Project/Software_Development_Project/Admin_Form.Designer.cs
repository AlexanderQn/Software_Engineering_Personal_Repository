namespace Software_Development_Project
{
    partial class Admin_Form
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
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.dGVLoad = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordChange = new System.Windows.Forms.TextBox();
            this.userPrivChange = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(12, 12);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowHeadersWidth = 51;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(480, 426);
            this.dGV1.TabIndex = 0;
            // 
            // dGVLoad
            // 
            this.dGVLoad.Location = new System.Drawing.Point(499, 414);
            this.dGVLoad.Name = "dGVLoad";
            this.dGVLoad.Size = new System.Drawing.Size(75, 23);
            this.dGVLoad.TabIndex = 1;
            this.dGVLoad.Text = "Load";
            this.dGVLoad.UseVisualStyleBackColor = true;
            this.dGVLoad.Click += new System.EventHandler(this.dGVLoad_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(713, 414);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(607, 107);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(607, 281);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(583, 66);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(128, 22);
            this.usernameInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter username of entry you wish to delete/edit.";
            // 
            // passwordChange
            // 
            this.passwordChange.Location = new System.Drawing.Point(593, 168);
            this.passwordChange.Name = "passwordChange";
            this.passwordChange.Size = new System.Drawing.Size(100, 22);
            this.passwordChange.TabIndex = 7;
            // 
            // userPrivChange
            // 
            this.userPrivChange.Location = new System.Drawing.Point(593, 220);
            this.userPrivChange.Name = "userPrivChange";
            this.userPrivChange.Size = new System.Drawing.Size(100, 22);
            this.userPrivChange.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userPrivChange);
            this.Controls.Add(this.passwordChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dGVLoad);
            this.Controls.Add(this.dGV1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Button dGVLoad;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordChange;
        private System.Windows.Forms.TextBox userPrivChange;
    }
}