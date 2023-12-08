﻿public class Rectangle
{
    private float length;
    private float width;

    public Rectangle(float l, float w)
    {
        this.length = l;
        this.width = w;
    }

    public float CalculateArea()
    {
        var Area = length * width;
        Console.WriteLine(" The area of the rectangle is" + Area);
        return Area;
    }
}