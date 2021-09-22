using LabNet2021.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabNet2021.Logic;


namespace LabNet2021.UI
{
    public partial class FrmModify : Form
    {
        bool shipperFlag = true;
        ShippersLogic shippersLogic;
        CategoriesLogic categoriesLogic;
        Categories categories;
        Shippers shippers;

        /// <summary>
        /// Builder Shippers
        /// </summary>
        /// <param name="shippers"></param>
        /// <param name="shipperFlag"></param>
        public FrmModify(Shippers shippers, bool shipperFlag)
        {
            InitializeComponent();
            this.shipperFlag = shipperFlag;
            this.shippers = shippers;
            this.shippersLogic = new ShippersLogic();
        }

        /// <summary>
        /// Builder Categories
        /// </summary>
        /// <param name="categories"></param>
        /// <param name="shipperFlag"></param>
        public FrmModify(Categories categories, bool shipperFlag)
        {
            InitializeComponent();
            this.shipperFlag = shipperFlag;
            this.categories = categories;
            this.categoriesLogic = new CategoriesLogic();
        }
        
        /// <summary>
        /// Event Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmShippers_Load(object sender, EventArgs e)
        {
            SetInfo(shipperFlag);
        }

        /// <summary>
        /// Set the necessary information in the fields of the form.
        /// </summary>
        /// <param name="shipper">Is it a Shipper?</param>
        private void SetInfo(bool shipper)
        {
            try
            {
                if (shipper)
                {
                    this.lblName.Text = "Shipper Name";
                    this.lblPhone.Text = "Phone";
                    this.txbID.Text = shippers.ShipperID.ToString();
                    this.txbName.Text = shippers.CompanyName;
                    this.txbPhone.Text = shippers.Phone;
                }
                else
                {
                    this.lblName.Text = "Category Name";
                    this.lblPhone.Text = "Description";
                    this.txbID.Text = categories.CategoryID.ToString();
                    this.txbName.Text = categories.CategoryName;
                    this.txbPhone.Text = categories.Description;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event button MODIFY.<br></br>Modify a categories or shippers as appropriate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (shipperFlag)
                {
                    shippers.CompanyName = this.txbName.Text.Trim();
                    shippers.Phone = this.txbPhone.Text.Trim();
                    shippersLogic.Update(shippers);
                }
                else
                {
                    categories.CategoryName = this.txbName.Text.Trim();
                    categories.Description = this.txbPhone.Text.Trim();
                    categoriesLogic.Update(categories);
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Valid characters must be entered.\n\n--Log--\n {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event button Cancel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Keypad lock for the telephone field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (shipperFlag && (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
