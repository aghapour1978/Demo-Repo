using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace ReadXML
{
    public partial class frmMain : Form
    {
        BindingSource bs = new BindingSource();
        public frmMain()
        {
            InitializeComponent();
        }

        private void CmdReadXML_Click(object sender, EventArgs e)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            FileStream fs = new FileStream("3211.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);


            //MessageBox.Show(ReadXMLNodes(xmldoc, "LastLoginTime"));
            //MessageBox.Show(ReadXMLNodes(xmldoc, "LastLoginIp"));
            //MessageBox.Show(ReadXMLNodes(xmldoc, "LoginCount"));
        }

        //private string ReadXMLNodes(XmlDataDocument xmldoc,string strNodeName)
        //{
        //    string strRet = "";
        //    XmlNodeList xmlnode;
        //    xmlnode = xmldoc.GetElementsByTagName(strNodeName);
        //    //xmlnode = xmldoc.GetElementsByTagName("LastLoginIP");
        //    //for (int i = 0; i <= xmlnode.Count - 1; i++)
        //    {
        //        try
        //        {
        //            strRet = (xmlnode[0].ChildNodes.Item(0).InnerText.Trim());
        //        }
        //        catch { }
        //    }

        //    return strRet;
        //}

        //private void ReadXML(string strFileName, System.Data.DataTable tbl)
        //{
        //    XmlDataDocument xmldoc = new XmlDataDocument();

        //    XmlNodeList xmlnode;
        //    int i = 0;
        //    string str = null;
        //    FileStream fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
        //    xmldoc.Load(fs);



        //    xmlnode = xmldoc.GetElementsByTagName("USER");

        //    for (i = 0; i <= xmlnode.Count - 1; i++)
        //    {
        //        //xmlnode[i].ChildNodes.Item(0).InnerText.Trim();


        //        /*
        //                        DataRow rowTbl1 = tbl.NewRow();
        //                        rowTbl1["UserName"] = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
        //                        rowTbl1["EnableAccount"] = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
        //                        rowTbl1["EnablePassword"] = xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
        //                        rowTbl1["Password"] = xmlnode[i].ChildNodes.Item(3).InnerText.Trim();
        //                        rowTbl1["ProtocolType"] = xmlnode[i].ChildNodes.Item(4).InnerText.Trim();
        //                        rowTbl1["EnableExpire"] = xmlnode[i].ChildNodes.Item(5).InnerText.Trim();
        //                        rowTbl1["ExpireTime"] = xmlnode[i].ChildNodes.Item(6).InnerText.Trim();
        //         */
        //        XmlNodeList xmlnodeFolder;
        //        cbUserName.Items.Add(xmlnode[i].ChildNodes.Item(0).InnerText.Trim());

        //        {
        //            xmlnodeFolder = xmldoc.GetElementsByTagName("Folder");
        //            for (int j = 0; j <= xmlnodeFolder.Count - 1; j++)
        //            {
        //                DataRow rowTbl = tbl.NewRow();
        //                rowTbl["UserName"] = ReadXMLNodes(xmldoc, "UserName");// xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
        //                rowTbl["EnableAccount"] = ReadXMLNodes(xmldoc, "EnableAccount"); // xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
        //                rowTbl["EnablePassword"] = ReadXMLNodes(xmldoc, "EnablePassword"); // xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
        //                rowTbl["Password"] = "";// ReadXMLNodes(xmldoc, ""); //xmlnode[i].ChildNodes.Item(3).InnerText.Trim();
        //                rowTbl["ProtocolType"] = ReadXMLNodes(xmldoc, "ProtocolType"); //xmlnode[i].ChildNodes.Item(4).InnerText.Trim();
        //                rowTbl["EnableExpire"] = ReadXMLNodes(xmldoc, "EnableExpire"); //xmlnode[i].ChildNodes.Item(5).InnerText.Trim();
        //                rowTbl["ExpireTime"] = ReadXMLNodes(xmldoc, "ExpireTime"); //xmlnode[i].ChildNodes.Item(6).InnerText.Trim();
        //                rowTbl["LoginCount"] = ReadXMLNodes(xmldoc, "LoginCount"); //xmlnode[i].ChildNodes.Item(47).InnerText.Trim();
        //                rowTbl["LastLoginIp"] = ReadXMLNodes(xmldoc, "LastLoginIp"); //xmlnode[i].ChildNodes.Item(52).InnerText.Trim();

        //                rowTbl["LastLoginTime"] = ReadXMLNodes(xmldoc, "LastLoginTime"); //xmlnode[i].ChildNodes.Item(53).InnerText.Trim();
        //                //rowTbl["LastLoginTime"] = ReadXMLNodes(xmldoc, ""); //xmlnode[i].ChildNodes.Item(54).InnerText.Trim();
        //                //rowTbl[""] = xmlnode[i].ChildNodes.Item(6).InnerText.Trim();




        //                rowTbl["Path"]= xmlnodeFolder[j].ChildNodes.Item(0).InnerText.Trim();
        //                rowTbl["Alias"]= xmlnodeFolder[j].ChildNodes.Item(1).InnerText.Trim();
        //                rowTbl["Home_Dir"]= xmlnodeFolder[j].ChildNodes.Item(2).InnerText.Trim();
        //                rowTbl["File_Read"]= xmlnodeFolder[j].ChildNodes.Item(3).InnerText.Trim();
        //                rowTbl["File_Write"]= xmlnodeFolder[j].ChildNodes.Item(4).InnerText.Trim();
        //                rowTbl["File_Append"]= xmlnodeFolder[j].ChildNodes.Item(5).InnerText.Trim();
        //                rowTbl["File_Delete"]= xmlnodeFolder[j].ChildNodes.Item(6).InnerText.Trim();
        //                rowTbl["Directory_List"]= xmlnodeFolder[j].ChildNodes.Item(7).InnerText.Trim();
        //                rowTbl["Directory_Rename"]= xmlnodeFolder[j].ChildNodes.Item(8).InnerText.Trim();
        //                rowTbl["Directory_Make"]= xmlnodeFolder[j].ChildNodes.Item(9).InnerText.Trim();
        //                rowTbl["Directory_Delete"]= xmlnodeFolder[j].ChildNodes.Item(10).InnerText.Trim();
        //                rowTbl["File_Rename"]= xmlnodeFolder[j].ChildNodes.Item(11).InnerText.Trim();
        //                rowTbl["Zip_File"]= xmlnodeFolder[j].ChildNodes.Item(12).InnerText.Trim();
        //                rowTbl["Unzip_File"]= xmlnodeFolder[j].ChildNodes.Item(13).InnerText.Trim();

        //                tbl.Rows.Add(rowTbl);

        //                //xmlnodeFolder[i].ChildNodes.Item(0).InnerText.Trim();
        //                //str = xmlnode + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
        //                //MessageBox.Show(str);
        //            }
        //        }
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpLastLoginDate.Value = new DateTime(2000,1,1,0,0,0);
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text= folderBrowserDialog1.SelectedPath;
            }
        }


        int iCnt = 0;

        private void Start(string dir)
        {

            //System.Data.DataTable tbl = new System.Data.DataTable("M");
            //tbl.Columns.Add("UserName");
            //tbl.Columns.Add("LoginCount");
            //tbl.Columns.Add("LastLoginTime");
            //tbl.Columns.Add("LastLoginIp");

            //tbl.Columns.Add("Path");
            //tbl.Columns.Add("Alias");
            //tbl.Columns.Add("Home_Dir");
            //tbl.Columns.Add("File_Read");
            //tbl.Columns.Add("File_Write");
            //tbl.Columns.Add("File_Append");
            //tbl.Columns.Add("File_Delete");
            //tbl.Columns.Add("Directory_List");
            //tbl.Columns.Add("Directory_Rename");
            //tbl.Columns.Add("Directory_Make");
            //tbl.Columns.Add("Directory_Delete");
            //tbl.Columns.Add("File_Rename");
            //tbl.Columns.Add("Zip_File");
            //tbl.Columns.Add("Unzip_File");

            //tbl.Columns.Add("ExpireTime");
            //tbl.Columns.Add("EnableAccount");
            //tbl.Columns.Add("Password");
            //tbl.Columns.Add("EnablePassword");
            //tbl.Columns.Add("ProtocolType");
            //tbl.Columns.Add("EnableExpire");

            //tbl.Clear();

            dgvReport.DataSource = null;
            dgvReport.AutoGenerateColumns = true;

            //foreach (string f in Directory.GetFiles(dir))
            //{
            //    //try
            //    {
            //        ReadXML(f, tbl);
            //        iCnt++;
            //    }
            //    //catch (Exception Ex)
            //    {
            //        //MessageBox.Show(Ex.Message);
            //    }
            //}

            System.Data.DataTable tbl = ReadXML.Reader.Start(txtPath.Text);

            dgvReport.DataSource = tbl;
            bs.DataSource = (System.Data.DataTable)dgvReport.DataSource;

            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tsslCount.Text = dgvReport.Rows.Count.ToString();
            tsslCount.Text += string.Format(" Users: {0}",iCnt);
            dgvReport.AutoResizeColumns();
        }
        private void CmdStart_Click(object sender, EventArgs e)
        {
            Start(txtPath.Text);

        }

        private void CmdExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdXls = new SaveFileDialog();
            sfdXls.Filter = "Excel Files (*.Xls) |*.xls";
            sfdXls.Title = "Save in Excel File";
            if ( sfdXls.ShowDialog() == DialogResult.OK)
            {
                if (sfdXls.FileName != "")
                {
                    getExcelFile(sfdXls.FileName);
                }
            }

            
        }


        private void getExcelFile(string strFileName)
        {

            //Create COM Objects. Create a COM object for everything that is referenced
            int rowCount = 1;// xlRange.Rows.Count;
            int colCount = 1;// xlRange.Columns.Count;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!

            /*
             prepare output file*/
            Excel.Application xlAppOut = new Microsoft.Office.Interop.Excel.Application();

            //////////////////
            //////

            if (xlAppOut == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            object misValue = System.Reflection.Missing.Value;
            Excel.Workbook xlWorkBookOut = xlAppOut.Workbooks.Add(misValue);
            Excel.Worksheet xlWorkSheetOut = (Excel.Worksheet)xlWorkBookOut.Worksheets.get_Item(1);

            //xlWorkBookOut 
            //xlWorkSheetOut = 




            /*            if (xlRange.Cells[1, 1] != null && xlRange.Cells[1, 1].Value2 != null)
                        {
                            if (xlRange.Cells[1, 2] != null && xlRange.Cells[1, 2].Value2 != null)
                            {
                                xlWorkSheetOut.Cells[1, 1] = xlRange.Cells[1, 1].Value2.ToString();
                                xlWorkSheetOut.Cells[1, 2] = xlRange.Cells[1, 2].Value2.ToString();
                                xlWorkSheetOut.Cells[1, 3] = "شناسه واریز";
                            }
                        }*/





            //            DataView typeFilter = new DataView((DataTable)dgvReport.DataSource,string.Format(@"
            //(UserName LIKE '%{0}%')
            //AND (Alias LIKE '%{1}%')
            //AND (Path LIKE '%{2}%')
            //AND (LastLoginTime >= '{3}')
            //", cbUserName.Text, txtAlias.Text, txtPathSearch.Text, dtpLastLoginDate.Value.ToString("yyyy-MM-dd tt:mm:ss")),"",DataViewRowState.OriginalRows);
            //            DataTable dtFiltered = typeFilter.ToTable();
            System.Data.DataTable tbl = (System.Data.DataTable)dgvReport.DataSource;//RefreshListReport();
            int iColIndex = 0;
            int iOutputFileRowCnt = 1;
            {
                iColIndex = 0;
                foreach (DataColumn col in tbl.Columns)
                {
                    iColIndex++;
                    xlWorkSheetOut.Cells[iOutputFileRowCnt, iColIndex] = col.ToString();
                }
            }

            iColIndex = 0;
            foreach (DataRow row in tbl.Rows)
            {
                {
                    iOutputFileRowCnt++;
                    iColIndex = 0;
                    foreach (DataColumn col in tbl.Columns)
                    {

                        iColIndex++;
                        xlWorkSheetOut.Cells[iOutputFileRowCnt, iColIndex] = row[col].ToString();

                        //xlWorkSheetOut.Cells[i, iColIndex].NumberFormat = "@";
                    }
                    //xlWorkSheetOut.Cells[i, 2].NumberFormat = "#";
                }
            }

            //xlWorkSheetOut.Cells.HorizontalAlignment = HorizontalAlignment.Right;





            //////////////////////////////
            //formatting
            if (iOutputFileRowCnt > 2)
            {
                int iCol = Convert.ToInt32('A') + iColIndex - 1;
                string strLastColIndex = Convert.ToChar(iCol).ToString();
                string strLastRow = string.Format("{0}", iOutputFileRowCnt);

                //MessageBox.Show(strLastColIndex);
                //string strEnd = string.Format("R{0}", iOutputFileRowCnt - 1);
                //Excel.Range workSheet_range = xlWorkSheetOut.get_Range(/*string.Format("A1", iColIndex)*/, strEnd + 1);

                Excel.Range workSheet_range = xlWorkSheetOut.get_Range("A1", strLastColIndex + strLastRow);



                workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
                //workSheet_range.Cells.HorizontalAlignment = HorizontalAlignment.Center;
                xlWorkSheetOut.Columns.AutoFit();
                xlWorkSheetOut.Cells.VerticalAlignment = HorizontalAlignment.Center;
                //xlWorkSheetOut.Cells.HorizontalAlignment = HorizontalAlignment.Center;
                //                xlWorkSheetOut.Cells.RowHeight = 25;
                xlWorkSheetOut.Rows.RowHeight = 25;
                //xlWorkSheetOut.Rows.HorizontalAlignment = HorizontalAlignment.Center;
                xlWorkSheetOut.Columns.HorizontalAlignment = HorizontalAlignment.Center;


                workSheet_range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }


            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            ////release com objects to fully kill excel process from running in the background
            //Marshal.ReleaseComObject(xlRange);
            //Marshal.ReleaseComObject(xlWorksheet);

            ////close and release
            //xlWorkbook.Close();
            //Marshal.ReleaseComObject(xlWorkbook);

            ////quit and release
            //xlApp.Quit();
            //Marshal.ReleaseComObject(xlApp);

            // Save output file
            {
                xlWorkBookOut.SaveAs(strFileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBookOut.Close(true, misValue, misValue);
                //IStyle pageHeader = (IStyle)xlWorkBookOut.Styles.Add("PageHeaderStyle");
                //IStyle tableHeader = (IStyle)xlWorkBookOut.Styles.Add("TableHeaderStyle");


                xlAppOut.Quit();

                Marshal.ReleaseComObject(xlWorkSheetOut);
                Marshal.ReleaseComObject(xlWorkBookOut);
                Marshal.ReleaseComObject(xlAppOut);
            }

            Process.Start(strFileName);
        }

        private void CmdRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }


        private void RefreshList()
        {
            bs.Filter = string.Format(@"
(UserName LIKE '%{0}%')
AND (Alias LIKE '%{1}%')
AND (Path LIKE '%{2}%')
AND (LastLoginTime >= '{3}')
", cbUserName.Text, txtAlias.Text, txtPathSearch.Text,  dtpLastLoginDate.Value.ToString("yyyy-MM-dd tt:mm:ss"));
            //MessageBox.Show(bs.Filter);
            if (txtLoginCount.Text != "")
            {
                bs.Filter += string.Format(@"
                AND(LoginCount = {0})
", txtLoginCount.Text);
            }

            //dgvReport.DataSource = bs.DataSource;
            tsslCount.Text = dgvReport.Rows.Count.ToString();



            //var distinctRows = (from DataGridViewRow row in dgvReport.Rows
            //                    select row.Cells[0]
            //                   ).Distinct().Count();
            //MessageBox.Show(distinctRows.ToString());

            /*var result = dgvReport.Rows.Cast<DataGridViewRow>()
                .Where(r => r.Cells[0].Value != null)
                .Select(r => r.Cells[0].Value)
                .GroupBy(id => id)
                    .OrderByDescending(id => id.Count())
                    .Select(g => new { Id = g.Key, Count = g.Count() });
            MessageBox.Show(result.);*/

        }

        private void CbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
