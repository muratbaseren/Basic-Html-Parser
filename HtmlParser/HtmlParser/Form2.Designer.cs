namespace HtmlParser
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabloyuXMLYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabloyuExcelYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabloyuSQLeExportEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpDatabases = new System.Windows.Forms.GroupBox();
            this.lstDatabases = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbWinAut = new System.Windows.Forms.RadioButton();
            this.rdbSqlAut = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpDatabases.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabloyuXMLYapToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tabloyuExcelYapToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tabloyuSQLeExportEtToolStripMenuItem,
            this.toolStripMenuItem3,
            this.kapatToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // tabloyuXMLYapToolStripMenuItem
            // 
            this.tabloyuXMLYapToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tabloyuXMLYapToolStripMenuItem.Name = "tabloyuXMLYapToolStripMenuItem";
            this.tabloyuXMLYapToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.tabloyuXMLYapToolStripMenuItem.Text = "Tabloyu XML Yap !";
            this.tabloyuXMLYapToolStripMenuItem.Click += new System.EventHandler(this.tabloyuXMLYapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // tabloyuExcelYapToolStripMenuItem
            // 
            this.tabloyuExcelYapToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tabloyuExcelYapToolStripMenuItem.Name = "tabloyuExcelYapToolStripMenuItem";
            this.tabloyuExcelYapToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.tabloyuExcelYapToolStripMenuItem.Text = "Tabloyu Excel Yap !";
            this.tabloyuExcelYapToolStripMenuItem.Click += new System.EventHandler(this.tabloyuExcelYapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // tabloyuSQLeExportEtToolStripMenuItem
            // 
            this.tabloyuSQLeExportEtToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tabloyuSQLeExportEtToolStripMenuItem.Enabled = false;
            this.tabloyuSQLeExportEtToolStripMenuItem.Name = "tabloyuSQLeExportEtToolStripMenuItem";
            this.tabloyuSQLeExportEtToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.tabloyuSQLeExportEtToolStripMenuItem.Text = "Tabloyu SQL \'e Export Et !";
            this.tabloyuSQLeExportEtToolStripMenuItem.Click += new System.EventHandler(this.tabloyuSQLeExportEtToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpDatabases);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(629, 439);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 439);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(182, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Baðlantýsý Kurma";
            // 
            // grpDatabases
            // 
            this.grpDatabases.Controls.Add(this.lstDatabases);
            this.grpDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDatabases.Location = new System.Drawing.Point(5, 227);
            this.grpDatabases.Name = "grpDatabases";
            this.grpDatabases.Padding = new System.Windows.Forms.Padding(5);
            this.grpDatabases.Size = new System.Drawing.Size(182, 207);
            this.grpDatabases.TabIndex = 1;
            this.grpDatabases.TabStop = false;
            this.grpDatabases.Text = "Databases";
            // 
            // lstDatabases
            // 
            this.lstDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDatabases.FormattingEnabled = true;
            this.lstDatabases.Location = new System.Drawing.Point(5, 18);
            this.lstDatabases.Name = "lstDatabases";
            this.lstDatabases.Size = new System.Drawing.Size(172, 173);
            this.lstDatabases.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(5, 18);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtServerName);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnConnect);
            this.splitContainer2.Panel2.Controls.Add(this.rdbSqlAut);
            this.splitContainer2.Panel2.Controls.Add(this.rdbWinAut);
            this.splitContainer2.Panel2.Controls.Add(this.txtPassword);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.txtUserName);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer2.Size = new System.Drawing.Size(172, 199);
            this.splitContainer2.SplitterDistance = 46;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtServerName
            // 
            this.txtServerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtServerName.Location = new System.Drawing.Point(3, 21);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(164, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(3, 21);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(164, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanýcý Adý";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(3, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(164, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Þifre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbWinAut
            // 
            this.rdbWinAut.AutoSize = true;
            this.rdbWinAut.Checked = true;
            this.rdbWinAut.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbWinAut.Location = new System.Drawing.Point(3, 79);
            this.rdbWinAut.Name = "rdbWinAut";
            this.rdbWinAut.Size = new System.Drawing.Size(164, 17);
            this.rdbWinAut.TabIndex = 6;
            this.rdbWinAut.TabStop = true;
            this.rdbWinAut.Text = "Windows Authentication";
            this.rdbWinAut.UseVisualStyleBackColor = true;
            this.rdbWinAut.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChange);
            // 
            // rdbSqlAut
            // 
            this.rdbSqlAut.AutoSize = true;
            this.rdbSqlAut.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbSqlAut.Location = new System.Drawing.Point(3, 96);
            this.rdbSqlAut.Name = "rdbSqlAut";
            this.rdbSqlAut.Size = new System.Drawing.Size(164, 17);
            this.rdbSqlAut.TabIndex = 7;
            this.rdbSqlAut.Text = "SQL Authentication";
            this.rdbSqlAut.UseVisualStyleBackColor = true;
            this.rdbSqlAut.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChange);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConnect.Location = new System.Drawing.Point(3, 121);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(164, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Baðlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(205, 6);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 463);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "XML , Excel , SQL Export";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grpDatabases.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabloyuXMLYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tabloyuExcelYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tabloyuSQLeExportEtToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpDatabases;
        private System.Windows.Forms.ListBox lstDatabases;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RadioButton rdbSqlAut;
        private System.Windows.Forms.RadioButton rdbWinAut;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}