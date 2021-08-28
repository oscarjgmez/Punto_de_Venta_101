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
    public partial class ListCutSale : Form
    {
        private List<CutSaleDataGrid> cutDatas = new List<CutSaleDataGrid>();
        private BindingSource source = new BindingSource();
        private bool isLoaded = false;
        public ListCutSale()
        {
            InitializeComponent();
            loadCutSaleList();
        }

        private void loadCutSaleList()
        {
            var db = new SqliteDBContextConn();
            var cuts = db.cut.ToList();
            foreach (var cut in cuts)
            {
                var cutDatagrid = new CutSaleDataGrid();
                cutDatagrid.IdCorte = cut.ID;
                cutDatagrid.FechaDeCreación = cut.CutDate;
                cutDatas.Add(cutDatagrid);
                source.DataSource = cutDatas.OrderByDescending(t => t.IdCorte);
            }
            refreshDatagrid();
            if (cuts.Count > 0)
                isLoaded = true;
        }

        private void ListCutSale_Load(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                dgvCutSaleList.Columns[0].HeaderText = "Folio";
                dgvCutSaleList.Columns[1].HeaderText = "Fecha de corte";

                dgvCutSaleList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvCutSaleList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dtpSaleSearchDate_CloseUp(object sender, EventArgs e)
        {
            var db = new SqliteDBContextConn();
            var cuts = db.cut.Where(p => p.CutDate >= dtpSaleSearchDate.Value.Date).ToList();
            foreach (var cut in cuts)
            {
                var cutDatagrid = new CutSaleDataGrid();
                cutDatagrid.IdCorte = cut.ID;
                cutDatagrid.FechaDeCreación = cut.CutDate;
                cutDatas.Add(cutDatagrid);
                source.DataSource = cutDatas.OrderByDescending(t => t.IdCorte);
            }
            refreshDatagrid();
        }

        private void refreshDatagrid()
        {
            source.ResetBindings(true);
            dgvCutSaleList.DataSource = source;
        }
    }
}
