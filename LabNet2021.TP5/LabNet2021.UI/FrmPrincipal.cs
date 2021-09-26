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
    public partial class FrmPrincipal : Form
    {
        ProductsLogic productsLogic;
        CustomersLogic customersLogic;
        OrdersLogic ordersLogic;
        CategoriesLogic categoriesLogic;

        public FrmPrincipal()
        {
            InitializeComponent();
            productsLogic = new ProductsLogic();
            customersLogic = new CustomersLogic();
            ordersLogic = new OrdersLogic();
            categoriesLogic = new CategoriesLogic();
        }
        private void DataGridShow(object listData)
        {
            try
            {
                this.dgvList.DataSource = null;
                this.dgvList.DataSource = listData;
                this.dgvList.RemoveColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 1\n\n  - Devolver objeto customer";
                DataGridShow(new List<Customers>() { customersLogic.ObjectCustomers() });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnQuery2_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 2\n\n  - Devolver todos los productos sin stock";
                DataGridShow(productsLogic.AllProductsOutOfStock());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 3\n\n  - Devolver todos los productos que tienen stock y que cuestan más de 3 por unidad";
                DataGridShow(productsLogic.AllProductsInStockAndCostMoreThree());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 4\n\n  - Devolver todos los customers de la Región WA";
                DataGridShow(customersLogic.AllCustomersFromRegion("WA"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 5\n\n  - Devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789";
                List<Products> bufferProducts = new List<Products>() { productsLogic.ProductsForID(789) };
                if (bufferProducts[0] != null)
                {
                    DataGridShow(bufferProducts);
                }
                else
                {
                    this.dgvList.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 6\n\n  - Devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.";
                DataGridShow(customersLogic.NameCustomersUppercaseLowercase());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery7_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 7\n\n  - Devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1 / 1 / 1997";
                DataGridShow(ordersLogic.CustomersOrdersForRegionAndDate("WA", new DateTime(1997 - 1 - 1)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery8_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 8\n\n  - Devolver los primeros 3 Customers de la  Región WA.";
                DataGridShow(customersLogic.FirstCustomersPerRegion(3, "WA"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery9_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 9\n\n  - Devolver lista de productos ordenados por nombre.";
                DataGridShow(productsLogic.ProductsOrderByName());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery10_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 10\n\n  - Devolver lista de productos ordenados por unit in stock de mayor a menor.";
                DataGridShow(productsLogic.ProductsOrderByStock());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery11_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 11\n\n  - Devolver las distintas categorías asociadas a los productos.";
                DataGridShow(productsLogic.ProductsAndCategories());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery12_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 12\n\n  - Devolver el primer elemento de una lista de productos";
                List<Products> bufferList = new List<Products>() { productsLogic.FirstProducts() };
                if (bufferList[0] != null)
                {
                    DataGridShow(bufferList);
                }
                else
                {
                    this.dgvList.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery13_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbText.Text = "\nQuery 13\n\n  - Devolver los customer con la cantidad de ordenes asociadas";
                DataGridShow(customersLogic.CustomersAndOrders());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
