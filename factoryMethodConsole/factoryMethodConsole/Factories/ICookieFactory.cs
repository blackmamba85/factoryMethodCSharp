using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethodConsole.Factories
{
    /// <summary>
    /// This represents the abstract creator and defines a factory method that will return
    /// an object of type Cookie, the concrete method CreateCookie() will internally call
    /// the abstract method MakeCookie() implemented by the subclasses 
    /// </summary>
    public abstract class ICookieFactory
    {
        protected abstract ICookie MakeCookie();

        public ICookie CreateCookie()
        {
            return this.MakeCookie();
        }
    }
}
