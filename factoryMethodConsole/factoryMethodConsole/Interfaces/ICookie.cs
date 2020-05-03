using System;
using System.Collections.Generic;
using System.Text;

namespace factoryMethodConsole
{
    /// <summary>
    /// Cookie Interface to provide signature of common functionalities 
    /// that will be implemented by concrete cookie classes
    /// </summary>
    public interface ICookie
    {
        string GetCookie();       
    }
    
}
