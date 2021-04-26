using System;
using System.Globalization;
using System.Collections.Generic;
using exrcFixacao.Entities;

namespace exrcFixacao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Products { get; set; } //Classe produto gera um tipo Produto que não precisa ser inicializado e pode ser usdado como parâmetro

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Products = product;
        }

        public double SubTotal() //Funções que trazem o resultado direto não precisam de parâmetro
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Products.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture); //A função com resultado pode ser utilizado na formação das strings (impressão)
        }
    }
}
