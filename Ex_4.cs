public class Shape
{
    public virtual int CalculateArea()
    {
        return 0;
    }

}


public class Circle : Shape
{

    public int radius;
    public Circle(int r)
    {
        this.radius = r;
    }

    public override int CalculateArea()
    {
        var Area = (int)(15 * radius * radius);
        Console.WriteLine(Area+ "is the area of the given circle.");
        return Area;
    }
}