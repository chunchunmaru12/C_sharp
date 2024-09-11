/*
* LINQ : Language Integrated Query
* Query syntax in C# to retrieve data from different sources and formats
* Similarly like SQL(Structured Query Language) used to save and retrieve data from a database. In the same way LINQ is a structured query syntax built in c# to retrieve data from a different sources  such as 
- collection
- ADO.NET Dataset
- XML
-MS SQL Server
-Other databases

-> Dev -uses-> LINQ ---To Query---> Object Collection (LINQ to Objects)
                                  > ADO.NET Dataset (LINQ to Dataset)
                                  > XML Document (LINQ to XML)
                                  > Entity Framework (LINQ to Entity)
                                  > SQL database (LINQ to SQL)
                                  > Other databases

* Query Syntax VS Method Syantax(Lambda):
    Similar to SQl Longer   Using Lambda Expression and Shorter
* LINQ Operators:
* Filtering -> Where, OfType
* Sorting -> OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
* Grouping -> GroupBy, ToLookUp
* Join -> GroupJoin, Join
* Projection -> Select,SelectMany
* Aggregation -> Aggregate, Average, Count, LonCount, Max, Min, Sum
* Elements -> ElementAt, First, Last, FirstOrDefault,Single
* Set -> Distinct, Except, Intersect, Union
* Concatenation -> Concat
*/
using System;
namespace Chapter4{
    class Example1{
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            //Query Syntax:
            var result = from num in numbers where num>5 select num;
            //Method Syntax (lambda expression)
            var resultTwo= numbers.Where(n =>n>5);
            Console.WriteLine("number Greter than 5:");
            foreach (var item in result)
            {   
                Console.WriteLine(item);
                
            }
        }
    }
}