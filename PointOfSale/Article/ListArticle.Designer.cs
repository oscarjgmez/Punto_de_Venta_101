
namespace PointOfSale.Article
{
    partial class ListArticle
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
            this.grpArtSearchBy = new System.Windows.Forms.GroupBox();
            this.cmbArtSub = new System.Windows.Forms.ComboBox();
            this.cmbArtCat = new System.Windows.Forms.ComboBox();
            this.cmbArtFam = new System.Windows.Forms.ComboBox();
            this.txtArtSearchBarCode = new System.Windows.Forms.TextBox();
            this.dgvArtProducts = new System.Windows.Forms.DataGridView();
            this.btnArtAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpArtSearchBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grpArtSearchBy
            // 
            this.grpArtSearchBy.Controls.Add(this.label4);
            this.grpArtSearchBy.Controls.Add(this.label3);
            this.grpArtSearchBy.Controls.Add(this.label2);
            this.grpArtSearchBy.Controls.Add(this.label1);
            this.grpArtSearchBy.Controls.Add(this.cmbArtSub);
            this.grpArtSearchBy.Controls.Add(this.cmbArtCat);
            this.grpArtSearchBy.Controls.Add(this.cmbArtFam);
            this.grpArtSearchBy.Controls.Add(this.txtArtSearchBarCode);
            this.grpArtSearchBy.Location = new System.Drawing.Point(12, 12);
            this.grpArtSearchBy.Name = "grpArtSearchBy";
            this.grpArtSearchBy.Size = new System.Drawing.Size(703, 96);
            this.grpArtSearchBy.TabIndex = 0;
            this.grpArtSearchBy.TabStop = false;
            this.grpArtSearchBy.Text = "Buscar por:";
            // 
            // cmbArtSub
            // 
            this.cmbArtSub.FormattingEnabled = true;
            this.cmbArtSub.Location = new System.Drawing.Point(502, 59);
            this.cmbArtSub.Name = "cmbArtSub";
            this.cmbArtSub.Size = new System.Drawing.Size(185, 23);
            this.cmbArtSub.TabIndex = 3;
            this.cmbArtSub.SelectedIndexChanged += new System.EventHandler(this.cmbArt_SelectedIndexChanged);
            // 
            // cmbArtCat
            // 
            this.cmbArtCat.FormattingEnabled = true;
            this.cmbArtCat.Location = new System.Drawing.Point(119, 54);
            this.cmbArtCat.Name = "cmbArtCat";
            this.cmbArtCat.Size = new System.Drawing.Size(274, 23);
            this.cmbArtCat.TabIndex = 2;
            this.cmbArtCat.SelectedIndexChanged += new System.EventHandler(this.cmbArt_SelectedIndexChanged);
            // 
            // cmbArtFam
            // 
            this.cmbArtFam.FormattingEnabled = true;
            this.cmbArtFam.Location = new System.Drawing.Point(496, 22);
            this.cmbArtFam.Name = "cmbArtFam";
            this.cmbArtFam.Size = new System.Drawing.Size(191, 23);
            this.cmbArtFam.TabIndex = 1;
            this.cmbArtFam.SelectedIndexChanged += new System.EventHandler(this.cmbArt_SelectedIndexChanged);
            // 
            // txtArtSearchBarCode
            // 
            this.txtArtSearchBarCode.Location = new System.Drawing.Point(119, 22);
            this.txtArtSearchBarCode.Name = "txtArtSearchBarCode";
            this.txtArtSearchBarCode.PlaceholderText = "Teclee un código de barras";
            this.txtArtSearchBarCode.Size = new System.Drawing.Size(266, 23);
            this.txtArtSearchBarCode.TabIndex = 0;
            this.txtArtSearchBarCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtArtSearchBarCode_KeyUp);
            // 
            // dgvArtProducts
            // 
            this.dgvArtProducts.AllowUserToAddRows = false;
            this.dgvArtProducts.AllowUserToDeleteRows = false;
            this.dgvArtProducts.AllowUserToResizeColumns = false;
            this.dgvArtProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvArtProducts.Location = new System.Drawing.Point(12, 114);
            this.dgvArtProducts.Name = "dgvArtProducts";
            this.dgvArtProducts.ReadOnly = true;
            this.dgvArtProducts.RowTemplate.Height = 25;
            this.dgvArtProducts.ShowCellErrors = false;
            this.dgvArtProducts.ShowCellToolTips = false;
            this.dgvArtProducts.ShowEditingIcon = false;
            this.dgvArtProducts.ShowRowErrors = false;
            this.dgvArtProducts.Size = new System.Drawing.Size(703, 331);
            this.dgvArtProducts.TabIndex = 1;
            this.dgvArtProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtProducts_CellDoubleClick);
            // 
            // btnArtAddProduct
            // 
            this.btnArtAddProduct.Location = new System.Drawing.Point(512, 451);
            this.btnArtAddProduct.Name = "btnArtAddProduct";
            this.btnArtAddProduct.Size = new System.Drawing.Size(203, 23);
            this.btnArtAddProduct.TabIndex = 2;
            this.btnArtAddProduct.Text = "Agregar un producto [F5]";
            this.btnArtAddProduct.UseVisualStyleBackColor = true;
            this.btnArtAddProduct.Click += new System.EventHandler(this.btnArtAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Familia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subcategoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Código de barras:";
            // 
            // ListArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 483);
            this.Controls.Add(this.btnArtAddProduct);
            this.Controls.Add(this.dgvArtProducts);
            this.Controls.Add(this.grpArtSearchBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListArticle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de productos";
            this.Load += new System.EventHandler(this.ListArticle_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListArticle_KeyDown);
            this.grpArtSearchBy.ResumeLayout(false);
            this.grpArtSearchBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpArtSearchBy;
        private System.Windows.Forms.ComboBox cmbArtSub;
        private System.Windows.Forms.ComboBox cmbArtCat;
        private System.Windows.Forms.ComboBox cmbArtFam;
        private System.Windows.Forms.TextBox txtArtSearchBarCode;
        public System.Windows.Forms.DataGridView dgvArtProducts;
        private System.Windows.Forms.Button btnArtAddProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}