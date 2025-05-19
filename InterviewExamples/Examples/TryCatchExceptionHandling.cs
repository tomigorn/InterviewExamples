using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewExamples.Examples
{
    internal class TryCatchExceptionHandling
    {
        public static void Run()
        {
            try
            {
                Console.WriteLine("Start");
                DoWork();
                Console.WriteLine("After DoWork");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Cleanup done.");
            }
        }

        static void DoWork()
        {
            try
            {
                Console.WriteLine("Doing work...");
                ThrowSomething();
                Console.WriteLine("Work completed");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Caught invalid operation");
            }
        }

        static void ThrowSomething()
        {
            throw new ArgumentException("Bad input");
        }
    }
}
