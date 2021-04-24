using System;
using System.Collections.Generic;
using System.Text;
using exrcFixacao.Entities.Enums;

namespace exrcFixacao.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; } = new Client();
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItens.Remove(item);
        }

    }
}
