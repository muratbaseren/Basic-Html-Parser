namespace HtmlParser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAddressBar = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabloListesiVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabloSatýrlarýnýListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabloHücreleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tablolarýDataTableYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.örnekHTMLAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddressBar
            // 
            this.txtAddressBar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAddressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddressBar.Location = new System.Drawing.Point(0, 0);
            this.txtAddressBar.Name = "txtAddressBar";
            this.txtAddressBar.Size = new System.Drawing.Size(608, 20);
            this.txtAddressBar.TabIndex = 0;
            this.txtAddressBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddressBar.Click += new System.EventHandler(this.txtAddressBar_Click);
            this.txtAddressBar.TextChanged += new System.EventHandler(this.txtAddressBar_TextChanged);
            this.txtAddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddressBar_KeyDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(608, 402);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(182, 400);
            this.treeView1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.webBrowser1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer2.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(420, 402);
            this.splitContainer2.SplitterDistance = 242;
            this.splitContainer2.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(418, 240);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(418, 130);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.dataTableViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTMLAçToolStripMenuItem,
            this.örnekHTMLAçToolStripMenuItem,
            this.toolStripMenuItem3,
            this.tabloListesiVerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tabloSatýrlarýnýListeleToolStripMenuItem,
            this.tabloHücreleriListeleToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tablolarýDataTableYapToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // hTMLAçToolStripMenuItem
            // 
            this.hTMLAçToolStripMenuItem.Name = "hTMLAçToolStripMenuItem";
            this.hTMLAçToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.hTMLAçToolStripMenuItem.Text = "HTML Aç";
            this.hTMLAçToolStripMenuItem.Click += new System.EventHandler(this.hTMLOpenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(201, 6);
            // 
            // tabloListesiVerToolStripMenuItem
            // 
            this.tabloListesiVerToolStripMenuItem.Name = "tabloListesiVerToolStripMenuItem";
            this.tabloListesiVerToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tabloListesiVerToolStripMenuItem.Text = "Tablo Listesi Ver";
            this.tabloListesiVerToolStripMenuItem.Click += new System.EventHandler(this.tabloListesiVerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // tabloSatýrlarýnýListeleToolStripMenuItem
            // 
            this.tabloSatýrlarýnýListeleToolStripMenuItem.Enabled = false;
            this.tabloSatýrlarýnýListeleToolStripMenuItem.Name = "tabloSatýrlarýnýListeleToolStripMenuItem";
            this.tabloSatýrlarýnýListeleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tabloSatýrlarýnýListeleToolStripMenuItem.Text = "Tablo Satýrlarýný Listele";
            this.tabloSatýrlarýnýListeleToolStripMenuItem.Click += new System.EventHandler(this.tabloSatýrlarýnýListeleToolStripMenuItem_Click);
            // 
            // tabloHücreleriListeleToolStripMenuItem
            // 
            this.tabloHücreleriListeleToolStripMenuItem.Enabled = false;
            this.tabloHücreleriListeleToolStripMenuItem.Name = "tabloHücreleriListeleToolStripMenuItem";
            this.tabloHücreleriListeleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tabloHücreleriListeleToolStripMenuItem.Text = "Tablo Hücreleri Listele";
            this.tabloHücreleriListeleToolStripMenuItem.Click += new System.EventHandler(this.tabloHücreleriListeleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 6);
            // 
            // tablolarýDataTableYapToolStripMenuItem
            // 
            this.tablolarýDataTableYapToolStripMenuItem.Enabled = false;
            this.tablolarýDataTableYapToolStripMenuItem.Name = "tablolarýDataTableYapToolStripMenuItem";
            this.tablolarýDataTableYapToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tablolarýDataTableYapToolStripMenuItem.Text = "Tablolarý DataTable yap !";
            this.tablolarýDataTableYapToolStripMenuItem.Click += new System.EventHandler(this.tablolarýDataTableYapToolStripMenuItem_Click);
            // 
            // dataTableViewToolStripMenuItem
            // 
            this.dataTableViewToolStripMenuItem.Enabled = false;
            this.dataTableViewToolStripMenuItem.Name = "dataTableViewToolStripMenuItem";
            this.dataTableViewToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.dataTableViewToolStripMenuItem.Text = "Data Table View";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Program-File1-4.ico");
            // 
            // örnekHTMLAçToolStripMenuItem
            // 
            this.örnekHTMLAçToolStripMenuItem.Name = "örnekHTMLAçToolStripMenuItem";
            this.örnekHTMLAçToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.örnekHTMLAçToolStripMenuItem.Text = "Örnek HTML Aç";
            this.örnekHTMLAçToolStripMenuItem.Click += new System.EventHandler(this.örnekHTMLAçToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 422);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtAddressBar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HTML Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddressBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabloListesiVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tablolarýDataTableYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabloSatýrlarýnýListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabloHücreleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dataTableViewToolStripMenuItem;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.ToolStripMenuItem hTMLAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem örnekHTMLAçToolStripMenuItem;
    }
}

