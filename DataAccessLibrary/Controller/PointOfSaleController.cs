using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLibrary.Model;
using DataAccessLibrary.Repository;
using DataAccessLibrary.Service;
using ResultHelper;
namespace DataAccessLibrary.Controller{
    public class PointOfSaleController{
        public  Result result { get; set; }
        public PointOfSale record { get; set; }

        public void SelectSellerTransactions(DataGridView dgvDisplay,DateTime paramDateFrom, DateTime paramDateTo, string paramUserName)
        {
            IPointOfSale service = new PointOfSaleRepository();

            var records = service.SelectSellerTransactions(paramDateFrom, paramDateTo, paramUserName);

            dgvDisplay.DataSource = records;

            dgvDisplay.Columns["Id"].Visible = false;
            dgvDisplay.Columns["ProductId"].Visible = false;
            dgvDisplay.Columns["ProfitSignal"].Visible = false;

            dgvDisplay.Columns["TransactionDateTime"].HeaderText = "Transaction Date";
            dgvDisplay.Columns["ReceiptNumber"].HeaderText = "Receipt Number";
            dgvDisplay.Columns["CustomerName"].HeaderText = "Customer";
            dgvDisplay.Columns["SellerName"].HeaderText = "Seller";
            dgvDisplay.Columns["Price"].HeaderText = "Sold Price";
            dgvDisplay.Columns["SuggestedRetailPrice"].HeaderText = "Retail Price";
            dgvDisplay.Columns["DistributorPrice"].HeaderText = "Distributor Price";
            dgvDisplay.Columns["ProfitPerStock"].HeaderText = "Profit Per Stock";
            dgvDisplay.Columns["TotalProfit"].HeaderText = "Total Profit";
            dgvDisplay.Columns["SellerShare"].HeaderText = "Seller Share";
            dgvDisplay.Columns["SellerProfit"].HeaderText = "Seller Profit";
            dgvDisplay.Columns["NetProfit"].HeaderText = "Net Profit";

            dgvDisplay.Columns["NetProfit"].Width = 180;

            dgvDisplay.Columns["DistributorPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDisplay.Columns["SuggestedRetailPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDisplay.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDisplay.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDisplay.Columns["TotalProfit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDisplay.Columns["ProfitPerStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDisplay.Columns["SellerShare"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDisplay.Columns["SellerProfit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDisplay.Columns["NetProfit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDisplay.Columns["TotalProfit"].ValueType = typeof(string);
            dgvDisplay.Columns["ProfitPerStock"].ValueType = typeof(string);
            dgvDisplay.Columns["SellerShare"].ValueType = typeof(decimal);
            dgvDisplay.Columns["SellerProfit"].ValueType = typeof(decimal);
            //dgvDisplay.Columns["SellerProfit"].ValueType = typeof(string);
            foreach (DataGridViewColumn column in dgvDisplay.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            foreach (DataGridViewRow row in dgvDisplay.Rows)
            {
                if (row.Cells["ProfitSignal"].Value.ToString() == "Green")
                {
                    row.Cells["TotalProfit"].Style.ForeColor = Color.Green;
                    row.Cells["ProfitPerStock"].Style.ForeColor = Color.Green;
                }
                else
                {
                    row.Cells["TotalProfit"].Style.ForeColor = Color.Red;
                    row.Cells["ProfitPerStock"].Style.ForeColor = Color.Red;
                }
                row.Cells["TotalProfit"].Style.Font = new Font(dgvDisplay.Font, FontStyle.Bold);
                row.Cells["ProfitPerStock"].Style.Font = new Font(dgvDisplay.Font, FontStyle.Bold);

                decimal value = Convert.ToDecimal(row.Cells["TotalProfit"].Value);
                row.Cells["TotalProfit"].Value = value.ToString("c", new CultureInfo("en-PH"));
            }
        }
        public List<PointOfSale> SelectAll(){
            
            IPointOfSale service = new PointOfSaleRepository();
            List<PointOfSale> record = new List<PointOfSale>();

            result = new Result();

            try
            {
                record = service.SelectAll();
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }
        public List<PointOfSalesViewModel> SelectViewModelAll()
        {
            IPointOfSale service = new PointOfSaleRepository();
            List<PointOfSalesViewModel> record = new List<PointOfSalesViewModel>();

            result = new Result();

            try
            {
                record = service.SelectAllViewModel();
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }

        public Result Add() {
            IPointOfSale service = new PointOfSaleRepository();
            service.Record = record;
            
            result = new Result();
            try{
                result = service.Add();
               
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }

        public Result Edit()
        {
            IPointOfSale service = new PointOfSaleRepository();
            service.Record = record;

            result = new Result();
            try{
                result = service.Edit();
                
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }
        public Result Delete()
        {
            IPointOfSale service = new PointOfSaleRepository();
            service.Record = record;

            result = new Result();
            try{
                result = service.Delete();
               
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }
    }
}
