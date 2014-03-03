using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HtmlParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Private Methods

        //Oluþturduðum web sayfasýný otomatik açar...
        //Örnek olarak benzer bi sayfa yapýlabilir..
        private void hTMLOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.FileName = string.Empty;
            ofd.Filter = "HTML Files(*.html;*.htm)|*.html;*.htm";
            ofd.FilterIndex = 0;
            ofd.Multiselect = false;
            ofd.RestoreDirectory = true;
            ofd.Title = "HTML Dosya Aç";
            
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtAddressBar.Text = ofd.FileName;
                this.txtAddressBar_KeyDown(this.txtAddressBar, new KeyEventArgs(Keys.Enter));
            }
        }

        private List<HtmlTagPointer> ReadTableTag(string[] KaynakKodSatirlari)
        {
            /*
             * Buradaki amaç;
             * 
             * RichTextBox'daki satýrlarda tek tek "<table" ifadesi arýyoruz.. Dikkat "<table>" deðil çünkü table'ýn style
             * ayarý yapýlmýþsa "<table Border="1px" >" gibi biçimler mevcut olabilir. Fakat "<table" ifadesi olmasý gerekir 
             * ve sabittir.. Bir table tag açýldýðýný bildirir.
             * 
             * Burada RichTextBox satýrlarýnda tek tek gezerken o an ki satýrda bir table tag açýlýp açýlmadýðýný
             * Contains(içerir) metodu ile yakalýyoruz.. Amacým, HtmlTagPointer isimli class ile ilk for döngüsü ile
             * açýlan table tag'lerinin satýr numarasýný kaydetmek.
             * 
             * Ikinci for döngüsü ile de kapanýþ satýr numaralarýný yakalamak.. Böylece tablolar belirlenir..
             */
            List<HtmlTagPointer> tagPointerList = new List<HtmlTagPointer>();

            for (int i = 1; i < KaynakKodSatirlari.Length; i++)
            {
                if (KaynakKodSatirlari[i].Contains("<table"))
                {
                    HtmlTagPointer tagPointer = new HtmlTagPointer();
                    tagPointer.StartLineNumber = i;

                    tagPointerList.Add(tagPointer);
                }
            }

            int k = 0;

            if (tagPointerList.Count != 0)
            {
                for (int i = 1; i < KaynakKodSatirlari.Length; i++)
                {
                    if (KaynakKodSatirlari[i].Contains("</table"))
                    {
                        HtmlTagPointer tagPointer = tagPointerList[k];
                        tagPointer.EndLineNumber = i;

                        k++;
                    }
                }
            }
            return tagPointerList;
        }

        /// <summary>
        /// Hücre deðerini alan metod..
        /// </summary>
        /// <param name="cellPointer">Hücre 'nin td tag satýr nolarý..
        /// </param>
        /// <returns></returns>
        private string ReadCellValue(HtmlTagPointer cellPointer)
        {
            /*
             * 8) <td> deger
             * 9) </td>
             * 
             * Þeklinde deðerler saklanýr..
             * Burada CellPointer iki deðer tutuyor StartLineNumber=8 ve EndLineNumber=9 bizim amacýmýz StartLineNumber nolu 
             * satýrda ">" etiketinden EndLineNumber nolu satýrsa "<" etiketi arasýna kadar okuma yapacaðýz..
             */

            System.Text.StringBuilder strValue = new System.Text.StringBuilder();

            for (int i = cellPointer.StartLineNumber; i <= cellPointer.EndLineNumber; i++)
            {
                if (i != cellPointer.EndLineNumber)
                {
                    /*
                     * Html de okuyacaðýmýz deðerin satýrda baþladýðý index..
                     */
                    int degerBaslangic = this.richTextBox1.Lines[i].IndexOf('>');
                    strValue.AppendLine(this.richTextBox1.Lines[i].Substring(degerBaslangic + 1, this.richTextBox1.Lines[i].Length - degerBaslangic - 1));
                }
                else
                {
                    /*
                     * Html de "</td>" tag'inden önceki ksýýmda okunur..
                     */
                    int degerSonu = this.richTextBox1.Lines[i].IndexOf('<');
                    strValue.AppendLine(this.richTextBox1.Lines[i].Substring(0, degerSonu));
                }
            }

            //Deðerin sonuda boþluk varsa temizlenir..
            return strValue.ToString().TrimEnd();

        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtAddressBar.Text = " ";
            this.treeView1.Nodes.Add("Tablolar");
        }

        private void txtAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            /*
             * Enter 'a basýlýnca..
             */
            if (e.KeyCode == Keys.Enter)
            {
                /*
                 * Eðer adres yazýlmýþsa..
                 * Adresi Bar'ý kontrol ediyoruz adres var mý? Boþ deðilse..
                 * Bu sefer adres kontrol edilir.. Geçerli bir web Url 'simi diye eðer geçerli bir url ise..
                 * System.UriTypeConverter ile  URL'ye dönüþtürülür..
                 * WebBrowser navigate metodu ile adres açýlýr..
                 */
                if (txtAddressBar.Text.Trim() != "")
                {
                    System.UriTypeConverter uriConverter = new UriTypeConverter();

                    if (uriConverter.IsValid(txtAddressBar.Text))
                    {
                        this.webBrowser1.Navigate(uriConverter.ConvertFromString(txtAddressBar.Text).ToString());
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir internet adresi giriniz..");
                    }
                }
                else
                {
                    MessageBox.Show("Bir web adresi giriniz..");
                }
            }
        }

        private void txtAddressBar_TextChanged(object sender, EventArgs e)
        {
            /*
             * Biraz görselite katýyorum..
             */
            if (this.txtAddressBar.Text.Trim() == "" || this.txtAddressBar.Text == "Bir web adresi giriniz..")
            {
                this.txtAddressBar.Text = "Bir web adresi giriniz..";
                this.txtAddressBar.Font = new Font("Segoe Print", 8, FontStyle.Bold | FontStyle.Italic);
                this.txtAddressBar.ForeColor = Color.White;
                return;
            }
            else
            {
                this.txtAddressBar.Font = new Font("Segoe Print", 9, FontStyle.Bold | FontStyle.Italic);
                this.txtAddressBar.ForeColor = Color.Navy;
            }
        }

        private void txtAddressBar_Click(object sender, EventArgs e)
        {
            this.txtAddressBar.SelectAll();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            /*
             * Web sayfanýn kaynak kodunu okur..
             * 
             * Kaynak kodu içeren bir dosya sistemi(stream) oluþturulur..
             * Dosya okuyucu(streamReader) oluþturulur ve okuyacaðý dosya belirtilir..
             */
            System.IO.Stream stream = this.webBrowser1.DocumentStream;
            System.IO.StreamReader reader = new System.IO.StreamReader(stream);

            //Kaynak kod okunur ve richtextbox 'a aktarýlýr..
            this.richTextBox1.Text = reader.ReadToEnd();
        }

        private void tabloListesiVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Her liste ver denildiðinde temizleme yapýlýr..
             * Sürekli ayný Node'lar oluþmasýn diye
             * 
             * Tablolar isimli node genel node'dýr.. 
             * Bir deðiþkene aktarýlýr..
             */
            this.treeView1.Nodes[0].Nodes.Clear();
            TreeNode rootNode = this.treeView1.Nodes[0];

            /*
             * Tablolarýn bilgisinin listesi alýnýr..
             */
            List<HtmlTagPointer> TagPointerList = this.ReadTableTag(richTextBox1.Lines);

            /*
             * Eðer web sayfasýnda tablo varsa..
             */
            if (TagPointerList.Count != 0)
            {
                /*
                 * Kaydedilen tablolar sýrasýyla rootNode'a eklenir..
                 * Bu ekleme iþleminde HtmlTagPointer class'larý node'ýn tag özelliðine atýlýr.
                 */
                for (int i = 0; i < TagPointerList.Count; i++)
                {
                    HtmlTagPointer tagPointer = TagPointerList[i];

                    TreeNode tn = new TreeNode("Tablo-" + (i + 1).ToString());
                    tn.Tag = tagPointer;

                    rootNode.Nodes.Add(tn);
                }
            }


            /*
             * aktifleþen butonlar..
             */
            this.tabloSatýrlarýnýListeleToolStripMenuItem.Enabled = true;
        }

        private void tabloSatýrlarýnýListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode rootNode = this.treeView1.Nodes[0];

            if (rootNode.Nodes.Count != 0)
            {
                foreach (TreeNode tn in rootNode.Nodes)
                {
                    HtmlTagPointer tablePoint = (HtmlTagPointer)tn.Tag;

                    List<HtmlTagPointer> RowPointerList = new List<HtmlTagPointer>();

                    /*
                     * tr baþlangýçlarý kaydedilir..
                     */
                    for (int i = tablePoint.StartLineNumber; i < tablePoint.EndLineNumber; i++)
                    {
                        if (this.richTextBox1.Lines[i].Contains("<tr"))
                        {
                            HtmlTagPointer rowPointer = new HtmlTagPointer();
                            rowPointer.StartLineNumber = i;

                            RowPointerList.Add(rowPointer);
                        }
                    }

                    int k = 0;
                    /*
                     * tr bitiþleri kaydedilir..
                     */
                    for (int i = tablePoint.StartLineNumber; i < tablePoint.EndLineNumber; i++)
                    {
                        if (this.richTextBox1.Lines[i].Contains("</tr"))
                        {
                            HtmlTagPointer rowPointer = RowPointerList[k];
                            rowPointer.EndLineNumber = i;

                            k++;
                        }
                    }

                    /*
                     * Yakalanan tr 'ler treeView'a eklenir..
                     */
                    if (RowPointerList.Count != 0)
                    {
                        for (int i = 0; i < RowPointerList.Count; i++)
                        {
                            TreeNode rowTreeNode = new TreeNode("Row-" + (i + 1).ToString());
                            rowTreeNode.Tag = RowPointerList[i];

                            tn.Nodes.Add(rowTreeNode);
                        }
                    }
                }
            }

            /*
             * aktifleþen butonlar..
             */
            this.tabloHücreleriListeleToolStripMenuItem.Enabled = true;
        }

        private void tabloHücreleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * tabloSatýrlarýnýListeleToolStripMenuItem_Click event'i ile ayný kod satýrý aslýnda
             * sadece en baþýnda tüm tablolar için dön var bide "<tr" deðil "<td" tag aranýyor..
             */

            /*
             * Tüm tablolar için dön..
             */
            foreach (TreeNode t in this.treeView1.Nodes[0].Nodes)
            {
                TreeNode tableNode = t;
                /*
                 * Tablonun satýrlarý varsa..
                 */
                if (tableNode.Nodes.Count != 0)
                {
                    /*
                     * Tüm satýrlarda dön..
                     */
                    foreach (TreeNode rowNode in tableNode.Nodes)
                    {
                        HtmlTagPointer RowPoint = (HtmlTagPointer)rowNode.Tag;

                        List<HtmlTagPointer> CellPointerList = new List<HtmlTagPointer>();

                        /*
                         * td baþlangýçlarý kaydedilir..
                         */
                        for (int i = RowPoint.StartLineNumber; i < RowPoint.EndLineNumber; i++)
                        {
                            if (this.richTextBox1.Lines[i].Contains("<td"))
                            {
                                HtmlTagPointer cellPointer = new HtmlTagPointer();
                                cellPointer.StartLineNumber = i;

                                CellPointerList.Add(cellPointer);
                            }
                        }

                        int k = 0;
                        /*
                         * td bitiþleri kaydedilir..
                         */
                        for (int i = RowPoint.StartLineNumber; i < RowPoint.EndLineNumber; i++)
                        {
                            if (this.richTextBox1.Lines[i].Contains("</td"))
                            {
                                HtmlTagPointer cellPointer = CellPointerList[k];
                                cellPointer.EndLineNumber = i;

                                k++;
                            }
                        }

                        /*
                         * Yakalanan td 'ler treeView'a eklenir..
                         */
                        if (CellPointerList.Count != 0)
                        {
                            for (int i = 0; i < CellPointerList.Count; i++)
                            {
                                TreeNode cellTreeNode = new TreeNode("Cell-" + (i + 1).ToString());
                                cellTreeNode.Tag = CellPointerList[i];

                                rowNode.Nodes.Add(cellTreeNode);
                            }
                        }
                    }
                }
            }

            /*
             * aktifleþen butonlar..
             */
            this.tablolarýDataTableYapToolStripMenuItem.Enabled = true;
        }

        private void tablolarýDataTableYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode rootNode = this.treeView1.Nodes[0];

            this.dataTableViewToolStripMenuItem.DropDownItems.Clear();

            foreach (TreeNode tableNode in rootNode.Nodes)
            {
                //O an ki tablo için datatatble oluþturulur..
                System.Data.DataTable dt = new DataTable(tableNode.Text);

                int rowCount = tableNode.Nodes.Count;
                int cellCount = tableNode.Nodes[0].Nodes.Count;

                //Datatable kolonlarý oluþturulur..
                for (int i = 0; i < cellCount; i++)
                {
                    dt.Columns.Add("Column-" + (i + 1).ToString());
                }

                //Satýrlarý oluþturulur..
                for (int i = 0; i < rowCount; i++)
                {
                    TreeNode rowNode = tableNode.Nodes[i];
                    DataRow dr = dt.NewRow();

                    //Satýrlara deðerler eklenir..
                    for (int j = 0; j < cellCount; j++)
                    {
                        TreeNode cellNode = rowNode.Nodes[j];
                        HtmlTagPointer cellPointer = (HtmlTagPointer)cellNode.Tag;

                        //Satýr deðeri bir metod ile alýnýr..
                        string cellValue = this.ReadCellValue(cellPointer);
                        //satýra deðer yazýlýr..
                        dr[j] = cellValue;
                    }

                    //satýr tabloya eklenir..
                    dt.Rows.Add(dr);
                }


                //dataTableViewToolStripMenuItem altýna menü Item'lar eklenir....
                ToolStripItem tsi = new ToolStripButton();
                tsi.Text = tableNode.Text;
                tsi.Image = ImageList1.Images[0];
                tsi.Tag = dt;

                //Eklediðimiz item'lar týklanýnca çalýþacak void yazýlýr..
                tsi.Click += new EventHandler(tsi_Click);

                this.dataTableViewToolStripMenuItem.DropDownItems.Add(tsi);
            }

            ToolStripItem tsItm = new ToolStripSeparator();
            tsItm.Text = "-";

            this.dataTableViewToolStripMenuItem.DropDownItems.Add(tsItm);

            /*
             * Tüm tablolarýn kaydedilmeisini otomatik saðlayan bir item..(Excel ve XML için..)
             */
            tsItm = new ToolStripButton();
            tsItm.Text = "Tüm Tablolarý Excel 'e Kaydet !";
            tsItm.Click += new EventHandler(tsItmDoExcel_Click);

            this.dataTableViewToolStripMenuItem.DropDownItems.Add(tsItm);

            tsItm = new ToolStripButton();
            tsItm.Text = "Tüm Tablolarý XML Yap !";
            tsItm.Click += new EventHandler(tsItmDoXML_Click);

            this.dataTableViewToolStripMenuItem.DropDownItems.Add(tsItm);

            /*
             * menu aktifleþtirilir..
             */
            this.dataTableViewToolStripMenuItem.Enabled = true;
        }

        void tsItmDoExcel_Click(object sender, EventArgs e)
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
                        excelFile = new System.IO.FileInfo(Application.StartupPath + "\\" + "dosya.xlsx");
                        break;
                    case 2:
                        excelFile = new System.IO.FileInfo(Application.StartupPath + "\\" + "dosya.xls");
                        break;
                    default:
                        break;
                }

                //Kaydet denilen konuma excel dosyasý kopyalanýr..
                excelFile.CopyTo(sfd.FileName, true);

                Form2 frm2 = new Form2();

                /*
                 * Tablolar yazýlýr..
                 */
                foreach (ToolStripItem tsi in this.dataTableViewToolStripMenuItem.DropDownItems)
                {
                    if (tsi is ToolStripButton && tsi.Image != null)
                    {
                        ToolStripButton tsb = tsi as ToolStripButton;
                        frm2.CreateExcelFile((DataTable)tsb.Tag, sfd);
                    }
                }
            }
        }

        void tsItmDoXML_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            fbd.SelectedPath = System.IO.Directory.GetCurrentDirectory();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Form2 frm2 = new Form2();

                /*
                 * Tablolar yazýlýr..
                 */
                foreach (ToolStripItem tsi in this.dataTableViewToolStripMenuItem.DropDownItems)
                {
                    if (tsi is ToolStripButton && tsi.Image != null)
                    {
                        ToolStripButton tsb = tsi as ToolStripButton;
                        frm2.CreateXmlFile((DataTable)tsb.Tag, fbd.SelectedPath + "\\" + tsb.Text + ".xml");
                    }
                }
            }
        }

        /// <summary>
        /// Data table View menüsünden bir item seçilince çalýþacak olan metod..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tsi_Click(object sender, EventArgs e)
        {
            ToolStripItem tsi = (ToolStripButton)sender;

            Form2 frm2 = new Form2();
            frm2.SetDataTable((DataTable)tsi.Tag);

            frm2.Show();
        }

        #endregion

        private void örnekHTMLAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtAddressBar.Text = Application.StartupPath + "\\" + "htmlsample.htm";
            this.txtAddressBar_KeyDown(this.txtAddressBar, new KeyEventArgs(Keys.Enter));
        }

    }
}