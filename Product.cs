using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__proj_2026
{
    public class Product: IProduct
    {
        
        private int product_id;

        private string product_name;

        private string product_description;

        private int product_price;

        private int product_rating;

        private string[] product_category;

        public int GetProduct_id()
        {
            
            return this.product_id;

        }

        public void SetProduct_id(int id)
        {
            
            this.product_id = id;

        }

        public string GetProduct_name()
        {

            return this.product_name;

        }

        public void SetProduct_name(string name)
        {

            this.product_name = name;

        }

        public string GetProduct_description()
        {
            
            return this.product_description;

        }

        public void SetProduct_description(string description)
        {

            this.product_description = description;

        }

        public int GetProduct_price()
        {
            
            return this.product_price;

        }

        public void SetProduct_price(int price)
        {

            this.product_price = price;

        }

        public int GetProduct_rating()
        {
            
            return this.product_rating;

        }

        public void SetProduct_rating(int rating)
        {

            this.product_rating = rating;

        }

        public string[] GetProduct_category()
        {

            return this.product_category;
            
        }

        public void SetProduct_category(string[] categories)
        {
            
            this.product_category = categories;

        }

        public Product(
            int _id, 
            string _name, 
            string _description, 
            int _price,
            int _rating,
            string[] _category
        ){

            this.product_id = _id;

            this.product_name = _name;

            this.product_description = _description;

            this.product_price = _price;

            this.product_rating = _rating;

            this.product_category = _category;
            
        }

    }
}