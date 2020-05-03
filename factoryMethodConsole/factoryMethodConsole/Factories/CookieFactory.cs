using factoryMethodConsole.Factories;
using factoryMethodConsole.ProductClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethodConsole
{
    /// <summary>
    /// Concrete creator classes will override the abstract factory method 
    /// we will need one concrete factory per class that will implement the     
    /// </summary>
    public class CookieChocolateChipFactory : ICookieFactory
    {
        protected override ICookie MakeCookie()
        {
            ICookie cookiechocochip = new CookieChocolateChip();
            return cookiechocochip;
        }
    }

    public class CookiePeanutButterFactory : ICookieFactory
    {
        protected override ICookie MakeCookie()
        {
            ICookie peanutButterCookie = new CookiePeanutButter();
            return peanutButterCookie;
        }
    }

    public class CookieSugarCookieFactory : ICookieFactory
    {
        protected override ICookie MakeCookie()
        {
            ICookie cookieSugar = new CookieSugarCookie();
            return cookieSugar;
        }
    }
    
   

}
