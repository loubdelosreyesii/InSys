using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InSys.GlobalVariables;

namespace InSys
{
    public partial class CheckedItems : UserControl
    {
        public int InventoryQuantity { get; set; }
        public int ProductID { get; set; }
        public string Currency { get; set; }
        public string Photo { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public decimal Price{ get; set; }
        public decimal TotalPrice { get; set; }
        public Control parentControl { get; set; }
        public int ProductTypeID { get; set; }
        public string SearchText { get; set; }
        
        public CheckedItems()
        {
            InitializeComponent();
        }
        
        private void CheckedItems_Load(object sender, EventArgs e)
        {
            nuQuantity.Maximum = InventoryQuantity;

            if ((Currency == null) || (Currency.Length > 0))
                Currency = "en-PH";
            
            if (Photo != null)
                picProductPhoto.ImageLocation = Photo;
            else
                picProductPhoto.ImageLocation =  Path.GetDirectoryName(Application.ExecutablePath) + $"\\Defaults\\no-photo.png";

            if (Model != null)
                lblModel.Text = Model;

            if(Brand !=null)
                lblBrand.Text = Brand;

            if(Quantity != 0)
                nuQuantity.Value = Quantity;

            if(Price != 0 )
                txtPrice.Text = $"{string.Format(new CultureInfo(Currency), "{0:C}", (Price))}";

            if((Quantity!=0) && (Price !=0))
                txtTotalPrice.Text = $"{string.Format(new CultureInfo(Currency),"{0:C}",(Quantity * Price))}";
        }

        private void nuQuantity_ValueChanged(object sender, EventArgs e)
        {
            Quantity = Convert.ToInt32(nuQuantity.Value);
            Calculate();

        }
        private void Calculate() {
            TotalPrice = (Quantity * Price);
            txtTotalPrice.Text = $"{string.Format(new CultureInfo(Currency), "{0:C}", TotalPrice)}";
            UpdateMainCart();
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
           
            
        }
        private void UpdateMainCart() {
            var _item = checkedProducts.Where(p => p.Id == ProductID);

            if (_item != null) {
                foreach (var item in checkedProducts.Where(p=>p.Id == ProductID))
                {
                    item.Quantity = Quantity;
                    item.SuggestedRetailPrice = Price;
                }
            }
            GlobalMethods.UpdatePOSUI();
            GlobalMethods.RefreshGridBindings(SearchText, ProductTypeID);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            decimal newPrice = 0.00m;
            int testInput;
            string strPrice = txtPrice.Text;


            if (!int.TryParse(strPrice.Substring(0, 1), out testInput))
            {
                strPrice = txtPrice.Text.Substring(1, txtPrice.Text.Length - 1);
            }
            else
            {
                strPrice = txtPrice.Text;
            }

            if (decimal.TryParse(strPrice, out newPrice))
            {
                Price = newPrice;
                //    TotalPrice = Convert.ToDecimal(strPrice);

                //    txtTotalPrice.Text = $"{string.Format(new CultureInfo(Currency), "{0:C}", (Quantity * newPrice))}";
                //    string strFormatted = $"{string.Format(new CultureInfo(Currency), "{0:C}", (newPrice))}";
                //    txtPrice.Text = strFormatted;
                //}
                Calculate();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (parentControl != null)
            {
                var _item = checkedProducts.Where(p => p.Id == ProductID).SingleOrDefault();
                checkedProducts.Remove(_item);

                parentControl.Controls.Remove(this);

                GlobalMethods.UpdatePOSUI();
                GlobalMethods.RefreshGridBindings(SearchText, ProductTypeID);
            }
        }
    }

}
