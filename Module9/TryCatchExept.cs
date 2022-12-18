using System;
using System.IO;

namespace Module9
{
    public class TryCatchExept : Exception
    {

        public static Exception myEx = new MyException("Пароль слишком короткий");
        public static Exception nullEx = new ArgumentNullException("Поле пусто");
        public static Exception timeOut = new TimeoutException("Вышло время ожидания");
        public static Exception rangEx = new FormatException("Пароль должен сотоять из цифр");
        public static Exception dirEx = new DirectoryNotFoundException("Папка не найдена");
        public static Exception[] exMass = new Exception[5];
        
        
        public static Exception TryCatchFinally()
        {
            exMass[1] = myEx;
            exMass[2] = nullEx;
            exMass[3] = timeOut;
            exMass[4] = rangEx;
            exMass[5] = dirEx;          
            foreach(Exception ex in exMass)
            {
                return ex;
            }
            return null;
        }
    }
}
