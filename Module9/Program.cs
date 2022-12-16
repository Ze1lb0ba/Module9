using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.ExceptionServices;

namespace Module9
{
    class Program
    {
        
        static void Main(string[] args)
        {
           int i =0;
           MyException exeption = new MyException();
           try 
           {
                int enter = Int32.Parse(Console.ReadLine());
                i = MyException.TryCatchException(enter);
           }
            
           catch
           {
                Exception[] exept = MyException.InitializeException();
                Console.WriteLine(exept[i]);
           } 
        }
    }

    public class MyException: Exception
    {
        public static Exception ex = new Exception("Неизвестная ошибка.");
        public static IndexOutOfRangeException indexEx = new IndexOutOfRangeException();
        public static PlatformNotSupportedException platformEx = new PlatformNotSupportedException();
        public static PathTooLongException pathEx = new PathTooLongException();
        public static TimeoutException timeOutEx = new TimeoutException();
        
        static Exception[] exMass = new Exception[5];
 
        public static Exception[] InitializeException()
        {
            exMass[1] = ex;
            exMass[2] = indexEx;
            exMass[3] = platformEx;
            exMass[4] = pathEx;
            exMass[5] = timeOutEx;
            return exMass;
        }

        public static int TryCatchException(int enter)
        {
            if (enter == 1)
                return 1;
            if (enter == 2)
                return 2;
            if (enter == 3)
                return 3;
            if (enter == 4)
                return 4;
            else return 1;
        }
    }

}
