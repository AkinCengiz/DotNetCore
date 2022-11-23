using System.ComponentModel;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            //matematik.Topla(5, 7);
            int sonuc = matematik.Topla(3, 5);
            int sonuc2 = matematik.Topla(1, 2, 3, 4, 5, 6);
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
        }
    }

    class Matematik
    {
        //public void Topla(int number1, int number2)
        //{
        //    Console.WriteLine(number1 + number2);
        //}
        public int Topla(int number1, int number2=100)
        {
            return number2 + number1;
        }

        public int Topla(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        public int Topla(params int[] numbers)
        {
            int sonuc = 0;
            foreach (int number in numbers)
            {
                sonuc += number;
            }

            return sonuc;
        }
        public int Cikar(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}