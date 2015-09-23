using System;

namespace Sample
{
    public class Target1
    {
        public static void DoSomething()
        {
            try
            {
                Console.WriteLine("I ran!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DoSomething1()
        {
            try
            {
                Console.WriteLine("I ran!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}