using System;

namespace factoryMethodConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory method design pattern example:");

            ICookie chocolatechipcookie = new CookieChocolateChipFactory().CreateCookie();
            ICookie peanutbuttercookie = new CookiePeanutButterFactory().CreateCookie();
            ICookie sugarcookie = new CookieSugarCookieFactory().CreateCookie();
          
            if (chocolatechipcookie != null)
            {
                Console.WriteLine(chocolatechipcookie.GetCookie());
                
            }
            if (peanutbuttercookie != null)
            {
                Console.WriteLine(peanutbuttercookie.GetCookie());

            }
            if (sugarcookie != null)
            {
                Console.WriteLine(sugarcookie.GetCookie());

            }
            Console.ReadLine();
        }
    }
}
