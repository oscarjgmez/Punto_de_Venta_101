
namespace PointOfSale.Sale
{
    partial class ListCutSale
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
            this.dgvCutSaleList = new System.Windows.Forms.DataGridView();
            this.dtpSaleSearchDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCutSaleList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCutSaleList
            // 
            this.dgvCutSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCutSaleList.Location = new System.Drawing.Point(12, 41);
            this.dgvCutSaleList.Name = "dgvCutSaleList";
            this.dgvCutSaleList.RowTemplate.Height = 25;
            this.dgvCutSaleList.Size = new System.Drawing.Size(304, 397);
            this.dgvCutSaleList.TabIndex = 0;
            // 
            // dtpSaleSearchDate
            // 
            this.dtpSaleSearchDate.Location = new System.Drawing.Point(117, 6);
            this.dtpSaleSearchDate.Name = "dtpSaleSearchDate";
            this.dtpSaleSearchDate.Size = new System.Drawing.Size(200, 23);
            this.dtpSaleSearchDate.TabIndex = 2;
            this.dtpSaleSearchDate.CloseUp += new System.EventHandler(this.dtpSaleSearchDate_CloseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por fecha:";
            // 
            // ListCutSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSaleSearchDate);
            this.Controls.Add(this.dgvCutSaleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ListCutSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas de cortes";
            this.Load += new System.EventHandler(this.ListCutSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCutSaleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCutSaleList;
        private System.Windows.Forms.DateTimePicker dtpSaleSearchDate;
        private System.Windows.Forms.Label label1;
    }
}