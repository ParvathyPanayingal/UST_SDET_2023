using Basic_Programs;
using Basic_Programs.ExceptionMessages;

/*Employee employee =new (1223,"abc","IT",10000);
Console.WriteLine("Employee id :{0} \n"+
    "Name : {1} \n" +
    "Dept : {2} \n" +
    "Basic Pay : {3} ",
    employee.Eid,
    employee.Empname, 
    employee.Dept, 
    employee.Basicpay);
Console.WriteLine("Net Pay : {0} ",employee.CalcultaeSalary());*/

/*ArraySample arraySample = new ();
ArraySample jarray = new();
//arraySample.Onedim();
//arraySample.Twodim();
arraySample.Jarray();*/

/*StudentsMarks marks = new();
marks.RollNo = 32;
marks.StudentName = "Parvathy";
marks.City = "Kozhikode";
marks.Mark1 = 90;
marks.Mark2 = 85;
marks.Mark3 = 97;
marks.DisplayStudentDetails();
Console.WriteLine("Total:"+marks.CalculateTotal());
Console.WriteLine("Average:"+marks.CalculateAverage());*/

/*StudentGrade grade = new();
grade.RollNo = 32;
grade.StudentName = "Parvathy";
grade.City = "Kozhikode";
grade.Mark1 = 90;
grade.Mark2 = 85;
grade.Mark3 = 97;
grade.DisplayStudentDetails();
Console.WriteLine("Total:" + grade.CalculateTotal());
Console.WriteLine("Average:" + grade.CalculateAverage());
Console.WriteLine("Grade:" + grade.CalculateGrade());*/

/*Console.WriteLine("1.TS 2.NTS");

switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff tstaff = new TeachingStaff();
        tstaff.Staffid = 111;
        tstaff.Name = "TS1";
        tstaff.Department = "CS";
        tstaff.Specializations = "O,DBMS";
        tstaff.Semester = 4;
        tstaff.DisplayStaffDetails();
        tstaff.DisplayTSDetails();
        break; 

case 2 :
    NonTeachingStaff ntstaff = new NonTeachingStaff();
        ntstaff.Staffid = 999;
        ntstaff.Name = "TS1";
        ntstaff.Department = "Admin";
        ntstaff.Responsibilities = "Attendence";
        ntstaff.Experience = 4;
        ntstaff.DisplayNonTSDetails();
        ntstaff.DisplayNonTSDetails();
    break;

}*/
//TeachingStaff ts = new TeachingStaff();
//NonTeachingStaff nts = new NonTeachingStaff();

/*
 EV ev = new();
ev.Vehnum = 4343;
ev.Brand = "MARUTI";
ev.Model = "aa";
ev.Disp();
Console.WriteLine( ev.setTypeForVehicle());

PV pv = new();
pv.Vehnum =2119;
pv.Brand = "KIA";
pv.Model = "bb";
pv.Disp();
Console.WriteLine(pv.setTypeForVehicle());
*/

/*Doctor doc=new Doctor();
doc.AddNewDoctor(1234,"abc");
doc.DisplayDoctorDetails();
doc.ModifyDoctor(5678,"def");
doc.DisplayDoctorDetails();
doc.BookApp(9876,"AAA");
doc.DelApp("AAA");*/

//BankDetails bank=new BankDetails(1234,123456789L,"AA","Inactive");
//BankDetails bank1 = new();
/*BankDetails bank2=new (1234,123456789L,"Parvathy","Inactive");


bank2.WelcomeMessage();
//bank2.WelcomeMessage("Parvathy");
Console.WriteLine("1.Custid 2.Accno 3.Name");
int choice=Convert.ToInt32(Console.ReadLine());

switch(choice)
{
    case 1:
        Console.WriteLine("Custid : ");
        bank2.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
        break;

    case 2:
        Console.WriteLine("Accno : ");
        bank2.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
        break;

    case 3:
        Console.WriteLine("Name : ");
        bank2.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
        break;

    default:Console.WriteLine("Enter between 1-3");
        break;
}
bank2.ExitMessage();*/

//NGC nGC =new NGC();
//nGC.ArrayListHandling();
//nGC.Stackhandling();
//nGC.Queuehandling();
//nGC.HThandling();
//nGC.SLHandling();
//Basic_Programs.GC gc = new();
//gc.ListHandling();
//gc.Stackhandling();
//gc.Dicthandling();

/*ExceptionHandling exceptionHandling = new(10,150);
try
{
    exceptionHandling.NumCheck();
}
catch(Num1Exception ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    exceptionHandling.NumCheckOne();
}
catch (Num2Exception ex)
{
    Console.WriteLine(ex.Message);
}*/
/*
try
{

    excep.Divide();


}
catch (ArithmeticException ex)
{
    Console.WriteLine(MyExceptions.expmesslist[1]);
    // Console.WriteLine(ex.Source); //namespace
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(MyExceptions.expmesslist[2]);
}
catch (Exception ex)  //if this is given at the top the individual exceptions will not be catched.
{
    Console.WriteLine(MyExceptions.expmesslist[3]);
}
finally
{
    Console.WriteLine("Done");
}
*/
//excep.NumCheck();

//FileOperations fo= new FileOperations();
//fo.CreateFile();
//fo.WriteData();
//fo.ReadData();
//fo.CopyMoveFile();g3
//fo.DeleteFile();
//fo.FileProperties();

/*GenericEx<int> g1 = new GenericEx<int>(10, 20);
Console.WriteLine(g1.Val1 + " " + g1.Val2);

GenericEx<double> g2 = new GenericEx<double>(10.44545, 20.1233);
Console.WriteLine(g2.Val1 + " " + g2.Val2);

GenericEx<string> g3 = new GenericEx<string>("Hai", "Hello !");
Console.WriteLine(g3.Val1 + " " + g3.Val2);

GenericEx<bool> g4 = new GenericEx<bool>(true, false);
Console.WriteLine(g4.Val1 + " " + g4.Val2);
*/

/*GenericEx<int> ga = new (new int[3] { 10, 20, 30 });
//Console.WriteLine (ga.Arr);
ga.Disp();*/


/*static void Swap<T>(ref T num1, ref T num2)
{
    T temp;
    temp = num1;
    num1 = num2;
    num2 = temp;
}
int n1 = 10, n2 = 20;
char c1 = 'A', c2 = 'B';

Swap<int>(ref n1, ref n2);
Swap<char>(ref c1, ref c2);

Console.WriteLine("a={0},b={1}",n1,n2);
Console.WriteLine("c={0}, d={1}", c1, c2);
*/


//DeligateEx.cs

//public delegate void Del1(string mesg);
//public delegate void Del2(int n1,int n2);
//class Program
//{
//    public static void Main(string[] args)
//    {

//        Del1 dobj1 = DelegateEx.MethodA;
//        dobj1("Hello there !");

//        DelegateEx delEx = new();
//        Del2 dobj2 = delEx.Add;
//        dobj2(10, 20);

//        Del2 dobj3 = delEx.Sub;
//        dobj3(10, 20);
//    }
//}


using System;

class CustomStack<T>
{
    private T[] stackArray;
    private int top;
    private int maxSize;

    public CustomStack(int size)
    {
        maxSize = size;
        stackArray = new T[maxSize];
        top = -1;
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == maxSize - 1;
    }

    public void Push(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack is full. Cannot push.");
            return;
        }
        stackArray[++top] = item;
        Console.WriteLine($"Pushed: {item}");
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot pop.");
            return default(T);
        }
        T poppedItem = stackArray[top--];
        Console.WriteLine($"Popped: {poppedItem}");
        return poppedItem;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot peek.");
            return default(T);
        }
        return stackArray[top];
    }
}

//class Program
//{
//    static void Main()
//    {
//        CustomStack<int> stack = new CustomStack<int>(5);

//        stack.Push(1);
//        stack.Push(2);
//        stack.Push(3);

//        var topItem = stack.Peek();
//        Console.WriteLine($"Top item: {topItem}");

//        stack.Pop();
//        stack.Pop();
//        stack.Pop();
//        stack.Pop(); // Trying to pop from an empty stack

//        stack.Push(4);
//    }
//}




//class CustomQueue<T>
//{
//    private T[] queueArray;
//    private int front;
//    private int rear;
//    private int maxSize;

//    public CustomQueue(int size)
//    {
//        maxSize = size;
//        queueArray = new T[maxSize];
//        front = -1;
//        rear = -1;
//    }

//    public bool IsEmpty()
//    {
//        return front == -1;
//    }

//    public bool IsFull()
//    {
//        return (rear == maxSize - 1 && front == 0) || (rear + 1 == front);
//    }

//    public void Enqueue(T item)
//    {
//        if (IsFull())
//        {
//            Console.WriteLine("Queue is full. Cannot enqueue.");
//            return;
//        }
//        if (rear == maxSize - 1)
//        {
//            rear = 0;
//        }
//        else
//        {
//            rear++;
//        }
//        queueArray[rear] = item;

//        if (front == -1)
//        {
//            front = 0;
//        }
//        Console.WriteLine($"Enqueued: {item}");
//    }

//    public T Dequeue()
//    {
//        if (IsEmpty())
//        {
//            Console.WriteLine("Queue is empty. Cannot dequeue.");
//            return default(T);
//        }

//        T dequeuedItem = queueArray[front];

//        if (front == rear)
//        {
//            front = rear = -1;
//        }
//        else if (front == maxSize - 1)
//        {
//            front = 0;
//        }
//        else
//        {
//            front++;
//        }
//        Console.WriteLine($"Dequeued: {dequeuedItem}");
//        return dequeuedItem;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        CustomQueue<int> queue = new CustomQueue<int>(5);

//        queue.Enqueue(1);
//        queue.Enqueue(2);
//        queue.Enqueue(3);

//        queue.Dequeue();
//        queue.Dequeue();
//        queue.Dequeue();
//        queue.Dequeue(); // Trying to dequeue from an empty queue

//        queue.Enqueue(4);
//        queue.Enqueue(5);
//    }
//};


class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

class CustomLinkedList<T>
{
    private Node<T> head;

    public CustomLinkedList()
    {
        head = null;
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public void AddNode(T data)
    {
        var newNode = new Node<T>(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Console.WriteLine($"Added: {data}");
    }

    public bool RemoveNode(T data)
    {
        if (IsEmpty())
        {
            Console.WriteLine("List is empty. Cannot remove.");
            return false;
        }

        if (head.Data.Equals(data))
        {
            head = head.Next;
            Console.WriteLine($"Removed: {data}");
            return true;
        }

        var current = head;
        while (current.Next != null)
        {
            if (current.Next.Data.Equals(data))
            {
                current.Next = current.Next.Next;
                Console.WriteLine($"Removed: {data}");
                return true;
            }
            current = current.Next;
        }
        Console.WriteLine($"Data not found: {data}");
        return false;
    }

    public void DisplayList()
    {
        if (IsEmpty())
        {
            Console.WriteLine("List is empty.");
            return;
        }

        var current = head;
        Console.Write("List: ");
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        CustomLinkedList<int> linkedList = new CustomLinkedList<int>();

        linkedList.AddNode(1);
        linkedList.AddNode(2);
        linkedList.AddNode(3);

        linkedList.RemoveNode(2);
        linkedList.RemoveNode(4); // Trying to remove a non-existent node

        linkedList.DisplayList();
    }
}









