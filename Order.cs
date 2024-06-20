using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chedder_app
{
    internal class Order
    {
        public int Id { get; set; }
        public int Users_id { get; set; }
        public int Status_id { get; set; }
        public int Price { get; set; }
        public Order() { }
        public Order (int id, int users_id, int status_id, int price)
        {
            Id = id;
            Users_id = users_id;
            Status_id = status_id;
            Price = price;
        }
    }
}
