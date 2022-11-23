string[] cities = new string[] { "İstanbul", "İzmir", "Ankara" };
Console.WriteLine(cities.Length);
foreach (string city in cities)
{
    Console.WriteLine(city);
}

List<string> cities2 = new List<string>();
cities2.Add("İstanbul");
cities2.Add("Ankara");
cities2.Add("İzmir");
Console.WriteLine("=====================");
foreach (string city in cities2)
{
    Console.WriteLine(city);
}