using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//here we are creating a customized exception

public class UserNotFoundException : Exception
{
    public UserNotFoundException()
    {

    }
    public UserNotFoundException(string message, Exception ex) : base(message, ex)
    {
        //Exception logic.

    }
    public UserNotFoundException(string message) : base(message)
    {
        //Exception logic.  

    }

    //we can throw this new customized exception in our code.

}

