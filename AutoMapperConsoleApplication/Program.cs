using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Show("下午好!");



            var property = new DerivedClass();


            var token = property.GetType().MetadataToken;

            var property1 = typeof(DerivedClass);

            var arrayList = new List<string> { "10", "20" };





            Product[] products = { new Product { Name = "apple", Code = 9 },
                       new Product { Name = "orange", Code = 4 },
                       new Product { Name = "apple", Code = 9 },
                       new Product { Name = "lemon", Code = 12 } };

           

           
            IEnumerable<Product> noduplicates =
                products.Distinct(new ProductComparer());




            foreach (var product in noduplicates)
                Console.WriteLine(product.Name + " " + product.Code);






        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Code { get; set; }
    }
    public class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            if (Object.ReferenceEquals(x, y))
                return true;
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;
            return x.Code == y.Code && x.Name == y.Name;
        }



        public int GetHashCode(Product product)
        {
            if (Object.ReferenceEquals(product, null)) return 0;
            int hashProductName = product.Name == null ? 0 : product.Name.GetHashCode();
            int hashProductCode = product.Code.GetHashCode();
            return hashProductName ^ hashProductCode;
        }

    }
}

