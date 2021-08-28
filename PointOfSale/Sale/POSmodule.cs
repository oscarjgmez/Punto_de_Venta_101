using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Connection;
using System.Linq;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace PointOfSale
{
    public partial class POSmodule : Form
    {
        private List<ProdSaleDataGrid> listprod = new List<ProdSaleDataGrid>();
        private BindingSource source = new BindingSource();
        private float cantidadPagar = 0, cantidadPagada = 0;
        private int fontSize = 14;
        private IFirebaseClient client;
        private Data data;
        public POSmodule(IFirebaseClient client, Data data)
        {
            InitializeComponent();
            this.client = client;
            this.data = data;
            txtPoSBarCode.Select();
            var res = SystemInformation.VirtualScreen;
            int monitors = SystemInformation.MonitorCount;
            int x = 0;
            if (monitors == 1)
                x = res.Width;
            else if (monitors > 1)
                x = Math.Abs(res.X);
            int y = res.Height;
            responsivePointOfSale(x, y);
            dynamicDate();
            getIDSale();
        }

        private void dynamicDate()
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblPoSCurrentDate.Text = "Fecha: " + DateTime.Now.ToString();
        }

        private void getIDSale()
        {
            var db = new SqliteDBContextConn();
            int lastSale = 1;
            try
            {
                lastSale = db.pos.OrderByDescending(p => p.ID).First().ID + 1;
            }
            catch (Exception ex)
            {

            }
            lblPoSId.Text = lastSale.ToString();
        }

        private void responsivePointOfSale(int x, int y) //x are widht and y heigth
        { //Return new values for width of columns
            if (y >= 1080)
            {
                dgvPoSArtList.Size = new Size(1882, 230);
                txtPoSBarCode.Size = new Size(x - 415, 176);
                fontSize = 24;
            }
            if (y <= 768)
            {
                dgvPoSArtList.Size = new Size(1328, 230);
                txtPoSBarCode.Size = new Size(x - 415, 176);
                fontSize = 16;
            }
            btnPoSProductInf.Location = new Point(x - 384, 43);
            grpbSale.Location = new Point(x - 352, y - 250);
            btnPoSConfirm.Location = new Point(x - 316, y - 142);
            lblPoSKeyFunctions.Location = new Point(10, y - 40);
            grpbPoSSale.Location = new Point(x - 138, 5);
            btnPoSOpenDrawer.Location = new Point(10, y - 70);
            btnPoSConfig.Location = new Point(115, y - 70);
            dgvPoSArtList.Width = x - 25;
        }

        private void btnPoSProductInf_Click(object sender, EventArgs e)
        {
            using (var articleInf = new Article.ArticleInf())
            {
                var result = articleInf.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var val = articleInf.prod;
                    if (val != null)
                        AddProduct(val);
                }
            }
        }

        private void POSmodule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
                btnPoSProductInf_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.F10)
                new Article.ListArticle().ShowDialog(this);
            if (e.KeyCode == Keys.F11)
                new Sale.CutSale().ShowDialog(this);
            if (e.KeyCode == Keys.F12)
                new Sale.ListSale().ShowDialog(this);
            if (e.KeyCode == Keys.F4)
                btnPoSConfirm_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.F8)
                btnPoSOpenDrawer_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.Escape)
            {
                var result = new MessageMsg("Seguro de que deseas cerrar?", "Si, cerrar", "No, quedarse").ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    takeAwayBranchoffice(client, searchUserPass(data.User));
                    Application.Exit();
                }
            }
        }

        private Data searchUserPass(string user)
        {
            FirebaseResponse response = client.Get(user);
            Data result = response.ResultAs<Data>();
            return result;
        }

        private void POSmodule_Load(object sender, EventArgs e)
        {
            dgvPoSArtList.DataSource = listprod;

            dgvPoSArtList.Columns[0].Visible = false;

            dgvPoSArtList.Columns[1].HeaderText = "Código de barras";
            dgvPoSArtList.Columns[3].HeaderText = "Precio";
            dgvPoSArtList.Columns[4].HeaderText = "Cantidad";

            dgvPoSArtList.Columns[1].Width = 350;
            //dgvPoSArtList.Columns[2].Width = 650;
            dgvPoSArtList.Columns[3].Width = 250;
            dgvPoSArtList.Columns[4].Width = 250;
            dgvPoSArtList.Columns[5].Width = 150;
            //dgvPoSArtList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPoSArtList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvPoSArtList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvPoSArtList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvPoSArtList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPoSArtList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPoSArtList.Font = new Font("Arial", fontSize);
            dgvPoSArtList.ColumnHeadersHeight = 80;
        }

        public void AddProduct(Product prod)
        {
            bool r = searchForProduct(prod.ID);
            if (!r)
            {
                var newProd = new ProdSaleDataGrid();
                newProd.IdProduct = prod.ID;
                newProd.CódigoBarras = prod.ProductCode;
                newProd.Nombre = prod.ProductName;
                newProd.PrecioVenta = prod.ProductPrice;
                newProd.CantidadComprar = 1;
                newProd.Subtotal = prod.ProductPrice;
                listprod.Add(newProd);
                source.DataSource = listprod;
                cantidadPagar += prod.ProductPrice;
            }
            lblPoSCostSaleValue.Text = cantidadPagar.ToString();
            RefreshDatagrid();
        }

        private bool searchForProduct(int prodID)
        {
            bool result = false;
            if (listprod.Count != 0)
            {
                cantidadPagar = 0;
                foreach (var prod in listprod)
                {
                    if (prod.IdProduct == prodID)
                    {
                        prod.CantidadComprar += 1;
                        prod.Subtotal = prod.CantidadComprar * prod.PrecioVenta;
                        result = true;
                    }
                    cantidadPagar += prod.Subtotal;
                }
            }
            return result;
        }

        private void RefreshDatagrid()
        {
            source.ResetBindings(true);
            dgvPoSArtList.DataSource = source;
            txtPoSBarCode.Clear();
            txtPoSBarCode.Select();
        }

        private async void btnPoSConfirm_Click(object sender, EventArgs e)
        {
            checkPaySale();
            var db = new SqliteDBContextConn();
            await db.Database.EnsureCreatedAsync();
            var pos = new PointOfSales();
            if (listprod.Count > 0 && cantidadPagada >= cantidadPagar)
            {
                saveSale(pos, db);
                saveProdSale(pos.ID, listprod, db);
                removeFromStock(listprod, db);
                new MessageMsg("La venta se ha realizado con éxito!").ShowDialog(this);
                cantidadPagar = 0;
                var products = db.PointOfSale_Product.Where(p => p.PoSID == pos.ID).ToList();
                printArticles(pos, listprod);
                openDrawer();
                clearAll();
                getIDSale();
            }
            else if (listprod.Count == 0)
                new MessageMsg("Sin productos en la venta").ShowDialog(this);
            else if (cantidadPagada < cantidadPagar)
                new MessageMsg("Porfavor, ingrese la venta").ShowDialog(this);
        }

        private void removeFromStock(List<ProdSaleDataGrid> prods, SqliteDBContextConn db)
        {
            foreach (var prod in prods)
            {
                var rProd = db.prod.Find(prod.IdProduct);
                rProd.QuantityStorage -= prod.CantidadComprar;
                db.SaveChanges();
            }
        }

        private void checkPaySale()
        {
            if (mtxtPoSCharge.Text != "$    .") { cantidadPagada = float.Parse(mtxtPoSCharge.Text.Substring(1)); } else { cantidadPagada = 0; }
        }

        private async void saveSale(PointOfSales pos, SqliteDBContextConn db)
        {
            pos.SalePrice = float.Parse(lblPoSCostSaleValue.Text);
            pos.SalePayPrice = cantidadPagada;
            pos.SaleChange = cantidadPagada - float.Parse(lblPoSCostSaleValue.Text);
            pos.SaleDate = DateTime.Now;
            pos.LastUpdate = DateTime.Now;
            db.pos.Add(pos);
            await db.SaveChangesAsync();
        }

        private async void saveProdSale(int posid, List<ProdSaleDataGrid> prods, SqliteDBContextConn db)
        {
            foreach (var prod in prods)
            {
                var prodPos = new PointOfSale_Product();
                float prodPrice = db.prod.Find(prod.IdProduct).ProductPrice;
                prodPos.PoSID = posid;
                prodPos.ProductID = prod.IdProduct;
                prodPos.ProductQty = prod.CantidadComprar;
                prodPos.ProductsPrices = prod.CantidadComprar * prodPrice;
                db.PointOfSale_Product.Add(prodPos);
                await db.SaveChangesAsync();
            }
        }

        private void clearAll()
        {
            lblPoSCostSaleValue.Text = cantidadPagar.ToString();
            mtxtPoSCharge.Clear();
            listprod.Clear();
            source.DataSource = listprod;
            RefreshDatagrid();
        }

        private void txtPoSBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var db = new SqliteDBContextConn();
                Product prod = new Product();
                prod = db.prod.FirstOrDefault(p => p.ProductCode == txtPoSBarCode.Text.Replace("\r\n",""));
                if (prod != null)
                    AddProduct(prod);
                else
                    new MessageMsg("Parece que no se encontró producto").ShowDialog(this);
            }
        }

        private void dgvPoSArtList_DataSourceChanged(object sender, EventArgs e)
        {
            dgvPoSArtList.Refresh();
            dgvPoSArtList.Update();
        }

        private void dgvPoSArtList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialogResult = new MessageMsg("Estas seguro de eliminar el producto?", "Claro!", "No").ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    int index = dgvPoSArtList.CurrentCell.RowIndex;
                    var productCode = dgvPoSArtList.Rows[index].Cells[0].Value;
                    removeFromList(int.Parse(productCode.ToString()));
                    source.DataSource = listprod;
                    RefreshDatagrid();
                    new MessageMsg("Unidad removida").ShowDialog(this);
                }
            }
        }

        private void printArticles(PointOfSales pointOfSale, List<ProdSaleDataGrid> pointOfSale_Products)
        {
            PrintTicket pt = new PrintTicket(pointOfSale, pointOfSale_Products);
            pt.printSale();
        }

        private void openDrawer()
        {
            PrintTicket pt = new PrintTicket();
            pt.openDrawerOnly();
        }

        private void btnPoSOpenDrawer_Click(object sender, EventArgs e)
        {
            openDrawer();
        }

        private void removeFromList(int prodID)
        {
            foreach (var prod in listprod)
            {
                if (prod.IdProduct == prodID)
                {
                    cantidadPagar -= prod.Subtotal;
                    listprod.Remove(prod); 
                    break;
                }
            }
            lblPoSCostSaleValue.Text = cantidadPagar.ToString();
        }

        private void btnPoSConfig_Click(object sender, EventArgs e)
        {
            new Config().ShowDialog();
        }

        private void takeAwayBranchoffice(IFirebaseClient client, Data d)
        {
            var data = new Data
            {
                User = d.User,
                Used = d.Used - 1,
                Pass = d.Pass,
                Avaible = d.Avaible,
                Creation = d.Creation,
                LastPay = d.LastPay
            };
            client.Update(d.User, data);
        }
    }
}
