namespace GestiuneVanzari
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCsvImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsXmlImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBinaryImport = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCsvExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsXmlExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBinaryExport = new System.Windows.Forms.ToolStripMenuItem();
            this.grbProduct = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExpDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvProducts = new System.Windows.Forms.ListView();
            this.epProductName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.epExpirationDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.grbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExpirationDate)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCsvImport,
            this.tsXmlImport,
            this.tsBinaryImport});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "&Import";
            // 
            // tsCsvImport
            // 
            this.tsCsvImport.Name = "tsCsvImport";
            this.tsCsvImport.Size = new System.Drawing.Size(152, 22);
            this.tsCsvImport.Text = "&CSV File";
            this.tsCsvImport.Click += new System.EventHandler(this.tsCsvImport_Click);
            // 
            // tsXmlImport
            // 
            this.tsXmlImport.Name = "tsXmlImport";
            this.tsXmlImport.Size = new System.Drawing.Size(152, 22);
            this.tsXmlImport.Text = "&XML File";
            this.tsXmlImport.Click += new System.EventHandler(this.tsXmlImport_Click);
            // 
            // tsBinaryImport
            // 
            this.tsBinaryImport.Name = "tsBinaryImport";
            this.tsBinaryImport.Size = new System.Drawing.Size(152, 22);
            this.tsBinaryImport.Text = "&Binary File";
            this.tsBinaryImport.Click += new System.EventHandler(this.tsBinaryImport_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCsvExport,
            this.tsXmlExport,
            this.tsBinaryExport});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "E&xport";
            // 
            // tsCsvExport
            // 
            this.tsCsvExport.Name = "tsCsvExport";
            this.tsCsvExport.Size = new System.Drawing.Size(152, 22);
            this.tsCsvExport.Text = "&CSV File";
            this.tsCsvExport.Click += new System.EventHandler(this.tsCsvExport_Click);
            // 
            // tsXmlExport
            // 
            this.tsXmlExport.Name = "tsXmlExport";
            this.tsXmlExport.Size = new System.Drawing.Size(152, 22);
            this.tsXmlExport.Text = "&XML File";
            this.tsXmlExport.Click += new System.EventHandler(this.tsXmlExport_Click);
            // 
            // tsBinaryExport
            // 
            this.tsBinaryExport.Name = "tsBinaryExport";
            this.tsBinaryExport.Size = new System.Drawing.Size(152, 22);
            this.tsBinaryExport.Text = "&Binary File";
            this.tsBinaryExport.Click += new System.EventHandler(this.tsBinaryExport_Click);
            // 
            // grbProduct
            // 
            this.grbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProduct.Controls.Add(this.btnAdd);
            this.grbProduct.Controls.Add(this.lbDescription);
            this.grbProduct.Controls.Add(this.tbDescription);
            this.grbProduct.Controls.Add(this.dtpExpDate);
            this.grbProduct.Controls.Add(this.tbPrice);
            this.grbProduct.Controls.Add(this.lbName);
            this.grbProduct.Controls.Add(this.tbProductName);
            this.grbProduct.Controls.Add(this.lbExpirationDate);
            this.grbProduct.Controls.Add(this.lbPrice);
            this.grbProduct.Location = new System.Drawing.Point(12, 27);
            this.grbProduct.Name = "grbProduct";
            this.grbProduct.Size = new System.Drawing.Size(607, 154);
            this.grbProduct.TabIndex = 3;
            this.grbProduct.TabStop = false;
            this.grbProduct.Text = "Products";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(526, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(301, 23);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 18;
            this.lbDescription.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(382, 19);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(219, 50);
            this.tbDescription.TabIndex = 19;
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
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(88, 49);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(148, 20);
            this.tbPrice.TabIndex = 13;
            this.tbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrice_Validating);
            this.tbPrice.Validated += new System.EventHandler(this.tbPrice_Validated);
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
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(88, 19);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(148, 20);
            this.tbProductName.TabIndex = 9;
            this.tbProductName.Validating += new System.ComponentModel.CancelEventHandler(this.tbProductName_Validating);
            this.tbProductName.Validated += new System.EventHandler(this.tbProductName_Validated);
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
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(7, 53);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 12;
            this.lbPrice.Text = "Price";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(630, 111);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(630, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chId
            // 
            this.chId.Text = "Product Id";
            this.chId.Width = 67;
            // 
            // chProductName
            // 
            this.chProductName.Text = "Name";
            this.chProductName.Width = 104;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 214;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            // 
            // chExpDate
            // 
            this.chExpDate.Text = "Expiration Date";
            this.chExpDate.Width = 112;
            // 
            // lvProducts
            // 
            this.lvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chProductName,
            this.chDescription,
            this.chPrice,
            this.chExpDate});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(12, 187);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(693, 239);
            this.lvProducts.TabIndex = 53;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
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
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grbProduct);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProducts";
            this.Text = "Products";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProducts_FormClosing);
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbProduct.ResumeLayout(false);
            this.grbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExpirationDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCsvImport;
        private System.Windows.Forms.ToolStripMenuItem tsXmlImport;
        private System.Windows.Forms.ToolStripMenuItem tsBinaryImport;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCsvExport;
        private System.Windows.Forms.ToolStripMenuItem tsXmlExport;
        private System.Windows.Forms.ToolStripMenuItem tsBinaryExport;
        private System.Windows.Forms.GroupBox grbProduct;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chProductName;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ColumnHeader chExpDate;
        private System.Windows.Forms.ErrorProvider epProductName;
        private System.Windows.Forms.ErrorProvider epPrice;
        private System.Windows.Forms.ErrorProvider epExpirationDate;

    }
}