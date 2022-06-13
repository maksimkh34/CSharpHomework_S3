Console.Clear();

int[] ReadPoint(string point)
{
    int[] result = {0, 0, 0};

    Console.WriteLine($"Coordinates of point {point}. ");

    Console.Write("X: ");
    result[0] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Y: ");
    result[1] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Z: ");
    result[2] = Convert.ToInt32(Console.ReadLine());

    return result;
}

double findlength(int[] pointA, int[] pointB)
{
    return Math.Round(Math.Sqrt(Math.Abs(Math.Pow(pointA[0]-pointB[0], 2)+Math.Pow(pointA[1]-pointB[1], 2)+Math.Pow(pointA[2]-pointB[2], 2))), 2);
}
int[] pointA = ReadPoint("A");
int[] pointB = ReadPoint("B");

Console.WriteLine("Result: " + findlength(pointA, pointB));