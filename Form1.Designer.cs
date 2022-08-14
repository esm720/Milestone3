namespace Milestone3
{
    partial class Form1
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.NameInputText = new System.Windows.Forms.TextBox();
            this.DescriptionInputText = new System.Windows.Forms.TextBox();
            this.PriceInputText = new System.Windows.Forms.TextBox();
            this.QuantityInputText = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NewItemBox = new System.Windows.Forms.GroupBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ItemsShopBox = new System.Windows.Forms.GroupBox();
            this.ShopInventoryLabel = new System.Windows.Forms.Label();
            this.RestockButton = new System.Windows.Forms.Button();
            this.StoreInvButton = new System.Windows.Forms.Button();
            this.NewItemBox.SuspendLayout();
            this.ItemsShopBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(314, 281);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(159, 65);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NameInputText
            // 
            this.NameInputText.Location = new System.Drawing.Point(163, 41);
            this.NameInputText.Multiline = true;
            this.NameInputText.Name = "NameInputText";
            this.NameInputText.Size = new System.Drawing.Size(310, 41);
            this.NameInputText.TabIndex = 1;
            // 
            // DescriptionInputText
            // 
            this.DescriptionInputText.Location = new System.Drawing.Point(163, 100);
            this.DescriptionInputText.Multiline = true;
            this.DescriptionInputText.Name = "DescriptionInputText";
            this.DescriptionInputText.Size = new System.Drawing.Size(310, 41);
            this.DescriptionInputText.TabIndex = 2;
            // 
            // PriceInputText
            // 
            this.PriceInputText.Location = new System.Drawing.Point(163, 165);
            this.PriceInputText.Multiline = true;
            this.PriceInputText.Name = "PriceInputText";
            this.PriceInputText.Size = new System.Drawing.Size(310, 41);
            this.PriceInputText.TabIndex = 3;
            // 
            // QuantityInputText
            // 
            this.QuantityInputText.Location = new System.Drawing.Point(163, 234);
            this.QuantityInputText.Multiline = true;
            this.QuantityInputText.Name = "QuantityInputText";
            this.QuantityInputText.Size = new System.Drawing.Size(310, 41);
            this.QuantityInputText.TabIndex = 4;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(163, 281);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(145, 65);
            this.AddItemButton.TabIndex = 5;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(70, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 45);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 100);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(160, 45);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NewItemBox
            // 
            this.NewItemBox.Controls.Add(this.DisplayButton);
            this.NewItemBox.Controls.Add(this.RemoveButton);
            this.NewItemBox.Controls.Add(this.QuantityLabel);
            this.NewItemBox.Controls.Add(this.PriceLabel);
            this.NewItemBox.Controls.Add(this.NameLabel);
            this.NewItemBox.Controls.Add(this.AddItemButton);
            this.NewItemBox.Controls.Add(this.DescriptionLabel);
            this.NewItemBox.Controls.Add(this.ExitButton);
            this.NewItemBox.Controls.Add(this.QuantityInputText);
            this.NewItemBox.Controls.Add(this.NameInputText);
            this.NewItemBox.Controls.Add(this.PriceInputText);
            this.NewItemBox.Controls.Add(this.DescriptionInputText);
            this.NewItemBox.Location = new System.Drawing.Point(34, 27);
            this.NewItemBox.Name = "NewItemBox";
            this.NewItemBox.Size = new System.Drawing.Size(558, 482);
            this.NewItemBox.TabIndex = 8;
            this.NewItemBox.TabStop = false;
            this.NewItemBox.Text = "Add New Item";
            // 
            // PriceLabel
            // 
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(-3, 165);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(160, 45);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Price:";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(-6, 230);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(160, 45);
            this.QuantityLabel.TabIndex = 9;
            this.QuantityLabel.Text = "Quantity:";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(163, 352);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(145, 65);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(314, 352);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(159, 65);
            this.DisplayButton.TabIndex = 9;
            this.DisplayButton.Text = "Display Inventory";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ItemsShopBox
            // 
            this.ItemsShopBox.Controls.Add(this.StoreInvButton);
            this.ItemsShopBox.Controls.Add(this.RestockButton);
            this.ItemsShopBox.Controls.Add(this.ShopInventoryLabel);
            this.ItemsShopBox.Location = new System.Drawing.Point(608, 27);
            this.ItemsShopBox.Name = "ItemsShopBox";
            this.ItemsShopBox.Size = new System.Drawing.Size(455, 482);
            this.ItemsShopBox.TabIndex = 9;
            this.ItemsShopBox.TabStop = false;
            this.ItemsShopBox.Text = "Items Shop";
            // 
            // ShopInventoryLabel
            // 
            this.ShopInventoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShopInventoryLabel.Location = new System.Drawing.Point(20, 46);
            this.ShopInventoryLabel.Name = "ShopInventoryLabel";
            this.ShopInventoryLabel.Size = new System.Drawing.Size(395, 229);
            this.ShopInventoryLabel.TabIndex = 10;
            // 
            // RestockButton
            // 
            this.RestockButton.Location = new System.Drawing.Point(236, 309);
            this.RestockButton.Name = "RestockButton";
            this.RestockButton.Size = new System.Drawing.Size(179, 94);
            this.RestockButton.TabIndex = 10;
            this.RestockButton.Text = "Restock";
            this.RestockButton.UseVisualStyleBackColor = true;
            this.RestockButton.Click += new System.EventHandler(this.RestockButton_Click);
            // 
            // StoreInvButton
            // 
            this.StoreInvButton.Location = new System.Drawing.Point(31, 309);
            this.StoreInvButton.Name = "StoreInvButton";
            this.StoreInvButton.Size = new System.Drawing.Size(170, 94);
            this.StoreInvButton.TabIndex = 10;
            this.StoreInvButton.Text = "Show Store Inventory";
            this.StoreInvButton.UseVisualStyleBackColor = true;
            this.StoreInvButton.Click += new System.EventHandler(this.StoreInvButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 706);
            this.Controls.Add(this.ItemsShopBox);
            this.Controls.Add(this.NewItemBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NewItemBox.ResumeLayout(false);
            this.NewItemBox.PerformLayout();
            this.ItemsShopBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox NameInputText;
        private System.Windows.Forms.TextBox DescriptionInputText;
        private System.Windows.Forms.TextBox PriceInputText;
        private System.Windows.Forms.TextBox QuantityInputText;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.GroupBox NewItemBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.GroupBox ItemsShopBox;
        private System.Windows.Forms.Button RestockButton;
        private System.Windows.Forms.Label ShopInventoryLabel;
        private System.Windows.Forms.Button StoreInvButton;
    }
}

