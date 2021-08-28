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
    public partial class ArticleInf : Form
    {
        public Product prod = new Product();
        public ArticleInf()
        {
            InitializeComponent();
            txtArtBarCode.Select();
        }

        private void searchProd(string code)
        {
            if (code != "")
            {
                var db = new SqliteDBContextConn();
                try
                {
                    var prod = db.prod.First(p => p.ProductCode == code);
                    lblArtNameProductValue.Text = prod.ProductName;
                    lblArtPriceValue.Text = "$" + prod.ProductPrice;
                    lblArtBrandValue.Text = prod.ProductBrand;
                    lblArtQuantityValue.Text = prod.QuantityStorage.ToString();
                    lblArtFamilyValue.Text = prod.ProductFamily;
                    lblArtCategoryValue.Text = prod.ProductCategory;
                    this.prod = prod;
                }
                catch (Exception ex){
                    new MessageMsg("No se encontró el producto").ShowDialog(this);
                }
            }
            else
                new MessageMsg("Escriba o escanee el código del producto").ShowDialog(this);
        }

        private void ArticleInf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
                searchProd(txtArtBarCode.Text);
            if (e.KeyCode == Keys.F6)
                acceptAndClose();
        }

        private void btnArtAccept_Click(object sender, EventArgs e)
        {
            acceptAndClose();
        }

        private void acceptAndClose()
        {
            new MessageMsg("Producto agregado a la venta").ShowDialog(this);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
