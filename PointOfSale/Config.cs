using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PointOfSale.Connection;
using System.Linq;

namespace PointOfSale
{
    public partial class Config : Form
    {
        string fileName = @"C:\Temp\configPOS.txt";
        public string printer;
        public Config()
        {
            InitializeComponent();
            searchPrinter();
            txtConfigPrinterName.Text = printer;
        }

        private async void savePrinter()
        {
            SqliteDBContextConn db = new SqliteDBContextConn();
            await db.Database.EnsureCreatedAsync();
            Printer p = new Printer();
            p.Name = printer;
            db.printer.Update(p);
            await db.SaveChangesAsync();
        }

        private void searchPrinter()
        {
            SqliteDBContextConn db = new SqliteDBContextConn();
            var name = db.printer.OrderByDescending(p => p.ID).Select(p => p.Name).First();
            printer = name;
        }

        private void txtConfigPrinterName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                printer = txtConfigPrinterName.Text;
                savePrinter();
                new MessageMsg("Impresora configurada con éxito!").ShowDialog(this);
            }
        }
    }
}
