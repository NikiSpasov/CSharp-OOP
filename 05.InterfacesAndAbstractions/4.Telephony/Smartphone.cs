using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Smartphone: IBrowseable, ICallable
{
    public void Browsing(List<string> site)
    {
        try
        {
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void Calling(List<string> number)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}

