using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chedder_app
{
    public partial class Square_form : Form
    {
        public Square_form()
        {
            InitializeComponent();
        }

        
        static List<Order> orders = new List<Order>(); //Все заказы

        static List<Label> load_orders_obj = new List<Label>(); //Списки лейблов, в 
        static List<Label> ready_orders_obj = new List<Label>(); // которые нужно вставить данные

        static List<string> load_orders = new List<string>();//Списки id 
        static List<string> ready_orders = new List<string>();// заказов
        private void back_btn_Click(object sender, EventArgs e)
        {
            Square_form.ActiveForm.Hide();
            Main_menu_form NewForm = new Main_menu_form();
            NewForm.ShowDialog();
            Close();
        }

        //Функция обновления заказов. Срабатывает каждые 5 секунд
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 5)
            {
                load_orders.Clear();
                ready_orders.Clear();
                
                for (int j = 0; j < load_orders_obj.Count; j++)
                {
                    load_orders_obj[j].Text = "";
                    ready_orders_obj[j].Text = "";
                }
                for (int j = 0; j < orders.Count; j++)
                {
                    string id = Convert.ToString(orders[j].Id);
                    if (id.Length == 1)
                    {
                        id = "00" + id;
                    }
                    else if (id.Length == 2)
                    {
                        id = "0" + id;
                    }
                    if (orders[j].Status_id == 0)
                    {
                        load_orders.Add("A-" + id);
                    }
                    else if (orders[j].Status_id == 1)
                    {
                        ready_orders.Add("A-" + id);
                    }

                }
                if (load_orders.Count > 8)
                {
                    load_orders = load_orders[0..8];
                }
                if (ready_orders.Count > 8)
                {
                    ready_orders = ready_orders[0..8];
                }
                for (int j = 0; j < load_orders.Count; j++)
                {
                    load_orders_obj[j].Text = load_orders[j];
                }
                for (int j = 0; j < ready_orders.Count; j++)
                {
                    ready_orders_obj[j].Text = ready_orders[j];
                }
                i = 0;
            }

        }

        private void Square_form_Load(object sender, EventArgs e)
        {
            //Здесь добавляются элементы в списки. Нужно будет заменить на подключение к спискам на сервере
            orders.Add(new Order(1, 1, 0, 200));
            orders.Add(new Order(2, 1, 0, 200));
            orders.Add(new Order(3, 1, 0, 200));
            orders.Add(new Order(4, 1, 0, 200));
            orders.Add(new Order(19, 1, 1, 200));
            orders.Add(new Order(234, 1, 0, 200));
            orders.Add(new Order(12, 1, 1, 200));
            orders.Add(new Order(0, 1, 0, 200));
            orders.Add(new Order(1, 1, 0, 200));
            orders.Add(new Order(2, 1, 0, 200));
            orders.Add(new Order(3, 1, 0, 200));
            orders.Add(new Order(4, 1, 0, 200));
            orders.Add(new Order(111, 1, 1, 200));
            orders.Add(new Order(234, 1, 0, 200));
            orders.Add(new Order(12, 1, 1, 200));
            orders.Add(new Order(0, 1, 0, 200));

           //А это не трогать
            load_orders_obj.Add(l_0);
            load_orders_obj.Add(l_1);
            load_orders_obj.Add(l_2);
            load_orders_obj.Add(l_3);
            load_orders_obj.Add(l_4);
            load_orders_obj.Add(l_5);
            load_orders_obj.Add(l_6);
            load_orders_obj.Add(l_7);
            ready_orders_obj.Add(r_0);
            ready_orders_obj.Add(r_1);
            ready_orders_obj.Add(r_2);
            ready_orders_obj.Add(r_3);
            ready_orders_obj.Add(r_4);
            ready_orders_obj.Add(r_5);
            ready_orders_obj.Add(r_6);
            ready_orders_obj.Add(r_7);
        }
    }
}
