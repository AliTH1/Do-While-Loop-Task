#region Task
while (true)
{
    Console.Write("Reqem daxil edin: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 10 && num < 20)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("Cut ededdir");
        }
        else
        {
            Console.WriteLine("Tek ededdir");
        }
    }
    else
    {
        break;
    }
}
#endregion