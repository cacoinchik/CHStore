using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace CHStore
{
    public partial class CartPage : MaterialForm
    {
        string ConnStr;
        SqlConnection connection;
        SqlCommand cmdk;
        SqlDataAdapter adapterk;
        DataTable Korzina;
        public CartPage()
        {
            InitializeComponent();
            //активация дизайна
            DesignActive();
        }
        private void CartPage_Load(object sender, EventArgs e)
        {
            //Подключение к БД
            ConnStr = @"Data Source=(localdb)\MSSQLLocalDB;" + "Initial Catalog = MyStore;" + "Integrated Security = True";
            connection = new SqlConnection(ConnStr);
            connection.Open();
            //Вывод таблицы Корзины
            string korzina = "SELECT * FROM Korzina";
            cmdk = new SqlCommand(korzina, connection);
            adapterk = new SqlDataAdapter(cmdk);
            Korzina = new DataTable();
            adapterk.Fill(Korzina);
            ViewKorzina.DataSource = Korzina;
            //Вывод суммы заказа
            SumLabel.Text = Sum().ToString();
        }
        #region Methods
        //Вычисление суммы товаров в корзине
        public decimal Sum()
        {
            decimal Price, Sum = 0;
            int Count;

            foreach (DataRow row in Korzina.Rows)
            {
                Price = Convert.ToDecimal(row["Price"]);
                Count = Convert.ToInt32(row["Count"]);
                Sum = Sum + Price * Count;
            }
            return Sum;
        }
        //Стили дизайна
        private void DesignActive()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple700, Primary.DeepPurple800, Primary.DeepPurple800, Accent.DeepOrange700, TextShade.WHITE);
        }
        
        //Вывод информации о выбранном товаре
        private void ViewKorzina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ViewKorzina.CurrentRow;
            string InfoName, InfoFirm;
            InfoFirm = row.Cells["Firm"].Value.ToString();
            InfoName = row.Cells["Name"].Value.ToString();
            FirmLabel.Text = InfoFirm;
            NameLabel.Text = InfoName;
            BackCountBox.Text = 1.ToString();
        }
        //Увеличить кол-ва
        private void CountPlus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(BackCountBox.Text);
            count++;
            BackCountBox.Text = count.ToString();
        }
        //Уменьшить кол-во
        private void CountMinus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(BackCountBox.Text);
            if (count <= 1)
            {
                MessageBox.Show("Нельзя удалить товара меньше чем 1");
                count = 1;
            }
            else
                count--;
            BackCountBox.Text = count.ToString();
        }
        #endregion
        #region DeleteProduct
        //Кнопка удлаить товар из корзины
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Korzina.Rows.Count == 0)
            {
                MessageBox.Show("Ваша корзина пуста");
            }
            else
            {
                DataGridViewRow row = ViewKorzina.CurrentRow;
                string Cartid = row.Cells["CartId"].Value.ToString();
                int id = (int)row.Cells["Id"].Value;
                int countnow = (int)row.Cells["Count"].Value;
                int checkcount = int.Parse(BackCountBox.Text);
                if (checkcount > countnow)
                {
                    MessageBox.Show("У вас нет такого количества товара в корзине");
                }
                else if (checkcount == countnow)
                {
                    BackCount(id, checkcount);
                    string deltovar = "DELETE FROM Korzina WHERE CartId= " + Cartid;
                    SqlCommand delcmd = new SqlCommand(deltovar, connection);
                    delcmd.ExecuteNonQuery();
                    Korzina.Clear();
                    adapterk.Fill(Korzina);
                    SumLabel.Text = Sum().ToString();
                }
                else if (checkcount < countnow)
                {
                    int newcount = UpdateCount(checkcount, Cartid);
                    string update = String.Format("UPDATE Korzina SET Count={0} WHERE CartId={1}", newcount, Cartid);
                    SqlCommand updatecmd = new SqlCommand(update, connection);
                    updatecmd.ExecuteNonQuery();
                    Korzina.Clear();
                    adapterk.Fill(Korzina);
                    BackCount(id, checkcount);

                }
            }
        }
        //Метод для возвращения количества товара если он был удалени из корзины
        private void BackCount(int id,int backcount)
        {
            int newcount;
            string cmd, update;
            SqlCommand command, updatecmd;
            cmd = String.Format("SELECT Count FROM Products WHERE Id={0}", id);
            command = new SqlCommand(cmd, connection);
            newcount = PutResult(command, backcount);
            update = String.Format("UPDATE Products SET Count={0} WHERE Id={1}", newcount, id);
            updatecmd = new SqlCommand(update, connection);
            updatecmd.ExecuteNonQuery();
        }
        private int PutResult(SqlCommand cmd,int backcount)
        {
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = int.Parse(reader.GetValue(0).ToString());
            reader.Close();
            int newcount = count + backcount;
            return newcount;
        }
        private int UpdateCount(int choicecount,string cartid)
        {
            string readcount = String.Format("SELECT Count FROM Korzina WHERE CartId={0}",cartid);
            SqlCommand countcmd = new SqlCommand(readcount, connection);
            SqlDataReader reader = countcmd.ExecuteReader();
            reader.Read();
            int countnow = int.Parse(reader.GetValue(0).ToString());
            reader.Close();
            int newcount = countnow - choicecount;
            return newcount;
        }
        #endregion
        #region Windows
        //Возвращение в магазин
        private void BackToShopButton_Click(object sender, EventArgs e)
        {
            var ui = Application.OpenForms[0];
            ui.Show();
            Close();
        }
        //Возвращение в магазин
        private void CartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            var ui = Application.OpenForms[0];
            ui.Show();
        }
        //Переход к оформлению заказа
        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (Korzina.Rows.Count==0)
            {
                MessageBox.Show("Ваша корзина пуста");
            }
            else 
            {
                var op = new OrderPage();
                op.sum = Sum();
                op.Show();
                this.Hide();
            }
        }
        //Переход к странице поиска заказов

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var sop = new SearchOrderPage();
            sop.Show();
            this.Hide();
        }

        #endregion

    }
}
