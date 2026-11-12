using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__proj_2026
{
    public class Cart: ICart
    {
        
        private List<Product> cart = new List<Product>();

        public void GetCart()
        {
            
            foreach(Product p in cart)
            {
                
                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("***********************************************************************************************************************************************************");
                
                Console.WriteLine("***********************************************************************************************************************************************************");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine($"          ================  {p.GetProduct_name()}  ================");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine(p.GetProduct_description());

                Console.WriteLine("");

                Console.WriteLine($"Price: ${p.GetProduct_price()}");

                Console.WriteLine("");

                Console.WriteLine("");

                string rating_stars = "";

                for(int r_c = 0; r_c < p.GetProduct_rating(); r_c++)
                {

                    rating_stars += "⭐️";

                }

                Console.WriteLine($"          ================  Rating: {rating_stars}  ================");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("***********************************************************************************************************************************************************");

                Console.WriteLine("***********************************************************************************************************************************************************");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("");

            }

        }

        public void SetCart(Product item)
        {
            
            this.cart.Add(item);

        }
    }
}