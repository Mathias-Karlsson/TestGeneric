using System;
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
            Console.ReadKey();
        }
    }
}
