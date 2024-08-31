/*
*Exception Handling in c#
* -> Structured way to handle runtime errors or exceptions condition that occur during execution of the program
* -> the try, catch and finally blocks are used to manage the exception
* -> Try=> contaains a code that might throw an exception
* -> Catch block => catches and handles the exception thrown by try block
* -> Finally => executes the code regardless of whether an exception is thrown or caught.
* Basic Syntax :
    try{}
    catch(Exception e){}
    finally{}
    *  Multiple catch block
        try{}
        catch(ExceptionA e){}
        catch(ExceptionB e){}
        catch(ExceptionC e){}
        finally{}
* System.Exception - Base Class
- NUllReferenceException
- OutOfReferencesException
- InvalidOperationException
- ArgumentNullException
- DivideByZeroException
- IndexOutOfRangeException
- FormatException

*/
using System;
namespace Chapter4{
    public class ExceptionOne{
    static void Dislpay(string? name){
        if(name==null){
            throw new Exception($"{nameof(name)} is null");
        }
        Console.WriteLine(name);
    }
    static void Main(string[] args)
    {
        try{
            //Dislpay("Hello");
            Dislpay(null);
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            Console.WriteLine("Finally block Executed");
        }
    }
}
}