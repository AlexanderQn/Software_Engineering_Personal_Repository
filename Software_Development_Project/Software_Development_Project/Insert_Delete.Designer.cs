namespace Software_Development_Project
{
    partial class Insert_Delete
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btLoadData = new System.Windows.Forms.Button();
            this.tbCompanyID = new System.Windows.Forms.TextBox();
            this.lbCompanyID = new System.Windows.Forms.Label();
            this.lbSoftwareName = new System.Windows.Forms.Label();
            this.lbSoftwareType = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductType = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btDeleteData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 12);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(439, 266);
            this.dgvProduct.TabIndex = 0;
            // 
            // btLoadData
            // 
            this.btLoadData.Location = new System.Drawing.Point(71, 305);
            this.btLoadData.Name = "btLoadData";
            this.btLoadData.Size = new System.Drawing.Size(97, 31);
            this.btLoadData.TabIndex = 1;
            this.btLoadData.Text = "Load Button";
            this.btLoadData.UseVisualStyleBackColor = true;
            this.btLoadData.Click += new System.EventHandler(this.btLoadData_Click);
            // 
            // tbCompanyID
            // 
            this.tbCompanyID.Location = new System.Drawing.Point(643, 59);
            this.tbCompanyID.Name = "tbCompanyID";
            this.tbCompanyID.Size = new System.Drawing.Size(145, 22);
            this.tbCompanyID.TabIndex = 2;
            // 
            // lbCompanyID
            // 
            this.lbCompanyID.AutoSize = true;
            this.lbCompanyID.Location = new System.Drawing.Point(531, 62);
            this.lbCompanyID.Name = "lbCompanyID";
            this.lbCompanyID.Size = new System.Drawing.Size(81, 16);
            this.lbCompanyID.TabIndex = 3;
            this.lbCompanyID.Text = "Company ID";
            // 
            // lbSoftwareName
            // 
            this.lbSoftwareName.AutoSize = true;
            this.lbSoftwareName.Location = new System.Drawing.Point(531, 103);
            this.lbSoftwareName.Name = "lbSoftwareName";
            this.lbSoftwareName.Size = new System.Drawing.Size(93, 16);
            this.lbSoftwareName.TabIndex = 4;
            this.lbSoftwareName.Text = "Product Name";
            // 
            // lbSoftwareType
            // 
            this.lbSoftwareType.AutoSize = true;
            this.lbSoftwareType.Location = new System.Drawing.Point(531, 149);
            this.lbSoftwareType.Name = "lbSoftwareType";
            this.lbSoftwareType.Size = new System.Drawing.Size(88, 16);
            this.lbSoftwareType.TabIndex = 5;
            this.lbSoftwareType.Text = "Product Type";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(531, 194);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(75, 16);
            this.lbDescription.TabIndex = 6;
            this.lbDescription.Text = "Description";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(644, 103);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(144, 22);
            this.tbProductName.TabIndex = 7;
            // 
            // tbProductType
            // 
            this.tbProductType.Location = new System.Drawing.Point(644, 143);
            this.tbProductType.Name = "tbProductType";
            this.tbProductType.Size = new System.Drawing.Size(144, 22);
            this.tbProductType.TabIndex = 8;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(644, 191);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(144, 22);
            this.tbDescription.TabIndex = 9;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(606, 247);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(96, 31);
            this.btInsert.TabIndex = 10;
            this.btInsert.Text = "Insert Data";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btDeleteData
            // 
            this.btDeleteData.Location = new System.Drawing.Point(298, 305);
            this.btDeleteData.Name = "btDeleteData";
            this.btDeleteData.Size = new System.Drawing.Size(97, 31);
            this.btDeleteData.TabIndex = 11;
            this.btDeleteData.Text = "Delete Data";
            this.btDeleteData.UseVisualStyleBackColor = true;
            this.btDeleteData.Click += new System.EventHandler(this.btDeleteData_Click);
            // 
            // Insert_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDeleteData);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbProductType);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbSoftwareType);
            this.Controls.Add(this.lbSoftwareName);
            this.Controls.Add(this.lbCompanyID);
            this.Controls.Add(this.tbCompanyID);
            this.Controls.Add(this.btLoadData);
            this.Controls.Add(this.dgvProduct);
            this.Name = "Insert_Delete";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btLoadData;
        private System.Windows.Forms.TextBox tbCompanyID;
        private System.Windows.Forms.Label lbCompanyID;
        private System.Windows.Forms.Label lbSoftwareName;
        private System.Windows.Forms.Label lbSoftwareType;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductType;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btDeleteData;
    }
}

