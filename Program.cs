using System;
using System.Diagnostics;
using System.Text;

namespace ASUTP
{
    class 
        Program
    {

        static void Main()
        {
            bool c = true;
            void ASCII() { //Задание 1

                Console.WriteLine("Insert ASCII symbol");
                string hexValue = Console.ReadLine();
                string value = ((char)Convert.ToInt64(hexValue, 16)).ToString();
                Console.WriteLine(value);
            }

            void BiggestInString() { //Задание 2
                int max = 0;
                Console.WriteLine("Insert Number");
                string value = Console.ReadLine();
                char[] subs = value.ToCharArray();
                for (int i = 0; i < subs.Length; i++)
                {
                    if (Convert.ToInt32(subs[i]) > max)
                    {
                        max = Convert.ToInt32(subs[i]);
                    }
                }
                Console.WriteLine(((char)max).ToString());
            }

            void FindBiggestNumber() { //Задание 3
                int[] arr = new int[10];
                int max = 0;
                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(-15, 14);
                    if (arr[i] > max)
                        max = arr[i];
                }
                for (int j = 0; j<arr.Length;j++)
                {
                    if (max <= 0)
                        Console.WriteLine(arr[j]);

                    else if (arr[j] * -1 > max)
                        Console.WriteLine(arr[j]);
                    
                }


                
            }

            void NumbersRazryad()
            {
                Console.WriteLine("Insert Number");
                string value = Console.ReadLine();
                int ValueNumber = Convert.ToInt32(value);
                int counter = 0;
                while (ValueNumber > 0)
                {
                    ValueNumber /= 10;
                    counter++;
                }
                Console.WriteLine(counter);
            }

            void NumbersSum()
            {
            int sum = 0;
            string value = "1";
            while (value != "") {
                        Console.WriteLine("Insert Number");
                        value = Console.ReadLine();
                        if (value != "")
                        {
                            sum += Convert.ToInt32(value);
                        } 
            }
            Console.WriteLine(sum);
            }
            
            while (c)
            {
                Console.WriteLine("Choose task:");
                Console.WriteLine("1.ASCII converter \n2.Find Biggest number in string \n3.Array numbers \n4.Number digit \n5. Sum of numbers \n0.Exit");
                string value = Console.ReadLine();
                switch(value) {

                    case "1":
                        Console.Clear();
                        ASCII();
                        break;
                    case "2":
                        Console.Clear();
                        BiggestInString();
                        break;
                    case "3":
                        Console.Clear();
                        FindBiggestNumber();
                        break;
                    case "4":
                        Console.Clear();
                        NumbersRazryad();
                        break;
                    case "5":
                        Console.Clear();
                        NumbersSum();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        c = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong choose, try again");
                        break;
                }
            }
            


        }
    }
}