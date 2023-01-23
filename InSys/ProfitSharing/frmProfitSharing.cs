using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMan;
using Model = DataAccessLibrary.Model;
using static InSys.GlobalVariables;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using System.IO;
using Path = System.IO.Path;

namespace InSys.ProfitSharing
{
    public partial class frmProfitSharing : Form
    {
        ProfitSharingController profitController = new ProfitSharingController();
        PointOfSaleController posController = new PointOfSaleController();

        Model.ProfitSharing record = new Model.ProfitSharing();
        List<Model.ProfitSharing> records = new List<Model.ProfitSharing>();

        Result result;

        frmProfitShareDetail frmDetail = new frmProfitShareDetail();
        BindingSource listSource = new BindingSource();

        public frmProfitSharing()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetail = new frmProfitShareDetail();
            
            frmDetail.IsAddTransaction = true;
            frmDetail.ShowDialog();

            RefreshGridBindings();
        }

        private void pnlFrame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmProfitSharing_Load(object sender, EventArgs e)
        {
            RefreshGridBindings();
            
            GenerateSaleTransactions();
        }

        private void RefreshGridBindings()
        {
            records = profitController.SelectAll();

            listSource.DataSource = records;

            listSource.ResetBindings(false);

            dgvwRecords.DataSource = listSource;

            dgvwRecords.Columns["SharePercentage"].HeaderText = "Share Percentage";
            dgvwRecords.Columns["SharePercentage"].Width = 180;

            dgvwRecords.Columns["Id"].Visible = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            record = new Model.ProfitSharing();
            frmDetail = new frmProfitShareDetail();

            if (dgvwRecords.Rows.Count == 0)
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.SellerName = selectedRow.SellerName;
            record.SharePercentage = selectedRow.SharePercentage;

            frmDetail.Record = record;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            record = new Model.ProfitSharing();

            if (dgvwRecords.Rows.Count == 0)
                MessageBox.Show("No Records to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("Are you sure you want to delete the selected row?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.SellerName = selectedRow.SellerName;
            record.SharePercentage = selectedRow.SharePercentage;

            profitController.record = record;
            result = profitController.Delete();

            MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGridBindings();
        }

        private void btnSearchTransactions_Click(object sender, EventArgs e)
        {
            GenerateSaleTransactions();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
            string strSaleReportDirectory = Path.Combine(Environment.CurrentDirectory, "Reports");
            if (!Directory.Exists(strSaleReportDirectory))
                Directory.CreateDirectory(strSaleReportDirectory);

            strSaleReportDirectory = Path.Combine(strSaleReportDirectory, "Sale Transactions");
            if (!Directory.Exists(strSaleReportDirectory)) 
                Directory.CreateDirectory(strSaleReportDirectory);

            using (SpreadsheetDocument spreadsheet = SpreadsheetDocument.Create($"{strSaleReportDirectory}\\SaleTransaction_{DateTime.Now.ToString("yyyyMMddhhmmss")}.xlsx", SpreadsheetDocumentType.Workbook))
            {
                // Add a WorkbookPart to the document.
                WorkbookPart workbookpart = spreadsheet.AddWorkbookPart();
                workbookpart.Workbook = new Workbook();

                // Add a WorksheetPart to the WorkbookPart.
                WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                // Add Sheets to the Workbook.
                Sheets sheets = spreadsheet.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

                // Append a new worksheet and associate it with the workbook.
                Sheet sheet = new Sheet()
                {
                    Id = spreadsheet.WorkbookPart.
                    GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Sale Transactions"
                };
                sheets.Append(sheet);

                // Get the sheetData cell table.
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Add the header row.
                Row row = new Row();
                for (int i = 0; i < dgvwPOSTransactions.Columns.Count; i++)
                {
                    if (dgvwPOSTransactions.Columns[i].Visible == false)
                        continue;

                    Cell cell = new Cell();
                    cell.DataType = CellValues.String;
                    cell.CellValue = new CellValue(dgvwPOSTransactions.Columns[i].HeaderText);
                    row.AppendChild(cell);
                }
                sheetData.AppendChild(row);

                // Add the data rows.
                for (int i = 0; i < dgvwPOSTransactions.Rows.Count; i++)
                {
                    row = new Row();
                    for (int j = 0; j < dgvwPOSTransactions.Columns.Count; j++)
                    {
                        if (dgvwPOSTransactions.Columns[j].Visible == false)
                            continue;

                        Cell cell = new Cell();
                        cell.DataType = CellValues.String;
                        cell.CellValue = new CellValue(dgvwPOSTransactions.Rows[i].Cells[j].Value.ToString());
                        row.AppendChild(cell);
                    }
                    sheetData.AppendChild(row);
                }
            }
                MessageBox.Show($"Successfully generated Sales Transactions Report.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Encountered: {ex.ToString()}",APP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void GenerateSaleTransactions() {
            dtpFrom.Value = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day, 0, 0, 0);
            dtpTo.Value = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day, 23, 59, 59);

            posController.SelectSellerTransactions(dgvwPOSTransactions, dtpFrom.Value, dtpTo.Value, txtKeywordSearch.Text);
        }
    }
}
