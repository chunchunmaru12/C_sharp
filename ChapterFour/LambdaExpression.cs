/*
* Lambda Expression:
-> Similar to Anonymous function with the difference that the lambda expression
you dont need to specify the type of the value that you input this making it more flexible
-> The "=>" is the lambda operator
Syntax:
1. Expression Lambda: Consists of the input and the expression 
input => expression;
2. Statement lambda: Consists of the input and set of statements
input=>{statements};
*/
namespace Chapter4{
    class LambdaExpression{
        static int Show()=>1;
        static int Add(int arg1, int arg2)=>(arg1+arg2);
        static string Print(string FirstName, string LastName)=>(FirstName+" "+LastName);
        delegate void ModifyNum(int inputNum);
        static void Main(string[] args)
        {
            Console.WriteLine(Show());
            Console.WriteLine(Add(5,3));
            Console.WriteLine(Print("Md","Noor"));
            //statement lambda
            ModifyNum change=x=>{
                int result=x+1;
                Console.WriteLine($"Result: {result}");
            };
            change(5);
        }
    }
}