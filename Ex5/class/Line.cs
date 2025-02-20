public class Line
{
    private Point pStart;
    private Point pEnd;

    public Line(Point pStart, Point pEnd) 
    {
        this.pStart = pStart;
        this.pEnd = pEnd;
    }

    public Line() {}

    public void Show()
    {
        Console.WriteLine($"Line with coordinates: {{{pStart}}} {{{pEnd}}}");
    }

    public double Dlina()
    {
        return pStart.Dlina(pEnd);
    }
}