using System.Diagnostics;
using System.Security.Cryptography;

namespace C__Methods_Default_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Verilmiş ədədi kvadratına yüksəldən metod. (Metodu cağırdıqdan sonra variable kvadratına yüksəlmiş olmalıdı)
            //2.Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod
            //3.Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable - mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.
            //4.Parameter olaraq integer array variable-i ve bir integer value qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod. Misal üçün int[] nums = { 1, 5, 7 } deyə bir variable - mız var.yazdığımız metodu çağırıb arqument olaraq nums və 3 göndərsək nums arrayının dəyəri  { 1,5,7,3} olmalıdır.

            //Optional
            //1)Verilmiş n ədədinin 3 - ə və 7 - ə bölünüb - bölünməməsini tapın.
            //2)Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin sayini tapin.
            //3)Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin cemini tapin.
            //4)Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
            //5)Verilmish arrayin icindeki cut ededlerin cemini tapin.

            #region Task1 
            Console.Write("Please enter your number: ");
            int square = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your number square is: {SquareOfNumber(square)}");
            #endregion

            #region Task2
            Console.Write("Please enter array length: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] numbers = GetArrayFromUser(arrayLength);
            int[] squared = ArrayNumbersSquare(numbers);

            PrintArray(squared);

            #endregion

            #region Task3

            Console.Write("Please enter a sentence for delete any space: ");
            string word = Console.ReadLine();
            Console.WriteLine($"Your word without space is: {DeleteSpace(word)}");

            #endregion

            #region Task4

            int[] newArray = {1,2,3,4,4,5};

            Console.WriteLine("Updated array: ");
            foreach (var item in UpdateArray(10,newArray))
                Console.WriteLine(item);

            #endregion


            //Optional
            #region Task1

            Console.Write("Please enter a natural number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            CheckNumber(num);

            #endregion

            #region Task2
            Console.Write("Please enter first number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter first number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Odd number count is: {CountOddNumBetweenNAndM(n, m)}");

            #endregion

            #region Task3

            Console.Write("Please enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter first number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Odd number count is: {SumOddNumBetweenNAndM(a, b)}");

            #endregion

            #region Task4

            Console.Write("Please enter number for find prime or composite: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PrimeOrComposite(c) ? "Your number is prime" : "Your number is composite");

            #endregion

            #region Task5
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"Sum of even numbers in array: {SumOfEvenNumbers(arr)}");

            #endregion
        }
        #region Task1
        public static int SquareOfNumber(int x)
        {
            while (x <= 0)
            {
                Console.Write("Your number should be natural number: ");
                x = Convert.ToInt32(Console.ReadLine());
            }
            return x*x;
        }

        #endregion

        #region Task2

        public static int[] ArrayNumbersSquare(int[] input)
        {
            int[] squared = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
                squared[i] = input[i] * input[i];
            return squared;

        }
        public static int[] GetArrayFromUser(int length)
        {
            int[] arr = new int[length];
            int num;
            for (int i = 0; i < length; i++)
            {
                do
                {
                    Console.Write("Please enter natural number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    arr[i] = num;
                }
                while (num <= 0);
            }
            return arr;
        }
        public static void PrintArray(int[] arr)
        {
            
            foreach (var item in arr)
            {
                Console.Write("Squared numbers: ");
                Console.WriteLine(item);
            }
        }

        #endregion

        #region Task3

        public static string DeleteSpace(string str)
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    result += str[i];
                }
            }
            return result;
        }

        #endregion

        #region Task4

        public static int[] UpdateArray(int value,  int[] arr)
        {
            int[] result = new int[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i];
               
            }
            result[^1] = value;
            return result;
        }

        #endregion

        //Optional
        #region Task1

        public static void CheckNumber(int num)
        {
            if(num <= 0)
            {
                Console.WriteLine("Your number should be natural.");
            }
            else if(num % 21 == 0)
            {
                Console.WriteLine("Your number is divisible by 3 and 7");
            }
            else
            {
                Console.WriteLine("Your number is not divisible by 3 and 7");
            }
        }

        #endregion

        #region Task2

        public static int CountOddNumBetweenNAndM(int n, int m)
        {
            int count = 0;
            if (n > m)
            {
                return 0;
            }
            else if (n < 0 && m < 0)
            {
                return 0;
            }
                for (int i = n; i < m; i++)
                {
                    if (i % 2 == 1)
                    {
                        count++;
                    }
                }
            return count;
        }

        #endregion

        #region Task3

        public static int SumOddNumBetweenNAndM(int n, int m)
        {
            int sum = 0;
            if (n > m)
            {
                return 0;
            }
            else if (n < 0 && m < 0)
            {
                return 0;
            }
            for (int i = n; i < m; i++)
            {
                if (i % 2 == 1)
                {
                    sum+=i;
                }
            }
            return sum;
        }

        #endregion

        #region Task4

        public static bool PrimeOrComposite(int a)
        {
            if (a < 2)
                return false;

            if (a == 2)
                return true;

            if (a % 2 == 0)
                return false;

            for (int i = 3; i * i <= a; i += 2)
            {
                if (a % i == 0)
                    return false;
            }

            return true;
        }

        #endregion

        #region Task5
        public static int SumOfEvenNumbers(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0) 
                {
                    sum+= array[i];
                }
            }
            return sum;
        }

        #endregion
    }
}
