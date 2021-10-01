using LabNet2021.Entities;
using LabNet2021.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNet2021.UI
{
    public partial class FrmAdd : Form
    {
        bool shipperFlag = true;

        /// <summary>
        /// Builder
        /// </summary>
        /// <param name="shipper"></param>
        public FrmAdd(bool shipperFlag)
        {
            InitializeComponent();
            this.shipperFlag = shipperFlag;
        }

        /// <summary>
        /// Event Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdd_Load(object sender, EventArgs e)
        {
            SetInfo(shipperFlag);
        }

        /// <summary>
        /// Set the necessary information in the fields of the form.
        /// </summary>
        /// <param name="shipper">Is it a Shipper?</param>
        private void SetInfo(bool shipper)
        {
            if (shipper)
            {
                this.lblName.Text = "Shipper Name";
                this.lblPhone.Text = "Phone";
            }
            else
            {
                this.lblName.Text = "Category Name";
                this.lblPhone.Text = "Description";
            }
        }

        /// <summary>
        /// Event button ADD.<br></br>Add a categories or shippers as appropriate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IABMLogic<Shippers> shippersDb = new ShippersLogic();
                IABMLogic<Categories> categoriesDb = new CategoriesLogic();
                if (shipperFlag)
                {
                    shippersDb.Add(new Shippers { CompanyName = txbName.Text.Trim(), Phone = txbDesciption.Text.Trim() });
                }
                else
                {
                    categoriesDb.Add(new Categories { CategoryName = txbName.Text.Trim(), Description = txbDesciption.Text.Trim() });
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
        /// Event button CANCEL.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Keypad lock for the telephone field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbDesciption_KeyDown(object sender, KeyEventArgs e)
        {           
            if (shipperFlag && (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
