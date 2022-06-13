void returnsqrs(int num)
{
    for(int i = 1; i<num; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}
Console.Write(Math.Pow(num, 3) + ". ");
}

Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
returnsqrs(num);