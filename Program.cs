int sum;
do
{
    sum = 0;
    System.Console.WriteLine("please enter x");
    int x = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("please enter y");
    int y = Convert.ToInt32(Console.ReadLine());
    for (var i = 1; i <= y; i++)
    {
        sum = sum + x;

    }
    System.Console.WriteLine(sum);
} while (sum != 0);

