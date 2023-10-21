using System.Reflection;
using CaseStudy;
using static System.Reflection.Metadata.BlobBuilder;


int num = 1;
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

} while (num != 0);