public class Car
{
    private string brand;
    private int year;
    private float price;


    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }

    public void CarDetails()
    {
        Console.WriteLine("The car's brand is " + brand);
        Console.WriteLine("The model year is " + year);
        Console.WriteLine("The price of the car is Rs " + price);

    }
}