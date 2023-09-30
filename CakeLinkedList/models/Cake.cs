using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeLinkedList.models
{
    public  class Cake
    {
        public string flavor { get; set; }
        public int size { get; set; }
        public  string color { get; set; }
        public double price { get; set; }
        public int portions { get; set; }
        public string distributor { get; set; }
        public Cake() { }

        public Cake(string flavor, int size, string color, double price, int portions, string distributor)
        {
            this.flavor = flavor;
            this.size = size;
            this.color = color;
            this.price = price;
            this.portions = portions;
            this.distributor = distributor;
        }

        public override string ToString()
        {
            return $"SABOR: {flavor}, TAMAÑO: {size}, COLOR: {color}, PRECIO: {price}, PORCIONES: {portions}, DISTRIBUIDOR: {distributor}";
        }

    }
}
