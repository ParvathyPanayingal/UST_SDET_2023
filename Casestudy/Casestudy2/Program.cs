using System.Reflection;
using Casestudy;
using static System.Reflection.Metadata.BlobBuilder;


/*int num = 1;
string? title;
int customerid;
string? customerName;
string? phonenumber;
string? orderdate;
int total;

do
{

    Console.WriteLine("1.Add Book\n2.Add Customer\n3.Place Order And Display Order\n4.Search Book\n5.Exit");
    Console.WriteLine("Choose The Option");
    int choice = Convert.ToInt32(Console.ReadLine());

    BookType[] bookType = new BookType[]
          {
            new("Harry Porter","J K Rowling",1112,300,"yes","Fiction"),


          };

    switch (choice)
    {
        case 1:

            Console.WriteLine("Book Added SuccessFully");
            foreach (BookType booktypes in bookType)
            {
                booktypes.DisplayDetails();
            }
            break;
        case 2:

            Console.WriteLine("Enter Customer Id");
            customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name");
            customerName = Console.ReadLine();
            Console.WriteLine("Enter Phonenumber");
            phonenumber = Console.ReadLine();

            Customer customer = new Customer(customerid, customerName, phonenumber);
            customer.DisplayCustomer();
            break;
        case 3:

            Console.WriteLine("Enter the Book Title");
            title = Console.ReadLine();


            if (bookType[0].Title.Equals(title))
            {
                foreach (var book in bookType)
                {
                    Console.WriteLine("Enter Order Date:");
                    orderdate = Console.ReadLine();
                    Console.WriteLine("Order Confirmed");
                    total = book.Price;
                    Order order = new Order(orderdate, total);

                    Console.WriteLine("Order Details is");

                    order.DisplayOrder();
                    Console.WriteLine($"Book Title is:{book.Title}");
                    Console.WriteLine($"Book Price is:{book.Price}");
                    Console.WriteLine($"Book Type is:{book.Genre}");


                }
            }
            else
            {
                Console.WriteLine("Not Available");
            }
            break;

        case 4:

            Console.WriteLine("Give Title of the BOOK");
            title = Console.ReadLine();
            foreach (var book in bookType)
            {
                if (book.Title.Equals(title))
                {
                    Console.WriteLine($"Book Title is:{book.Title}");
                    Console.WriteLine($"Book Price is:{book.Price}");
                    Console.WriteLine($"Book Availability is:{book.Availability}");




                }

                else
                {
                    Console.WriteLine("Book not available");
                }

            }

            break;

        case 5:


            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
    Console.WriteLine("For Continue press 2 or 1 for exit");
    num = Convert.ToInt32(Console.ReadLine());

} while (num != 0);*/

int option, choice;
do
{
    Console.WriteLine("***Big Mart***");

    Console.WriteLine("1.Add Product\n2.Add Customer\n3.PlaceOrder\n4.ProcessPayment\n" +
        "5.Deliver Product\n6.View Order History\n7.Exit" +
        "");
    Console.WriteLine("Enter Your Choice");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the Product Id");
            int productid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Product Type(Digital and physical)");
            string? productType = Console.ReadLine();
            Console.WriteLine("Enter Product Name");
            string? productName = Console.ReadLine();
            Console.WriteLine("Enter The Price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the stock Quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Product product = new Product();
            Product.products.Add(product);
            if (Product.products.Count > 0)
            {
                Console.WriteLine("Successfully Added");
            }
            else
            {
                Console.WriteLine("Failed to Add");
            }
            break;
        case 2:
            Console.WriteLine("Enter the CustomerId");
            int custid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Customer Name");
            string? custName = Console.ReadLine();
            Console.WriteLine("Enter the email");
            string? email = Console.ReadLine();
            Customers customer = new Customers(custid, custName, email);
            Customers.Customer.Add(customer);
            if (Customers.Customer.Count > 0)
            {
                Console.WriteLine("Successfully Added");
            }
            else
            {
                Console.WriteLine("Failed To Add Product");
            }
            break;
        case 3:
            Console.WriteLine("Enter The  Product Id");
            int id = Convert.ToInt32(Console.ReadLine());
            var data = Product.products.Find(x => x.ProductId == id);
            if (data != null)
            {
                DigitalProduct digitalProduct = new DigitalProduct();

                if (Product.ProductType == "Digital")
                {
                    digitalProduct.PlacingOrder();
                }
                else
                {
                    digitalProduct.PlacingOrder();
                }
            }
            else
            {
                Console.WriteLine("pRODUCT nOT fOUND");
            }
            break;
        case 4:

            break;
        case 5:
            Console.WriteLine("Enter The Type Of Product");
            string? typ = Console.ReadLine();
            DigitalProduct typProduct = new DigitalProduct();
            if (typ == Product.ProductType)
            {
                typProduct.DeliveringProduct();
            }
            else
            {
                typProduct.DeliveringProduct();
            }


            break;
        case 6:
            foreach (var order in OrderDetails.orderDetails)
            {
                Console.WriteLine($"Product Id Is:{order.ProductId}\nCustomer Name:{order.CustomerName}\n" +
                    $"Type:{order.Type}\nStatus:{order.Status}");
            }
            break;
        case 7:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;




    }
    Console.WriteLine("Do you want to contine(yes/No)");
    option = Convert.ToInt32(Console.ReadLine());

} while (option == 1);