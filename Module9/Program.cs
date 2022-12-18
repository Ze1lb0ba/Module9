using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.ExceptionServices;

namespace Module9
{
    class Program
    {
        static Exception ex;
        static void Main(string[] args)
        {
           TryCatchExept exeption = new TryCatchExept();
           try 
           {
                Console.WriteLine("Введите пароль");
                string userPass = Console.ReadLine();

           }
            
           catch(Exception ex)
           {
                ex = TryCatchExept.TryCatchFinally();
           } 
        }
    }
}
