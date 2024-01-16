namespace TopSystemGeometricShapes;

public class Square(int sideLength) : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a square with side length {sideLength}");

        for (int i = 0; i <= sideLength; i++)
        {
            for(int j = 0; j <= sideLength; j++)
                Console.Write(" * ");
            
            Console.WriteLine();
        }
    }
}