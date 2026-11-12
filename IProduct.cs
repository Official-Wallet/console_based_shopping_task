using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__proj_2026
{
    public interface IProduct
    {

        int GetProduct_id();

        void SetProduct_id(int id);

        string GetProduct_name();

        void SetProduct_name(string name);

        string GetProduct_description();

        void SetProduct_description(string description);

        int GetProduct_price();

        void SetProduct_price(int price);

        int GetProduct_rating();

        void SetProduct_rating(int rating);

        string[] GetProduct_category();

        void SetProduct_category(string[] cateories);
        
    }
}