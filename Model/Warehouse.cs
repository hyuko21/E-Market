using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Warehouse
    {
        private List<Product> products = new List<Product>()
        {
            new Product() { Name = "Massas Cortadas 500g", Amount = 100, Category = "Massas", Maker = "Vitarella", Price = 2.98m },
            new Product() { Name = "Macarrão Espaguete 500g", Amount = 100, Category = "Massas", Maker = "Gostoso", Price = 1.49m },
            new Product() { Name = "Biscoito Cream Cracker 400g", Amount = 150, Category = "Biscoitos", Maker = "Estrela", Price = 2.39m },
            new Product() { Name = "Mingau 230g", Amount = 170, Category = "Grãos", Maker = "Mucilon", Price = 3.39m },
            new Product() { Name = "Milho Verde 200g", Amount = 190, Category = "Enlatados", Maker = "Goiás Verde", Price = 1.28m },
            new Product() { Name = "Salsisha Congelada Hot Dog 1kg", Amount = 150, Category = "Carne", Maker = "Perdigão", Price = 6.99m },
            new Product() { Name = "Energético 2L", Amount = 120, Category = "Bebidas", Maker = "Infinity", Price = 6.99m },
            new Product() { Name = "Batata Congelada 1,5kg", Amount = 150, Category = "Frituras", Maker = "McCain", Price = 10.99m },
            new Product() { Name = "Linguiça de Frango 1kg", Amount = 150, Category = "Carne", Maker = "Sadia", Price = 8.99m},
            new Product() { Name = "Detergente Líquido 500ml", Amount = 150, Category = "Limpeza", Maker = "Minuano", Price = 1.49m },
            new Product() { Name = "Limpador Multiuso 500ml", Amount = 200, Category = "Limpeza", Maker = "Veja", Price = 2.95m },
            new Product() { Name = "Absorvente 16un", Amount = 150, Category = "Higiene Pessoal", Maker = "Sempre livre", Price = 9.98m },
            new Product() { Name = "Bebida Láctea 600g", Amount = 300, Category = "Bebidas", Maker = "Ninho", Price = 4.39m },
            new Product() { Name = "Pizza 460g", Amount = 120, Category = "Massas", Maker = "Sadia", Price = 9.98m },
            new Product() { Name = "Galinha Congelada 1kg", Amount = 150, Category = "Carne", Maker = "Somave", Price = 4.29m },
            new Product() { Name = "Café 250g", Amount = 160, Category = "Grãos", Maker = "Santa Clara", Price = 4.79m },
            new Product() { Name = "Pack Sabonete 6un 90g", Amount = 150, Category = "Higiene Pessoal", Maker = "Even", Price = 5.59m },
            new Product() { Name = "Papel Higiênico Dual f/d 30m", Amount = 110, Category = "Higiene Pessoal", Maker = "Mili", Price = 11.49m },
            new Product() { Name = "Fralda Hiper", Amount = 170, Category = "Higiene Pessoal", Maker = "Baby Roger", Price = 33.90m },
            new Product() { Name = "Biscoito Integral 120g", Amount = 220, Category = "Biscoitos", Maker = "Nesfit", Price = 1.99m },
            new Product() { Name = "Chocolate 45g", Amount = 150, Category = "Doces", Maker = "Kit Kat", Price = 1.99m },
            new Product() { Name = "Suco Regular 1L", Amount = 230, Category = "Bebidas", Maker = "Dafruta", Price = 3.09m },
            new Product() { Name = "Suco Regular 200ml", Amount = 200, Category = "Bebidas", Maker = "Dafruta", Price = 1.09m },
            new Product() { Name = "Suco 200ml", Amount = 210, Category = "Bebidas", Maker = "Kapo", Price = 1.25m },
            new Product() { Name = "Lasanha 600g", Amount = 150, Category = "Massas", Maker = "Sadia", Price = 9.98m },
            new Product() { Name = "Mortadela 1kg", Amount = 120, Category = "Carne", Maker = "Perdigão", Price = 5.69m },
            new Product() { Name = "Presunto de Peru 1kg", Amount = 150, Category = "Carne", Maker = "Sadia", Price = 16.49m },
            new Product() { Name = "Coxinha da Asa 1kg", Amount = 160, Category = "Carne", Maker = "Perdigão", Price = 11.89m },
            new Product() { Name = "Margarina 500g", Amount = 150, Category = "Derivados", Maker = "Deline", Price = 2.79m },
            new Product() { Name = "Papel Higiênico Dual f/d 30m", Amount = 110, Category = "Higiene Pessoal", Maker = "Mili", Price = 11.49m },
            new Product() { Name = "Bebida Láctea 1L", Amount = 170, Category = "Bebidas", Maker = "Batclan", Price = 2.99m },
            new Product() { Name = "Requijão 200g", Amount = 220, Category = "Derivados", Maker = "Clan", Price = 4.59m },
            new Product() { Name = "Polpa de Frutas Acerola 400g", Amount = 150, Category = "Frios", Maker = "Nordeste Fruit", Price = 2.89m }
        };

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
