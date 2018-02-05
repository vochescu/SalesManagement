namespace GestiuneVanzari
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbShearchProd = new System.Windows.Forms.TextBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsClients = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsProducts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTransactions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSearch.SuspendLayout();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.BackColor = System.Drawing.SystemColors.Info;
            this.gbSearch.Controls.Add(this.btnAll);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.lbName);
            this.gbSearch.Controls.Add(this.tbShearchProd);
            this.gbSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbSearch.Location = new System.Drawing.Point(12, 122);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(871, 82);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Products";
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAll.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAll.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAll.Location = new System.Drawing.Point(670, 17);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(121, 30);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "Show &All";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Image = global::GestiuneVanzari.Properties.Resources.search_button_png_transparent___2_;
            this.btnSearch.Location = new System.Drawing.Point(489, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "&SEARCH";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(146, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 17);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // tbShearchProd
            // 
            this.tbShearchProd.Location = new System.Drawing.Point(198, 21);
            this.tbShearchProd.Name = "tbShearchProd";
            this.tbShearchProd.Size = new System.Drawing.Size(196, 25);
            this.tbShearchProd.TabIndex = 0;
            this.tbShearchProd.Validating += new System.ComponentModel.CancelEventHandler(this.tbShearchProd_Validating);
            this.tbShearchProd.Validated += new System.EventHandler(this.tbShearchProd_Validated);
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.tsLogin,
            this.toolStripSeparator1,
            this.tsClients,
            this.toolStripSeparator2,
            this.tsProducts,
            this.toolStripSeparator3,
            this.tsTransactions,
            this.toolStripSeparator4,
            this.tsLogout,
            this.toolStripSeparator5});
            this.tsMenu.Location = new System.Drawing.Point(9, 2);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMenu.Size = new System.Drawing.Size(573, 117);
            this.tsMenu.Stretch = true;
            this.tsMenu.TabIndex = 1;
            this.tsMenu.TabStop = true;
            this.tsMenu.Text = "Menu";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 117);
            // 
            // tsLogin
            // 
            this.tsLogin.AutoSize = false;
            this.tsLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsLogin.Image")));
            this.tsLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsLogin.Size = new System.Drawing.Size(104, 114);
            this.tsLogin.Text = "&Log in";
            this.tsLogin.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 117);
            // 
            // tsClients
            // 
            this.tsClients.AutoSize = false;
            this.tsClients.Image = ((System.Drawing.Image)(resources.GetObject("tsClients.Image")));
            this.tsClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClients.Name = "tsClients";
            this.tsClients.Size = new System.Drawing.Size(104, 114);
            this.tsClients.Text = "&Clients";
            this.tsClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsClients.Click += new System.EventHandler(this.tsClients_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 117);
            // 
            // tsProducts
            // 
            this.tsProducts.AutoSize = false;
            this.tsProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsProducts.Image")));
            this.tsProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsProducts.Name = "tsProducts";
            this.tsProducts.Size = new System.Drawing.Size(104, 114);
            this.tsProducts.Text = "&Products";
            this.tsProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsProducts.Click += new System.EventHandler(this.tsProducts_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 117);
            // 
            // tsTransactions
            // 
            this.tsTransactions.AutoSize = false;
            this.tsTransactions.Image = ((System.Drawing.Image)(resources.GetObject("tsTransactions.Image")));
            this.tsTransactions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsTransactions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTransactions.Name = "tsTransactions";
            this.tsTransactions.Size = new System.Drawing.Size(104, 114);
            this.tsTransactions.Text = "&Transactions";
            this.tsTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsTransactions.Click += new System.EventHandler(this.tsTransactions_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 117);
            // 
            // tsLogout
            // 
            this.tsLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsLogout.Image")));
            this.tsLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogout.Name = "tsLogout";
            this.tsLogout.Size = new System.Drawing.Size(104, 114);
            this.tsLogout.Text = "Log &out";
            this.tsLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogout.Click += new System.EventHandler(this.tsLogout_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 117);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.productName,
            this.description,
            this.price,
            this.expDate,
            this.quantity});
            this.dgvResult.Location = new System.Drawing.Point(12, 210);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(871, 150);
            this.dgvResult.TabIndex = 2;
            // 
            // product_id
            // 
            this.product_id.FillWeight = 150F;
            this.product_id.HeaderText = "Product ID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 90;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 150;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 60;
            // 
            // expDate
            // 
            this.expDate.HeaderText = "Expiration Date";
            this.expDate.Name = "expDate";
            this.expDate.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 71;
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            this.epName.Icon = ((System.Drawing.Icon)(resources.GetObject("epName.Icon")));
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(895, 372);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.gbSearch);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainMenu";
            this.Text = "Sales Management";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsClients;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsProducts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsTransactions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbShearchProd;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.Button btnAll;
    }
}

