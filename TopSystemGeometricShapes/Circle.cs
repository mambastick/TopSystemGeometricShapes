namespace TopSystemGeometricShapes;

public class Circle(int radius) : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {radius}");
        
        var rIn = radius - 0.4;
        var rOut = radius + 0.4;
 
        for (double y = radius; y >= -radius; --y)
        {
            for (double x = -radius; x < rOut; x += 0.5)
            {
                var value = x * x + y * y;
                if (value >= rIn * rIn && value <= rOut * rOut)
                {
                    Console.Write("*");
                }
                else if (value < rIn * rIn && value < rOut * rOut)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
 
            Console.WriteLine();
        }
    }
}