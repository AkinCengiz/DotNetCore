int[] numbers = { 15, 14, 13 };
if (numbers[0] > numbers[1])
{
    if (numbers[0] > numbers[2])
    {
        Console.WriteLine("En büyük sayı : {0}", numbers[0]);
        if (numbers[1] > numbers[2])
        {
            Console.WriteLine("Ortanca sayı : {0}\nEn küçük sayı : {1}", numbers[1], numbers[2]);
        }

        else
        {
            Console.WriteLine("Ortanca sayı : {0}\nEn küçük sayı : {1}", numbers[2], numbers[1]);
        }
    }
    else
    {
        Console.WriteLine("En büyük sayı : {0}\nOrtanca sayı : {1}\nEn küçük sayı : {2}", numbers[2], numbers[0],
            numbers[1]);
    }
}
else if (numbers[1] > numbers[2])
{
    Console.WriteLine("En büyük sayı : {0}", numbers[1]);
    if (numbers[0] > numbers[2])
    {
        Console.WriteLine("Ortanca sayı : {0}\nEn küçük sayı : {1}", numbers[0], numbers[2]);
    }
    else
    {
        Console.WriteLine("Ortanca sayı : {0}\nEn küçük sayı : {1}", numbers[2], numbers[0]);
    }
}
else
{
    Console.WriteLine("En büyük sayı : {0}\nOrtanca sayı : {1}\nEn küçük sayı : {2}", numbers[2], numbers[1],
        numbers[0]);
}

Console.ReadLine();
