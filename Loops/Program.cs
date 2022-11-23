string[] krediler = new string[7];
krediler[0] = "Kredi 1";
krediler[1] = "Kredi 2";
krediler[2] = "Kredi 3";
krediler[3] = "Kredi 4";
krediler[4] = "Kredi 5";
krediler[5] = "Kredi 6";
krediler[6] = "Kredi 7";

for (int i = 0; i < krediler.Length; i++)
{
    Console.WriteLine(krediler[i]);
}
Console.WriteLine("===========================");
foreach(string kredi in krediler)
{
    Console.WriteLine(kredi);
}
Console.WriteLine("===========================");

int sayac = 0;
while(sayac < krediler.Length)
{
    Console.WriteLine(krediler[sayac]);
    sayac++;
}
Console.WriteLine("===========================");
do
{
    Console.WriteLine(krediler[0]);
} while (sayac < 0);
Console.ReadLine();