using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
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

namespace InSys
{
    public partial class frmChoosePrizes : Form
    {
        public Raffle RecordRaffle { get; set; }

        RafflePrizeController rafflePrizeController = new RafflePrizeController();
        List<RafflePrize> rafflePrizes = new List<RafflePrize>();
        InventoryController inventoryController = new InventoryController();
        ReferenceController referenceController = new ReferenceController();

        List<Inventory> inventories = new List<Inventory>();
        List<Reference> references = new List<Reference>();

        public frmChoosePrizes()
        {
            InitializeComponent();
        }
        private void RefreshGridBindings()
        {
            dgvwRecords.ScrollBars = ScrollBars.Both;

            rafflePrizes = rafflePrizeController.SelectAll().Where(p => p.RaffleId == RecordRaffle.Id && p.Quantity>0).ToList();
            inventories = inventoryController.SelectAll();
            references = referenceController.SelectAll();

            if (rafflePrizes.Count > 0)
            {
                var viewList = from invent in inventories
                               join prize in rafflePrizes on invent.Id equals prize.ProductId
                               join refe in references on invent.TypeID equals refe.Id
                               select new
                               {
                                   ProductPhoto = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Products\\{invent.Id}.jpg"),
                                   Id = prize.Id,
                                   ProductName = $"{refe.Name}-{invent.Model}",
                                   ProductId = invent.Id,
                                   SuggestedRetailPrice = invent.SuggestedRetailPrice,
                                   Quantity = prize.Quantity
                               };
                listSource.DataSource = viewList;
            }
            else
                listSource.DataSource = null;

            listSource.ResetBindings(false);    
        }
        BindingSource listSource = new BindingSource();

        private void frmChoosePrizes_Load(object sender, EventArgs e){
            RefreshGridBindings();
            dgvwRecords.DataSource = listSource;
        }

        private void btnChooseToRaffle_Click(object sender, EventArgs e)
        {
            if (dgvwRecords.Rows.Count <= 0)
                return;

            SelectedProductPrize = dgvwRecords.CurrentRow.DataBoundItem;
            this.Close();
        }

        public dynamic SelectedProductPrize { get; set; }

        private void dgvwRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
