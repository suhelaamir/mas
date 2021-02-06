using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class ExceptionCheck
    {
        public static void CalculateMehotd()
        {
            try
            {
                double result = 0, a = 98, b = 0 ;
                result = GiveSomeError(a, b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                try
                {
                    throw new Exception("love");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
        private static double GiveSomeError(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }
    }
}
