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
    public partial class CutSale : Form
    {
        //Pesos
        private int AmountBills1000p;
        private int AmountBills500p;
        private int AmountBills200p;
        private int AmountBills100p;
        private int AmountBills50p;
        private int AmountBills20p;
        private int AmountCoins100p;
        private int AmountCoins20p;
        private int AmountCoins10p;
        private int AmountCoins5p;
        private int AmountCoins2p;
        private int AmountCoins1p;
        private int AmountCoins50cp;
        //Dollars
        private int AmountBills100d;
        private int AmountBills50d;
        private int AmountBills20d;
        private int AmountBills10d;
        private int AmountBills5d;
        private int AmountBills2d;
        private int AmountBills1d;
        private int AmountCoins1000d;
        private int AmountCoins50d;
        private int AmountCoins25d;
        private int AmountCoins10d;
        private int AmountCoins5d;
        private int AmountCoins1d;

        private float dineroEnVenta;
        
        public CutSale()
        {
            InitializeComponent();
            textBox25.Select();
        }

        private void CutSale_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.F7)
                btnCutSaleAccept_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.F12)
                new Sale.ListCutSale().ShowDialog(this);
        }

        private void btnCutSaleAccept_Click(object sender, EventArgs e)
        {
            addSale();
        }

        private void addSale()
        {
            countMoney();
            if (dineroEnVenta > 0)
            {
                addCutSale();
                clearTextboxes();
                new MessageMsg("Corte de venta agregado correctamente").ShowDialog(this);
                this.Close();
            }
            else
            {
                DialogResult dialogResult = new MessageMsg("No se ha vendido nada, aun asi quieres hacer corte de caja?", "Claro!", "No").ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    addCutSale();
                    clearTextboxes();
                    new MessageMsg("Corte de venta agregado correctamente").ShowDialog(this);
                    this.Close();
                }
                else
                {
                    new MessageMsg("No se generó el corte").ShowDialog(this);
                    this.Close();
                }
            }

        }

        private void clearTextboxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
        }

        private void selectNumbers()
        {
            //Pesos
            if (textBox25.Text != "") { AmountBills1000p = int.Parse(textBox25.Text); } else { AmountBills1000p = 0; }
            if (textBox1.Text != "") { AmountBills500p = int.Parse(textBox1.Text); } else { AmountBills500p = 0; }
            if (textBox2.Text != "") { AmountBills200p = int.Parse(textBox2.Text); } else { AmountBills200p = 0; }
            if (textBox3.Text != "") { AmountBills100p = int.Parse(textBox3.Text); } else { AmountBills100p = 0; }
            if (textBox4.Text != "") { AmountBills50p = int.Parse(textBox4.Text); } else { AmountBills50p = 0; }
            if (textBox5.Text != "") { AmountBills20p = int.Parse(textBox5.Text); } else { AmountBills20p = 0; }
            if (textBox6.Text != "") { AmountCoins100p = int.Parse(textBox6.Text); } else { AmountCoins100p = 0; }
            if (textBox7.Text != "") { AmountCoins20p = int.Parse(textBox7.Text); } else { AmountCoins20p = 0; }
            if (textBox8.Text != "") { AmountCoins10p = int.Parse(textBox8.Text); } else { AmountCoins10p = 0; }
            if (textBox9.Text != "") { AmountCoins5p = int.Parse(textBox9.Text); } else { AmountCoins5p = 0; }
            if (textBox10.Text != "") { AmountCoins2p = int.Parse(textBox10.Text); } else { AmountCoins2p = 0; }
            if (textBox11.Text != "") { AmountCoins1p = int.Parse(textBox11.Text); } else { AmountCoins1p = 0; }
            if (textBox12.Text != "") { AmountCoins50cp = int.Parse(textBox12.Text); } else { AmountCoins50cp = 0; }
            //Dollars
            if (textBox24.Text != "") { AmountBills100d = int.Parse(textBox24.Text); } else { AmountBills100d = 0; }
            if (textBox23.Text != "") { AmountBills50d = int.Parse(textBox23.Text); } else { AmountBills50d = 0; }
            if (textBox21.Text != "") { AmountBills20d = int.Parse(textBox21.Text); } else { AmountBills20d = 0; }
            if (textBox19.Text != "") { AmountBills10d = int.Parse(textBox19.Text); } else { AmountBills10d = 0; }
            if (textBox17.Text != "") { AmountBills5d = int.Parse(textBox17.Text); } else { AmountBills5d = 0; }
            if (textBox14.Text != "") { AmountBills2d = int.Parse(textBox14.Text); } else { AmountBills2d = 0; }
            if (textBox22.Text != "") { AmountBills1d = int.Parse(textBox22.Text); } else { AmountBills1d = 0; }
            if (textBox20.Text != "") { AmountCoins1000d = int.Parse(textBox20.Text); } else { AmountCoins1000d = 0; }
            if (textBox18.Text != "") { AmountCoins50d = int.Parse(textBox18.Text); } else { AmountCoins50d = 0; }
            if (textBox16.Text != "") { AmountCoins25d = int.Parse(textBox16.Text); } else { AmountCoins25d = 0; }
            if (textBox15.Text != "") { AmountCoins10d = int.Parse(textBox15.Text); } else { AmountCoins10d = 0; }
            if (textBox13.Text != "") { AmountCoins5d = int.Parse(textBox13.Text); } else { AmountCoins5d = 0; }
            if (textBox26.Text != "") { AmountCoins1d = int.Parse(textBox26.Text); } else { AmountCoins1d = 0; }
        }

        private async void addCutSale()
        {
            var db = new SqliteDBContextConn();
            await db.Database.EnsureCreatedAsync();
            selectNumbers();
            var cut = new Connection.CutSale()
            {
                //Pesos
                AmountBills1000p = this.AmountBills1000p,
                AmountBills500p = this.AmountBills500p,
                AmountBills200p = this.AmountBills200p,
                AmountBills100p = this.AmountBills100p,
                AmountBills50p = this.AmountBills50p,
                AmountBills20p = this.AmountBills20p,
                AmountCoins100p = this.AmountCoins100p,
                AmountCoins20p = this.AmountCoins20p,
                AmountCoins10p = this.AmountCoins10p,
                AmountCoins5p = this.AmountCoins5p,
                AmountCoins2p = this.AmountCoins2p,
                AmountCoins1p = this.AmountCoins1p,
                AmountCoins50cp = this.AmountCoins50cp,
                //Dollars
                AmountBills100d = this.AmountBills100d,
                AmountBills50d = this.AmountBills50d,
                AmountBills20d = this.AmountBills20d,
                AmountBills10d = this.AmountBills10d,
                AmountBills5d = this.AmountBills5d,
                AmountBills2d = this.AmountBills2d,
                AmountBills1d = this.AmountBills1d,
                AmountCoins1000d = this.AmountCoins1000d,
                AmountCoins50d = this.AmountCoins50d,
                AmountCoins25d = this.AmountCoins25d,
                AmountCoins10d = this.AmountCoins10d,
                AmountCoins5d = this.AmountCoins5d,
                AmountCoins1d = this.AmountCoins1d,

                CutDate = DateTime.Now,

                //true = pesos, false = dollars
                totalD = total(false),
                totalP = total(true)
            };
            db.cut.Add(cut);
            await db.SaveChangesAsync();
            var pos = db.pos.Where(p => p.SaleCutID == 0);
            foreach (var point in pos)
            {
                point.SaleCutID = cut.ID;
                await db.SaveChangesAsync();
            }
            printCut(cut);
        }

        public double total(bool isPesos)
        {
            double total = 0;
            if (isPesos)
            {
                total = (AmountBills1000p * 1000) + (AmountBills500p * 500) + (AmountBills200p * 200) + (AmountBills100p * 100) + (AmountBills50p * 50) + (AmountBills20p * 20) + (AmountCoins100p * 100) + (AmountCoins20p * 20) + (AmountCoins10p * 10) + (AmountCoins5p * 5) + (AmountCoins2p * 2) + (AmountCoins1p * 1) + (AmountCoins50cp * .50); 
            }
            else
            {
                total = (AmountBills100d * 100) + (AmountBills50d * 50) + (AmountBills20d * 20) + (AmountBills10d * 10) + (AmountBills5d * 5) + (AmountBills2d * 2) + (AmountBills1d * 1) + (AmountCoins1000d * 1) + (AmountCoins50d * .50) + (AmountCoins25d * .25) + (AmountCoins10d * .1) + (AmountCoins5d * .05) + (AmountCoins1d * .01);
            }
            return total;
        }

        private void countMoney()
        {
            var db = new SqliteDBContextConn();
            List<PointOfSales> lpos = new List<PointOfSales>();
            try
            { 
                lpos = db.pos.Where(p => p.SaleCutID == 0).ToList();

                foreach (var point in lpos)
                {
                    dineroEnVenta += point.SalePayPrice;
                }
            }
            catch (Exception ex) 
            {
                new MessageMsg("Sin ventas").ShowDialog(this); 
            }
        }

        private void textBox_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 && 
                e.KeyCode == Keys.NumPad2 && 
                e.KeyCode == Keys.NumPad3 && 
                e.KeyCode == Keys.NumPad4 && 
                e.KeyCode == Keys.NumPad5 && 
                e.KeyCode == Keys.NumPad6 &&
                e.KeyCode == Keys.NumPad7 && 
                e.KeyCode == Keys.NumPad8 &&
                e.KeyCode == Keys.NumPad9 && 
                e.KeyCode == Keys.NumPad0)
            {
                (sender as TextBox).Text = e.KeyCode.ToString();
            }
            else
            {
                (sender as TextBox).Text = (sender as TextBox).Text.Substring(0, (sender as TextBox).Text.Length - 1);
            }
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

        private void printCut(Connection.CutSale cutSale)
        {
            PrintTicket pt = new PrintTicket(cutSale);
            pt.printCut();
        }
    }
}
