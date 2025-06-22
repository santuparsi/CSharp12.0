﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace HandsOnMultiThreading
{
    class Demo1
    {
        public static void Task1()
        {
                for(byte b=0;b<=255;b++)
            {
                Console.Write(b + " ");
                Thread.Sleep(500);
            }
        }
        public static void Task2()
        {
            for(byte b=0;b<=255;b++)
            {
                Console.WriteLine(Convert.ToChar(b));
                Thread.Sleep(500);
            }
        }
    }
    class Test_Demo1
    {
        static void Main()
        {
            Thread t1 = new Thread(Demo1.Task1);
            Thread t2 = new Thread(Demo1.Task2);
            t1.Start();
            t2.Start();
            Console.WriteLine("Main Thread Starting...");
        }
    }

}
