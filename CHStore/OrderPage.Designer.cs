
namespace CHStore
{
    partial class OrderPage
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.PayButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurenameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.RefusalButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(148, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Ваше имя*";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(148, 160);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(115, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Ваша фамилия";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(148, 240);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(135, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Номер телефона*";
            // 
            // PayButton
            // 
            this.PayButton.Depth = 0;
            this.PayButton.Location = new System.Drawing.Point(12, 454);
            this.PayButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PayButton.Name = "PayButton";
            this.PayButton.Primary = true;
            this.PayButton.Size = new System.Drawing.Size(104, 34);
            this.PayButton.TabIndex = 3;
            this.PayButton.Text = "Оплатить";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(152, 120);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(143, 20);
            this.NameBox.TabIndex = 4;
            // 
            // SurenameBox
            // 
            this.SurenameBox.Location = new System.Drawing.Point(152, 200);
            this.SurenameBox.Name = "SurenameBox";
            this.SurenameBox.Size = new System.Drawing.Size(143, 20);
            this.SurenameBox.TabIndex = 5;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(152, 280);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(143, 20);
            this.PhoneBox.TabIndex = 6;
            // 
            // RefusalButton
            // 
            this.RefusalButton.Depth = 0;
            this.RefusalButton.Location = new System.Drawing.Point(284, 454);
            this.RefusalButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RefusalButton.Name = "RefusalButton";
            this.RefusalButton.Primary = true;
            this.RefusalButton.Size = new System.Drawing.Size(104, 34);
            this.RefusalButton.TabIndex = 7;
            this.RefusalButton.Text = "Отказаться от покупки";
            this.RefusalButton.UseVisualStyleBackColor = true;
            this.RefusalButton.Click += new System.EventHandler(this.RefusalButton_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(13, 340);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(280, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "*-поля обязательные для заполнения";
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.RefusalButton);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.SurenameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "OrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderPage_FormClosed);
            this.Load += new System.EventHandler(this.OrderPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton PayButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurenameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private MaterialSkin.Controls.MaterialRaisedButton RefusalButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}