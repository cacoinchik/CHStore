
namespace CHStore
{
    partial class UserI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.FirmLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.RangeSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.DBView = new System.Windows.Forms.DataGridView();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.FirmList = new System.Windows.Forms.ComboBox();
            this.AddToCart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CartOpen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CountMinus = new System.Windows.Forms.Button();
            this.CountPlus = new System.Windows.Forms.Button();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.RangeBox = new System.Windows.Forms.ComboBox();
            this.rangestartposition = new System.Windows.Forms.TextBox();
            this.rangefinishposition = new System.Windows.Forms.TextBox();
            this.ChangeFilters = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TypeLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DBView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(664, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Количество товара";
            // 
            // FirmLabel
            // 
            this.FirmLabel.AutoSize = true;
            this.FirmLabel.Depth = 0;
            this.FirmLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FirmLabel.Location = new System.Drawing.Point(664, 171);
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
            this.NameLabel.Location = new System.Drawing.Point(747, 171);
            this.NameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 19);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(48, 320);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(45, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Цена";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 75);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(128, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Типы устрйоств-";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(289, 320);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(122, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Диапазон цены";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(254, 351);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(26, 19);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "От";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(254, 387);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(29, 19);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "До";
            // 
            // RangeSearch
            // 
            this.RangeSearch.AutoSize = true;
            this.RangeSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RangeSearch.Depth = 0;
            this.RangeSearch.Location = new System.Drawing.Point(314, 415);
            this.RangeSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RangeSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.RangeSearch.Name = "RangeSearch";
            this.RangeSearch.Primary = false;
            this.RangeSearch.Size = new System.Drawing.Size(59, 36);
            this.RangeSearch.TabIndex = 8;
            this.RangeSearch.Text = "Поиск";
            this.RangeSearch.UseVisualStyleBackColor = true;
            this.RangeSearch.Click += new System.EventHandler(this.RangeSearch_Click);
            // 
            // DBView
            // 
            this.DBView.AllowUserToAddRows = false;
            this.DBView.AllowUserToDeleteRows = false;
            this.DBView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBView.Location = new System.Drawing.Point(12, 97);
            this.DBView.Name = "DBView";
            this.DBView.ReadOnly = true;
            this.DBView.Size = new System.Drawing.Size(617, 198);
            this.DBView.TabIndex = 9;
            this.DBView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBView_CellClick);
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(152, 73);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(121, 21);
            this.ProductList.TabIndex = 10;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // FirmList
            // 
            this.FirmList.FormattingEnabled = true;
            this.FirmList.Location = new System.Drawing.Point(290, 73);
            this.FirmList.Name = "FirmList";
            this.FirmList.Size = new System.Drawing.Size(121, 21);
            this.FirmList.TabIndex = 11;
            this.FirmList.SelectedIndexChanged += new System.EventHandler(this.FirmList_SelectedIndexChanged);
            // 
            // AddToCart
            // 
            this.AddToCart.Depth = 0;
            this.AddToCart.Location = new System.Drawing.Point(644, 262);
            this.AddToCart.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Primary = true;
            this.AddToCart.Size = new System.Drawing.Size(193, 36);
            this.AddToCart.TabIndex = 12;
            this.AddToCart.Text = "Добавить товар в корзину";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // CartOpen
            // 
            this.CartOpen.Depth = 0;
            this.CartOpen.Location = new System.Drawing.Point(644, 431);
            this.CartOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.CartOpen.Name = "CartOpen";
            this.CartOpen.Primary = true;
            this.CartOpen.Size = new System.Drawing.Size(193, 32);
            this.CartOpen.TabIndex = 13;
            this.CartOpen.Text = "Корзина";
            this.CartOpen.UseVisualStyleBackColor = true;
            this.CartOpen.Click += new System.EventHandler(this.CartOpen_Click);
            // 
            // CountMinus
            // 
            this.CountMinus.Location = new System.Drawing.Point(644, 100);
            this.CountMinus.Name = "CountMinus";
            this.CountMinus.Size = new System.Drawing.Size(25, 25);
            this.CountMinus.TabIndex = 14;
            this.CountMinus.Text = "-";
            this.CountMinus.UseVisualStyleBackColor = true;
            this.CountMinus.Click += new System.EventHandler(this.CountMinus_Click);
            // 
            // CountPlus
            // 
            this.CountPlus.Location = new System.Drawing.Point(812, 100);
            this.CountPlus.Name = "CountPlus";
            this.CountPlus.Size = new System.Drawing.Size(25, 25);
            this.CountPlus.TabIndex = 15;
            this.CountPlus.Text = "+";
            this.CountPlus.UseVisualStyleBackColor = true;
            this.CountPlus.Click += new System.EventHandler(this.CountPlus_Click);
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(705, 103);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(64, 20);
            this.CountBox.TabIndex = 16;
            this.CountBox.Text = "1";
            this.CountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RangeBox
            // 
            this.RangeBox.FormattingEnabled = true;
            this.RangeBox.Items.AddRange(new object[] {
            "<10000",
            "10000-30000",
            "30000-50000",
            ">50000"});
            this.RangeBox.Location = new System.Drawing.Point(12, 342);
            this.RangeBox.Name = "RangeBox";
            this.RangeBox.Size = new System.Drawing.Size(121, 21);
            this.RangeBox.TabIndex = 17;
            this.RangeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // rangestartposition
            // 
            this.rangestartposition.Location = new System.Drawing.Point(297, 350);
            this.rangestartposition.Name = "rangestartposition";
            this.rangestartposition.Size = new System.Drawing.Size(100, 20);
            this.rangestartposition.TabIndex = 18;
            // 
            // rangefinishposition
            // 
            this.rangefinishposition.Location = new System.Drawing.Point(297, 386);
            this.rangefinishposition.Name = "rangefinishposition";
            this.rangefinishposition.Size = new System.Drawing.Size(100, 20);
            this.rangefinishposition.TabIndex = 19;
            // 
            // ChangeFilters
            // 
            this.ChangeFilters.Depth = 0;
            this.ChangeFilters.Location = new System.Drawing.Point(12, 415);
            this.ChangeFilters.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeFilters.Name = "ChangeFilters";
            this.ChangeFilters.Primary = true;
            this.ChangeFilters.Size = new System.Drawing.Size(156, 44);
            this.ChangeFilters.TabIndex = 20;
            this.ChangeFilters.Text = "Обновить";
            this.ChangeFilters.UseVisualStyleBackColor = true;
            this.ChangeFilters.Click += new System.EventHandler(this.ChangeFilters_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Depth = 0;
            this.TypeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TypeLabel.Location = new System.Drawing.Point(664, 137);
            this.TypeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(41, 19);
            this.TypeLabel.TabIndex = 21;
            this.TypeLabel.Text = "Type";
            // 
            // UserI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 475);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ChangeFilters);
            this.Controls.Add(this.rangefinishposition);
            this.Controls.Add(this.rangestartposition);
            this.Controls.Add(this.RangeBox);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.CountPlus);
            this.Controls.Add(this.CountMinus);
            this.Controls.Add(this.CartOpen);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.FirmList);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.DBView);
            this.Controls.Add(this.RangeSearch);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FirmLabel);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UserI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин компьютерной техники";
            this.Load += new System.EventHandler(this.UserI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel FirmLabel;
        private MaterialSkin.Controls.MaterialLabel NameLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialFlatButton RangeSearch;
        private System.Windows.Forms.DataGridView DBView;
        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.ComboBox FirmList;
        private MaterialSkin.Controls.MaterialRaisedButton AddToCart;
        private MaterialSkin.Controls.MaterialRaisedButton CartOpen;
        private System.Windows.Forms.Button CountMinus;
        private System.Windows.Forms.Button CountPlus;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.ComboBox RangeBox;
        private System.Windows.Forms.TextBox rangestartposition;
        private System.Windows.Forms.TextBox rangefinishposition;
        private MaterialSkin.Controls.MaterialRaisedButton ChangeFilters;
        private MaterialSkin.Controls.MaterialLabel TypeLabel;
    }
}

