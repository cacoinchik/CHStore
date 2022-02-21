using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace CHStore
{
    public partial class UserI : MaterialForm
    {
        string connstr,korzina,tovars,firms,products,TovarId,FirmId;
        SqlConnection connection;
        SqlCommand commandP,commandF,commandT,commandK;
        SqlDataAdapter adapterP,adapterF, adapterT,adapterK;
        DataTable Products,Tovars, Firms,Korzina;
        DataRow[] row;
        public UserI()
        {
            InitializeComponent();
            //активация дизайна
            DesignActive();
        }
        private void UserI_Load(object sender, EventArgs e)
        {
            //Подключение к БД
            connstr = @"Data Source=(localdb)\MSSQLLocalDB;" + "Initial Catalog = MyStore;" + "Integrated Security = True";
            connection = new SqlConnection(connstr);
            connection.Open();
            //Подключение к таблице товары
            ConnectToTovars();
            //Подключение к таблице фирмы
            ConnectToFirms();
            //Подключение к таблице продуктов
            ConnectToProducts();
            //Подключение к таблице корзина
            ConnectToKorzina();
            //Заполнение combobox типами товаров
            AddBoxContent();
        }
        #region Connects
        //Подключение к таблице товары
        private void ConnectToTovars()
        {
            tovars = "SELECT * FROM Tovars";
            commandT = new SqlCommand(tovars, connection);
            adapterT = new SqlDataAdapter(commandT);
            Tovars = new DataTable();
            adapterT.Fill(Tovars);
        }
        //Подключение к таблице фирмы
        private void ConnectToFirms()
        {
            firms = "SELECT * FROM Firms";
            commandF = new SqlCommand(firms, connection);
            adapterF = new SqlDataAdapter(commandF);
            Firms = new DataTable();
            adapterF.Fill(Firms);
        }
        //Подключение к таблице продуктов
        private void ConnectToProducts()
        {
            products = "SELECT *  FROM   Products ";
            commandP = new SqlCommand(products, connection);
            adapterP = new SqlDataAdapter(commandP);
            Products = new DataTable();
            adapterP.Fill(Products);
        }
        //Подключение к Корзине
        private void ConnectToKorzina()
        {
            korzina = "SELECT * FROM Korzina";
            commandK = new SqlCommand(korzina, connection);
            adapterK = new SqlDataAdapter(commandK);
            Korzina = new DataTable();
            adapterK.Fill(Korzina);
        }
        #endregion
        #region ChoiceTable
        //Выбор типа устройств
        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            products = "SELECT *  FROM   Products ";
            firms = "SELECT *  FROM   Firms ";
            int i = ProductList.SelectedIndex;
            if (i > 0)
            {
                row = Tovars.Select("Name = '" + ProductList.Text + "'");
                TovarId = row[0]["TovarId"].ToString();
                products = products + " WHERE  TovarId = " + TovarId;
                firms = firms + " WHERE  TovarId = " + TovarId;

                commandF.CommandText = firms;
                Firms.Clear();
                adapterF.Fill(Firms);               
                FirmList.Items.Clear();
                FirmList.Items.Add("Выберите фирму");
                foreach (DataRow firm in Firms.Rows)
                {
                    FirmList.Items.Add(firm["Name"]);
                }
                FirmList.SelectedIndex = 0;
                FirmList.Visible = true;
            }
            else FirmList.Visible = false;
            ChangeTable(products);
        }
        //Выбор товара по фирме
        private void FirmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = ProductList.SelectedIndex;
            int x = FirmList.SelectedIndex;
            products = "SELECT *  FROM   Products ";
            if (i > 0)
            {
                products = products + " WHERE  (TovarId = " + TovarId + ") ";
            }
            if (x > 0)
            {
                row = Firms.Select("Name = '" + FirmList.Text + "'");
                FirmId = row[0]["FirmId"].ToString();
                products = products + " AND (FirmId = " + FirmId + ")";
            }
            ChangeTable(products);
        }


        //заполнение combobox Товаров
        private void AddBoxContent()
        {
            ProductList.Items.Add("Выберите тип");
            foreach (DataRow row in Tovars.Rows)
            {
                ProductList.Items.Add(row["Name"]);
            }
            ProductList.SelectedIndex = 0;
        }
        #endregion
        #region Ranges
        //Выбор диапазона цены
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            NullRange();
            switch (RangeBox.SelectedIndex)
            {
                case 0:
                    products = products + " WHERE Price<10000";
                    ChangeTable(products);
                    products = "SELECT * FROM Products";
                    break;
                case 1:
                    products = products + " WHERE Price BETWEEN 10000 AND 30000";
                    ChangeTable(products);
                    products = "SELECT * FROM Products";
                    break;
                case 2:
                    products = products + " WHERE Price BETWEEN 30000 AND 50000";
                    ChangeTable(products);
                    products = "SELECT * FROM Products";
                    break;
                case 3:
                    products = products + " WHERE Price>50000";
                    ChangeTable(products);
                    products = "SELECT * FROM Products";
                    break;
            }
        }
        //Свой диапазон
        private void RangeSearch_Click(object sender, EventArgs e)
        {
            try
            {
                products = products + " WHERE Price BETWEEN " + rangestartposition.Text.ToString() + " AND " + rangefinishposition.Text.ToString();
                ChangeTable(products);
                products = "SELECT * FROM Products";
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните поля корректно");
            }
        }
        //Очистка полей диапазона
        private void NullRange()
        {
            rangestartposition.Text = null;
            rangefinishposition.Text = null;
        }
        #endregion
        #region Methods
        //Сброс фильтров
        private void ChangeFilters_Click(object sender, EventArgs e)
        {
            ProductList.SelectedIndex = 0;
            string cmd= "SELECT * FROM Products";
            ChangeTable(cmd);
        }
        //Обновление таблицы
        private void ChangeTable(string cmd)
        {
            commandP.CommandText = cmd;
            Products.Clear();
            adapterP.Fill(Products);
            DBView.DataSource = Products;
        }
        //Вывод информации о выбранном товаре
        private void DBView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DBView.CurrentRow;
            string InfoName, InfoFirm;
            int i =(int)row.Cells["TovarId"].Value;
            InfoFirm = row.Cells["Firm"].Value.ToString();
            InfoName = row.Cells["Name"].Value.ToString();
            FirmLabel.Text = InfoFirm;
            NameLabel.Text = InfoName;
            TypeLabel.Text = CheckType(i);
            CountBox.Text = 1.ToString();
        }
        //Определение типа товара
        private string CheckType(int i)
        {
            string result=null;
            switch (i)
            {
                case 1:
                    result = "Процессор";
                    break;
                case 2:
                    result = "Видеокарта";
                    break;
                case 3:
                    result = "Оперативная память";
                    break;
                case 4:
                    result = "Жесткий диск";
                    break;
                case 5:
                    result = "Материнская плата";
                    break;
                case 6:
                    result = "Блок питания";
                    break;
            }
            return result;
        }

        //Переход в корзину
        private void CartOpen_Click(object sender, EventArgs e)
        {
            var cp = new CartPage();
            cp.Show();
            this.Hide();
        }
        //Стили дизайна
        private void DesignActive()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple700, Primary.DeepPurple800, Primary.DeepPurple800, Accent.DeepOrange700, TextShade.WHITE);
        }
        #endregion
        #region AddToCart
        //Добавить в корзину
        private void AddToCart_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DBView.CurrentRow;
            int checkcount = int.Parse(CountBox.Text);
            if (checkcount <= 0)
            {
                MessageBox.Show("Введено неверное количество товара");
            }
            else
            {
                int enoughcount = (int)row.Cells["Count"].Value;
                if (enoughcount < checkcount)
                {
                    MessageBox.Show("На складе недостаточно товара, попробуйте уменьшить количество товара");
                }
                else
                {
                    //Получение данных из таблицы
                    string Id = "'" + row.Cells["Id"].Value.ToString() + "', ";
                    string Firm = "'" + row.Cells["Firm"].Value.ToString() + "', ";
                    string Name = "'" + row.Cells["Name"].Value.ToString() + "', ";
                    string checkName = row.Cells["Name"].Value.ToString();
                    var pr = row.Cells["Price"].Value;
                    string Price = pr.ToString();
                    string Count = CountBox.Text;
                    bool res = CheckAndAddToCart(Id, Name, Firm, Price, Count,checkName);
                    //Обновление строки количество товара
                    int del = int.Parse(CountBox.Text);
                    int countnow = (int)row.Cells["Count"].Value;
                    int id = (int)row.Cells["Id"].Value;
                    countnow = countnow - del;
                    UpdateCount(countnow,id);
                    if (res == false)
                    {
                        //Добавление товара в корзину
                        string Add = "INSERT INTO Korzina " + "(Id,Firm,Name,Price,Count) " + "VALUES (" + Id + Firm + Name + Price + Count + ")";
                        SqlCommand addcmd = new SqlCommand(Add, connection);
                        addcmd.ExecuteNonQuery();
                    }
                }
            }
            CountBox.Text = 1.ToString();
        }
        //Проверка корзины,есть ли в ней такой же товар
        private bool CheckAndAddToCart(string id,string name,string firm,string price,string count,string checkname)
        {
            ConnectToKorzina();
            string thisPosition;
            int upcount;
            bool res = false;
            foreach (DataRow row in Korzina.Rows)
            {
                thisPosition = row["Name"].ToString();
                upcount = (int)row["Count"];
                if (thisPosition == checkname)
                {
                    res = true;
                    upcount += int.Parse(count);
                    string Update = String.Format("UPDATE Korzina SET Count={0} WHERE Name LIKE '{1}'", upcount, thisPosition);
                    SqlCommand updatecmd = new SqlCommand(Update, connection);
                    updatecmd.ExecuteNonQuery();
                }
            }
            return res;
        }

        //Увеличение кол-ва товара
        private void CountPlus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(CountBox.Text);
            count++;
            CountBox.Text = count.ToString();
        }
        //Уменьшение кол-ва товара
        private void CountMinus_Click(object sender, EventArgs e)
        {
            int count = int.Parse(CountBox.Text);
            if (count <= 1)
            {
                MessageBox.Show("Нельзя добавить товара меньше чем 1");
                count = 1;
            }
            else
                count--;

            CountBox.Text = count.ToString();
        }
        //Обновление количества товара в БД
        private void UpdateCount(int countnow,int id)
        {
            string Update = String.Format("UPDATE Products SET Count={0} WHERE Id={1}", countnow, id);
            SqlCommand updatecmd = new SqlCommand(Update, connection);
            updatecmd.ExecuteNonQuery();
            products = "SELECT * FROM Products";
            ChangeTable(products);
        }
        #endregion

    }
}
