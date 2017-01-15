using System;
using System.Collections.Generic;
using System.Linq;

namespace T19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "asda" };
            int LengthOfArray = words.Length;
            Random rnd = new Random();
            int random = rnd.Next(1, 3);
            char[] letters = words[random].ToCharArray();
            bool WordIsHidden = true;
            char hiddenChar = '_';
            //fix 1 use a list or hashset or similar to store the selected chars
            var guessed = new List<char>();
            var retry = true;

            while (retry = true)
            {
                Console.WriteLine(letters);
                //fix 2, loop over the letters, checking whether they have been guessed
                foreach (var c in letters)
                {
                    if (guessed.Contains(c))
                        Console.Write(c);
                    else
                        Console.Write("_");
                }
                Console.WriteLine("\nEnter a letter!");
                char letter = char.Parse(Console.ReadLine());
                if (words[random].Contains<char>(letter))
                {
                    WordIsHidden = false;
                    guessed.Add(letter);
                }
                else
                {
                    if (WordIsHidden == true)
                    {
                        guessed.Clear();
                        Console.WriteLine("You guessed wrong!");
                    }
                }
            }
            }
    }
}
/*namespace T18
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            if (temp == word) { Console.WriteLine("palindromi!!!"); }
            else { Console.WriteLine("ei ole palindromi!!!"); }
        }
    }
}

namespace T17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = new List<int>();
            List<int> numbers2 = new List<int>();
            List<int> numbersMerge = new List<int>(numbers1.Count + numbers2.Count);
            int x;
            while (true)
            {
                Console.WriteLine("luku ensimmäiseen taulukkoon: ");
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    break;
                }
                else numbers1.Add(x);
            }

            while (true)
            {
                Console.WriteLine("luku toiseen taulukkoon: ");
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    break;
                }
                else numbers2.Add(x);
            }

            numbersMerge.AddRange(numbers1);
            numbersMerge.AddRange(numbers2);

            for (int i = 0; i < numbersMerge.Count; i++)
            {
               Console.WriteLine(numbersMerge[i]);
            }
                
        }
    }
}

namespace T16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number;
            int guess;
            int times=0;
            Console.WriteLine("arvaa luku 0-100 väliltä");
            number = rnd.Next(0, 100);
            while (true)
            {
                guess = int.Parse(Console.ReadLine());
                times++;
                if (number == guess) {
                    Console.WriteLine("arvasit oikein Arvausten määrä: " + times);
                    break;
                }
                else if (number < guess) { Console.WriteLine("luku on pienempi"); }
                else if (number > guess) { Console.WriteLine("luku on suurempi"); }
            }

        }
    }
}

namespace T15
{
    class Program
    {
        static void Main(string[] args)
        {
            int heigth;
            int x;
            int a;
            int tree = 1;
            Console.WriteLine("puun korkues?");
            heigth = int.Parse(Console.ReadLine());
            x = heigth - 3;
            a = heigth - 3;
            for (int i = 0; i <= heigth-3; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y < tree; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                tree += 2;
                x -= 1;
            }
            for (int i = 0; i < 2; i++)
            {
                for (int t = 0; t < a; t++)
                {
                    Console.Write(" ");
                }
                for (int f = 0; f < 1; f++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

namespace T14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int x;
            Console.WriteLine("anna arvosanat (6 = lopetus): ");
            while (true)
            {
                x = int.Parse(Console.ReadLine());
                if (x > 5)
                {
                    break;
                }
                else numbers.Add(x);
            }

            int[] array = numbers.ToArray();

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine();
                Console.Write(i);

                for (int j = 0; j < array.Length; j++)
                {
                    if (numbers[j] == i)
                    {
                        Console.Write("*");
                    }
                }

            }

        }
    }
}

namespace T13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int sum = 0;
            Console.WriteLine("anna tyylipisteet: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            for (int i = 1; i < numbers.Length-1; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Summa: " + sum);
        }
    }
}

namespace T12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("anna viisi lukua");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}

namespace T11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("anna luku: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

namespace T10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) { Console.WriteLine("HEP"); }
            }
        }
    }
}

namespace T9
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum=0;
            float a;
            List<float> numbers = new List<float>();

            Console.WriteLine("anna lukuja, kun haluat lopettaa syötä 0");
            while (true)
            {
                Console.Write("Anna luku: ");
                a = float.Parse(Console.ReadLine());

                if (a == 0) { break; }
                else { numbers.Add(a); }

            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Summa: " + sum);
        }
    }
}

namespace T8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            Console.WriteLine("Anna kolme lukua: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine("suurin numero: " + numbers[2]);
        }
    }
}

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Anna vuosiluku: ");
            year = int.Parse(Console.ReadLine());
            year = year % 4;
            if (year == 0) { Console.WriteLine("Karkausvuosi"); }
            else { Console.WriteLine("ei ole karkausvuosi"); }
        }
    }
}

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance;
            double price = 1.595;
            double kulutus = 7.02 / 100;
            Console.WriteLine("Anna ajettu matka kilometreissä: ");
            distance = int.Parse(Console.ReadLine());
            kulutus = kulutus * distance;
            price = price * kulutus;
            Console.WriteLine("bensaa kului: {0:0.00}L bensa kustannukset: {1:0.00}e ",kulutus, price );
        }
    }
}
namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds;
            Console.WriteLine("Anna sekunttimäärä");
            seconds = int.Parse(Console.ReadLine());
            TimeSpan h = TimeSpan.FromSeconds(seconds);
            Console.WriteLine(h);
        }
    }
}

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Anna ikäsi: ");
            age = int.Parse(Console.ReadLine());
            if (age < 18) { Console.WriteLine("Alaikäinen"); }
            else if (age > 65) { Console.WriteLine("seniori"); }
            else { Console.WriteLine("Aikuinen"); }
        }
    }
}

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sum;
            Console.WriteLine("Anna kolme lukua");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            sum = a + b + c;
            Console.WriteLine("Summa: " + sum );
            sum = sum / 3;
            Console.WriteLine("Keskiarvo: " + sum);
        }
    }
}

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            while (true)
            {
                Console.WriteLine("Anna luku 0-12");
                luku = int.Parse(Console.ReadLine());
                if (luku > 12 || luku < 0)
                {
                    Console.WriteLine("Anna uusi luku");
                }
                else break;
            }
            switch (luku)
            {
                case 0:
                case 1:
                    Console.WriteLine("Numerosi: 0");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Numeosi: 1");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Numerosi: 2");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Numerosi: 3");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Numerosi: 4");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Numerosi: 5");
                    break;
            }
        }
    }
}

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            while (true)
            {
                Console.WriteLine("Anna luku 1-3");
                luku = int.Parse(Console.ReadLine());
                if (luku > 3 || luku < 1)
                {
                    Console.WriteLine("Anna uusi luku");
                }
                else break;
                }
            switch (luku)
                {
                    case 1:
                        Console.WriteLine("yksi");
                        break;
                    case 2:
                        Console.WriteLine("kaksi");
                        break;
                    case 3:
                        Console.WriteLine("kolme");
                        break;
                }
            
        }
    }
}
*/
