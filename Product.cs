using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Product
    {
        int productCode;
        string productName;
        string productDescription;
        int productPrice;
        int iva = 22;

        public Product(string name, string description, int price)
        {
            if (productCode == 0)
            {
                Random rnd = new Random();
                productCode = rnd.Next();
            }

            productName = name;
            productDescription = description;
            productPrice = price;
        }

        public int getCode()
        {
            return this.productCode;
        }

        public string getName()
        {
            return this.productName;
        }

        public string setName(string value)
        {
            return this.productName = value;
        }

        public string getDescription()
        {
            return this.productDescription;
        }

        public string setDescription(string value)
        {
            return this.productDescription = value;
        }

        public int getPrice()
        {
            return this.productPrice;
        }

        public int setPrice(int value)
        {
            return this.productPrice = value;
        }

        public string getFullInfo()
        {
            return $"{this.productCode.ToString()}" + $" {this.productName}";
        }

        public int getFullPrice()
        {
            this.productPrice = (this.productPrice / 100) * 22;
            return this.productPrice;
        }
    }
        
}
