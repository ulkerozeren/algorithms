using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            //Console.WriteLine("n değerini giriniz: ");
            //string value = Console.ReadLine();

            //int.TryParse(value, out int n);

            //Console.WriteLine("isim ve soyisim giriniz: ");
            //string nameSurname = Console.ReadLine();

            // RepeatStringNTimes(nameSurname, n);

            //int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            //OrderArray(arr);

            // ReverseString("ulker");

            //Question4();


          //  DaysOfWeek();



            Console.ReadLine();

            
        }


        public static void DaysOfWeek()
        {
            DateTime now = DateTime.Today;
           
            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(now.ToString("dddd") + "(bugün)");
                }
                else
                {
                    Console.WriteLine(now.ToString("dddd"));
                }
                now = now.AddDays(1);
            }
        }


        public static void Question4()
        {
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            int[] newarr = new int[4];
            int i = 0;

            for ( i = 0; i < 2; i++)
            {
                newarr[i] = arr[i];
            }


            int x = arr.Length - 1;

            for (int j = x; j > 3; j--)
            {
               newarr[i]= arr[j];
                i++;
            }

            for (int j = 0; j < newarr.Length; j++)
            {
                Console.Write(newarr[j]);

            }
        }


        public static void ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            string reverString = new string(arr);
            Console.Write(reverString);
        }

        public static void RepeatStringNTimes(string nameSurname, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(nameSurname+ " ");
            }
        }

        public static void OrderArray(int[] arr)
        {
            Array.Sort(arr);
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }        

        }

    }
}
