
using Assignments;
using System.Diagnostics;

/*class Program
{
    static void Main(string[] args)
    {


        Product[] products = new Product[3];
        products[0] = new Product("Product 1", 10.0, 5);
        products[1] = new Product("Product 2", 20.0, 3);
        products[2] = new Product("Product 3", 15.0, 8);

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine("Product Name:" + products[i].productName);
            Console.WriteLine("Price:" + products[i].price);
            Console.WriteLine("Quantity:" + products[i].quantity);
            Console.WriteLine();

        }
        Console.WriteLine("Total Values:");
        for (int i = 0; i < products.Length; i++)
        {
            double totalValue = products[i].ProductValue();
            Console.WriteLine("Product Name:" + products[i].productName);
            Console.WriteLine("Product Value :" + totalValue);
            Console.WriteLine();


        }
    }
}*/
Students[] student = new Students[3];
student[0] = new Students("Amal", new int[] { 20, 30, 40 }, "A");
student[1] = new Students("Vimal", new int[] { 50, 45, 67 }, "B");
student[2] = new Students("Zahal", new int[] { 25, 50, 45 }, "C");


foreach (Students student2 in student)
{
    student2.DisplayStudentInfo();
    student2.CalculateAverage();
    student2.GetMarkSummary();
    Console.WriteLine();
}