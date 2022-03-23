using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp2
{
    public class ProductHolder
    {
        public List<Product> Products { get; set; }
        
    public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
    public void SortForPriceUp()
        {
            //code
        }
    public void SortForPriceDown()
        {
            //code
        }
    }
}
