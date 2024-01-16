namespace TopSystemGeometricShapes;

public class Ellipse(int semiMajorAxis, int semiMinorAxis) : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing an ellipse with semi-major axis {semiMajorAxis} and semi-minor axis {semiMinorAxis}");
        for (var i = -semiMinorAxis; i <= semiMinorAxis; i++)
        {
            for (var j = -semiMajorAxis; j <= semiMajorAxis; j++)
            {
                Console.Write(i * i * semiMajorAxis * semiMajorAxis + j * j * semiMinorAxis * semiMinorAxis <=
                              semiMajorAxis * semiMajorAxis * semiMinorAxis * semiMinorAxis
                    ? "*"
                    : " ");
            }
            Console.WriteLine();
        }
    }
}