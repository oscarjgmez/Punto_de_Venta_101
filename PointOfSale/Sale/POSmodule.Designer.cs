
namespace PointOfSale
{
    partial class POSmodule
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPoSBarCode = new System.Windows.Forms.TextBox();
            this.btnPoSProductInf = new System.Windows.Forms.Button();
            this.lblPoSSale = new System.Windows.Forms.Label();
            this.lblPoSCurrentDate = new System.Windows.Forms.Label();
            this.mtxtPoSCharge = new System.Windows.Forms.MaskedTextBox();
            this.lblPosReceived = new System.Windows.Forms.Label();
            this.lblPosCostSale = new System.Windows.Forms.Label();
            this.lblPoSCostSaleValue = new System.Windows.Forms.Label();
            this.btnPoSConfirm = new System.Windows.Forms.Button();
            this.lblPoSKeyFunctions = new System.Windows.Forms.Label();
            this.dgvPoSArtList = new System.Windows.Forms.DataGridView();
            this.lblPoSId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPoSOpenDrawer = new System.Windows.Forms.Button();
            this.grpbSale = new System.Windows.Forms.GroupBox();
            this.grpbPoSSale = new System.Windows.Forms.GroupBox();
            this.btnPoSConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoSArtList)).BeginInit();
            this.grpbSale.SuspendLayout();
            this.grpbPoSSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPoSBarCode
            // 
            this.txtPoSBarCode.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoSBarCode.Location = new System.Drawing.Point(12, 61);
            this.txtPoSBarCode.Name = "txtPoSBarCode";
            this.txtPoSBarCode.Size = new System.Drawing.Size(500, 50);
            this.txtPoSBarCode.TabIndex = 1;
            this.txtPoSBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPoSBarCode_KeyDown);
            // 
            // btnPoSProductInf
            // 
            this.btnPoSProductInf.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPoSProductInf.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPoSProductInf.Location = new System.Drawing.Point(532, 43);
            this.btnPoSProductInf.Name = "btnPoSProductInf";
            this.btnPoSProductInf.Size = new System.Drawing.Size(372, 94);
            this.btnPoSProductInf.TabIndex = 2;
            this.btnPoSProductInf.Text = "Botón para ingresar manualmente un producto";
            this.btnPoSProductInf.UseVisualStyleBackColor = true;
            this.btnPoSProductInf.Click += new System.EventHandler(this.btnPoSProductInf_Click);
            // 
            // lblPoSSale
            // 
            this.lblPoSSale.AutoSize = true;
            this.lblPoSSale.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoSSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblPoSSale.Location = new System.Drawing.Point(6, 19);
            this.lblPoSSale.Name = "lblPoSSale";
            this.lblPoSSale.Size = new System.Drawing.Size(85, 15);
            this.lblPoSSale.TabIndex = 3;
            this.lblPoSSale.Text = "No. de Venta";
            // 
            // lblPoSCurrentDate
            // 
            this.lblPoSCurrentDate.AutoSize = true;
            this.lblPoSCurrentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoSCurrentDate.Location = new System.Drawing.Point(12, 10);
            this.lblPoSCurrentDate.Name = "lblPoSCurrentDate";
            this.lblPoSCurrentDate.Size = new System.Drawing.Size(162, 21);
            this.lblPoSCurrentDate.TabIndex = 4;
            this.lblPoSCurrentDate.Text = "Fecha: dd/mm/aaaa";
            // 
            // mtxtPoSCharge
            // 
            this.mtxtPoSCharge.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtPoSCharge.Location = new System.Drawing.Point(219, 55);
            this.mtxtPoSCharge.Mask = "$0000.00";
            this.mtxtPoSCharge.Name = "mtxtPoSCharge";
            this.mtxtPoSCharge.Size = new System.Drawing.Size(110, 39);
            this.mtxtPoSCharge.TabIndex = 5;
            // 
            // lblPosReceived
            // 
            this.lblPosReceived.AutoSize = true;
            this.lblPosReceived.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPosReceived.Location = new System.Drawing.Point(90, 58);
            this.lblPosReceived.Name = "lblPosReceived";
            this.lblPosReceived.Size = new System.Drawing.Size(110, 32);
            this.lblPosReceived.TabIndex = 6;
            this.lblPosReceived.Text = "Recibido:";
            // 
            // lblPosCostSale
            // 
            this.lblPosCostSale.AutoSize = true;
            this.lblPosCostSale.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPosCostSale.Location = new System.Drawing.Point(6, 19);
            this.lblPosCostSale.Name = "lblPosCostSale";
            this.lblPosCostSale.Size = new System.Drawing.Size(196, 32);
            this.lblPosCostSale.TabIndex = 7;
            this.lblPosCostSale.Text = "Costo de venta:";
            // 
            // lblPoSCostSaleValue
            // 
            this.lblPoSCostSaleValue.AutoSize = true;
            this.lblPoSCostSaleValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoSCostSaleValue.Location = new System.Drawing.Point(232, 19);
            this.lblPoSCostSaleValue.Name = "lblPoSCostSaleValue";
            this.lblPoSCostSaleValue.Size = new System.Drawing.Size(97, 32);
            this.lblPoSCostSaleValue.TabIndex = 8;
            this.lblPoSCostSaleValue.Text = "0000.00";
            // 
            // btnPoSConfirm
            // 
            this.btnPoSConfirm.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPoSConfirm.Location = new System.Drawing.Point(599, 572);
            this.btnPoSConfirm.Name = "btnPoSConfirm";
            this.btnPoSConfirm.Size = new System.Drawing.Size(305, 66);
            this.btnPoSConfirm.TabIndex = 9;
            this.btnPoSConfirm.Text = "Confirmar la venta [F4]";
            this.btnPoSConfirm.UseVisualStyleBackColor = true;
            this.btnPoSConfirm.Click += new System.EventHandler(this.btnPoSConfirm_Click);
            // 
            // lblPoSKeyFunctions
            // 
            this.lblPoSKeyFunctions.AutoSize = true;
            this.lblPoSKeyFunctions.Location = new System.Drawing.Point(12, 623);
            this.lblPoSKeyFunctions.Name = "lblPoSKeyFunctions";
            this.lblPoSKeyFunctions.Size = new System.Drawing.Size(581, 15);
            this.lblPoSKeyFunctions.TabIndex = 10;
            this.lblPoSKeyFunctions.Text = "BUSCAR UN PRODUCT [F9] | VER INVETARIO [F10] | HACER CORTE DE CAJA [F11] | VER LI" +
    "STA DE VENTAS [F12]";
            // 
            // dgvPoSArtList
            // 
            this.dgvPoSArtList.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvPoSArtList.AllowUserToAddRows = false;
            this.dgvPoSArtList.AllowUserToDeleteRows = false;
            this.dgvPoSArtList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPoSArtList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPoSArtList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPoSArtList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPoSArtList.Location = new System.Drawing.Point(12, 171);
            this.dgvPoSArtList.Name = "dgvPoSArtList";
            this.dgvPoSArtList.ReadOnly = true;
            this.dgvPoSArtList.RowTemplate.Height = 25;
            this.dgvPoSArtList.Size = new System.Drawing.Size(892, 283);
            this.dgvPoSArtList.TabIndex = 11;
            this.dgvPoSArtList.DataSourceChanged += new System.EventHandler(this.dgvPoSArtList_DataSourceChanged);
            this.dgvPoSArtList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPoSArtList_KeyDown);
            // 
            // lblPoSId
            // 
            this.lblPoSId.AutoSize = true;
            this.lblPoSId.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoSId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblPoSId.Location = new System.Drawing.Point(90, 19);
            this.lblPoSId.Name = "lblPoSId";
            this.lblPoSId.Size = new System.Drawing.Size(14, 15);
            this.lblPoSId.TabIndex = 12;
            this.lblPoSId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "$";
            // 
            // btnPoSOpenDrawer
            // 
            this.btnPoSOpenDrawer.Location = new System.Drawing.Point(12, 597);
            this.btnPoSOpenDrawer.Name = "btnPoSOpenDrawer";
            this.btnPoSOpenDrawer.Size = new System.Drawing.Size(100, 23);
            this.btnPoSOpenDrawer.TabIndex = 13;
            this.btnPoSOpenDrawer.Text = "Abrir cajon [F8]";
            this.btnPoSOpenDrawer.UseVisualStyleBackColor = true;
            this.btnPoSOpenDrawer.Click += new System.EventHandler(this.btnPoSOpenDrawer_Click);
            // 
            // grpbSale
            // 
            this.grpbSale.Controls.Add(this.lblPosReceived);
            this.grpbSale.Controls.Add(this.mtxtPoSCharge);
            this.grpbSale.Controls.Add(this.lblPosCostSale);
            this.grpbSale.Controls.Add(this.lblPoSCostSaleValue);
            this.grpbSale.Controls.Add(this.label1);
            this.grpbSale.Location = new System.Drawing.Point(565, 460);
            this.grpbSale.Name = "grpbSale";
            this.grpbSale.Size = new System.Drawing.Size(339, 100);
            this.grpbSale.TabIndex = 14;
            this.grpbSale.TabStop = false;
            // 
            // grpbPoSSale
            // 
            this.grpbPoSSale.Controls.Add(this.lblPoSSale);
            this.grpbPoSSale.Controls.Add(this.lblPoSId);
            this.grpbPoSSale.Location = new System.Drawing.Point(784, 1);
            this.grpbPoSSale.Name = "grpbPoSSale";
            this.grpbPoSSale.Size = new System.Drawing.Size(120, 44);
            this.grpbPoSSale.TabIndex = 15;
            this.grpbPoSSale.TabStop = false;
            // 
            // btnPoSConfig
            // 
            this.btnPoSConfig.Location = new System.Drawing.Point(119, 596);
            this.btnPoSConfig.Name = "btnPoSConfig";
            this.btnPoSConfig.Size = new System.Drawing.Size(22, 23);
            this.btnPoSConfig.TabIndex = 16;
            this.btnPoSConfig.UseVisualStyleBackColor = true;
            this.btnPoSConfig.Click += new System.EventHandler(this.btnPoSConfig_Click);
            // 
            // POSmodule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(913, 654);
            this.Controls.Add(this.btnPoSConfig);
            this.Controls.Add(this.btnPoSProductInf);
            this.Controls.Add(this.grpbPoSSale);
            this.Controls.Add(this.grpbSale);
            this.Controls.Add(this.btnPoSOpenDrawer);
            this.Controls.Add(this.dgvPoSArtList);
            this.Controls.Add(this.lblPoSKeyFunctions);
            this.Controls.Add(this.btnPoSConfirm);
            this.Controls.Add(this.lblPoSCurrentDate);
            this.Controls.Add(this.txtPoSBarCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POSmodule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta - Be Fashion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POSmodule_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.POSmodule_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoSArtList)).EndInit();
            this.grpbSale.ResumeLayout(false);
            this.grpbSale.PerformLayout();
            this.grpbPoSSale.ResumeLayout(false);
            this.grpbPoSSale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPoSBarCode;
        private System.Windows.Forms.Button btnPoSProductInf;
        private System.Windows.Forms.Label lblPoSSale;
        private System.Windows.Forms.Label lblPoSCurrentDate;
        private System.Windows.Forms.MaskedTextBox mtxtPoSCharge;
        private System.Windows.Forms.Label lblPosReceived;
        private System.Windows.Forms.Label lblPosCostSale;
        private System.Windows.Forms.Label lblPoSCostSaleValue;
        private System.Windows.Forms.Button btnPoSConfirm;
        private System.Windows.Forms.Label lblPoSKeyFunctions;
        private System.Windows.Forms.DataGridView dgvPoSArtList;
        private System.Windows.Forms.Label lblPoSId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPoSOpenDrawer;
        private System.Windows.Forms.GroupBox grpbSale;
        private System.Windows.Forms.GroupBox grpbPoSSale;
        private System.Windows.Forms.Button btnPoSConfig;
    }
}

