using NorthwindDal.Model;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            NorthwindContext context = new NorthwindContext();

            foreach (Product item in context.Products)
            {
                Console.WriteLine($"{item.ProductName}: {item.UnitPrice}");
            }
        }

        [Test]
        public void Test2()
        {
            Product product = new Product() { ProductName = "Schwarzer Tee" };

            NorthwindContext context = new NorthwindContext();
            context.Products.Add(product);

            context.SaveChanges();
        }
    }
}