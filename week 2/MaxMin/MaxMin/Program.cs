﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        static void f1()
        {
            FileStream fs = new FileStream(@"c:\test\file new.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);


            string s = sr.ReadLine(); // "1 2 3 4 5 6 7"
            string[] arr = s.Split(); // ["1", "2", "3", "4", "5", "6", "7"];


            int maxi = int.Parse(arr[0]);

            for (int i = 0; i < arr.Length; i++)
            {
                int t = int.Parse(arr[i]);
                if (t > maxi)
                {
                    maxi = t;
                }

              
            }
                Console.Write(maxi);

                sr.Close();
                fs.Close();

                Console.ReadKey();
            
        }

        static void f2()
        {
            FileStream fs = new FileStream(@"c:\test\file new.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);


            string s = sr.ReadLine(); // "1 2 3 4 5 6 7"
            string[] arr = s.Split(); // ["1", "2", "3", "4", "5", "6", "7"];

            int mini = int.Parse(arr[0]);

            for (int i = 0; i < arr.Length; i++)
            {
                int t = int.Parse(arr[i]);
                if (t < mini)
                {
                    mini = t;
                }

              
            }
            Console.Write(mini);

            sr.Close();
            fs.Close();

            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            f1();
        }
    }
}