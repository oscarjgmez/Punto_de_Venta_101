using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PointOfSale.Connection;
using System.Linq;

namespace PointOfSale.Sale
{
    public partial class SaleInf : Form
    {
        private List<ProdSaleDataGrid> listprod = new List<ProdSaleDataGrid>();
        private PointOfSales sale = new PointOfSales();
        private BindingSource source = new BindingSource();
        private bool areProductsLoaded = false;
        public SaleInf(int saleID)
        {
            InitializeComponent();
            viewSale_Products(saleID);
        }

        private void viewSale_Products(int saleID)
        {
            var db = new SqliteDBContextConn();
            PointOfSales sale = new PointOfSales();
            List<PointOfSale_Product> prods = new List<PointOfSale_Product>();
            try{
                sale = db.pos.FirstOrDefault(p => p.ID == saleID);
            }
            catch (Exception ex){
                new MessageMsg("No hay venta").ShowDialog(this);
                this.Close();
            }
            try{
                prods = db.PointOfSale_Product.Where(p => p.PoSID == saleID).ToList();
                if (prods.Count > 0)
                    areProductsLoaded = true;
            }
            catch (Exception ex){
                new MessageMsg("No se vendio nada en esta venta").ShowDialog(this);
            }
            lblSaleInfID.Text = sale.ID.ToString();
            this.sale = sale;
            lblSaleInfDate.Text = sale.LastUpdate.ToString();
            lblSaleInfPrice.Text = sale.SalePayPrice.ToString();
            lblSaleInfCutSale.Text = sale.SaleCutID.ToString();
            if (sale.SaleCutID == 0)
            {
                lblSaleInfCutSale.Text = "Caja abierta";
                label5.Hide();
            }
            foreach (var prod in prods)
            {
                var dgp = new ProdSaleDataGrid();
                var product = db.prod.FirstOrDefault(p => p.ID == prod.ProductID);
                dgp.IdProduct = prod.ProductID;
                dgp.CódigoBarras = product.ProductCode;
                dgp.Nombre = product.ProductName;
                dgp.PrecioVenta = product.ProductPrice;
                dgp.CantidadComprar = prod.ProductQty;
                dgp.Subtotal = prod.ProductsPrices;
                listprod.Add(dgp);
                source.DataSource = listprod;
            }
            dgvSaleInf.DataSource = source;
        }

        private void SaleInf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void SaleInf_Load(object sender, EventArgs e)
        {
            if (areProductsLoaded)
            {
                dgvSaleInf.Columns[0].Visible = false;

                dgvSaleInf.Columns[1].HeaderText = "Código de barras";
                dgvSaleInf.Columns[3].HeaderText = "Precio";
                dgvSaleInf.Columns[4].HeaderText = "Cantidad";
                dgvSaleInf.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSaleInf.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSaleInf.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSaleInf.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSaleInf.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void chkbSaleInfActive_CheckedChanged(object sender, EventArgs e)
        {
            var db = new SqliteDBContextConn();
            var products = checkedCheckBox(chkbSaleInfActive.Checked, db, sale.ID);
            if (products.Count > 0)
            {
                source.ResetBindings(true);
                dgvSaleInf.DataSource = source;
                listprod.Clear();
                listprod = products;
            }
            else if (products.Count == 0)
            {
                dgvSaleInf.Rows.Clear();
                dgvSaleInf.Refresh();
                listprod.Clear();
            }
        }

        private List<ProdSaleDataGrid> checkedCheckBox(bool isChecked, SqliteDBContextConn db, int posID)
        {
            List<Product> products = new List<Product>();
            List<PointOfSale_Product> pos_prod = new List<PointOfSale_Product>();
            List<ProdSaleDataGrid> posProds = new List<ProdSaleDataGrid>();
            try
            {
                pos_prod = db.PointOfSale_Product.Where(p => p.PoSID == posID).ToList();
            }
            catch (Exception ex)
            {
                new MessageMsg("No hay Venta").ShowDialog(this);
            }
            if (isChecked)
            {
                try
                {
                    foreach (var prod in pos_prod)
                    {
                        var product = db.prod.FirstOrDefault(p => p.ProductActive == true && p.ID == prod.ProductID);
                        if (product != null)
                            products.Add(product);
                    }
                }
                catch (Exception ex)
                {
                    new MessageMsg("Esta venta no tiene artículos activos").ShowDialog(this);
                }
            }
            else if (!isChecked)
            {
                foreach (var prod in pos_prod)
                {
                    var product = db.prod.FirstOrDefault(p => p.ID == prod.ProductID);
                    products.Add(product);
                }
            }
            foreach (var prod in products)
            {
                var dgp = new ProdSaleDataGrid();
                dgp.IdProduct = prod.ID;
                dgp.CódigoBarras = prod.ProductCode;
                dgp.Nombre = prod.ProductName;
                dgp.PrecioVenta = prod.ProductPrice;
                var prodQ = pos_prod.First(p => p.ProductID == prod.ID);
                dgp.CantidadComprar = prodQ.ProductQty;
                dgp.Subtotal = prodQ.ProductsPrices;
                posProds.Add(dgp);
                source.DataSource = posProds;
            }
            return posProds;
        }
    }
}
