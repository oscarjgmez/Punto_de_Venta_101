using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class MessageMsg : Form
    {
        private bool containsButtons = false;
        public MessageMsg(String msg)
        {
            InitializeComponent();
            lblMsg.Text = msg;
            btnAccept.Hide();
            btnCancel.Hide();
            this.Height = 85;
            this.Width = 600;
        }

        public MessageMsg(String msg, String accept, String cancel)
        {
            InitializeComponent();
            lblMsg.Text = msg;
            btnAccept.Text = accept;
            btnCancel.Text = cancel;
            containsButtons = true;
        }

        private void MessageMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && !containsButtons)
                this.Close();
        }
    }
}
