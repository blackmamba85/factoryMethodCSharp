using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethodConsole
{
    public class CookieChocolateChip : ICookie
    {
        public string GetCookie()
        {
            return "I am a chocolate chip cookie";
        }
    }
}
