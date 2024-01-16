namespace TopSystemGeometricShapes;

public class Rectangle(int sideA, int sideB) : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle with side A = {sideA} and side B = {sideB}");
        
        for (int i = 0; i <= sideA; i++)
        {
            for (int j = 0; j < sideB; j++)
                Console.Write(" * ");
            
            Console.WriteLine();
        }
    }
}