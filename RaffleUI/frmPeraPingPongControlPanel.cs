using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaffleUI
{
    public partial class frmPeraPingPongControlPanel : Form
    {
        PingPongPrizeController _pingPongPrizeController = new PingPongPrizeController();
        public List<sp_PingPongDraw_SelectForView_Result> prizes { get; set; }
        private List<sp_PingPongDraw_SelectForView_Result> openedPrizes = new List<sp_PingPongDraw_SelectForView_Result>();

        private List<sp_PingPongDraw_SelectForView_Result> finalPrizesToDisplay = new 
List<sp_PingPongDraw_SelectForView_Result>();

        private List<sp_PingPongDraw_SelectForView_Result> prizesTemp = new
List<sp_PingPongDraw_SelectForView_Result>();
        public bool isPic1Open { get; set; }
        public bool isPic2Open { get; set; }
        public bool isPic3Open { get; set; }
        public bool isPic4Open { get; set; }
        public bool isPic5Open { get; set; }


        public frmPeraPingPongControlPanel()
        {
            InitializeComponent();
        }
        private void shufflePrizes() {
            prizesTemp = prizes;
            finalPrizesToDisplay = new List<sp_PingPongDraw_SelectForView_Result>();

            Random rng = new Random();
            sp_PingPongDraw_SelectForView_Result itemToRemove;
            int intId;

            if (isPic1Open)
            {
                intId = Convert.ToInt32(pic1.Tag);
                itemToRemove = prizesTemp.Where(p => p.RafflePrizeId == intId).First();

                openedPrizes.Add(itemToRemove); //OpenedCards
                prizesTemp.Remove(itemToRemove);//RemainingCards
            }

            if (isPic2Open)
            {
                intId = Convert.ToInt32(pic2.Tag);
                itemToRemove = prizesTemp.Where(p => p.RafflePrizeId == intId).First();

                openedPrizes.Add(itemToRemove); //OpenedCards
                prizesTemp.Remove(itemToRemove);//RemainingCards
            }

            if (isPic3Open)
            {
                intId = Convert.ToInt32(pic3.Tag);
                itemToRemove = prizesTemp.Where(p => p.RafflePrizeId == intId).First();

                openedPrizes.Add(itemToRemove); //OpenedCards
                prizesTemp.Remove(itemToRemove);//RemainingCards
            }

            if (isPic4Open)
            {
                intId = Convert.ToInt32(pic4.Tag);
                itemToRemove = prizesTemp.Where(p => p.RafflePrizeId == intId).First();

                openedPrizes.Add(itemToRemove); //OpenedCards
                prizesTemp.Remove(itemToRemove);//RemainingCards
            }

            if (isPic5Open)
            {
                intId = Convert.ToInt32(pic5.Tag);
                itemToRemove = prizesTemp.Where(p => p.RafflePrizeId == intId).First();

                openedPrizes.Add(itemToRemove); //OpenedCards
                prizesTemp.Remove(itemToRemove);//RemainingCards
            }


            var shuffledcards = prizesTemp.OrderBy(a => rng.Next()).ToList();

            string strPhoto = string.Empty;
            if (!isPic1Open)
            {
                strPhoto = $"{Environment.CurrentDirectory}\\Products\\{shuffledcards.First().InventoryId}.jpg";

                pic1.Image = new Bitmap(strPhoto);
                pic1.Tag = shuffledcards.First().RafflePrizeId;

                finalPrizesToDisplay.Add(shuffledcards.First());
                shuffledcards.Remove(shuffledcards.First());
            }
            else
            {
                finalPrizesToDisplay.Add(openedPrizes.First());
                openedPrizes.Remove(openedPrizes.First());
            }


            if (!isPic2Open)
            {
                strPhoto = $"{Environment.CurrentDirectory}\\Products\\{shuffledcards.First().InventoryId}.jpg";

                pic2.Image = new Bitmap(strPhoto);
                pic2.Tag = shuffledcards.First().RafflePrizeId;

                finalPrizesToDisplay.Add(shuffledcards.First());
                shuffledcards.Remove(shuffledcards.First());
            }
            else
            {
                finalPrizesToDisplay.Add(openedPrizes.First());
                openedPrizes.Remove(openedPrizes.First());
            }
            if (!isPic3Open)
            {
                strPhoto = $"{Environment.CurrentDirectory}\\Products\\{shuffledcards.First().InventoryId}.jpg";

                pic3.Image = new Bitmap(strPhoto);
                pic3.Tag = shuffledcards.First().RafflePrizeId;

                finalPrizesToDisplay.Add(shuffledcards.First());
                shuffledcards.Remove(shuffledcards.First());

            }
            else
            {
                finalPrizesToDisplay.Add(openedPrizes.First());
                openedPrizes.Remove(openedPrizes.First());
            }
            if (!isPic4Open)
            {
                strPhoto = $"{Environment.CurrentDirectory}\\Products\\{shuffledcards.First().InventoryId}.jpg";

                pic4.Image = new Bitmap(strPhoto);
                pic4.Tag = shuffledcards.First().RafflePrizeId;

                finalPrizesToDisplay.Add(shuffledcards.First());
                shuffledcards.Remove(shuffledcards.First());
            }
            else
            {
                finalPrizesToDisplay.Add(openedPrizes.First());
                openedPrizes.Remove(openedPrizes.First());
            }
            if (!isPic5Open)
            {
                strPhoto = $"{Environment.CurrentDirectory}\\Products\\{shuffledcards.First().InventoryId}.jpg";

                pic5.Image = new Bitmap(strPhoto);
                pic5.Tag = shuffledcards.First().RafflePrizeId;

                finalPrizesToDisplay.Add(shuffledcards.First());
                shuffledcards.Remove(shuffledcards.First());
            }
            else
            {
                finalPrizesToDisplay.Add(openedPrizes.First());
                openedPrizes.Remove(openedPrizes.First());
            }
            prizes = finalPrizesToDisplay;
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
            shufflePrizes();
        }

        private void frmPeraPingPongControlPanel_Load(object sender, EventArgs e)
        {
            this.Width = 100;
            shufflePrizes();
        }

        private void pic3_Click(object sender, EventArgs e)
        {

        }
    }
}
