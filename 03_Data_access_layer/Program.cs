using _03_Data_access_layer;
using System.Configuration;

internal class Program
{
    /* CRUD
    [C] - Create
    [R] - Read
    [U] - Update
    [D] - Delete
     */
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding= System.Text.Encoding.UTF8;

        SportShopDb db = new SportShopDb(ConfigurationManager.ConnectionStrings["connShop"].ConnectionString);
        /*db.AddProduct(new Product()
        {
            Name = "Обруч",
            Type = "Аксесуари",
            Quantity = 25,
            CostPrice = 10,
            Price = 150,
            Producer = "Україна"
        });*/

        /*var products = db.getAll();
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }*/
        var product = db.getOneProducr(1);
        Console.WriteLine(product);
        product.Name = "Шкарпетки";
        db.Update(product);
        product = db.getOneProducr(1);
        Console.WriteLine(product);

        db.Delete(3);
    }
}