namespace Ex5;

class Program
{
    static void Main(string[] args)
    {
        Test1();
    }

    static void Test1()
    {
        Console.WriteLine($"\n////// Test class: Point \\\\\\\\\\\\");
        Point p1 = new Point();
        Point p2 = new Point(5.2, 2.1);
        p1.Show();
        p2.Show();
        
        Console.WriteLine($"\n////// Test class: Line \\\\\\\\\\\\");
        Line l1 = new Line(p1, p2);
        l1.Show();
        double dtr = l1.Dlina();
        Console.WriteLine($"Dlina l1: {dtr:f2}");
    }
}
