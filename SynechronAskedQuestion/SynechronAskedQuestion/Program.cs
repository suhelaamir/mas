using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace SynechronAskedQuestion
{
    public class Formatters
    {
        IList<string> forMatters = new List<string>();
        public IEnumerable<string> Get()
        {
            foreach (var item in GlobalConfiguration.Configuration.Formatters)
            {
                forMatters.Add(item.ToString());
            }
            return forMatters.AsEnumerable<string>();
        }
    }
    class Atos
    {
        private int x;
        public void SetX(int i)
        {
            x = i;
        }
    }
    class BAtos : Atos, ADFH
    {
        private int x;

        public string Version { get; set; }

        public void SetX(int i)
        {
            x = i;
        }
    }
    public interface ADFH
    {
        string Version { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Formatters objFormatters = new Formatters();
            objFormatters.Get();


            multipleconstructorcalled.CallMethods();


            HideUsingNewOverride objHideUsingNewOverride1 = new HideUsingNewOverride();
            objHideUsingNewOverride1.MethodToCreateInstance();

            GenericsPractice<string> objGenericStr = new GenericsPractice<string>();
            objGenericStr.AddOrUpdate(0, "Amir");
            objGenericStr.AddOrUpdate(1, "Khizr Khan");

            GenericsPractice<int> objGenericsPracticeINT = new GenericsPractice<int>();
            objGenericsPracticeINT.AddOrUpdate(0, 12);
            objGenericsPracticeINT.AddOrUpdate(1, 123);

            Console.WriteLine(objGenericStr.GetData(0));
            Console.WriteLine(objGenericsPracticeINT.GetData(0));



            MyDelegate del = new MyDelegate(DelegateSyntax.GetStringName);
            del("Amir");


            CustomerService objCustomerService = new CustomerService();
            objCustomerService.GetCustomerName(1);
            //var salaryObj = HieghtSalaryUsingLinq.GetSalary().OrderByDescending(e => e.salary).Select(x => x.salary).Distinct().Take(Number_sal)
            //    .Skip(Number_sal - 1).FirstOrDefault();

            //var salaryObj = HieghtSalaryUsingLinq.GetSalary().OrderByDescending(e => e.salary)
            //    .Skip(2).FirstOrDefault();

            var result = from n in HieghtSalaryUsingLinq.GetSalary() orderby n descending select n;

            CopyConstructor user = new CopyConstructor("Khizr Khan", "Pune");
            CopyConstructor user1 = new CopyConstructor(user);
            user1.name = "Arslan Khan";
            user1.location = "Deoria";
            Console.WriteLine(user.name + " "+ user.location);
            Console.WriteLine(user1.name + " " + user1.location);

            Console.ReadLine();
            //AbstractClassPractice obj = new AbstractClassPractice();

            Methods objm = new Methods();
            objm.Calling();


            PrimeNumber objprimeNumber = new PrimeNumber();
            objprimeNumber.PrimeNum();
            UsingBlock objUsing = new UsingBlock();
            objUsing.CallUsingMethod();
            int[] syndata = {1, 2, 4, 0 };
            var data = (from n in syndata where n > 2 select n).FirstOrDefault();
            var data1 = from o in syndata select o;
            var resutData = data1.Where(x=>x>2).FirstOrDefault();

            Atos objB = new BAtos();
            objB.SetX(10);

            PrintStar.PrintStarOnDemand();
            string[] arrBuyBTCWithCC = { "India", "New York", "Japan" };
            var isExists = arrBuyBTCWithCC.GroupBy(g => g).Select(x => new { name = x.Key }).FirstOrDefault(x=>x.name=="India");

            for (int i = 0; i <= 10; i++)
            {
                Random rdm = new Random();
                int numb = rdm.Next(1000, 100000);
                Thread.Sleep(1000);
                Console.WriteLine(numb);
            }
            Console.ReadLine();
            ThoughtFocusInterviewQuestions.Test();
            #region Anagrams
            Anagrams.AnagramsCheck();
            #endregion
            string objExtension = string.Empty;
            string love = objExtension.GetSubstringInAddress("ILoveyouTalatKhizrArslanKhan");
            Janu objJanu = new Janu();
            objJanu.i = 90;
            objJanu.j = 100;
            objJanu.display();
            ////Console.Readline();();
            #region struct
            StructPractice objStruct = new StructPractice();
            Console.WriteLine(objStruct.x+ " : " + objStruct.y);
            //
            #endregion struct

            #region Find duplicates in an Array
            //Find duplicate of integer value and char
            FindDuplicateSingleDigitOrCharInArray.findDuplicateSingleDigitOrCharInArray();

            // how to check the duplicate records in array using LINQ
            ContainsDuplicatesUsingLINQ.DuplicateValues();

            //Find duplicate records in array
            FindDuplicateInArrayCollection.FindDuplicateInArrayCollections();

            // find duplicate characters in string name
            DuplicateCharactersInCharArray.DuplicateChar();
            //Console.Readline();();

            HighestStudentScore.HighestScore();
            #endregion Find duplicates in an Array

            #region Others
            //extenshin method implementation
            StringCount stringCount = new StringCount();
            stringCount.SomeMethod("Amir KHan");

            //2.
            int num = ExtensionMethod.IntegerExtension("1234");

            //Single/SingleOrDefault and First/FirstOrDefault
            int[] intHolder = new int[] { 1,2,3,4,5,6 };
            var intVal = intHolder.OrderByDescending(g => g).SkipWhile(x => x>=4);
            var newVal = intVal.SkipWhile(x => x >= 4);

            //Destructor checks
            Third t = new Third();
            #region Event 
            InvokEvent ie = new InvokEvent();
            ie.Event();
            Atidan.findDuplicate();
            #endregion Event
            
            #endregion Others

            #region ReadOnly
            ReadOnlyConstants rdOnly = new ReadOnlyConstants();
            #endregion ReadOnly

            #region Delegate
            Delegate.callDelegate();
            // Console.ReadLine();
            Delegate objDelegate = new Delegate();
            int ResultDelegate = objDelegate.getOperationToPerform(1).Invoke(12,13);

            Delegate2 d2 = new Delegate2();
            
            d2.MyEvent += new Delegate2.MyDelegate(d2.Display);
            d2.MyEvent -= null;
            d2.RaiseEvent();
            Console.WriteLine();
            
            #endregion Delegate

            #region FindNthHighestNumber
            FindNthHighestUsingLinq nHighestNumber = new FindNthHighestUsingLinq();
            nHighestNumber.FindNthHighestNumber();
            #endregion

            #region UseAbstractClass
            UseAbstractClass useAbsClass = new UseAbstractClass();
            useAbsClass.MainMethod();
            
            #endregion

            #region Exception Check
            ExceptionCheck.CalculateMehotd();
            //Console.ReadLine();
            #endregion Exception Check

            #region FindDuplicateStrInTheSentenceAndFindCalculatedValueInArray
            FindDuplicateStrInTheSentenceAndFindCalculatedValueInArray obj = new FindDuplicateStrInTheSentenceAndFindCalculatedValueInArray();
            obj.Find();
            #endregion FindDuplicateStrInTheSentenceAndFindCalculatedValueInArray
            #region Abstract Class Functionality
            CorporateCustomer crpCustomer = new CorporateCustomer();
            SavingCustomer savCustomer = new SavingCustomer();
            #endregion

            #region Singleton class check
            NormalClass nobj = new NormalClass { ABC=5};
            Console.WriteLine("value of ABC is {0}", nobj.ABC);

            var objsingleton1 = SingletonVsStaticClass.Instance;
            objsingleton1.Message = "Today is the meeting at 10";

            var objsingleton2 = SingletonVsStaticClass.Instance;

            Console.WriteLine("checking both are equal : "+objsingleton1.Equals(objsingleton2));

            string returnedValue = StaticClass.ShowMessage();
            Console.WriteLine(returnedValue);
            
            #endregion

            #region Generics
            TietoEmployee tietoEmp = new TietoEmployee();
            tietoEmp.GetEqualAndContains();
            KGK<string> kgk = new KGK<string>();
            kgk.myVal = "Amir";
            KGK<int> kgkIntType = new KGK<int>();
            kgkIntType.myVal = 9000;
            
            #endregion Generics
            #region LinqPractice
            LinqPractice linqObj = new LinqPractice();
            linqObj.GetCalled();
            #endregion
            #region HideUsingNewOverride
            HideUsingNewOverride objHideUsingNewOverride = new HideUsingNewOverride();
            objHideUsingNewOverride.MethodToCreateInstance();
            #endregion
            #region AsyncAwaitProgramming
            AsyncAwaitProgramming.CallAllMethod();
            #endregion AsyncAwaitProgramming
            #region LinqPractice
            EvenNumbers.SumOfEvenNumbers();
            //Joins in Linq
            Employee.GetResultUsingLeftJoin();
            #endregion LinqPractice
            #region FuctionCallUsingRef
            RefKeywordPractice.FuctionCallUsingRef();
            #endregion FuctionCallUsingRef
            #region Sealed Class
            PracticeInheritance objPracticeInheritance = new PracticeInheritance();
            // IInheritance1 objIInheritance1 = (IInheritance1)objPracticeInheritance;
            // objIInheritance1.M1();
            B objA = new B();
            #endregion Sealed Class
            #region Dispose and Finalize
            FinalizeDemo d = new FinalizeDemo();
            d.Dispose();
            d = null;
            #endregion Dispose and Finalize
            #region Interview Asked
            // ThoughtFocusInterviewQuestions.Test();
            #endregion
            Console.ReadLine();
        }
    }
}
