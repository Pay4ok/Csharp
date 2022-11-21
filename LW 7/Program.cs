using System;
using System.Collections;
using System.Collections.Generic;

namespace LW_7
{
    class Program
    {
        static int Foo(params NumericList[] _params) // First param it fromArray, second it toArray
        {
            foreach (var elem in _params[0])
            {
                _params[1].Add(elem);
            }
            return 0;
        } 
        // Example Function

        static void Main(string[] args)
        {
            {
                NumericList fromArray = new NumericList();
                NumericList list = new NumericList();
                IExecuteble<int, NumericList>.metod m = Foo;

                for (int i = 0; i < 1_000_000; i++) { fromArray.Add(i); }

                long time = IExecuteble<int, NumericList>.GetExecTime(m, fromArray, list);
                Console.WriteLine($"{time}ms, {list.Count}");
            } 
            // Example of work IExecutable<>.GetExecTime

            {
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < 20; i++)
                {
                    arrayList.Add(i + ", string");
                    Console.WriteLine(arrayList[i]);
                }

                NumericList numList = new NumericList();
                numList.AddFrom<ArrayList>(arrayList);
                Console.WriteLine("Catch test");
            }

            {
                NumericList list = new NumericList() { 10, 20, 30 };
                list.ReadFromXML("../../../objects.xml");
            }
            // Writing to XML


            List<LW_4.Confectionery> confectioneries = new List<LW_4.Confectionery>();
            confectioneries.Add(new LW_4.Candy(1,1,10,"red_candy","19.10.2020",2));
            // 4
        }
    }
}
