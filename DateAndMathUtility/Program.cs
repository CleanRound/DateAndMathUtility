public class Program
{
    public static Action DisplayCurrentTime = () => Console.WriteLine("Current Time: " + DateTime.Now.ToString("HH:mm:ss"));
    public static Action DisplayCurrentDate = () => Console.WriteLine("Current Date: " + DateTime.Now.ToString("yyyy-MM-dd"));
    public static Action DisplayCurrentDayOfWeek = () => Console.WriteLine("Current Day of the Week: " + DateTime.Now.DayOfWeek);

    public static Func<double, double, double> CalculateTriangleArea = (baseLength, height) => 0.5 * baseLength * height;
    public static Func<double, double, double> CalculateRectangleArea = (length, width) => length * width;

    public static void Main()
    {
        DisplayCurrentTime();

        DisplayCurrentDate();

        DisplayCurrentDayOfWeek();

        double triangleBase = 5.0;
        double triangleHeight = 10.0;
        double triangleArea = CalculateTriangleArea(triangleBase, triangleHeight);
        Console.WriteLine($"Area of the triangle (base={triangleBase}, height={triangleHeight}): {triangleArea}");

        double rectangleLength = 4.0;
        double rectangleWidth = 7.0;
        double rectangleArea = CalculateRectangleArea(rectangleLength, rectangleWidth);
        Console.WriteLine($"Area of the rectangle (length={rectangleLength}, width={rectangleWidth}): {rectangleArea}");
    }
}
