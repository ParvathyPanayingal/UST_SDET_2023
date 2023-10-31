
using Assignments;
using Assignments.MyException;
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
/*Students[] student = new Students[3];
student[0] = new Students("Amal", new int[] { 20, 30, 40 }, "A");
student[1] = new Students("Vimal", new int[] { 50, 45, 67 }, "B");
student[2] = new Students("Zahal", new int[] { 25, 50, 45 }, "C");


foreach (Students student2 in student)
{
    student2.DisplayStudentInfo();
    student2.CalculateAverage();
    student2.GetMarkSummary();
    Console.WriteLine();
}*/


/*ElectronicProduct ep = new(2, "Apple", 25000, 1);
ep.DisplayProduct();
ep.DisplayWarrantyPeriod();
Console.WriteLine();



DigitalProduct dp = new DigitalProduct("PDF", 2, "samsung", 50000, 3);
dp.DisplayProduct();
dp.DisplayWarrantyPeriod();
dp.DisplayDigitalProduct();*/

/*Console.Write("Enter the employee id:");
int id =Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the first name:");
string firstname=Console.ReadLine();
Console.Write("Enter the last name :");
string lastname=Console.ReadLine();
Console.Write("Enter the age :");
int age=Convert.ToInt32(Console.ReadLine());

Employee employee=new Employee(firstname,lastname,age,id);
employee.DisplayInfo(age);*/

/*Console.Write("Enter the radius:");
double radius=Convert.ToDouble(Console.ReadLine());
Circle circle =new Circle(radius);
circle.Draw();
Console.WriteLine("Area:" + circle.CalculateArea());
Console.WriteLine("Perimeter:" +circle.CalculatePerimeter());
Console.Write("Enter the length:");
double length=Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the Width:");
double width=Convert.ToDouble(Console.ReadLine());
Rectangle rectangle = new Rectangle(length, width);
rectangle.Draw();
Console.WriteLine("Area:"+rectangle.CalculateArea());
Console.WriteLine("Perimeter:"+rectangle.CalculatePerimeter());*/

/*InsurancePolicy ip=new InsurancePolicy("Parvathy",123,3000);
ip.RenewPolicy();
ip.RenewPolicy(6500);*/

//Console.Write("Enter the policyId:");
//int policyId=Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the policy name:");
//string? policyName=Console.ReadLine();
//Console.Write("Enter the policy amount:");
//double premiumAmount =Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter the age:");
//int age=Convert.ToInt32(Console.ReadLine());
//LifeInsurance lifeInsurance =new LifeInsurance(policyId,policyName,premiumAmount,age);
//Console.WriteLine("Premium amount:" + lifeInsurance.CalculatePremium());
//Console.Write("Enter the policy id:");
//int policyId1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the policy name:");
//string? policyName1 = Console.ReadLine();
//Console.Write("Enter the policy amount:");
//double premiumAccount1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter the car type:");
//string type=Console.ReadLine().ToLower();
//CarInsurance car = new CarInsurance(policyId, policyName1, premiumAccount1, type);
//Console.WriteLine(car.CalculatePremium());

//CustomerData customerData= new CustomerData();
//customerData.DispAllDetails();
//Console.WriteLine("enter phone number:");
//long phoneNumber=Convert.ToInt64(Console.ReadLine());
//customerData.DispCustomerData(phoneNumber);

//CallRecord record = new CallRecord();
//Console.WriteLine("Enter the phone number");
//long number = Convert.ToInt64(Console.ReadLine());
//CallRecord.CallHistory(number);

//Patient patient = new Patient();
//Console.Write("Enter the patient Id:");
//int id = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Name:");
//string name = Console.ReadLine();
//Console.Write("Enter the Age:");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Diagnosis:");
//string diagnosis = Console.ReadLine();
//try
//{
//    patient.AddPatient(id, name, age, diagnosis);

//}
//catch (MyExceptions ex)
//{
//    Console.WriteLine(ex.Message);
//}

/*MedicalRecord medicalRecord = new MedicalRecord();


Console.Write("Enter the patient Id:");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the record Id:");
        int r_id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Name:");
        string name = Console.ReadLine();
        Console.Write("Enter the Age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Diagnosis:");
        string diagnosis = Console.ReadLine();
        Console.Write("Enter the treatment cost:");
        double cost = Convert.ToDouble(Console.ReadLine());
        try
        {
            medicalRecord.AddMedicalRecord(r_id, id, name, age, diagnosis, cost);
            medicalRecord.DisplayDetails();
        }
        catch (InvalidMedicalRecordException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidPatientDataException ex)
        {
            Console.WriteLine(ex.Message);
       }*/


//Patient patient = new Patient();
//int option=1;
//do
//{
//    Console.WriteLine("Enter the choice:");
//    Console.WriteLine("1.Add Patient Record\n2.View Patient Record\n3.Exit");
//    switch (Convert.ToInt32(Console.ReadLine()))
//    {
//        case 1:
//            Console.Write("Enter the patient Id:");
//            int id = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Name:");
//            string name = Console.ReadLine();
//            Console.Write("Enter the Age:");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Diagnosis:");
//            string diagnosis = Console.ReadLine();
//            patient.AddPatientTextFile(id, name, age, diagnosis);
//            break;

//            case 2:
//            patient.ReadDetails();
//            break;

//        case 3:
//            Environment.Exit(0);
//            break;
//        default:
//            Console.WriteLine("Invalid choice");
//            break;

//    }  
//    Console.WriteLine("Do you wish to continue?\n1.Yes\n2.No");
//    option=Convert.ToInt32(Console.ReadLine());
//}
//while(option!=2);


//Console.WriteLine("Enter the choice:\n1.")



/*HotelRoom hotel = new HotelRoom(401, "Double", true);
RoomReservation<HotelRoom> room = new();

room.BookRoom(hotel);
Console.WriteLine("Hotel Room booked Successfully");
Console.WriteLine("Details are :");
string? status;
foreach (var item in RoomReservation<HotelRoom>.values)
{
    if (item.IsBooked)
        status = "Engaged";
    else
        status = "Not Engaged";
    Console.WriteLine("Room Number:{0} Room Type:{1} Status:{2} ", item.RoomNumber, item.RoomType, status);
}
Console.WriteLine("Enter the room number for canceling:");
int num = Convert.ToInt32(Console.ReadLine());
var roomNum = HotelRoom.GetRoom(num);
if (roomNum != null)
{
    room.CancelRoom(roomNum);
    Console.WriteLine("Room is canceled");
}
else
{
    Console.WriteLine("Room doesn't exist");
}*/


/*Inventory<string> inventory = new Inventory<string>();
int choice, option;
do
{
    Console.WriteLine("Choose The Menu");
    Console.WriteLine("1.Add Product\n2.Update Product\n3.RemoveProduct\n4.Search ProductById\n5.Search Product By Name");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter The Product Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The ProductName");
            string? productname = Console.ReadLine();
            Console.WriteLine("Enter The Price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity in stock");
            int qty = Convert.ToInt32(Console.ReadLine());
            inventory.AddProduct(new Products<string>(id, productname, price, qty));
            break;
        case 2:
            Console.WriteLine("Enter the product id Do You want update");
            int proid = Convert.ToInt32(Console.ReadLine());
            var prId = inventory.FindProductById(proid);
            if (prId != null)
            {
                Console.WriteLine("Enter the Product Name");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter the price");
                double pric = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the qty");
                int qt = Convert.ToInt32(Console.ReadLine());
                inventory.UpdateProduct(proid, name, pric, qt);
                Console.WriteLine("Successfully Updated");

            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }

            break;
        case 3:
            Console.WriteLine("Enter the product Id Do You Want Delete");
            int ids = Convert.ToInt32(Console.ReadLine());
            var data = inventory.FindProductById(ids);
            if (data != null)
            {
                inventory.DeleteProduct(ids);
                Console.WriteLine("Product Deleted Success!!!!");
            }
            else
            {
                Console.WriteLine("No Product available!!!");
            }
            break;
        case 4:
            Console.WriteLine("View Product BY Id");
            Console.WriteLine("Enter The Product Id");
            int pid = Convert.ToInt32(Console.ReadLine());
            Products<string> pro = inventory.FindProductById(pid);
            if (pro != null)
            {
                Console.WriteLine($"Product Id:{pro.ProductId}\nProduct Name:{pro.ProductName}" +
                    $"\nPrice:{pro.Price}\nQuantity:{pro.QuantityInStock}");
            }
            else
            {
                Console.WriteLine("No Product Available");
            }



            break;
        case 5:
            Console.WriteLine("Search Product By Name");
            string? proname = Console.ReadLine();
            List<Products<string>> dat = inventory.FindProductByName(proname);
            if (dat != null)
            {
                foreach (Products<string> p in dat)
                {
                    Console.WriteLine($"Product Id:{p.ProductId}\nProduct Name:{p.ProductName}" +
                    $"\nPrice:{p.Price}\nQuantity:{p.QuantityInStock}");
                }
            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Option!!!!");
            break;
    }
    Console.WriteLine("Do you want to continue \n1. Yes \n2.No");
    option = Convert.ToInt32(Console.ReadLine());

} while (option == 1);*/

//Employees
/*class Program
{
    public delegate double DelegateOne(Employees employee);
    public delegate double DelegateTwo(Employees employeeone);

    public static void Main(String[] args)
    {
        DelegateBonus delegateExample = new DelegateBonus();
        Employees employee = new(1, "Parvathy", 4);
        Employees employeeone = new(2, "Aiswarya", 5);
        DelegateOne delegateOne = Employees.BonusCalculation;
        DelegateTwo delegateTwo = Employees.BonusCalculation;
        Console.WriteLine($"Employee Name:{employee.EmployeeName}\nPerformance Rating:{employee.PerformanceRange}\nBonus Amount:{delegateOne(employee)}");
        Console.WriteLine($"Employee Name:{employeeone.EmployeeName}\nPerformance Rating:{employeeone.PerformanceRange}\nBonus Amount:{delegateTwo(employeeone)}");

    }
}*/

//HotelEvent
class Program
{
    public delegate string DelegateMessageOne(string msg);
    public delegate string DelegateMessageTwo(string msg);
    public static void Main(string[] args)
    {
        HotelEvent hotelEvent = new("Dance", "Calicut", "12.00:1-11-2023", 4);
        DelegateMessageOne delegateMessageOne = HotelEvent.EventRegistration;
        if (hotelEvent != null)
        {
            Console.WriteLine(delegateMessageOne($"Hai {hotelEvent.EventName} is Successfully Registered the event on {hotelEvent.EventDate}"));
        }
        else
        {
            Console.WriteLine(delegateMessageOne("Unsuccessfully registered"));
        }
        HotelEvent hotelEventone = new("Concert", "Ernakulam", "12.0013-10-2023", 6);

        DelegateMessageTwo delegateMessageTwo = HotelEvent.EventRegistration;
        if (hotelEventone != null)
        {
            Console.WriteLine(delegateMessageTwo($"Hai {hotelEventone.EventName} is Successfully Registered the event on {hotelEventone.EventDate}"));
        }
        else
        {
            Console.WriteLine(delegateMessageTwo("Unsuccessfully registered"));
        }
    }
}









