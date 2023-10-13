using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductTest();
        // CategoryTest();
        // OrderTest();
        //ProductDetailTest();
    }

    private static void ProductDetailTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetProductDetails().Data)
        {
            Console.WriteLine(product.ProductName+" -- "+product.CategoryName+" -- "+product.UnitsInStock);
        }
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        var result = productManager.GetAll();

        if (result.Succeess)
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }

    }

    private static void OrderTest()
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());

        foreach (var order in orderManager.GetOrderByCity("Madrid"))
        {
            Console.WriteLine(order.OrderId + " " + order.OrderDate);
        }
    }
}