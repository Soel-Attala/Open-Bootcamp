//CLASE 17 - EXCEPTIONS
//here we gonna use a lot the commands try - catch - finally
//exceptions are unexpected, undesired situations, mistakes, errors, etc.

Console.WriteLine(DivisionSegura(1, 2));
static double DivisionSegura(double a, double b)
{
    return a / b;

}

//now we gonna create a mistake:

static double DivisionSegura2(double a, double b)
{
    if (b == 0)
    {
        throw new UserNotFoundException();
    }
    return a / b;
}

//In the console we can see the exception when trying to divide by zero
try
{
    Console.WriteLine(DivisionSegura2(1, 0));
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message} you can't divide by zero");
}

/*
 * if we don't execute the catch we cannot continue with our code, 
 * but doing so allows us to continue trapping the error
 */


//we will now create an array and force another error:
int[] arr = new int[3];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;
//Console.WriteLine(arr[3]);
//we can see in the console:
//Unhandled exception: "Index was outside the bounds of the array".

try
{
    Console.WriteLine(arr[3]);
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
}

/*again we see that the catch allows us to continue with the program
 *despite the error, since it catches the exception.
 */


