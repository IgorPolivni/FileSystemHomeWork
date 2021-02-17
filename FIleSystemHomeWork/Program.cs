using System;
using System.Collections.Generic;
using System.IO;

namespace FIleSystemHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Первое Задание");

            StreamReader streamReader = new StreamReader("FibonacciNumbers.txt");
            string text = streamReader.ReadToEnd();
            text = text.Trim(' ');
            var numbers = text.Split(" ");
            List<int> numbersList = new List<int>();
            foreach(var number in numbers)
            {
                numbersList.Add(int.Parse(number));
            }
            int count = numbers.Length;
            if (count >= 2) 
            {
                for (int i = 0; i < count; i++)
                {
                    numbersList.Add(numbersList[numbersList.Count-1] + numbersList[numbersList.Count - 2]);
                }
            }
            streamReader.Close();

            StreamWriter streamWriter = new StreamWriter("FibonacciNumbers.txt");
            foreach (var element in numbersList)
            {
                streamWriter.Write($"{element} ");
            }
            streamWriter.Close();
            
            Console.WriteLine("Все прошло успешно!");
            Console.ReadLine();
            Console.Clear();

            //------------------------------------------------
            Console.WriteLine("Второе задание");

            streamReader = new StreamReader("INPUT.txt");
            text = streamReader.ReadToEnd();
            text = text.Trim(' ');
            numbers = text.Split(" ");
            int sum = new int();
            foreach(var number in numbers)
            {
                sum += int.Parse(number);
            }
            streamReader.Close();

            streamWriter = new StreamWriter("OUTPUT.txt");
            streamWriter.Write(sum);
            streamWriter.Close();

            Console.WriteLine("Все прошло успешно!");
            Console.ReadLine();
            Console.Clear();



        }
    }
}
