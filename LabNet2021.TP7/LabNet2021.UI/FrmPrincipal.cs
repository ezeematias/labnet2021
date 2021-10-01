using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabNet2021.Entities;
using LabNet2021.Logic;

namespace LabNet2021.UI
{
    public partial class frmPrincipal : Form
    {
        Categories categories;
        Shippers shippers;        
        bool shipperFlag = true;

        public frmPrincipal()
        {
            InitializeComponent();

            categories = new Categories();
            shippers = new Shippers();            
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            shipperFlag = false;
            LoadDataGrid(shipperFlag);
        }

        private void btnShippers_Click(object sender, EventArgs e)
        {
            shipperFlag = true;
            LoadDataGrid(shipperFlag);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd();
        }

        private void FormAdd()
        {
            FrmAdd frmAdd = new FrmAdd(shipperFlag);            
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                LoadDataGrid(shipperFlag);
            }
        }

        private void FormModify()
        {
            try
            {
                FrmModify frmModify;
                if (shipperFlag)
                {
                    frmModify = new FrmModify((Shippers)this.dgvList.CurrentRow.DataBoundItem, shipperFlag);
                }
                else
                {
                    frmModify = new FrmModify((Categories)this.dgvList.CurrentRow.DataBoundItem, shipperFlag);

                }
                if (frmModify.ShowDialog() == DialogResult.OK)
                {
                    LoadDataGrid(shipperFlag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataGrid(bool shipper)
        {
            try
            {
                IABMLogic<Shippers> shippersDb = new ShippersLogic();
                IABMLogic<Categories> categoriesDb = new CategoriesLogic();
                this.dgvList.DataSource = null;
                if (shipper)
                {
                    if (shippersDb.GetAll().Count == 0)
                    {
                        ButtonStatus(false);
                    }
                    else
                    {
                        this.dgvList.DataSource = shippersDb.GetAll();
                        ButtonStatus(true);
                    }
                }
                else
                {
                    if (categoriesDb.GetAll().Count == 0)
                    {
                        ButtonStatus(false);
                    }
                    else
                    {
                        this.dgvList.DataSource = categoriesDb.GetAll();
                        ButtonStatus(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            LoadDataGrid(shipperFlag);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                IABMLogic<Shippers> shippersDb = new ShippersLogic();
                IABMLogic<Categories> categoriesDb = new CategoriesLogic();
                if (MessageBox.Show("Are you sure you want to delete the record?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (shipperFlag)
                    {
                        shippers = (Shippers)this.dgvList.CurrentRow.DataBoundItem;
                        shippersDb.Delete(shippers.ShipperID);
                    }
                    else
                    {
                        categories = (Categories)this.dgvList.CurrentRow.DataBoundItem;
                        categoriesDb.Delete(categories.CategoryID);
                    }
                    LoadDataGrid(shipperFlag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormModify();
        }

        private void ButtonStatus(bool status)
        {
            this.btnDelete.Enabled = status;
            this.btnUpdate.Enabled = status;
        }
    }
}
