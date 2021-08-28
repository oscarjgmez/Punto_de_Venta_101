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
    public partial class ListSale : Form
    {
        List<SaleDataGrid> saleDatas = new List<SaleDataGrid>();
        private BindingSource source = new BindingSource();
        private bool isLoaded = false;
        public ListSale()
        {
            InitializeComponent();
            viewSales();
        }

        private void viewSales()
        {
            var db = new SqliteDBContextConn();
            List<PointOfSales> sales = new List<PointOfSales>();
            try
            {
                sales = db.pos.ToList();
                if (sales.Count > 0)
                    isLoaded = true;
            }
            catch (Exception ex)
            {
                new MessageMsg("No existen ventas").ShowDialog(this);
                this.Close();
            }                
            foreach (var sale in sales)
            {
                var dgs = new SaleDataGrid();
                dgs.IdVenta = sale.ID;
                dgs.PrecioVenta = sale.SalePrice;
                dgs.FechaDeVenta = sale.SaleDate;
                saleDatas.Add(dgs);
            }
            source.DataSource = saleDatas.OrderByDescending(t => t.IdVenta);
            refreshDatagrid();
        }

        private void searchSales()
        {
            saleDatas.Clear();
            var db = new SqliteDBContextConn();
            List<PointOfSales> sales = new List<PointOfSales>();
            try
            {
                if (txtSaleSearchCode.Text == "" && dtpSaleSearchDate.Value == null)
                    sales = db.pos.OrderBy(p => p.ID).ToList();
                else if (txtSaleSearchCode.Text == "" && dtpSaleSearchDate.Value != null)
                    sales = db.pos.Where(p => p.SaleDate.Date >= dtpSaleSearchDate.Value.Date).OrderBy(p => p.ID).ToList();
                else if (txtSaleSearchCode.Text != "" && dtpSaleSearchDate.Value == null)
                    sales = db.pos.Where(p => p.ID == int.Parse(txtSaleSearchCode.Text)).OrderBy(p => p.ID).ToList();
                else
                    sales = db.pos.Where(p => p.ID == int.Parse(txtSaleSearchCode.Text) && p.SaleDate.Date >= dtpSaleSearchDate.Value.Date).OrderBy(p => p.ID).ToList();
            }
            catch (Exception ex)
            {
                new MessageMsg("No existen ventas").ShowDialog(this);
                this.Close();
            }
            foreach (var sale in sales)
            {
                var dgs = new SaleDataGrid();
                dgs.IdVenta = sale.ID;
                dgs.PrecioVenta = sale.SalePrice;
                dgs.FechaDeVenta = sale.SaleDate;
                saleDatas.Add(dgs);
            }
            source.DataSource = saleDatas.OrderByDescending(t => t.IdVenta);
            refreshDatagrid();
        }

        private void refreshDatagrid()
        {
            source.ResetBindings(true);
            dgvSaleList.DataSource = source;
        }

        private void ListSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void dgvSaleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int value = int.Parse(dgvSaleList.Rows[e.RowIndex].Cells[0].Value.ToString());
                new SaleInf(value).ShowDialog(this);
                this.Close();
            }
        }

        private void txtSaleSearchCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchSales();
        }

        private void ListSale_Load(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                dgvSaleList.Columns[0].HeaderText = "Folio";
                dgvSaleList.Columns[1].HeaderText = "Precio total";
                dgvSaleList.Columns[2].HeaderText = "Fecha";

                dgvSaleList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSaleList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSaleList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dtpSaleSearchDate_CloseUp(object sender, EventArgs e)
        {
            searchSales();
        }
    }
}
