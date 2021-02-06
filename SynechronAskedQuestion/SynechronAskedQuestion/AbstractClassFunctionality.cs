using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    //  If you want the abstract method to be invoked automatically whenever an instance of the class that is derived from the abstract class is created, 
    //  then we would call it in the constructor of the abstract class. 
    //  1. If the "finally" block is being executed after an exception has occurred in the try block, 
    //  2. and if that exception is not handled
    //  3. and if the finally block throws an exception
    //  Then the original exception that occurred in the try block is lost.
    public abstract class AbstractClassFunctionality
    {
        protected AbstractClassFunctionality()
        {
            try
            {
                Print();
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString();
            }
        }
        public abstract void Print();
    }
    public class CorporateCustomer : AbstractClassFunctionality
    {
        public override void Print()
        {
            try
            {
                Console.WriteLine("This is Corporate Customer");
                throw new Exception("try block error message.");
            }
            catch (Exception ex)
            {
                throw new Exception("throws catch block error.");
            }
            finally
            {
                throw new Exception("finally block throws an error.");
            }
        }
    }
    public class SavingCustomer : AbstractClassFunctionality
    {
        public override void Print()
        {
            string doreversString = "Amir Suhel";
            string reversedString = string.Join(" ", doreversString.Split(' ').Select(x => new string(x.Reverse().ToArray())));
            Console.WriteLine(reversedString);
        }
    }
}
