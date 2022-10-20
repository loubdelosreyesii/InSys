using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static InSys.GlobalVariables;
namespace InSys
{
    public partial class frmRaffleDetail : Form
    {
        RaffleController raffleController = new RaffleController();
        RafflePrizeController rafflePrizeController = new RafflePrizeController();
        RaffleLuckyDrawPrizeController raffleLuckyDrawPrizeController = new RaffleLuckyDrawPrizeController();
        PingPongPrizeController pingPongPrizeController = new PingPongPrizeController();
        InventoryController inventoryController = new InventoryController();
        ReferenceController referenceController = new ReferenceController();

        public Raffle Record { get; set; }
        public RafflePrize RecordPrize { get; set; }
        public RaffleLuckyDrawPrize RecordPrizeLuckyDraw { get; set; }
        public PingPongPrize RecordPrizePingPong { get; set; }
        public bool IsAddTransaction { get; set; }
        public Result result { get; set; }

        frmRafflePrizeDetail frmDetail;
        frmLuckyDrawPrizeDetail frmDetailLuckyDraw;
        frmPingPongPrizeDetail frmDetailPingPong;

        List<Inventory> inventories = new List<Inventory>();
        List<Reference> references = new List<Reference>();
        List<RafflePrize> rafflePrizes = new List<RafflePrize>();
        List<RaffleLuckyDrawPrize> raffleLuckyDrawPrizes = new List<RaffleLuckyDrawPrize>();
        List<PingPongPrize> pingPongPrizes = new List<PingPongPrize>(); 

        Inventory recordInventory = new Inventory();
        public frmRaffleDetail(){
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e){
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e){

            if (txtNName.Text.Trim().Length <= 0)
            {
                MessageBox.Show("No Raffle Name provided. Please try again.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime dtDrawDateToSave = new DateTime(dtpDrawDate.Value.Year, dtpDrawDate.Value.Month, dtpDrawDate.Value.Day);
            TimeSpan dtDrawTimeToSave = dtpDrawTime.Value.TimeOfDay;

            DateTime dtFormattedDrawDateTime = dtDrawDateToSave + dtDrawTimeToSave;

            decimal decEntryPrice = 0.00m;

            if (!decimal.TryParse(txtEntryPrice.Text, out decEntryPrice)) {
                MessageBox.Show("Invalid Raffle Entry Price Amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (IsAddTransaction)
            {
                Record = new Raffle();

                Record.Name = txtNName.Text;
                Record.Description = txtDescription.Text;
                Record.EntryPrice = Convert.ToDecimal(txtEntryPrice.Text);
                Record.DrawDate = dtFormattedDrawDateTime;
                Record.MaxEntries = Convert.ToInt32(0);

                raffleController.record = Record;
                result = raffleController.Add();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Record.Name = txtNName.Text;
                Record.Description = txtDescription.Text;
                Record.EntryPrice = Convert.ToDecimal(txtEntryPrice.Text);
                Record.DrawDate = dtFormattedDrawDateTime;
                Record.MaxEntries = Convert.ToInt32(0);

                raffleController.record = Record;
                result = raffleController.Edit();

                Record = raffleController.record;

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.btnCancel.Hide();
            this.btnSave.Hide();
        }
        private void frmInventoryDetail_Load(object sender, EventArgs e)
        {
            dtpDrawTime.CustomFormat = "hh:mm:ss";
            if (Record != null)
            {
                txtNName.Text = Record.Name;
                txtEntryPrice.Text = Record.EntryPrice.ToString();
                txtDescription.Text = Record.Description;
                dtpDrawDate.Value = Record.DrawDate.Date;
                dtpDrawTime.Value = Record.DrawDate;
                //nudMaxEntries.Value= Record.MaxEntries;  
            }
            RefreshGridBindings();

            dgvwRecords.DataSource = listSource;
            dgvRecordsLuckyDraw.DataSource = listSourceLuckyDraw;
            dgvPingPongPrizes.DataSource = listSourcePingPong;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Record.Id == 0){ 
                MessageBox.Show("The Raffle record needs to be added in the system first before managing the Prizes.",APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmDetail = new frmRafflePrizeDetail();
            frmDetail.RecordRaffle = Record;
            frmDetail.IsAddTransaction = true;

            frmDetail.ShowDialog();
            RefreshGridBindings();
        }

        private void RefreshGridBindings()
        {
            dgvwRecords.ScrollBars = ScrollBars.Both;
            
            rafflePrizes = rafflePrizeController.SelectAll().Where(p => p.RaffleId == Record.Id).ToList();
            raffleLuckyDrawPrizes = raffleLuckyDrawPrizeController.SelectAll().Where(p=>p.RaffleId== Record.Id).ToList();
            pingPongPrizes = pingPongPrizeController.SelectAll().Where(p=>p.RaffleId == Record.Id).ToList();

            inventories = inventoryController.SelectAll();
            references = referenceController.SelectAll();

            var viewList = from invent in inventories
                           join prize in rafflePrizes on invent.Id equals prize.ProductId
                           join refe in references on invent.TypeID equals refe.Id
                           select new
                           {
                                Id= prize.Id,
                                ProductName = $"{refe.Name}-{invent.Model}",
                                ProductId = invent.Id,
                                SuggestedRetailPrice = invent.SuggestedRetailPrice,
                                Quantity = prize.Quantity,
                               ShuffleLevel =  prize.ShuffleLevel
                           };

            var viewListLuckyDraw = from invent in inventories
                                    join prize in raffleLuckyDrawPrizes on invent.Id equals prize.ProductId
                                    join refe in references on invent.TypeID equals refe.Id
                                    select new
                                    {
                                        Id = prize.Id,
                                        ProductName = $"{refe.Name}-{invent.Model}",
                                        ProductId = invent.Id,
                                        SuggestedRetailPrice = invent.SuggestedRetailPrice,
                                        Quantity = prize.Quantity,
                                        ShuffleLevel = prize.ShuffleLevel
                                    };

            var viewListPingPong = from invent in inventories
                                    join prize in pingPongPrizes on invent.Id equals prize.ProductId
                                    join refe in references on invent.TypeID equals refe.Id
                                    select new
                                    {
                                        Id = prize.Id,
                                        ProductName = $"{refe.Name}-{invent.Model}",
                                        ProductId = invent.Id,
                                        SuggestedRetailPrice = invent.SuggestedRetailPrice,
                                        Quantity = prize.Quantity
                                    };

            listSource.DataSource = viewList.ToList();
            listSourceLuckyDraw.DataSource = viewListLuckyDraw.ToList();
            listSourcePingPong.DataSource = viewListPingPong.ToList();

            listSource.ResetBindings(false);
            listSourceLuckyDraw.ResetBindings(false);
            listSourcePingPong.ResetBindings(false);

        }
        BindingSource listSource = new BindingSource();
        BindingSource listSourceLuckyDraw = new BindingSource();
        BindingSource listSourcePingPong = new BindingSource();

        private void btnEdit_Click(object sender, EventArgs e)
        {
            RecordPrize = new RafflePrize();
            frmDetail.RecordRaffle = Record;
            frmDetail = new frmRafflePrizeDetail();

            if (dgvwRecords.Rows.Count == 0)
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            RecordPrize.Id = selectedRow.Id;
            RecordPrize.ProductId = selectedRow.ProductId;
            RecordPrize.Quantity = selectedRow.Quantity;

            frmDetail.Record = RecordPrize;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RecordPrize = new RafflePrize();
            recordInventory = new Inventory();

            if (dgvwRecords.Rows.Count == 0)
            {
                MessageBox.Show("No Raffle Prize Records to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected row?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            RecordPrize.Id = selectedRow.Id;
            recordInventory.Id = selectedRow.ProductId;

            inventoryController.record = recordInventory;
            recordInventory = inventoryController.Select();
            
            recordInventory.Quantity += selectedRow.Quantity;
            inventoryController.record = recordInventory;
            result = inventoryController.Edit();

            if (!result.Code) {
                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            rafflePrizeController.record = RecordPrize;
            result = rafflePrizeController.Delete();
            
            MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGridBindings();
        }

        private void btnAddLuckyPrize_Click(object sender, EventArgs e)
        {
            if (Record.Id == 0)
            {
                MessageBox.Show("The Raffle record needs to be added in the system first before managing the Prizes.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmDetailLuckyDraw = new frmLuckyDrawPrizeDetail();
            frmDetailLuckyDraw.RecordRaffle = Record;
            frmDetailLuckyDraw.IsAddTransaction = true;

            frmDetailLuckyDraw.ShowDialog();
            RefreshGridBindings();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (dgvwRecords.RowCount <=0){
                MessageBox.Show("Please select a prize record first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dynamic selectedPrizeRecord = dgvwRecords.CurrentRow.DataBoundItem;

            RecordPrize = new RafflePrize { 
                                Id = selectedPrizeRecord.Id,
                                Quantity = selectedPrizeRecord.Quantity,
                                ProductId = selectedPrizeRecord.ProductId,
                                ShuffleLevel = selectedPrizeRecord.ShuffleLevel
            };

            frmDetail = new frmRafflePrizeDetail();
            frmDetail.ProductToUpdate = selectedPrizeRecord.ProductName;
            frmDetail.RecordRaffle = Record;
            frmDetail.Record = RecordPrize;
            frmDetail.IsAddTransaction = false;

            frmDetail.ShowDialog();
            RefreshGridBindings();
        }

        private void btnEditLuckyPrize_Click(object sender, EventArgs e)
        {
            if (dgvRecordsLuckyDraw.RowCount <= 0)
            {
                MessageBox.Show("Please select a prize record first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dynamic selectedPrizeRecord = dgvRecordsLuckyDraw.CurrentRow.DataBoundItem;

            RecordPrizeLuckyDraw = new RaffleLuckyDrawPrize
            {
                Id = selectedPrizeRecord.Id,
                Quantity = selectedPrizeRecord.Quantity,
                ProductId = selectedPrizeRecord.ProductId,
                ShuffleLevel = selectedPrizeRecord.ShuffleLevel
            };

            frmDetailLuckyDraw = new frmLuckyDrawPrizeDetail();

            frmDetailLuckyDraw.ProductToUpdate = selectedPrizeRecord.ProductName;
            frmDetailLuckyDraw.RecordRaffle = Record;
            frmDetailLuckyDraw.Record = RecordPrizeLuckyDraw;
            frmDetailLuckyDraw.IsAddTransaction = false;

            frmDetailLuckyDraw.ShowDialog();
            RefreshGridBindings();
        }

        private void btnDeleteLuckyPrize_Click(object sender, EventArgs e)
        {
            RecordPrizeLuckyDraw = new RaffleLuckyDrawPrize();
            recordInventory = new Inventory();

            if (dgvRecordsLuckyDraw.Rows.Count == 0)
            {
                MessageBox.Show("No Lucky Draw Prize Records to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete the selected row?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            dynamic selectedRow = dgvRecordsLuckyDraw.CurrentRow.DataBoundItem;

            RecordPrizeLuckyDraw.Id = selectedRow.Id;
            recordInventory.Id = selectedRow.ProductId;

            inventoryController.record = recordInventory;
            recordInventory = inventoryController.Select();

            recordInventory.Quantity += selectedRow.Quantity;
            inventoryController.record = recordInventory;
            result = inventoryController.Edit();

            if (!result.Code)
            {
                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            raffleLuckyDrawPrizeController.record = RecordPrizeLuckyDraw;

            result = raffleLuckyDrawPrizeController.Delete();

            MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGridBindings();
        }

        private void btnAddPingPongPrize_Click(object sender, EventArgs e)
        {
            if (Record.Id == 0)
            {
                MessageBox.Show("The Raffle record needs to be added in the system first before managing the Prizes.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmDetailPingPong = new frmPingPongPrizeDetail();
            frmDetailPingPong.RecordRaffle = Record;
            frmDetailPingPong.IsAddTransaction = true;

            frmDetailPingPong.ShowDialog();
            RefreshGridBindings();
        }

        private void btnEditPingPongPrize_Click(object sender, EventArgs e)
        {
            if (dgvPingPongPrizes.RowCount <= 0)
            {
                MessageBox.Show("Please select a prize record first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dynamic selectedPrizeRecord = dgvPingPongPrizes.CurrentRow.DataBoundItem;

            RecordPrizePingPong = new PingPongPrize
            {
                Id = selectedPrizeRecord.Id,
                Quantity = selectedPrizeRecord.Quantity,
                ProductId = selectedPrizeRecord.ProductId
            };

            frmDetailPingPong = new frmPingPongPrizeDetail();

            frmDetailPingPong.ProductToUpdate = selectedPrizeRecord.ProductName;
            frmDetailPingPong.RecordRaffle = Record;
            frmDetailPingPong.Record = RecordPrizePingPong;
            frmDetailPingPong.IsAddTransaction = false;

            frmDetailPingPong.ShowDialog();
            RefreshGridBindings();
        }

        private void btnDeletePingPongPrize_Click(object sender, EventArgs e)
        {
            RecordPrizePingPong = new PingPongPrize();
            recordInventory = new Inventory();

            if (dgvPingPongPrizes.Rows.Count == 0)
            {
                MessageBox.Show("No Ping Pong Records to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete the selected row?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            dynamic selectedRow = dgvPingPongPrizes.CurrentRow.DataBoundItem;

            RecordPrizePingPong.Id = selectedRow.Id;
            recordInventory.Id = selectedRow.ProductId;

            inventoryController.record = recordInventory;
            recordInventory = inventoryController.Select();

            recordInventory.Quantity += selectedRow.Quantity;
            inventoryController.record = recordInventory;
            result = inventoryController.Edit();

            if (!result.Code)
            {
                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pingPongPrizeController.record = RecordPrizePingPong;

            result = pingPongPrizeController.Delete();

            MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshGridBindings();
        }
    }
}
