using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethodConsole.ProductClasses
{
    public class CookiePeanutButter : ICookie
    {
        public string GetCookie()
        {
            return "I am a peanut butter cookie";
        }
    }
}
