namespace TopSystemGeometricShapes;

public class Triangle(int rows, TriangleType type) : Shape
{
    private void PrintRightAngleTriangle(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
                
            Console.WriteLine();
        }
    }

    private void PrintLeftAngleTriangle(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = rows; j > i; j--)
                Console.Write(" ");

            for (int k = 1; k <= i; k++)
                Console.Write("*");

            Console.WriteLine();
        }
    }

    private void PrintIsoscelesTriangle(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - i - 1; j++)
                Console.Write(" ");

            for (int k = 0; k < 2 * i + 1; k++)
                Console.Write("*");

            Console.WriteLine();
        }
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a triangle with type: {type.ToString()} and {rows} rows");
        
        switch (type)
        {
            case TriangleType.RightAngle:
                PrintRightAngleTriangle(rows);
                return;
            
            case TriangleType.LeftAngle:
                PrintLeftAngleTriangle(rows);
                return;
            
            case TriangleType.Isosceles:
                PrintIsoscelesTriangle(rows);
                return;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }
    }
}

public enum TriangleType
{
    RightAngle,
    LeftAngle,
    Isosceles
}
