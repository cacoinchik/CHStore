using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CHStore
{
    public partial class OrderPage : MaterialForm
    {
        SqlConnection connection;
        SqlCommand cmd,cmdOr;
        SqlDataAdapter adapter,adapterOr;
        DataTable Korzina,Orders;
        public decimal sum;
        public OrderPage()
        {
            InitializeComponent();
            DesignActive();
        }
        private void OrderPage_Load(object sender, EventArgs e)
        {
            string ConnStr = @"Data Source=(localdb)\MSSQLLocalDB;" + "Initial Catalog = MyStore;" + "Integrated Security = True";
            connection = new SqlConnection(ConnStr);
            connection.Open();
        }
        //Подключение к Корзине
        private void ConnectToKorzina()
        {
            string korzina = "SELECT * FROM Korzina";
            cmd = new SqlCommand(korzina, connection);
            adapter = new SqlDataAdapter(cmd);
            Korzina = new DataTable();
            adapter.Fill(Korzina);
        }
        //Подключение к Заказам
        private void ConnectToOrders()
        {
            string orders = "SELECT * FROM Orders";
            cmdOr = new SqlCommand(orders, connection);
            adapterOr = new SqlDataAdapter(cmdOr);
            Orders = new DataTable();
            adapterOr.Fill(Orders);
        }
        //Стили дизайна
        private void DesignActive()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple700, Primary.DeepPurple800, Primary.DeepPurple800, Accent.DeepOrange700, TextShade.WHITE);
        }
        //Возврат к покупкам
        private void OrderPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            var cp = Application.OpenForms[0];
            cp.Show();
        }
        //Возврат к корзине
        private void RefusalButton_Click(object sender, EventArgs e)
        {
            var cp = Application.OpenForms[0];
            cp.Show();
            Close();
        }
        //Подтверждение заказа
        private void PayButton_Click(object sender, EventArgs e)
        {
            if(NameBox.Text.Length==0 || PhoneBox.Text.Length == 0)
            {
                MessageBox.Show("Заполните обязательные поля");
            }
            else
            {
                Pay();
                Clear();
                MessageBox.Show("Ваш заказ оформлен!\nЖдём вас на выдачу товара завтра с 8:00 до 21:00\nНе забудьте телефон,он нужен для проверки заказа!");
                var cp = Application.OpenForms[0];
                cp.Show();
                Close();
            }
        }

        //Оформление заказа
        private void Pay()
        {
            ConnectToKorzina();
            string name, surename, phone, result = null, firm = null, tname = null, count = null,summ=null;
            name = NameBox.Text;
            surename = SurenameBox.Text;
            phone = PhoneBox.Text;
            foreach (DataRow row in Korzina.Rows)
            {
                firm = row["Firm"].ToString();
                tname = row["Name"].ToString();
                count = row["Count"].ToString();
                result = result + String.Format("({0} {1}) в количестве {2} шт ", firm, tname, count);
            }
            var date = DateTime.Now;
            summ = sum.ToString();
            string Order = String.Format("INSERT INTO Orders (Name,Surename,Phone,Date,OrderList,Price) VALUES (N'{0}',N'{1}','{2}','{3}',N'{4}','{5}')",name,surename,phone,date,result,summ);
            SqlCommand ordercmd = new SqlCommand(Order, connection);
            ordercmd.ExecuteNonQuery();
        }
        //Очистка корзины после оформления заказа
        private void Clear()
        {
            string clear = "DELETE FROM Korzina";
            SqlCommand clearcmd = new SqlCommand(clear, connection);
            clearcmd.ExecuteNonQuery();
        }
        

    }
}
