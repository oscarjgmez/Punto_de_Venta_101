using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
/*
 * Creador: Oscar Javier Gamez Sanchez
 * Hora creación 25-mayo-2021
 * Versión 1.0.0
 */

namespace PointOfSale
{
    public partial class LogIn : Form
    {
        string fileName = @"C:\Temp\configPOS.txt";
        string user, pass;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "dUxvyxSX3mVooSbAWYZsPJCEdvIFwhMdoNS3w7zE",
            BasePath = "https://puntodeventa-e2fe9-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;
        public LogIn()
        {
            InitializeComponent();
            var conn = connection();
            if (!conn)
            {
                new MessageMsg("Sin internet / Servidor no funciona").ShowDialog(this);
            }
            else
            {
                if (lookForFile())
                    searchUserPass();
            }
        }

        private async void connectUser()
        {
            var data = new Data
            {
                User = txtUser.Text,
                Pass = txtPass.Text,
            };
            SetResponse response = await client.SetAsync(txtUser.Text, data);
            Data result = response.ResultAs<Data>();
            new MessageMsg("Data inserted").ShowDialog(this);
        }

        private bool connection()
        {
            bool isEstablish = false;
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
                isEstablish = true;
            return isEstablish;
        }

        private async void searchUserPass()
        {
            FirebaseResponse response = await client.GetAsync(user);
            Data result = response.ResultAs<Data>();
            if (result.User != null)
            {
                if (pass == result.Pass)
                {
                    if ((result.Used + 1) <= result.Avaible)
                    {
                        createLookForFile();
                        insertBranchoffice(result);
                        this.Hide();
                    }
                    else
                    {
                        new MessageMsg("Ya no tienes accesos disponibles").ShowDialog();
                    }
                }
                else
                {
                    new MessageMsg("La contraseña está mal").ShowDialog();
                }
            }
        }

        private void insertBranchoffice(Data d)
        {
            var data = new Data
            {
                User = d.User,
                Used = d.Used + 1,
                Pass = d.Pass,
                Avaible = d.Avaible,
                Creation = d.Creation,
                LastPay = d.LastPay
            };
            FirebaseResponse response = client.Update(user, data);
            new POSmodule(client, response.ResultAs<Data>()).Show();
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                user = txtUser.Text.ToLower();
                pass = txtPass.Text;
                searchUserPass();
            }
        }

        private void createLookForFile()
        {
            try
            {
                // Check if file already exists. If yes, open it.     
                if (!File.Exists(fileName))
                {
                    // Create a new file     
                    using (FileStream fs = File.Create(fileName))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes(user + "\r\n");
                        fs.Write(title, 0, title.Length);
                        Byte[] txt = new UTF8Encoding(true).GetBytes(pass + "\r\n");
                        fs.Write(txt, 0, txt.Length);
                        byte[] author = new UTF8Encoding(true).GetBytes("Oscar");
                        fs.Write(author, 1, author.Length);
                    }
                }
                else if (File.Exists(fileName))
                {
                    using (StreamWriter sw = new FileInfo(fileName).CreateText())
                    {
                        sw.WriteLine(user);
                        sw.WriteLine(pass);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private bool lookForFile()
        {
            bool isExisting = false;
            try
            {
                // Check if file already exists. If yes, open it.     
                if (File.Exists(fileName))
                {
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        user = sr.ReadLine();
                        pass = sr.ReadLine();
                        sr.Close();
                    }
                    if (user != null && pass != null)
                        isExisting = true;
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            return isExisting;
        }
    }
}
