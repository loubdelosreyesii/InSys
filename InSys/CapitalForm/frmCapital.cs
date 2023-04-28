using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InSys.GlobalVariables;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Wordprocessing;

namespace InSys.CapitalForm
{
    public partial class frmCapital : Form
    {
        CapitalController capitalController = new CapitalController();
        Capital recordCapital = new Capital();

        public frmCapital()
        {
            InitializeComponent();
        }
        private void LoadBalance() {
            capitalController = new CapitalController();
            txtCurrentBalance.Text = capitalController.SelectCurrentBalance().ToString("N2");
        }

        private void LoadHistories() {
            capitalController = new CapitalController();

            dtpFrom.Value = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day, 0, 0, 0);
            dtpTo.Value = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day, 23, 59, 59);

            var recordHistories = capitalController.GetCapitalHistories(dtpFrom.Value,dtpTo.Value);

            var customRecordHistories = (from history in recordHistories
                                         select new { 
                                            Id = history.Id,
                                            TransactionDateTime = history.TransactionDateTime,
                                            RunningBalance = history.Amount+ history.OldFundBalance,
                                            Amount = history.Amount,
                                            Description = history.Description,
                                            OldFundBalance =    history.OldFundBalance
                                         }).ToList();
            dgvwPOSTransactions.DataSource = customRecordHistories;

            dgvwPOSTransactions.Columns["Id"].Visible = false;

            dgvwPOSTransactions.Columns["TransactionDateTime"].HeaderText = "Transaction Date/Time";
            dgvwPOSTransactions.Columns["RunningBalance"].HeaderText = "Running Balance";

            dgvwPOSTransactions.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvwPOSTransactions.Columns["OldFundBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvwPOSTransactions.Columns["RunningBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvwPOSTransactions.Columns["TransactionDateTime"].DisplayIndex = 0;
            dgvwPOSTransactions.Columns["TransactionDateTime"].Width = 200;
            dgvwPOSTransactions.Columns["Amount"].Width = 180;
            dgvwPOSTransactions.Columns["Description"].Width = 400;
            dgvwPOSTransactions.Columns["OldFundBalance"].Width = 180;
            dgvwPOSTransactions.Columns["RunningBalance"].Width = 180;

            dgvwPOSTransactions.Columns["Amount"].DefaultCellStyle.Format = "c";
            dgvwPOSTransactions.Columns["Amount"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
            dgvwPOSTransactions.Columns["OldFundBalance"].DefaultCellStyle.Format = "c";
            dgvwPOSTransactions.Columns["OldFundBalance"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
            dgvwPOSTransactions.Columns["RunningBalance"].DefaultCellStyle.Format = "c";
            dgvwPOSTransactions.Columns["RunningBalance"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");

        }
        private void btnAddFund_Click(object sender, EventArgs e)
        {
            pnlAddFund.Visible = true;
            txtFundAmountAdd.Text = String.Empty;
        }
        private void frmCapital_Load(object sender, EventArgs e)
        {
            LoadBalance();
            LoadHistories();
        }
        private void txtCurrentBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Decimal decAmountFunded;
            if (Decimal.TryParse(txtFundAmountAdd.Text, out decAmountFunded))
            {
                if (decAmountFunded < 0) {
                    MessageBox.Show("Amount provided is below zero. Please try again.", "InSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                capitalController = new CapitalController();
                pnlAddFund.Visible = false;

                recordCapital = new Capital();
                recordCapital.Id = 1;
                recordCapital.Amount = Convert.ToDecimal(txtCurrentBalance.Text) + decAmountFunded;
                recordCapital.TransactionDateTime = DateTime.Now;
                capitalController.record = recordCapital;
                capitalController.AddFund("Add Fund");
            }
            else
            {
                MessageBox.Show("Invalid Amount provided. Please try again.", "InSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadBalance();
            LoadHistories();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlAddFund.Visible = false;
            LoadBalance();
            LoadHistories();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            LoadBalance();
            LoadHistories();
        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {
            try
            {
                string strSaleReportDirectory = Path.Combine(Environment.CurrentDirectory, "Reports");
                if (!Directory.Exists(strSaleReportDirectory))
                    Directory.CreateDirectory(strSaleReportDirectory);

                strSaleReportDirectory = Path.Combine(strSaleReportDirectory, "Capital History");
                if (!Directory.Exists(strSaleReportDirectory))
                    Directory.CreateDirectory(strSaleReportDirectory);

                using (SpreadsheetDocument spreadsheet = SpreadsheetDocument.Create($"{strSaleReportDirectory}\\CapitalHistory_{DateTime.Now.ToString("yyyyMMddhhmmss")}.xlsx", SpreadsheetDocumentType.Workbook))
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
                        Name = "Capital History"
                    };
                    sheets.Append(sheet);

                    // Get the sheetData cell table.
                    SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                    // Add the header row.
                    Row row = new Row();
                    foreach (var item in dgvwPOSTransactions.Columns.OfType<DataGridViewColumn>().OrderBy(x=>x.DisplayIndex))
                    {
                        if (item.Visible == false)
                            continue;

                        Cell cell = new Cell();
                        cell.DataType = CellValues.String;
                        cell.CellValue = new CellValue(item.HeaderText);
                        row.AppendChild(cell);
                    }
                    
                    sheetData.AppendChild(row);
                    Worksheet worksheet = spreadsheet.WorkbookPart.WorksheetParts.First().Worksheet;
                    // Add the data rows.
                    for (int i = 0; i < dgvwPOSTransactions.Rows.Count; i++)
                    {
                        row = new Row();
                        foreach (var item in dgvwPOSTransactions.Columns.OfType<DataGridViewColumn>().OrderBy(x => x.DisplayIndex))
                        {
                            if (item.Visible == false)
                                continue;

                            Cell cell = new Cell();
                            cell.DataType = CellValues.String;
                            
                            if (item.HeaderText == "Transaction Date/Time")
                                cell.CellValue = new CellValue(dgvwPOSTransactions.Rows[i].Cells[2].Value.ToString());
                            else
                                cell.CellValue = new CellValue(dgvwPOSTransactions.Rows[i].Cells[item.DisplayIndex].Value.ToString());

                            var cellFormat = new CellFormat() { NumberFormatId = 164 };

                            row.AppendChild(cell);
                        }
                        sheetData.AppendChild(row);
                    }

                }
                MessageBox.Show($"Successfully generated Capital History Report.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Encountered: {ex.ToString()}", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
