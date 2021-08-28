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
    public partial class AddEditArticle : Form
    {

        private bool isEdit = false, canAddEdit = true, isCompleted = false;
        private int productID;
        public AddEditArticle()
        {
            InitializeComponent();
            btnArtAddAccept.Text = "Agregar el producto";
        }

        public AddEditArticle(bool isEdit, int productID)
        {
            InitializeComponent();
            btnArtAddAccept.Text = "Editar el producto";
            this.isEdit = isEdit;
            this.productID = productID;
            var db = new SqliteDBContextConn();
            var product = db.prod.Find(productID);
            editProduct(product);
        }

        private void btnArtAddAccept_Click(object sender, EventArgs e)
        {
            if (!isEdit && canAddEdit)
            {
                if (checkProduct(txtArtAddBarCode.Text))
                    addProduct();
            }
            else if (isEdit && canAddEdit)
                editProduct();
            if (isEdit && canAddEdit)
                new MessageMsg("Producto editado correctamente").ShowDialog(this);
            else if (!isEdit && canAddEdit)
                new MessageMsg("Producto agregado correctamente").ShowDialog(this);
            else if (!canAddEdit)
                new MessageMsg("La inserción ha fallado").ShowDialog(this);
            this.Close();
            
        }

        private bool checkProduct(String code)
        {
            bool isChecked = false;
            var db = new SqliteDBContextConn();
            Product product = new Product();
            try
            {
                product = db.prod.FirstOrDefault(p => p.ProductCode == code);
            }
            catch (Exception ex) { }
            if (product == null)
            {
                canAddEdit = true;
                isChecked = true;
            }
            else
            {
                new MessageMsg("Ya se cuenta con un producto con este código de producto").ShowDialog(this);
                txtArtAddBarCode.Select();
                canAddEdit = false;
                isChecked = false;
            }
            return isChecked;
        }

        private async void addProduct()
        {
            var db = new SqliteDBContextConn();
            await db.Database.EnsureCreatedAsync();
            var product = new Product()
            {
                ProductCode = txtArtAddBarCode.Text,
                ProductActive = chkArtAddActive.Checked,
                ProductName = txtArtAddNameProduct.Text,
                ProductPrice = int.Parse(txtArtAddPrice.Text),
                ProductBrand = txtArtAddBrand.Text,
                QuantityStorage = int.Parse(txtArtAddQuantity.Text),
                ProductFamily = txtArtAddFamily.Text,
                ProductCategory = txtArtAddCategory.Text,
                ProductSubCategory = txtArtAddSubcat.Text,
                Creation = DateTime.Now,
                LastUpdate = DateTime.Now
            };
            db.prod.Add(product);
            await db.SaveChangesAsync();
        }

        private void editProduct()
        {
            var db = new SqliteDBContextConn();
            var product = db.prod.Find(productID);
            product.ProductCode = txtArtAddBarCode.Text;
            product.ProductActive = chkArtAddActive.Checked;
            product.ProductName = txtArtAddNameProduct.Text;
            product.ProductPrice = int.Parse(txtArtAddPrice.Text);
            product.ProductBrand = txtArtAddBrand.Text;
            product.QuantityStorage = int.Parse(txtArtAddQuantity.Text);
            product.ProductFamily = txtArtAddFamily.Text;
            product.ProductCategory = txtArtAddCategory.Text;
            product.ProductSubCategory = txtArtAddSubcat.Text;
            product.LastUpdate = DateTime.Now;
            db.SaveChanges();
        }

        private void editProduct(Product product)
        {
            txtArtAddBarCode.Text = product.ProductCode;
            chkArtAddActive.Checked = product.ProductActive;
            txtArtAddNameProduct.Text = product.ProductName;
            txtArtAddPrice.Text = product.ProductPrice.ToString();
            txtArtAddBrand.Text = product.ProductBrand;
            txtArtAddQuantity.Text = product.QuantityStorage.ToString();
            txtArtAddFamily.Text = product.ProductFamily;
            txtArtAddCategory.Text = product.ProductCategory;
            txtArtAddSubcat.Text = product.ProductSubCategory;
        }

        private void AddEditArticle_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnArtAddAccept_Click(sender, new EventArgs());
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtArtAddBarCode_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
