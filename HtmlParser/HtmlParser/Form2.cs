using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;


namespace HtmlParser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void SetDataTable(DataTable dt)
        {
            this.Text = dt.TableName;
            this.dataGridView1.DataSource = dt;
        }


        #region XML Export

        public void CreateXmlFile(DataTable dt, string fileName)
        {
            try
            {
                /*
                 * DataTable nesnesinin WriteXML metodu ile XmlSchema ile tablo yazýlýr..
                 */
                dt.WriteXml(fileName, XmlWriteMode.WriteSchema, true);

                MessageBox.Show("Tablo XML olarak kaydedildi..", "XML Kayýt Baþarýlý..", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void tabloyuXMLYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Data Table To XML File";
            sfd.Filter = "XML Dosyalar(*.xml)|*.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.CreateXmlFile((DataTable)dataGridView1.DataSource, sfd.FileName);
            }
        }

        #endregion



        #region Excel Export

        public void CreateExcelFile(DataTable dt, SaveFileDialog sfd)
        {

            //Excel dosyasý için baðlantý ve sorgu çalýþtýrýcý tamýnlanýr..
            OleDbConnection conOleDBConnection = new OleDbConnection();
            OleDbCommand comOleDBCommand = new OleDbCommand();

            switch (sfd.FilterIndex)
            {
                case 1:
                    /*
                     * Excel 2007 için..
                     */
                    conOleDBConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + sfd.FileName + ";Extended Properties=" + Char.ConvertFromUtf32(34) + "Excel 12.0" + Char.ConvertFromUtf32(34) + ";";
                    break;
                case 2:
                    /*
                     * Excel 2003 için..
                     */
                    conOleDBConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sfd.FileName + ";Extended Properties=" + Char.ConvertFromUtf32(34) + "Excel 8.0" + Char.ConvertFromUtf32(34) + ";";
                    break;
                default:
                    break;
            }

            

            //Command connection özelliði ayarlanýr...
            comOleDBCommand.Connection = conOleDBConnection;

            //Baðlantý açýlýr..
            conOleDBConnection.Open();

            #region Export Excel

            /*
             * Excel dosyasýnda tablo oluþturmak için kolon isimleri sýralanýr.
             */
            System.Text.StringBuilder columnText = new StringBuilder();

            foreach (DataColumn dc in dt.Columns)
            {
                columnText.Append("[" + dc.ColumnName + "] string, ");
            }

            columnText = columnText.Remove(columnText.Length - 2, 2);

            /*
             * Excel dosyasýnda tablo oluþturulur..
             */
            comOleDBCommand.CommandText = "CREATE TABLE [" + dt.TableName.Replace("-", "").ToString() + "] (" + columnText + ");";
            comOleDBCommand.ExecuteNonQuery();


            /*
             * Kolon isimleri insert sorgusu için sýralanýr..
             */
            System.Text.StringBuilder columns = new StringBuilder();

            foreach (DataColumn dc in dt.Columns)
            {
                columns.Append("[" + dc.ColumnName + "], ");
            }

            columns = columns.Remove(columns.Length - 2, 2);

            /*
             * Datatable'daki her bir satýr excel dosyasýndaki tabloya eklenir..
             */
            foreach (DataRow datRow in dt.Rows)
            {
                comOleDBCommand.CommandType = CommandType.Text;

                /*
                 * Kolon deðerleri insert sorgusu için sýralanýr..
                 */
                System.Text.StringBuilder values = new StringBuilder();

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    values.Append("'" + datRow[i].ToString() + "', ");
                }

                values = values.Remove(values.Length - 2, 2);

                /*
                 * Insert cümlesi oluþturulur..
                 */
                comOleDBCommand.CommandText = "INSERT INTO [" + dt.TableName.Replace("-", "").ToString() + "$] (" + columns + ") VALUES (" + values + ");";

                /*
                 * Satýr eklenir..
                 */
                comOleDBCommand.ExecuteNonQuery();
            }


            MessageBox.Show("Kayýt iþlemi baþarýlý..", "Kayýt iþlemi Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            #endregion

            //Baðlantý kapatýlýr..
            conOleDBConnection.Close();

        }

        private void tabloyuExcelYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dosya kaydet dialog penceresi özellikleri ayarlanýr..
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Excel Export";
            sfd.Filter = "Excel 2007 (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo excelFile = null;

                switch (sfd.FilterIndex)
                {
                    case 1:
                        /*
                         * Excel 2007 için..
                         */
                       excelFile = new System.IO.FileInfo(Application.StartupPath + "\\" + "dosya.xlsx");
                        break;
                    case 2:
                        /*
                         * Excel 2003 için..
                         */
                        excelFile = new System.IO.FileInfo(Application.StartupPath + "\\" + "dosya.xls");
                        break;
                    default:
                        break;
                }

                //Kaydet denilen konuma excel dosyasý kopyalanýr..
                excelFile.CopyTo(sfd.FileName, true);

                //Excel'e yazýlmak üzere datatable yollanýr..
                this.CreateExcelFile((DataTable)this.dataGridView1.DataSource, sfd);
            }
        }

        #endregion



        #region SQL Process

        private void RadioButtons_CheckedChange(object sender, EventArgs e)
        {
            if (this.rdbWinAut.Checked)
            {
                this.txtUserName.Enabled = false;
                this.txtPassword.Enabled = false;
            }
            else
            {
                this.txtUserName.Enabled = true;
                this.txtPassword.Enabled = true;
            }
        }

        /// <summary>
        /// Baðlantýyý kuracak özellik..
        /// </summary>
        private Server _srv;
        public Server Srv
        {
            get { return _srv; }
            set { _srv = value; }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            /*
             * Baðlantý þekline göre server nesnesi oluþturulur..
             */
            if (this.rdbWinAut.Checked)
            {
                this._srv = new Server(new ServerConnection(txtServerName.Text));
            }
            else
            {
                this._srv = new Server(new ServerConnection(txtServerName.Text, txtUserName.Text, txtPassword.Text));
            }

            /*
             * Database'ler listelenir..
             */
            foreach (Database db in Srv.Databases)
            {
                this.lstDatabases.Items.Add(db);
            }

            if (this.lstDatabases.Items.Count != 0)
            {
                this.tabloyuSQLeExportEtToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Tabloyu kaydedecek bir database listesi yapýlamadý.. Lütfen ilk önce sisteminize bir database ekleyiniz..", "Database listesi mevcut deðil !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        #region SQL Export

        private void tabloyuSQLeExportEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Eðer tabloyu kaydedecek bir database seçilmediyse iþlem durur..
             */
            if (this.lstDatabases.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tabloyu Export etmek için bir database seçiniz..", "Seçili database yok !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            try
            {
                /*
             * Kaydedilecek tablo okunur..
             */
                DataTable dt = (DataTable)this.dataGridView1.DataSource;

                /*
                 * Tablo oluþturulur..
                 */
                Table tbl = new Table((Database)this.lstDatabases.SelectedItem, dt.TableName);

                /*
                 * Tablo kolonlarý eklenir..
                 */
                foreach (DataColumn dc in dt.Columns)
                {
                    Column clm = new Column(tbl, dc.ColumnName, new DataType(SqlDataType.NVarCharMax));

                    tbl.Columns.Add(clm);
                }

                /*
                 * Seçili database'de tablo oluþturulur..
                 */
                tbl.Create();

                /*
                 * Tablonun oluþturulduðu database'e baðlantý çevrilir..
                 */
                this.Srv.ConnectionContext.SqlConnectionObject.Open();
                this.Srv.ConnectionContext.SqlConnectionObject.ChangeDatabase(((Database)this.lstDatabases.SelectedItem).Name);

                /*
                 * Insert cumlesini otomatik oluþturmak için CommandBuilder kullandým..
                 * CommandBUilder ise DataAdapter nesnesi ister..
                 * DataAdapter nesnesinede Hangi tablonun insert cümlesini oluþturacaksan onun select sorgusu yazýlýr..
                 * Baðlantýda zaten vardý, bidaha oluþturulmaz verilir..
                 */
                System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [" + dt.TableName + "]", this.Srv.ConnectionContext.SqlConnectionObject);
                System.Data.SqlClient.SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);

                /*
                 * Insert cümlesi oluþturulur..
                 */
                cmdBuilder.DataAdapter.InsertCommand = cmdBuilder.GetInsertCommand(false);

                /*
                 * Sýrayla datatable'ýmýzdaki satýrlar parametre þeklinde deðerleri ile beraber eklenir ve
                 * insert iþlemi execute edilir..
                 */
                foreach (DataRow dr in dt.Rows)
                {
                    //Her defada parametreleri temzilemezsek ayný parametreleri birden fazla kere eklemiþ oluruz..
                    cmdBuilder.DataAdapter.InsertCommand.Parameters.Clear();

                    int i = 0;

                    foreach (Column c in tbl.Columns)
                    {
                        cmdBuilder.DataAdapter.InsertCommand.Parameters.AddWithValue("@p" + (i + 1).ToString(), dr[i].ToString());
                        i++;
                    }

                    //Deðerler insert edilir..
                    cmdBuilder.DataAdapter.InsertCommand.ExecuteNonQuery();
                }

                /*
                 * Eðer bu noktaya ulaþýlýrsa sorunsuzca tablo SQL 'e atýlmýþ demektir..
                 */
                MessageBox.Show("Tablo baþarýyla database'e kaydedilmiþtir..", "SQL Export Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                /*
                 * SQL HATA !
                 */
                System.Windows.Forms.MessageBox.Show(sqlEx.Message, sqlEx.Source, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                /*
                 * GENEL HATA !
                 */
                System.Windows.Forms.MessageBox.Show(ex.Message, ex.Source, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxDefaultButton.Button1);
            }
            finally
            {
                //Eðer hata sonucunda baðlantý açýk kaldýysa kapatýlýr..
                if (this.Srv.ConnectionContext.SqlConnectionObject.State == System.Data.ConnectionState.Open)
                {
                    this.Srv.ConnectionContext.SqlConnectionObject.Close();
                }
            }
        }

        #endregion

        #endregion


        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}