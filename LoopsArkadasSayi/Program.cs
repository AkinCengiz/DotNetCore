int number1, number2;
Console.WriteLine("İlk sayıyı giriniz : ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz : ");
number2 = Convert.ToInt32(Console.ReadLine());


int pozitifBolen1 = 0, pozitifBolen2 = 0;
for (int i = 1; i <= number1 / 2; i++)
{
    if (number1 % i == 0)
    {
        pozitifBolen1 += i;
    }
}

for (int i = 1; i <= number2 / 2; i++)
{
    if (number2 % i == 0)
    {
        pozitifBolen2 += i;
    }
}

if (number1 == pozitifBolen2 && number2 == pozitifBolen1)
{
    Console.WriteLine("{0} sayısı ile {1} sayısı arkadaş sayıdır...",number1,number2);
}
else
{
    Console.WriteLine("{0} sayısı ile {1} sayısı arkadaş sayı değildir...", number1, number2);
}
