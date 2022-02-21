using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace CHStore
{
    public partial class SearchOrderPage : MaterialForm 
    {
        string ConnStr,Order=null;
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable Orders;
        public SearchOrderPage()
        {
            InitializeComponent();
            DesignActive();
            InfoLabel.Text = "Для поиска вашего заказа вам нужно указать ваше имя и номер\nтелефона,так мы удостоверимся что заказ принадлежит вам";
            //Подключение к БД
            ConnStr = @"Data Source=(localdb)\MSSQLLocalDB;" + "Initial Catalog = MyStore;" + "Integrated Security = True";
            connection = new SqlConnection(ConnStr);
            connection.Open();
            OrderInfoName.Visible = false;
            OrderInfoDate.Visible = false;
            OrderInfoPrice.Visible = false;
            ShowOrderListButton.Visible = false;
        }
        //Стили дизайна
        private void DesignActive()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple700, Primary.DeepPurple800, Primary.DeepPurple800, Accent.DeepOrange700, TextShade.WHITE);
        }
        //Возвращение к корзине
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var ui = Application.OpenForms[1];
            ui.Show();
            Close();
        }
        //Выход из окна поиска заказа
        private void SearchOrderPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            var ui=Application.OpenForms[1];
            ui.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(NameBox.Text.Length==0 || PhoneBox.Text.Length==0)
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                string Name = NameBox.Text;
                string Phone = PhoneBox.Text;
                string search = String.Format("SELECT * FROM Orders WHERE Phone={0} AND Name=N'{1}'", Phone, Name);
                SqlCommand searchcmd = new SqlCommand(search, connection);
                searchcmd.ExecuteNonQuery();
                adapter = new SqlDataAdapter(searchcmd);
                Orders = new DataTable();
                adapter.Fill(Orders);
                if (Orders.Rows.Count == 0)
                {
                    MessageBox.Show("К сожалению ваш заказ не найден, проверьте введенные вами данные.");
                }
                else
                {
                    string Surename=null,Date=null,Price=null;
                    MessageBox.Show(Name+" ваш заказ найден");
                    foreach(DataRow row in Orders.Rows)
                    {
                        Surename = row["Surename"].ToString();
                        Date = row["Date"].ToString();
                        Order = row["OrderList"].ToString();
                        Price = row["Price"].ToString();
                    }
                    OrderInfoName.Visible = true;
                    OrderInfoDate.Visible = true;
                    OrderInfoPrice.Visible = true;
                    ShowOrderListButton.Visible = true;
                    OrderInfoName.Text = Name + " " + Surename;
                    OrderInfoDate.Text = "Дата вашего заказа-" + Date;
                    OrderInfoPrice.Text = "Сумма вашего заказа-" + Price;
                }
            }
            

        }
        //Вывод содержимого заказа
        private void ShowOrderListButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Order);
        }
    }
}
