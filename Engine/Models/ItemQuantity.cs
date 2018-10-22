using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemQuantity
    {
        public int ID { get; set; }
        public int Quantity { get; set; }

        public ItemQuantity(int id, int quantity)
        {
            ID = id;
            Quantity = quantity;
        }
    }
}
