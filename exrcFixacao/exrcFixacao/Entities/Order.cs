using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using exrcFixacao.Entities;
using exrcFixacao.Entities.Enums;

namespace exrcFixacao.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; } = new Client();
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();
        //Listas podem ser usadas para armazenar registros de classes que fazem a composição de uma segunda classe

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

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem it in OrderItens)
            {
                sum += it.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("=============");
            sb.AppendLine("Order moment: " +  Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("================***==================");
            sb.AppendLine("Order itens:");
            foreach(OrderItem it in OrderItens)
            {

                sb.AppendLine(it.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
