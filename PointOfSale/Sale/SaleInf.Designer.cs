
namespace PointOfSale.Sale
{
    partial class SaleInf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaleInfID = new System.Windows.Forms.Label();
            this.lblSaleInfPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaleInfDate = new System.Windows.Forms.Label();
            this.dgvSaleInf = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaleInfCutSale = new System.Windows.Forms.Label();
            this.chkbSaleInfActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio de la venta:";
            // 
            // lblSaleInfID
            // 
            this.lblSaleInfID.AutoSize = true;
            this.lblSaleInfID.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaleInfID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSaleInfID.Location = new System.Drawing.Point(144, 3);
            this.lblSaleInfID.Name = "lblSaleInfID";
            this.lblSaleInfID.Size = new System.Drawing.Size(71, 45);
            this.lblSaleInfID.TabIndex = 1;
            this.lblSaleInfID.Text = "000";
            // 
            // lblSaleInfPrice
            // 
            this.lblSaleInfPrice.AutoSize = true;
            this.lblSaleInfPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaleInfPrice.Location = new System.Drawing.Point(661, 400);
            this.lblSaleInfPrice.Name = "lblSaleInfPrice";
            this.lblSaleInfPrice.Size = new System.Drawing.Size(66, 25);
            this.lblSaleInfPrice.TabIndex = 2;
            this.lblSaleInfPrice.Text = "999.99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio total de la venta:";
            // 
            // lblSaleInfDate
            // 
            this.lblSaleInfDate.AutoSize = true;
            this.lblSaleInfDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaleInfDate.Location = new System.Drawing.Point(506, 17);
            this.lblSaleInfDate.Name = "lblSaleInfDate";
            this.lblSaleInfDate.Size = new System.Drawing.Size(215, 25);
            this.lblSaleInfDate.TabIndex = 4;
            this.lblSaleInfDate.Text = "dd/MM/yyyy hh:mm:ss";
            // 
            // dgvSaleInf
            // 
            this.dgvSaleInf.AllowUserToAddRows = false;
            this.dgvSaleInf.AllowUserToDeleteRows = false;
            this.dgvSaleInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleInf.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleInf.Location = new System.Drawing.Point(23, 102);
            this.dgvSaleInf.Name = "dgvSaleInf";
            this.dgvSaleInf.RowTemplate.Height = 25;
            this.dgvSaleInf.Size = new System.Drawing.Size(704, 286);
            this.dgvSaleInf.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de productos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(642, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Corte de caja:";
            // 
            // lblSaleInfCutSale
            // 
            this.lblSaleInfCutSale.AutoSize = true;
            this.lblSaleInfCutSale.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaleInfCutSale.Location = new System.Drawing.Point(106, 400);
            this.lblSaleInfCutSale.Name = "lblSaleInfCutSale";
            this.lblSaleInfCutSale.Size = new System.Drawing.Size(13, 13);
            this.lblSaleInfCutSale.TabIndex = 3;
            this.lblSaleInfCutSale.Text = "0";
            // 
            // chkbSaleInfActive
            // 
            this.chkbSaleInfActive.AutoSize = true;
            this.chkbSaleInfActive.Location = new System.Drawing.Point(137, 74);
            this.chkbSaleInfActive.Name = "chkbSaleInfActive";
            this.chkbSaleInfActive.Size = new System.Drawing.Size(65, 19);
            this.chkbSaleInfActive.TabIndex = 7;
            this.chkbSaleInfActive.Text = "Activos";
            this.chkbSaleInfActive.UseVisualStyleBackColor = true;
            this.chkbSaleInfActive.CheckedChanged += new System.EventHandler(this.chkbSaleInfActive_CheckedChanged);
            // 
            // SaleInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.chkbSaleInfActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSaleInf);
            this.Controls.Add(this.lblSaleInfDate);
            this.Controls.Add(this.lblSaleInfCutSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSaleInfPrice);
            this.Controls.Add(this.lblSaleInfID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "SaleInf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de la venta";
            this.Load += new System.EventHandler(this.SaleInf_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleInf_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaleInfID;
        private System.Windows.Forms.Label lblSaleInfPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaleInfDate;
        private System.Windows.Forms.DataGridView dgvSaleInf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaleInfCutSale;
        private System.Windows.Forms.CheckBox chkbSaleInfActive;
    }
}