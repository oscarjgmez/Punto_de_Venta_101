
namespace PointOfSale.Sale
{
    partial class ListSale
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
            this.dtpSaleSearchDate = new System.Windows.Forms.DateTimePicker();
            this.dgvSaleList = new System.Windows.Forms.DataGridView();
            this.grpArtSearchBy = new System.Windows.Forms.GroupBox();
            this.txtSaleSearchCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleList)).BeginInit();
            this.grpArtSearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpSaleSearchDate
            // 
            this.dtpSaleSearchDate.Location = new System.Drawing.Point(157, 22);
            this.dtpSaleSearchDate.Name = "dtpSaleSearchDate";
            this.dtpSaleSearchDate.Size = new System.Drawing.Size(200, 23);
            this.dtpSaleSearchDate.TabIndex = 1;
            this.dtpSaleSearchDate.CloseUp += new System.EventHandler(this.dtpSaleSearchDate_CloseUp);
            // 
            // dgvSaleList
            // 
            this.dgvSaleList.AllowUserToAddRows = false;
            this.dgvSaleList.AllowUserToDeleteRows = false;
            this.dgvSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleList.Location = new System.Drawing.Point(12, 72);
            this.dgvSaleList.Name = "dgvSaleList";
            this.dgvSaleList.RowTemplate.Height = 25;
            this.dgvSaleList.Size = new System.Drawing.Size(367, 366);
            this.dgvSaleList.TabIndex = 3;
            this.dgvSaleList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleList_CellDoubleClick);
            // 
            // grpArtSearchBy
            // 
            this.grpArtSearchBy.Controls.Add(this.dtpSaleSearchDate);
            this.grpArtSearchBy.Controls.Add(this.txtSaleSearchCode);
            this.grpArtSearchBy.Location = new System.Drawing.Point(12, 12);
            this.grpArtSearchBy.Name = "grpArtSearchBy";
            this.grpArtSearchBy.Size = new System.Drawing.Size(367, 54);
            this.grpArtSearchBy.TabIndex = 2;
            this.grpArtSearchBy.TabStop = false;
            this.grpArtSearchBy.Text = "Buscar por:";
            // 
            // txtSaleSearchCode
            // 
            this.txtSaleSearchCode.Location = new System.Drawing.Point(6, 22);
            this.txtSaleSearchCode.Name = "txtSaleSearchCode";
            this.txtSaleSearchCode.PlaceholderText = "Código de la venta";
            this.txtSaleSearchCode.Size = new System.Drawing.Size(145, 23);
            this.txtSaleSearchCode.TabIndex = 0;
            this.txtSaleSearchCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSaleSearchCode_KeyDown);
            // 
            // ListSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.dgvSaleList);
            this.Controls.Add(this.grpArtSearchBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "ListSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de ventas";
            this.Load += new System.EventHandler(this.ListSale_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListSale_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleList)).EndInit();
            this.grpArtSearchBy.ResumeLayout(false);
            this.grpArtSearchBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpSaleSearchDate;
        private System.Windows.Forms.DataGridView dgvSaleList;
        private System.Windows.Forms.GroupBox grpArtSearchBy;
        private System.Windows.Forms.TextBox txtSaleSearchCode;
    }
}