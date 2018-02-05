namespace GestiuneVanzari
{
    partial class frmEditProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditProduct));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.grbProduct = new System.Windows.Forms.GroupBox();
            this.epProductName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.epExpirationDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExpirationDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(254, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(173, 253);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(7, 53);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 12;
            this.lbPrice.Text = "Price";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Location = new System.Drawing.Point(7, 84);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(79, 13);
            this.lbExpirationDate.TabIndex = 14;
            this.lbExpirationDate.Text = "Expiration Date";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(88, 19);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(148, 20);
            this.tbProductName.TabIndex = 9;
            this.tbProductName.Validating += new System.ComponentModel.CancelEventHandler(this.tbProductName_Validating);
            this.tbProductName.Validated += new System.EventHandler(this.tbProductName_Validated);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(7, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 13);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Product Name";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(88, 49);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(148, 20);
            this.tbPrice.TabIndex = 13;
            this.tbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrice_Validating);
            this.tbPrice.Validated += new System.EventHandler(this.tbPrice_Validated);
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Location = new System.Drawing.Point(88, 80);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(148, 20);
            this.dtpExpDate.TabIndex = 15;
            this.dtpExpDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpExpDate_Validating);
            this.dtpExpDate.Validated += new System.EventHandler(this.dtpExpDate_Validated);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(73, 112);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(219, 50);
            this.tbDescription.TabIndex = 19;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(7, 131);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 18;
            this.lbDescription.Text = "Description";
            // 
            // grbProduct
            // 
            this.grbProduct.Controls.Add(this.lbDescription);
            this.grbProduct.Controls.Add(this.tbDescription);
            this.grbProduct.Controls.Add(this.dtpExpDate);
            this.grbProduct.Controls.Add(this.tbPrice);
            this.grbProduct.Controls.Add(this.lbName);
            this.grbProduct.Controls.Add(this.tbProductName);
            this.grbProduct.Controls.Add(this.lbExpirationDate);
            this.grbProduct.Controls.Add(this.lbPrice);
            this.grbProduct.Location = new System.Drawing.Point(12, 12);
            this.grbProduct.Name = "grbProduct";
            this.grbProduct.Size = new System.Drawing.Size(332, 203);
            this.grbProduct.TabIndex = 6;
            this.grbProduct.TabStop = false;
            this.grbProduct.Text = "Products";
            // 
            // epProductName
            // 
            this.epProductName.ContainerControl = this;
            // 
            // epPrice
            // 
            this.epPrice.ContainerControl = this;
            // 
            // epExpirationDate
            // 
            this.epExpirationDate.ContainerControl = this;
            // 
            // frmEditProduct
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.grbProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 350);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "frmEditProduct";
            this.Text = "frmEditProduct";
            this.Load += new System.EventHandler(this.frmEditProduct_Load);
            this.grbProduct.ResumeLayout(false);
            this.grbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExpirationDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.GroupBox grbProduct;
        private System.Windows.Forms.ErrorProvider epProductName;
        private System.Windows.Forms.ErrorProvider epPrice;
        private System.Windows.Forms.ErrorProvider epExpirationDate;
    }
}