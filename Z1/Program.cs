void checknum(int num)
{
    if(num<100000 && num>9999)
    {
    if(num%10 == num/10000 && (num/1000)%10 == (num/10)%10)
    {
        Console.Write("Yes");
    }
    else
    {
        Console.Write("No");
    }
    }
else
{
    Console.Write("Error. Incorrect number");
}

}

Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());

checknum(num);