﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSample<string> dss = new DataSample<string>("Forty-two");
            DataSample<int> dsi = new DataSample<int>(42);

            String s = dss.GetData();
            int i = dsi.GetData();

            Console.WriteLine(String.Format("s={0}, i={1}", s, i));

            String[] words = { "C++", "MacOS", "C#", "Android", "Python" };
            String middle = DataSample<string>.getMiddleElement(words);

            Console.WriteLine(middle);

            ListOfObjects<string> list = new ListOfObjects<string>();
            list.AddObject("Forty-two");
            list.AddObject("Twenty-one");
            list.AddObject("Three");
            list.AddObject("Sixty-six");
            list.AddObject("Twenty");
            list.AddObject("Ten");
            list.AddObject("Fifty-five");
            list.AddObject("Twenty-three");
            list.AddObject("Twelve");
            list.AddObject("Eleven");
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(list.GetObject(index));
            }
            Console.ReadKey();
        }
    }
}
