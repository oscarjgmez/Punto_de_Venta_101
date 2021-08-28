
namespace PointOfSale.Article
{
    partial class AddEditArticle
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
            this.txtArtAddBarCode = new System.Windows.Forms.TextBox();
            this.lblArtAddQuantity = new System.Windows.Forms.Label();
            this.lblArtAddBrand = new System.Windows.Forms.Label();
            this.lblArtAddPrice = new System.Windows.Forms.Label();
            this.lblArtAddNameProduct = new System.Windows.Forms.Label();
            this.txtArtAddNameProduct = new System.Windows.Forms.TextBox();
            this.txtArtAddPrice = new System.Windows.Forms.TextBox();
            this.txtArtAddBrand = new System.Windows.Forms.TextBox();
            this.txtArtAddQuantity = new System.Windows.Forms.TextBox();
            this.btnArtAddAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArtAddFamily = new System.Windows.Forms.TextBox();
            this.txtArtAddCategory = new System.Windows.Forms.TextBox();
            this.txtArtAddSubcat = new System.Windows.Forms.TextBox();
            this.chkArtAddActive = new System.Windows.Forms.CheckBox();
            this.lblArrAddCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArtAddBarCode
            // 
            this.txtArtAddBarCode.Location = new System.Drawing.Point(12, 33);
            this.txtArtAddBarCode.Name = "txtArtAddBarCode";
            this.txtArtAddBarCode.Size = new System.Drawing.Size(383, 23);
            this.txtArtAddBarCode.TabIndex = 1;
            this.txtArtAddBarCode.TextChanged += new System.EventHandler(this.txtArtAddBarCode_TextChanged);
            // 
            // lblArtAddQuantity
            // 
            this.lblArtAddQuantity.AutoSize = true;
            this.lblArtAddQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtAddQuantity.Location = new System.Drawing.Point(206, 164);
            this.lblArtAddQuantity.Name = "lblArtAddQuantity";
            this.lblArtAddQuantity.Size = new System.Drawing.Size(189, 21);
            this.lblArtAddQuantity.TabIndex = 4;
            this.lblArtAddQuantity.Text = "Cantidad en inventario:";
            // 
            // lblArtAddBrand
            // 
            this.lblArtAddBrand.AutoSize = true;
            this.lblArtAddBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtAddBrand.Location = new System.Drawing.Point(12, 109);
            this.lblArtAddBrand.Name = "lblArtAddBrand";
            this.lblArtAddBrand.Size = new System.Drawing.Size(61, 21);
            this.lblArtAddBrand.TabIndex = 5;
            this.lblArtAddBrand.Text = "Marca:";
            // 
            // lblArtAddPrice
            // 
            this.lblArtAddPrice.AutoSize = true;
            this.lblArtAddPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtAddPrice.Location = new System.Drawing.Point(12, 164);
            this.lblArtAddPrice.Name = "lblArtAddPrice";
            this.lblArtAddPrice.Size = new System.Drawing.Size(148, 21);
            this.lblArtAddPrice.TabIndex = 6;
            this.lblArtAddPrice.Text = "Costo del artículo:";
            // 
            // lblArtAddNameProduct
            // 
            this.lblArtAddNameProduct.AutoSize = true;
            this.lblArtAddNameProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtAddNameProduct.Location = new System.Drawing.Point(12, 59);
            this.lblArtAddNameProduct.Name = "lblArtAddNameProduct";
            this.lblArtAddNameProduct.Size = new System.Drawing.Size(179, 21);
            this.lblArtAddNameProduct.TabIndex = 7;
            this.lblArtAddNameProduct.Text = "Nombre del producto:";
            // 
            // txtArtAddNameProduct
            // 
            this.txtArtAddNameProduct.Location = new System.Drawing.Point(12, 83);
            this.txtArtAddNameProduct.Name = "txtArtAddNameProduct";
            this.txtArtAddNameProduct.Size = new System.Drawing.Size(383, 23);
            this.txtArtAddNameProduct.TabIndex = 2;
            // 
            // txtArtAddPrice
            // 
            this.txtArtAddPrice.Location = new System.Drawing.Point(12, 196);
            this.txtArtAddPrice.Name = "txtArtAddPrice";
            this.txtArtAddPrice.Size = new System.Drawing.Size(242, 23);
            this.txtArtAddPrice.TabIndex = 4;
            this.txtArtAddPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtArtAddBrand
            // 
            this.txtArtAddBrand.Location = new System.Drawing.Point(12, 138);
            this.txtArtAddBrand.Name = "txtArtAddBrand";
            this.txtArtAddBrand.Size = new System.Drawing.Size(383, 23);
            this.txtArtAddBrand.TabIndex = 3;
            // 
            // txtArtAddQuantity
            // 
            this.txtArtAddQuantity.Location = new System.Drawing.Point(260, 196);
            this.txtArtAddQuantity.Name = "txtArtAddQuantity";
            this.txtArtAddQuantity.Size = new System.Drawing.Size(135, 23);
            this.txtArtAddQuantity.TabIndex = 5;
            this.txtArtAddQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // btnArtAddAccept
            // 
            this.btnArtAddAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnArtAddAccept.Location = new System.Drawing.Point(12, 352);
            this.btnArtAddAccept.Name = "btnArtAddAccept";
            this.btnArtAddAccept.Size = new System.Drawing.Size(383, 23);
            this.btnArtAddAccept.TabIndex = 10;
            this.btnArtAddAccept.Text = "Agregar / Editar el producto [F6]";
            this.btnArtAddAccept.UseVisualStyleBackColor = true;
            this.btnArtAddAccept.Click += new System.EventHandler(this.btnArtAddAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Familia del producto: (Opcional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(196, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categoria del producto: (Opcional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subcategoria: (Opcional)";
            // 
            // txtArtAddFamily
            // 
            this.txtArtAddFamily.Location = new System.Drawing.Point(12, 261);
            this.txtArtAddFamily.Name = "txtArtAddFamily";
            this.txtArtAddFamily.Size = new System.Drawing.Size(179, 23);
            this.txtArtAddFamily.TabIndex = 6;
            // 
            // txtArtAddCategory
            // 
            this.txtArtAddCategory.Location = new System.Drawing.Point(197, 261);
            this.txtArtAddCategory.Name = "txtArtAddCategory";
            this.txtArtAddCategory.Size = new System.Drawing.Size(198, 23);
            this.txtArtAddCategory.TabIndex = 7;
            // 
            // txtArtAddSubcat
            // 
            this.txtArtAddSubcat.Location = new System.Drawing.Point(12, 305);
            this.txtArtAddSubcat.Name = "txtArtAddSubcat";
            this.txtArtAddSubcat.Size = new System.Drawing.Size(383, 23);
            this.txtArtAddSubcat.TabIndex = 8;
            // 
            // chkArtAddActive
            // 
            this.chkArtAddActive.AutoSize = true;
            this.chkArtAddActive.Location = new System.Drawing.Point(189, 13);
            this.chkArtAddActive.Name = "chkArtAddActive";
            this.chkArtAddActive.Size = new System.Drawing.Size(60, 19);
            this.chkArtAddActive.TabIndex = 0;
            this.chkArtAddActive.Text = "Activo";
            this.chkArtAddActive.UseVisualStyleBackColor = true;
            // 
            // lblArrAddCode
            // 
            this.lblArrAddCode.AutoSize = true;
            this.lblArrAddCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArrAddCode.Location = new System.Drawing.Point(12, 9);
            this.lblArrAddCode.Name = "lblArrAddCode";
            this.lblArrAddCode.Size = new System.Drawing.Size(171, 21);
            this.lblArrAddCode.TabIndex = 7;
            this.lblArrAddCode.Text = "Código del producto:";
            // 
            // AddEditArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 387);
            this.Controls.Add(this.chkArtAddActive);
            this.Controls.Add(this.btnArtAddAccept);
            this.Controls.Add(this.txtArtAddQuantity);
            this.Controls.Add(this.txtArtAddSubcat);
            this.Controls.Add(this.txtArtAddBrand);
            this.Controls.Add(this.txtArtAddCategory);
            this.Controls.Add(this.txtArtAddPrice);
            this.Controls.Add(this.txtArtAddFamily);
            this.Controls.Add(this.txtArtAddNameProduct);
            this.Controls.Add(this.txtArtAddBarCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArtAddQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArtAddBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArtAddPrice);
            this.Controls.Add(this.lblArrAddCode);
            this.Controls.Add(this.lblArtAddNameProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "AddEditArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar / Editar un artículo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddEditArticle_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtArtAddBarCode;
        private System.Windows.Forms.Label lblArtAddQuantity;
        private System.Windows.Forms.Label lblArtAddBrand;
        private System.Windows.Forms.Label lblArtAddPrice;
        private System.Windows.Forms.Label lblArtAddNameProduct;
        private System.Windows.Forms.TextBox txtArtAddNameProduct;
        private System.Windows.Forms.TextBox txtArtAddPrice;
        private System.Windows.Forms.TextBox txtArtAddBrand;
        private System.Windows.Forms.TextBox txtArtAddQuantity;
        private System.Windows.Forms.Button btnArtAddAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArtAddFamily;
        private System.Windows.Forms.TextBox txtArtAddCategory;
        private System.Windows.Forms.TextBox txtArtAddSubcat;
        private System.Windows.Forms.CheckBox chkArtAddActive;
        private System.Windows.Forms.Label lblArrAddCode;
    }
}