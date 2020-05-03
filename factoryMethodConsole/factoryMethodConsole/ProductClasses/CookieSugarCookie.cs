using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethodConsole.ProductClasses
{
    public class CookieSugarCookie : ICookie
    {
        public string GetCookie()
        {
            return "I am a sugar cookie";
        }
    }
}
