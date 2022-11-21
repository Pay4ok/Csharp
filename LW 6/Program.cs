using System;
using System.Data;
using System.Diagnostics;
using LW_4;

namespace LW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ConfectioneryTypeException("First exception");
            }
            catch (ConfectioneryTypeException e)
            {
                Console.WriteLine(e.Message + "\n");
                //throw new Exception("Second exception");
            }  

            try
            {
                Confectionery confectionery = new Confectionery(
                    1, 50, 10, "coockie", "10.10.2022", 2);  // type exception

                try
                {
                    Confectionery confectionery1 = new Confectionery(
                        1, 50, 10, "coockie", "10.10.2022", 1);
                    try
                    {
                        Confectionery confectionery2 = new Confectionery(
                            10, 50, 10, "coockie", "10.10.2022", 2);  // type exception
                    }
                    catch (IndexOutOfRangeException) { }
                }
                catch (Exception e) { Console.WriteLine($"Im catch your exception : )\n{e.Message}\n{e.StackTrace}\n"); }
            }
            catch (ConfectioneryTypeException ex)
            {
                Console.WriteLine($"\nWe catch our exception: {ex} \n");
            }
            finally
            {
                Console.WriteLine("Finally block\n");
            }


            Product producе1 = new Product(
                10, new string('s', 100), "10.10.2022", 5); // length exception

            //Debug.Write(producе1);
            //Debug.WriteLine(producе1);
            //Debugger.Launch();
            Debugger.Break();
            Console.WriteLine("Programm still alive");


            Product product2 = new Product(
                20, new string('s', 10), "10.10.2022", 10); // guarantee period exception

            int a = 10;
            Debug.Assert(a >= 10, "ERROR");
        }
    }
}
