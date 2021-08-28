using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PointOfSale.Connection;
using System.Linq;

namespace PointOfSale.Article
{
    public partial class ListArticle : Form
    {
        private List<ProductDataGrid> productDatas = new List<ProductDataGrid>();
        private BindingSource source = new BindingSource();
        private bool isLoaded = false;
        public ListArticle()
        {
            InitializeComponent();
            startDataGrid();
            startCombos();
        }

        private void startCombos()
        {
            var db = new SqliteDBContextConn();
            List<String> families = new List<String>();
            List<String> categories = new List<String>();
            List<String> subcategories = new List<String>();
            try{ families = db.prod.Select(p => p.ProductFamily).Distinct().ToList(); }
            catch (Exception ex){ new MessageMsg("No hay familias de productos disponibles").ShowDialog(this); }
            cmbArtFam.Items.Add("Todas");
            foreach (var family in families)
                cmbArtFam.Items.Add(family);

            try{ categories = db.prod.Select(p => p.ProductCategory).Distinct().ToList(); }
            catch (Exception ex){ new MessageMsg("No hay categorías de productos disponibles").ShowDialog(this); }
            cmbArtCat.Items.Add("Todas");
            foreach (var category in categories)
                cmbArtCat.Items.Add(category);

            try { subcategories = db.prod.Select(p => p.ProductSubCategory).Distinct().ToList(); }
            catch (Exception ex) { new MessageMsg("No hay subcategorías de productos disponibles").ShowDialog(this); }
            cmbArtSub.Items.Add("Todas");
            foreach (var subcategory in subcategories)
                cmbArtSub.Items.Add(subcategory);

            cmbArtFam.SelectedIndex = 0;
            cmbArtCat.SelectedIndex = 0;
            cmbArtSub.SelectedIndex = 0;
        }

        private void startDataGrid()
        {
            var db = new SqliteDBContextConn();
            List<Product> products = new List<Product>();
            try
            {
                products = db.prod.ToList();
                if (products.Count > 0)
                    isLoaded = true;
            }
            catch (Exception ex)
            {
                new MessageMsg("No hay productos disponibles").ShowDialog(this);
            }            
            foreach (var product in products)
            {
                var dgp = new ProductDataGrid();
                dgp.IdProducto = product.ID;
                dgp.CódigoBarras = product.ProductCode;
                dgp.Nombre = product.ProductName;
                dgp.PrecioVenta = product.ProductPrice;
                dgp.Almacén = product.QuantityStorage;
                dgp.Marca = product.ProductBrand;
                dgp.Familia = product.ProductFamily;
                dgp.Categoría = product.ProductCategory;
                dgp.SubCategoría = product.ProductSubCategory;
                productDatas.Add(dgp);
                source.DataSource = productDatas;
            }
            refreshDatagrid();
        }

        private void refreshDatagrid()
        {
            source.ResetBindings(true);
            dgvArtProducts.DataSource = source;
        }

        private void searchDataGrid()
        {
            productDatas.Clear();
            var db = new SqliteDBContextConn();
            List<Product> products = new List<Product>();

            if (txtArtSearchBarCode.Text == "" && cmbArtFam.SelectedIndex <= 0 && cmbArtCat.SelectedIndex <= 0 && cmbArtSub.SelectedIndex <= 0)
                products = db.prod.ToList();
            /*Search by code on */
            else if (txtArtSearchBarCode.Text != "" && cmbArtFam.SelectedIndex <= 0 && cmbArtCat.SelectedIndex <= 0 && cmbArtSub.SelectedIndex <= 0)
                products = db.prod.Where(p => p.ProductCode == txtArtSearchBarCode.Text).ToList();
            /*Search by family on */
            else if (txtArtSearchBarCode.Text == "" && cmbArtFam.SelectedIndex >= 0 && cmbArtCat.SelectedIndex <= 0 && cmbArtSub.SelectedIndex <= 0)
                products = db.prod.Where(p => p.ProductFamily == cmbArtFam.Text).ToList();
            /*Search by category on*/
            else if (txtArtSearchBarCode.Text == "" && cmbArtFam.SelectedIndex <= 0 && cmbArtCat.SelectedIndex >= 0 && cmbArtSub.SelectedIndex <= 0)
                products = db.prod.Where(p => p.ProductCategory == cmbArtCat.Text).ToList();
            /*Search by subcategory on*/
            else if (txtArtSearchBarCode.Text == "" && cmbArtFam.SelectedIndex <= 0 && cmbArtCat.SelectedIndex <= 0 && cmbArtSub.SelectedIndex >= 0)
                products = db.prod.Where(p => p.ProductSubCategory == cmbArtSub.Text).ToList();
            /*Search with code on*/
            else if (txtArtSearchBarCode.Text != "" && cmbArtFam.SelectedIndex >= 0 && cmbArtCat.SelectedIndex <= 0 && cmbArtSub.SelectedIndex <= 0)
                products = db.prod.Where(p => p.ProductCode == txtArtSearchBarCode.Text && p.ProductFamily == cmbArtFam.Text).ToList();
            else if (txtArtSearchBarCode.Text != "" && cmbArtFam.SelectedIndex <= 0 && cmbArtCat.SelectedIndex >= 0 && cmbArtSub.SelectedIndex <= 0)
                products = db.prod.Where(p => p.ProductCode == txtArtSearchBarCode.Text && p.ProductCategory == cmbArtCat.Text).ToList();
            else if (txtArtSearchBarCode.Text != "" && cmbArtFam.SelectedIndex <= 0 && cmbArtCat.SelectedIndex <= 0 && cmbArtSub.SelectedIndex >= 0)
                products = db.prod.Where(p => p.ProductCode == txtArtSearchBarCode.Text && p.ProductSubCategory == cmbArtSub.Text).ToList();
            /*Search with family on*/
            else if (txtArtSearchBarCode.Text != "" && cmbArtFam.SelectedIndex >= 0 && cmbArtCat.SelectedIndex <= 0 && cmbArtSub.SelectedIndex <= 0)
                products = db.prod.Where(p => p.ProductFamily == cmbArtFam.Text && p.ProductCode == txtArtSearchBarCode.Text).ToList();
            else if (txtArtSearchBarCode.Text == "" && cmbArtFam.SelectedIndex >= 0 && cmbArtCat.SelectedIndex >= 0 && cmbArtSub.SelectedIndex <= 0)
                products = db.prod.Where(p => p.ProductFamily == cmbArtFam.Text && p.ProductCategory == cmbArtCat.Text).ToList();
            else if (txtArtSearchBarCode.Text == "" && cmbArtFam.SelectedIndex >= 0 && cmbArtCat.SelectedIndex <= 0 && cmbArtSub.SelectedIndex >= 0)
                products = db.prod.Where(p => p.ProductFamily == cmbArtFam.Text && p.ProductSubCategory == cmbArtSub.Text).ToList();
            /*Search with category on*/
            else if (txtArtSearchBarCode.Text != "" && cmbArtFam.SelectedIndex <= 0 && cmbArtCat.SelectedIndex >= 0 && cmbArtSub.SelectedIndex <= 0)
                products = db.prod.Where(p => p.ProductCategory == cmbArtCat.Text && p.ProductCode == txtArtSearchBarCode.Text).ToList();
            else if (txtArtSearchBarCode.Text == "" && cmbArtFam.SelectedIndex >= 0 && cmbArtCat.SelectedIndex >= 0 && cmbArtSub.SelectedIndex <= 0)
                products = db.prod.Where(p => p.ProductCategory == cmbArtCat.Text && p.ProductFamily == cmbArtFam.Text).ToList();
            else if (txtArtSearchBarCode.Text == "" && cmbArtFam.SelectedIndex <= 0 && cmbArtCat.SelectedIndex >= 0 && cmbArtSub.SelectedIndex >= 0)
                products = db.prod.Where(p => p.ProductCategory == cmbArtCat.Text && p.ProductSubCategory == cmbArtSub.Text).ToList();
            /*Search with subcategory on*/
            else if (txtArtSearchBarCode.Text != "" && cmbArtFam.SelectedIndex >= 0 && cmbArtCat.SelectedIndex <= 0 && cmbArtSub.SelectedIndex >= 0)
                products = db.prod.Where(p => p.ProductSubCategory == cmbArtSub.Text && p.ProductCode == txtArtSearchBarCode.Text).ToList();
            else if (txtArtSearchBarCode.Text == "" && cmbArtFam.SelectedIndex >= 0 && cmbArtCat.SelectedIndex <= 0 && cmbArtSub.SelectedIndex >= 0)
                products = db.prod.Where(p => p.ProductSubCategory == cmbArtSub.Text && p.ProductFamily == cmbArtFam.Text).ToList();
            else if (txtArtSearchBarCode.Text == "" && cmbArtFam.SelectedIndex >= 0 && cmbArtCat.SelectedIndex >= 0 && cmbArtSub.SelectedIndex >= 0)
                products = db.prod.Where(p => p.ProductSubCategory == cmbArtSub.Text && p.ProductCategory == cmbArtCat.Text).ToList();

            foreach (var product in products)
            {
                var dgp = new ProductDataGrid();
                dgp.IdProducto = product.ID;
                dgp.CódigoBarras = product.ProductCode;
                dgp.Nombre = product.ProductName;
                dgp.PrecioVenta = product.ProductPrice;
                dgp.Almacén = product.QuantityStorage;
                dgp.Marca = product.ProductBrand;
                dgp.Familia = product.ProductFamily;
                dgp.Categoría = product.ProductCategory;
                dgp.SubCategoría = product.ProductSubCategory;
                productDatas.Add(dgp);
                source.DataSource = productDatas;
            }
            refreshDatagrid();
        }

        private void ListArticle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                new Article.AddEditArticle().ShowDialog(this);
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void dgvArtProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int value = int.Parse(dgvArtProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
                new AddEditArticle(true, value).ShowDialog(this);
                this.Close();
            }
        }

        private void btnArtAddProduct_Click(object sender, EventArgs e)
        {
            new Article.AddEditArticle().ShowDialog(this);
        }

        private void cmbArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchDataGrid();
        }

        private void txtArtSearchBarCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchDataGrid();
        }

        private void ListArticle_Load(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                dgvArtProducts.Columns[0].Visible = false;
                dgvArtProducts.Columns[5].Visible = false;
                dgvArtProducts.Columns[6].Visible = false;
                dgvArtProducts.Columns[7].Visible = false;
                dgvArtProducts.Columns[8].Visible = false;
                dgvArtProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvArtProducts.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvArtProducts.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvArtProducts.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvArtProducts.Columns[1].HeaderText = "Código de barras";
                dgvArtProducts.Columns[2].HeaderText = "Nombre del producto";
                dgvArtProducts.Columns[3].HeaderText = "Precio de venta";
                dgvArtProducts.Columns[4].HeaderText = "Cantidad en almacen";
            }
        }
    }
}
