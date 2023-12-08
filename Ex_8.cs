public struct Point2D
{
    public float x { get; set; }
    public float y { get; set; }
}

public class Calculating_distance
{
    public static float CalculateDistance(Point2D pt1, Point2D pt2)
    {
        float distX = pt2.x - pt1.x;
        float distY = pt2.y - pt1.y;

        float Eculidean_distance = (float)Math.Sqrt(distX * distX+ distY * distY);
        return Eculidean_distance;
    }
}