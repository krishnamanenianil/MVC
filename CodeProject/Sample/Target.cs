﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Target
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