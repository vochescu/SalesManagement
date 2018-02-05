namespace GestiuneVanzari
{
    partial class frmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients));
            this.lvClients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbClients = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCsvImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsXmlImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBinaryImport = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCsvExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsXmlExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBinaryExport = new System.Windows.Forms.ToolStripMenuItem();
            this.grbClients.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvClients
            // 
            this.lvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvClients.GridLines = true;
            this.lvClients.Location = new System.Drawing.Point(12, 195);
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(803, 279);
            this.lvClients.TabIndex = 2;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            this.lvClients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client Id";
            this.columnHeader1.Width = 53;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 131;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adress";
            this.columnHeader6.Width = 147;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "City";
            this.columnHeader7.Width = 91;
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(86, 19);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(121, 20);
            this.tbClientId.TabIndex = 9;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(16, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(64, 13);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Client Name";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(745, 100);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 35);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(747, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 35);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNewClient
            // 
            this.btnNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewClient.Image = global::GestiuneVanzari.Properties.Resources.new_user;
            this.btnNewClient.Location = new System.Drawing.Point(745, 27);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(68, 65);
            this.btnNewClient.TabIndex = 13;
            this.btnNewClient.Text = "&New Client";
            this.btnNewClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Image = global::GestiuneVanzari.Properties.Resources.search_button_png_transparent___2_;
            this.btnSearch.Location = new System.Drawing.Point(213, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 30);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&SEARCH";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grbClients
            // 
            this.grbClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbClients.Controls.Add(this.tbClientId);
            this.grbClients.Controls.Add(this.lbName);
            this.grbClients.Controls.Add(this.btnSearch);
            this.grbClients.Location = new System.Drawing.Point(12, 100);
            this.grbClients.Name = "grbClients";
            this.grbClients.Size = new System.Drawing.Size(729, 71);
            this.grbClients.TabIndex = 16;
            this.grbClients.TabStop = false;
            this.grbClients.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 17;
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
            this.tsCsvImport.Size = new System.Drawing.Size(128, 22);
            this.tsCsvImport.Text = "&CSV File";
            // 
            // tsXmlImport
            // 
            this.tsXmlImport.Name = "tsXmlImport";
            this.tsXmlImport.Size = new System.Drawing.Size(128, 22);
            this.tsXmlImport.Text = "&XML File";
            // 
            // tsBinaryImport
            // 
            this.tsBinaryImport.Name = "tsBinaryImport";
            this.tsBinaryImport.Size = new System.Drawing.Size(128, 22);
            this.tsBinaryImport.Text = "&Binary File";
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
            this.tsCsvExport.Size = new System.Drawing.Size(128, 22);
            this.tsCsvExport.Text = "&CSV File";
            // 
            // tsXmlExport
            // 
            this.tsXmlExport.Name = "tsXmlExport";
            this.tsXmlExport.Size = new System.Drawing.Size(128, 22);
            this.tsXmlExport.Text = "&XML File";
            // 
            // tsBinaryExport
            // 
            this.tsBinaryExport.Name = "tsBinaryExport";
            this.tsBinaryExport.Size = new System.Drawing.Size(128, 22);
            this.tsBinaryExport.Text = "&Binary File";
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(827, 486);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.lvClients);
            this.Controls.Add(this.grbClients);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClients";
            this.Text = "Clients";
            this.grbClients.ResumeLayout(false);
            this.grbClients.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbClients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCsvImport;
        private System.Windows.Forms.ToolStripMenuItem tsXmlImport;
        private System.Windows.Forms.ToolStripMenuItem tsBinaryImport;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCsvExport;
        private System.Windows.Forms.ToolStripMenuItem tsXmlExport;
        private System.Windows.Forms.ToolStripMenuItem tsBinaryExport;

    }
}