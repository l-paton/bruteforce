using CommandLine;
using System;

namespace BruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Parser.Default.ParseArguments<Options>(args).MapResult((Options opts) => Options.Attack(opts), errs => 1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }
    }
}
