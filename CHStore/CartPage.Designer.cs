
namespace CHStore
{
    partial class CartPage
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
            this.ViewKorzina = new System.Windows.Forms.DataGridView();
            this.FirmLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RemoveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SumLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.OrderButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CountMinus = new System.Windows.Forms.Button();
            this.CountPlus = new System.Windows.Forms.Button();
            this.BackCountBox = new System.Windows.Forms.TextBox();
            this.BackToShopButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.ViewKorzina)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewKorzina
            // 
            this.ViewKorzina.AllowUserToAddRows = false;
            this.ViewKorzina.AllowUserToDeleteRows = false;
            this.ViewKorzina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewKorzina.Location = new System.Drawing.Point(12, 78);
            this.ViewKorzina.Name = "ViewKorzina";
            this.ViewKorzina.ReadOnly = true;
            this.ViewKorzina.Size = new System.Drawing.Size(643, 306);
            this.ViewKorzina.TabIndex = 0;
            this.ViewKorzina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewKorzina_CellClick);
            // 
            // FirmLabel
            // 
            this.FirmLabel.AutoSize = true;
            this.FirmLabel.Depth = 0;
            this.FirmLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FirmLabel.Location = new System.Drawing.Point(724, 93);
            this.FirmLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FirmLabel.Name = "FirmLabel";
            this.FirmLabel.Size = new System.Drawing.Size(39, 19);
            this.FirmLabel.TabIndex = 1;
            this.FirmLabel.Text = "Firm";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Depth = 0;
            this.NameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameLabel.Location = new System.Drawing.Point(853, 93);
            this.NameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 19);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Depth = 0;
            this.RemoveButton.Location = new System.Drawing.Point(728, 191);
            this.RemoveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Primary = true;
            this.RemoveButton.Size = new System.Drawing.Size(174, 36);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Удалить товар";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(661, 333);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(168, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Сумма вашего заказа:";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Depth = 0;
            this.SumLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.SumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SumLabel.Location = new System.Drawing.Point(835, 333);
            this.SumLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(17, 19);
            this.SumLabel.TabIndex = 5;
            this.SumLabel.Text = "1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(921, 333);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(58, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "рублей";
            // 
            // OrderButton
            // 
            this.OrderButton.Depth = 0;
            this.OrderButton.Location = new System.Drawing.Point(728, 390);
            this.OrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Primary = true;
            this.OrderButton.Size = new System.Drawing.Size(174, 36);
            this.OrderButton.TabIndex = 7;
            this.OrderButton.Text = "Оформить заказ";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // CountMinus
            // 
            this.CountMinus.Location = new System.Drawing.Point(728, 141);
            this.CountMinus.Name = "CountMinus";
            this.CountMinus.Size = new System.Drawing.Size(25, 25);
            this.CountMinus.TabIndex = 8;
            this.CountMinus.Text = "-";
            this.CountMinus.UseVisualStyleBackColor = true;
            this.CountMinus.Click += new System.EventHandler(this.CountMinus_Click);
            // 
            // CountPlus
            // 
            this.CountPlus.Location = new System.Drawing.Point(877, 141);
            this.CountPlus.Name = "CountPlus";
            this.CountPlus.Size = new System.Drawing.Size(25, 25);
            this.CountPlus.TabIndex = 9;
            this.CountPlus.Text = "+";
            this.CountPlus.UseVisualStyleBackColor = true;
            this.CountPlus.Click += new System.EventHandler(this.CountPlus_Click);
            // 
            // BackCountBox
            // 
            this.BackCountBox.Location = new System.Drawing.Point(786, 144);
            this.BackCountBox.Name = "BackCountBox";
            this.BackCountBox.Size = new System.Drawing.Size(64, 20);
            this.BackCountBox.TabIndex = 10;
            this.BackCountBox.Text = "1";
            this.BackCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackToShopButton
            // 
            this.BackToShopButton.Depth = 0;
            this.BackToShopButton.Location = new System.Drawing.Point(481, 390);
            this.BackToShopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackToShopButton.Name = "BackToShopButton";
            this.BackToShopButton.Primary = true;
            this.BackToShopButton.Size = new System.Drawing.Size(174, 36);
            this.BackToShopButton.TabIndex = 12;
            this.BackToShopButton.Text = "Вернуться в магазин";
            this.BackToShopButton.UseVisualStyleBackColor = true;
            this.BackToShopButton.Click += new System.EventHandler(this.BackToShopButton_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 390);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(174, 36);
            this.materialRaisedButton1.TabIndex = 13;
            this.materialRaisedButton1.Text = "Поиск заказа";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // CartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 449);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.BackToShopButton);
            this.Controls.Add(this.BackCountBox);
            this.Controls.Add(this.CountPlus);
            this.Controls.Add(this.CountMinus);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FirmLabel);
            this.Controls.Add(this.ViewKorzina);
            this.Name = "CartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CartPage_FormClosed);
            this.Load += new System.EventHandler(this.CartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewKorzina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewKorzina;
        private MaterialSkin.Controls.MaterialLabel FirmLabel;
        private MaterialSkin.Controls.MaterialLabel NameLabel;
        private MaterialSkin.Controls.MaterialRaisedButton RemoveButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel SumLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton OrderButton;
        private System.Windows.Forms.Button CountMinus;
        private System.Windows.Forms.Button CountPlus;
        private System.Windows.Forms.TextBox BackCountBox;
        private MaterialSkin.Controls.MaterialRaisedButton BackToShopButton;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}