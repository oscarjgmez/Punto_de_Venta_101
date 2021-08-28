using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale.Connection
{
    class PrintTicket
    {
        private float x = 0; //Where is start
        private float y = 40; //Where is start
        private float width = 300; //Size of paper for 58mm on printer
        private float height = 40; //Size of the length of  ticket
        private string fontName = "Arial";
        private int fontSize = 14;
        private int subFontSize = 7;
        private string actualDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        private string pos_name = "BeFashion";
        private string pos_ad = "Avenida Tlaxcala 14 y 15";
        private string pos_ad2 = "LOCAL 2, #1407 Colonia: Jalisco";
        private string pos_cp = "C.P. 83447 San Luis R.C., Son."; 
        private string pos_rfc = "RFC: TOGR600720EA6";

        private string saleNote = "NOTA DE VENTA";
        private string dat = "Fecha: ";

        private string msj = "Cantidad-/-Nombre        Precio";
        private string line = "-------------------------------";
        private string lineD = "-------------DLLS---------------";
        private string lineP = "-------------MXN--------------";
        private string printer;
        private PointOfSales point = new PointOfSales();
        private List<ProdSaleDataGrid> products = new List<ProdSaleDataGrid>();
        private CutSale cut = new CutSale();

        public PrintTicket()
        {
            searchPrinter();
        }

        public PrintTicket(CutSale cut)
        {
            this.cut = cut;
            searchPrinter();
        }

        public PrintTicket(PointOfSales pos, List<ProdSaleDataGrid> pos_prod)
        {
            this.point = pos;
            this.products = pos_prod;
            searchPrinter();
        }
        private void searchPrinter()
        {
            SqliteDBContextConn db = new SqliteDBContextConn();
            var name = db.printer.OrderByDescending(p => p.ID).Select(p => p.Name).First();
            printer = name;
        }

        public void printCut()
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                ps.PrinterName = printer;
                pd.PrinterSettings = ps;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = pd;
                printDialog.Document.PrintPage += printCutSale;
                printDialog.Document.Print();
            }
            catch (Exception ex)
            {
                new MessageMsg("Error: " + ex).ShowDialog();
            }
        }

        private void printCutSale(object sender, PrintPageEventArgs e)
        {
            Font f = new Font(fontName, fontSize);
            // Set format of string. the string aligment
            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;
            StringFormat left = new StringFormat();
            left.Alignment = StringAlignment.Near;
            StringFormat right = new StringFormat();
            right.Alignment = StringAlignment.Far;

            e.Graphics.DrawString("", f, Brushes.Black, new RectangleF(x, y, width, height), center);
            y += e.Graphics.MeasureString("", f).Height;

            e.Graphics.DrawString(pos_name, f, Brushes.Black, new RectangleF(x, y, width, height), center);
            y += e.Graphics.MeasureString(pos_name, f).Height;
            e.Graphics.DrawString("CORTE DE CAJA", f, Brushes.Black, new RectangleF(x, y, width, height), center);
            y += e.Graphics.MeasureString(saleNote, f).Height;
            e.Graphics.DrawString(dat + actualDate, f, Brushes.Black, new RectangleF(x, y, width, height), left);
            y += e.Graphics.MeasureString(saleNote, f).Height;
            Font sf = new Font(fontName, subFontSize);

            e.Graphics.DrawString(lineD, sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(lineD, sf).Height;

            e.Graphics.DrawString("Billetes de 100 dolares: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 100 dolares: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills100d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills100d.ToString(), sf).Height;
            e.Graphics.DrawString("Billetes de 50 dolares: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 50 dolares: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills50d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills50d.ToString(), sf).Height;
            e.Graphics.DrawString("Billetes de 20 dolares: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 20 dolares: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills20d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills20d.ToString(), sf).Height;
            e.Graphics.DrawString("Billetes de 10 dolares: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 10 dolares: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills10d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills10d.ToString(), sf).Height; 
            e.Graphics.DrawString("Billetes de 5 dolares: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 5 dolares: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills5d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills5d.ToString(), sf).Height;
            e.Graphics.DrawString("Billetes de 2 dolares: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 2 dolares: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills2d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills2d.ToString(), sf).Height;
            e.Graphics.DrawString("Billetes de 1 dolar: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 1 dolar: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills1d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills1d.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 1 dolar: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 1 dolar: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins1000d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins1000d.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 50 centavos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 50 centavos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins50d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins50d.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 25 centavos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 25 centavos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins25d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins25d.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 10 centavos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 10 centavos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins10d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins10d.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 5 centavos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 5 centavos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins5d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins5d.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 1 centavos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 1 centavos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins1d.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins1d.ToString(), sf).Height;

            e.Graphics.DrawString(lineP, sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(lineP, sf).Height;

            e.Graphics.DrawString("Billetes de 1000 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 1000 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills1000p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills1000p.ToString(), sf).Height;
            e.Graphics.DrawString("Billetes de 500 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 500 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills500p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills500p.ToString(), sf).Height;
            e.Graphics.DrawString("Billetes de 200 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 200 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills200p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills200p.ToString(), sf).Height;
            e.Graphics.DrawString("Billetes de 100 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 100 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills100p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills100p.ToString(), sf).Height;
            e.Graphics.DrawString("Billetes de 50 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 50 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills50p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills50p.ToString(), sf).Height;
            e.Graphics.DrawString("Billetes de 20 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Billetes de 20 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountBills20p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountBills20p.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 100 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 100 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins100p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins100p.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 20 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 20 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins20p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins20p.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 10 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 10 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins10p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins10p.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 5 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 5 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins5p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins5p.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 2 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 2 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins2p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins2p.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 1 pesos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 1 pesos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins1p.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins1p.ToString(), sf).Height;
            e.Graphics.DrawString("Monedas de 50 centavos: ", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("Monedas de 50 centavos: ", sf).Height;
            e.Graphics.DrawString("                                      " + cut.AmountCoins50cp.ToString(), sf, Brushes.Black, new RectangleF(x, y, width, height), right);
            y += e.Graphics.MeasureString(cut.AmountCoins50cp.ToString(), sf).Height;

            e.Graphics.DrawString(line, sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(line, sf).Height;

            e.Graphics.DrawString("Total en dlls: $" + string.Format("{0:0,0.00}", cut.totalD), sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(line, sf).Height;
            e.Graphics.DrawString("Total en pesos: $" + string.Format("{0:0,0.00}", cut.totalP), sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(line, sf).Height;
        }

        public void printSale()
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                ps.PrinterName = printer;
                pd.PrinterSettings = ps;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = pd;
                printDialog.Document.PrintPage += printPage;
                printDialog.Document.Print();
            }
            catch (Exception ex)
            {
                new MessageMsg("Error: " + ex).ShowDialog();
            }
        }

        private void printPage(object sender, PrintPageEventArgs e)
        {
            Font f = new Font(fontName, fontSize);
            // Set format of string. the string aligment
            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;
            StringFormat left = new StringFormat();
            left.Alignment = StringAlignment.Near;
            StringFormat right = new StringFormat();
            right.Alignment = StringAlignment.Far;

            e.Graphics.DrawString("", f, Brushes.Black, new RectangleF(x, y, width, height), center);
            y += e.Graphics.MeasureString("", f).Height;

            e.Graphics.DrawString(pos_name, f, Brushes.Black, new RectangleF(x, y, width, height), center);
            y += e.Graphics.MeasureString(pos_name, f).Height;
            e.Graphics.DrawString(pos_ad, f, Brushes.Black, new RectangleF(x, y, width, height), center);
            y += e.Graphics.MeasureString(pos_ad, f).Height;
            e.Graphics.DrawString(pos_ad2, f, Brushes.Black, new RectangleF(x, y, width, height), center);
            y += e.Graphics.MeasureString(pos_ad2, f).Height;
            e.Graphics.DrawString(pos_cp, f, Brushes.Black, new RectangleF(x, y, width, height), center);
            y += e.Graphics.MeasureString(pos_cp, f).Height;
            e.Graphics.DrawString(pos_rfc, f, Brushes.Black, new RectangleF(x, y, width, height), center);
            y += e.Graphics.MeasureString(pos_rfc, f).Height;
            y += e.Graphics.MeasureString("", f).Height;
            y += e.Graphics.MeasureString("", f).Height;
            e.Graphics.DrawString(saleNote, f, Brushes.Black, new RectangleF(x, y, width, height), left);
            y += e.Graphics.MeasureString(saleNote, f).Height;
            e.Graphics.DrawString(dat + actualDate, f, Brushes.Black, new RectangleF(x, y, width, height), left);
            y += e.Graphics.MeasureString(saleNote, f).Height;
            Font sf = new Font(fontName, subFontSize);
            e.Graphics.DrawString(line, sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(msj, sf).Height;

            e.Graphics.DrawString("Folio de venta: " + point.ID, sf, Brushes.Black, new RectangleF(x, y, width, height), left);
            y += e.Graphics.MeasureString(point.ID.ToString(), sf).Height;
            e.Graphics.DrawString("Fecha v.: " + point.SaleDate, sf, Brushes.Black, new RectangleF(x, y, width, height), left);
            y += e.Graphics.MeasureString(point.SaleDate.ToString(), sf).Height;
            e.Graphics.DrawString(msj, sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(msj, sf).Height;
            e.Graphics.DrawString(line, sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(msj, sf).Height;

            foreach (var product in products)
            {
                SqliteDBContextConn db = new SqliteDBContextConn();
                Product prod = new Product();
                try
                {
                    prod = db.prod.FirstOrDefault(p => p.ID == product.IdProduct);
                    e.Graphics.DrawString(product.CantidadComprar.ToString() + " - " + product.Nombre, sf, Brushes.Black, new RectangleF(x, y, width, height));
                    y += e.Graphics.MeasureString(prod.ProductCode, sf).Height;
                    e.Graphics.DrawString("                                        $" + product.Subtotal, sf, Brushes.Black, new RectangleF(x, y, width, height), right);
                    y += e.Graphics.MeasureString(product.Subtotal.ToString(), sf).Height;
                    e.Graphics.DrawString("", sf, Brushes.Black, new RectangleF(x, y, width, height));
                    y += e.Graphics.MeasureString("", sf).Height;
                }
                catch (Exception ex)
                {
                    new MessageMsg("No se enconcontró el producto: con el ID: " + product.IdProduct + ex).ShowDialog();
                }
            }
            e.Graphics.DrawString("", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("", sf).Height;
            e.Graphics.DrawString("", sf, Brushes.Black, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString("", sf).Height;
            e.Graphics.DrawString(line, sf, Brushes.Black, new RectangleF(x, y * 2, width, height));
            y += e.Graphics.MeasureString(line, sf).Height;
            e.Graphics.DrawString("Total de la venta: $" + point.SalePrice, sf, Brushes.Black, new RectangleF(x, y * 2, width, height));
            y += e.Graphics.MeasureString(point.SalePrice.ToString(), sf).Height;
            e.Graphics.DrawString("Pagado: $" + point.SalePayPrice, sf, Brushes.Black, new RectangleF(x, y * 2, width, height));
            y += e.Graphics.MeasureString("" + point.SalePayPrice, sf).Height;
        }

        public void openDrawerOnly()
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                //ps.PrinterName = "Microsoft Print to PDF";
                ps.PrinterName = printer;
                pd.PrinterSettings = ps;
                pd.PrintPage += openDrawer;
                pd.Print();
            }
            catch (Exception ex)
            {
                new MessageMsg("Error: " + ex).ShowDialog();
            }
        }

        private void openDrawer(object sender, PrintPageEventArgs e)
        {
            Font f = new Font(fontName, fontSize);
            // Set format of string. the string aligment
            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;
            StringFormat left = new StringFormat();
            left.Alignment = StringAlignment.Near;
            StringFormat right = new StringFormat();
            right.Alignment = StringAlignment.Far;

            var rectangle = new RectangleF(x, y, width, height);
            e.Graphics.MeasureCharacterRanges("", f, rectangle, center);
            y += rectangle.Height;
        }
    }
}
