public class Program
{
    public static void Main(string[] args)
    {
        //ex-1
        Car obj = new Car("Audi", 2023, 1300.22f);
        obj.CarDetails();


        //ex-2
        BankAccount accObj = new BankAccount("127687347983", 26387);

        accObj.Deposite(30000);
        accObj.Withdraw(10000);
        accObj.Total_Balance();

        //ex-3
        Rectangle recObj = new Rectangle(60, 20);
        recObj.CalculateArea();

        //ex-4
        Circle areaObj = new Circle(27);
        areaObj.CalculateArea();

        //ex-5
        Student stdObj = new Student("John Doe", 20, "Computer");
        stdObj.Introduce();

        //ex-6
        Stack<int> stackObj = new Stack<int>();
        stackObj.Push(3);
        stackObj.Push(5);
        stackObj.Push(8);
        stackObj.Pop();
        stackObj.Peek();
        stackObj.isEmpty();

        //ex-7
        Calendar calendar = new Calendar();

        calendar.PrintWeekdays();

        //ex-8
        Point2D pointA = new Point2D { x = 4.0f, y = 9.0f };
        Point2D pointB = new Point2D { x = 6.0f, y = 3.0f };


        float distance = Calculating_distance.CalculateDistance(pointA, pointB);


        Console.WriteLine($"Distance between Point A and B: {distance}");
    }


}