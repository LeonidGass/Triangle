using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_Reading_2
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(@"e:\file.txt");
            int counter = 0;
            string line;
            String s;

            while ((line = sr.ReadLine()) != null)//
                counter++;                        //count lines
            sr.Close();                           //
            
            sr = new StreamReader(@"e:\file2.txt");

            int[,] mas = new int[counter, counter];
                   for (int i = 0; i < counter; i++)
                   {
                       s = sr.ReadLine();
                       var result = s.Split(new[] { ' ' });

                       for (int j = 0; j <= i; j++)
                       {
                           mas[i, j] = Int32.Parse(result[j]); 
                       }
                   }

                   int sum;
                   for (int i = counter - 2; i >= 0; i--)
                   {
                     for (int j = 0; j <= i; j++)
                       {
                           sum = -12414421;
                           if (j - 1 >= 0) if (sum < (mas[i, j] + mas[i + 1, j - 1])) sum = mas[i, j] + mas[i + 1, j - 1]; //down-left
                           if (sum < (mas[i, j] + mas[i + 1, j])) sum = mas[i, j] + mas[i + 1, j]; // down
                           if (sum < (mas[i, j] + mas[i + 1, j + 1])) sum = mas[i, j] + mas[i + 1, j + 1]; // down-right
                           mas[i, j] = sum;
                       }
                   }

                   Console.WriteLine(mas[0,0]);
                   
            
            Console.ReadKey();
        }
    }
}
