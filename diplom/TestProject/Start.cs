using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Start
    {
        public static int countOk = 0;
        public static int countError = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Автоматизированное тестирование проекта.");
            testURLHomePage();
            Console.WriteLine("Удачно пройдено тестов: " + countOk);
            Console.WriteLine("Завалено тестов: " + countError);
        }

        static void testURLHomePage() 
        {
            TestHomePage test = new TestHomePage();
            Console.WriteLine("Навигация на главной странице:");
            try
            {
                test.TestMethod_URLHomePage();
                countOk++;
            }
            catch (Exception) { countError++; }
        }
    }
}
