namespace Software_Development_Project
{
    partial class editDBForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TargetValueTextBox = new System.Windows.Forms.RichTextBox();
            this.ConditionValueTextBox = new System.Windows.Forms.RichTextBox();
            this.TableNameListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnSelectListBox = new System.Windows.Forms.ListBox();
            this.ConditionSelectListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(92, 325);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(796, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // TargetValueTextBox
            // 
            this.TargetValueTextBox.Location = new System.Drawing.Point(396, 228);
            this.TargetValueTextBox.Name = "TargetValueTextBox";
            this.TargetValueTextBox.Size = new System.Drawing.Size(204, 49);
            this.TargetValueTextBox.TabIndex = 5;
            this.TargetValueTextBox.Text = "SetTargetTo";
            this.TargetValueTextBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // ConditionValueTextBox
            // 
            this.ConditionValueTextBox.Location = new System.Drawing.Point(721, 228);
            this.ConditionValueTextBox.Name = "ConditionValueTextBox";
            this.ConditionValueTextBox.Size = new System.Drawing.Size(221, 49);
            this.ConditionValueTextBox.TabIndex = 7;
            this.ConditionValueTextBox.Text = "ConditionValue";
            // 
            // TableNameListBox
            // 
            this.TableNameListBox.FormattingEnabled = true;
            this.TableNameListBox.ItemHeight = 16;
            this.TableNameListBox.Items.AddRange(new object[] {
            "Business_Areas_Table",
            "Companies_Locations_Table",
            "Companies_Table",
            "Financial_Services_Client_Types_Table",
            "Modules_Table",
            "Products_Capabilites_Table",
            "Products_Table"});
            this.TableNameListBox.Location = new System.Drawing.Point(32, 80);
            this.TableNameListBox.Name = "TableNameListBox";
            this.TableNameListBox.Size = new System.Drawing.Size(252, 116);
            this.TableNameListBox.TabIndex = 8;
            this.TableNameListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ColumnSelectListBox
            // 
            this.ColumnSelectListBox.FormattingEnabled = true;
            this.ColumnSelectListBox.ItemHeight = 16;
            this.ColumnSelectListBox.Location = new System.Drawing.Point(396, 80);
            this.ColumnSelectListBox.Name = "ColumnSelectListBox";
            this.ColumnSelectListBox.Size = new System.Drawing.Size(204, 116);
            this.ColumnSelectListBox.TabIndex = 10;
            this.ColumnSelectListBox.SelectedIndexChanged += new System.EventHandler(this.ColumnSelectListBox_SelectedIndexChanged);
            // 
            // ConditionSelectListBox
            // 
            this.ConditionSelectListBox.FormattingEnabled = true;
            this.ConditionSelectListBox.ItemHeight = 16;
            this.ConditionSelectListBox.Location = new System.Drawing.Point(721, 80);
            this.ConditionSelectListBox.Name = "ConditionSelectListBox";
            this.ConditionSelectListBox.Size = new System.Drawing.Size(221, 116);
            this.ConditionSelectListBox.TabIndex = 11;
            this.ConditionSelectListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Field to Edit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Condition to Filter By";
            // 
            // editDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConditionSelectListBox);
            this.Controls.Add(this.ColumnSelectListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableNameListBox);
            this.Controls.Add(this.ConditionValueTextBox);
            this.Controls.Add(this.TargetValueTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox TargetValueTextBox;
        private System.Windows.Forms.RichTextBox ConditionValueTextBox;
        private System.Windows.Forms.ListBox TableNameListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ColumnSelectListBox;
        private System.Windows.Forms.ListBox ConditionSelectListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

