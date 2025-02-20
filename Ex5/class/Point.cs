public class Point
{
    private double x;
    private double y;
    
    public Point(double x, double y) 
    {
        this.x = x;
        this.y = y;
    }

    public Point() {}

    public void Show()
    {
        Console.WriteLine($"Point with coordinate: {{{x}, {y}}}");
    }

    public double Dlina(Point p)
    {
        double result = Math.Sqrt((this.x - p.x) * (this.x - p.x) + (this.y - p.y) * (this.y - p.y));
        return result;
    }

    public override string ToString()
    {
        return x + " ; " + y;
    }
}