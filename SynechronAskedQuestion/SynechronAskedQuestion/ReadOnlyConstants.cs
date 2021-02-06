using System;
using System.Configuration;

namespace SynechronAskedQuestion
{
    /// <summary>
    /// https://www.c-sharpcorner.com/UploadFile/0c1bb2/read-only-and-constant-in-C-Sharp/
    /// const fields has to be initialized while declaration only, while readonly fields can be initialized at declaration or in the constructor.
    /// const variables can declared in methods ,while readonly fields cannot be declared in methods.
    /// const fields cannot be used with static modifier, while readonly fields can be used with static modifier.
    /// const field is a compile-time constant, the readonly field can be used for run time constants.
    ///We can use Readonly, when value is not absolute constant
    ///means which can be changed frequently,like dollar vs INR ,in this requirement we can set the value through configuration file or another variable expression so we can avoid to change class file frequently.
    /// </summary>
    public sealed class ReadOnlyConstants
    {
        public static readonly string r= ConfigurationManager.AppSettings["DallorPrice"];
        readonly int a;
        const int b = 100;
        int c = 11;
        readonly string dallar;
        public ReadOnlyConstants()
        {
            const int h= 5;
            Console.WriteLine("r1 has value {0}", r);
            dallar = ConfigurationManager.AppSettings["DallorPrice"];
            Console.WriteLine("r has value {0}", dallar);
            a = b + c;
            Console.WriteLine("a has its value {0} and {1}", a, h);
            //Console.Readline();();
        }

    }
}
