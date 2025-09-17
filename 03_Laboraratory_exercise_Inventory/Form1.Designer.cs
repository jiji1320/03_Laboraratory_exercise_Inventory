namespace _03_Laboraratory_exercise_Inventory
{
    partial class frmAddProduct
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
            this._ProductName = new System.Windows.Forms.Label();
            this._Category = new System.Windows.Forms.Label();
            this._MfgDate = new System.Windows.Forms.Label();
            this._ExpDate = new System.Windows.Forms.Label();
            this._Quantity = new System.Windows.Forms.Label();
            this._SellPrice = new System.Windows.Forms.Label();
            this._Description = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtPickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.gridViewProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // _ProductName
            // 
            this._ProductName.AutoSize = true;
            this._ProductName.Location = new System.Drawing.Point(59, 119);
            this._ProductName.Name = "_ProductName";
            this._ProductName.Size = new System.Drawing.Size(44, 13);
            this._ProductName.TabIndex = 1;
            this._ProductName.Text = "Product";
            // 
            // _Category
            // 
            this._Category.AutoSize = true;
            this._Category.Location = new System.Drawing.Point(59, 158);
            this._Category.Name = "_Category";
            this._Category.Size = new System.Drawing.Size(49, 13);
            this._Category.TabIndex = 2;
            this._Category.Text = "Category";
            // 
            // _MfgDate
            // 
            this._MfgDate.AutoSize = true;
            this._MfgDate.Location = new System.Drawing.Point(59, 203);
            this._MfgDate.Name = "_MfgDate";
            this._MfgDate.Size = new System.Drawing.Size(54, 13);
            this._MfgDate.TabIndex = 3;
            this._MfgDate.Text = "Mfg. Date";
            // 
            // _ExpDate
            // 
            this._ExpDate.AutoSize = true;
            this._ExpDate.Location = new System.Drawing.Point(59, 241);
            this._ExpDate.Name = "_ExpDate";
            this._ExpDate.Size = new System.Drawing.Size(54, 13);
            this._ExpDate.TabIndex = 4;
            this._ExpDate.Text = "Exp. Date";
            // 
            // _Quantity
            // 
            this._Quantity.AutoSize = true;
            this._Quantity.Location = new System.Drawing.Point(59, 278);
            this._Quantity.Name = "_Quantity";
            this._Quantity.Size = new System.Drawing.Size(23, 13);
            this._Quantity.TabIndex = 5;
            this._Quantity.Text = "Qty";
            // 
            // _SellPrice
            // 
            this._SellPrice.AutoSize = true;
            this._SellPrice.Location = new System.Drawing.Point(59, 309);
            this._SellPrice.Name = "_SellPrice";
            this._SellPrice.Size = new System.Drawing.Size(51, 13);
            this._SellPrice.TabIndex = 6;
            this._SellPrice.Text = "Sell Price";
            // 
            // _Description
            // 
            this._Description.AutoSize = true;
            this._Description.Location = new System.Drawing.Point(408, 119);
            this._Description.Name = "_Description";
            this._Description.Size = new System.Drawing.Size(60, 13);
            this._Description.TabIndex = 7;
            this._Description.Text = "Description";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(588, 309);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(79, 25);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(121, 275);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(134, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(121, 116);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(134, 20);
            this.txtProductName.TabIndex = 10;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(121, 306);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(134, 20);
            this.txtSellPrice.TabIndex = 11;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(121, 155);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(134, 21);
            this.cbCategory.TabIndex = 12;
            // 
            // dtPickerMfgDate
            // 
            this.dtPickerMfgDate.Location = new System.Drawing.Point(121, 203);
            this.dtPickerMfgDate.Name = "dtPickerMfgDate";
            this.dtPickerMfgDate.Size = new System.Drawing.Size(134, 20);
            this.dtPickerMfgDate.TabIndex = 13;
            // 
            // dtPickerExpDate
            // 
            this.dtPickerExpDate.Location = new System.Drawing.Point(121, 241);
            this.dtPickerExpDate.Name = "dtPickerExpDate";
            this.dtPickerExpDate.Size = new System.Drawing.Size(134, 20);
            this.dtPickerExpDate.TabIndex = 14;
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.Location = new System.Drawing.Point(409, 149);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(264, 157);
            this.richTxtDescription.TabIndex = 15;
            this.richTxtDescription.Text = "";
            // 
            // gridViewProductList
            // 
            this.gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProductList.Location = new System.Drawing.Point(25, 340);
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.Size = new System.Drawing.Size(642, 104);
            this.gridViewProductList.TabIndex = 16;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.gridViewProductList);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.dtPickerExpDate);
            this.Controls.Add(this.dtPickerMfgDate);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this._Description);
            this.Controls.Add(this._SellPrice);
            this.Controls.Add(this._Quantity);
            this.Controls.Add(this._ExpDate);
            this.Controls.Add(this._MfgDate);
            this.Controls.Add(this._Category);
            this.Controls.Add(this._ProductName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddProduct";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _ProductName;
        private System.Windows.Forms.Label _Category;
        private System.Windows.Forms.Label _MfgDate;
        private System.Windows.Forms.Label _ExpDate;
        private System.Windows.Forms.Label _Quantity;
        private System.Windows.Forms.Label _SellPrice;
        private System.Windows.Forms.Label _Description;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DateTimePicker dtPickerMfgDate;
        private System.Windows.Forms.DateTimePicker dtPickerExpDate;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.DataGridView gridViewProductList;
    }
}

