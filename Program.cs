using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Linq
{
    class Program
    {
        static bool Filter(int number) 
        {
            if (number > 10)
            {
                return true;
            }
            return false;
        }


        static void Main(string[] args)
        {
            var numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(100);
            numbers.Add(50);
            numbers.Add(2);


            //Linq -using ready algorithms  List integrated native queries
            //numbers.Where(number => number > 10); // Lambda Expression //anonimous function, no name function-
            //numbers.Where(x => x > 0); //  Lambda expression, anonimous function., function whitout name
                                       // withput saying what type of data we get in, and what type of data we get out.
                                       //var lambda = (x , y) => Console.WriteLine( x + y );
                                       // lambda expresion is a short record of a given mehtod 
                                       //var result = numbers.Where(x => x > 10); //
           // var result = numbers.Count(n => n > 10); //Count me all numbers in collection numbers that n > 10;
          //  Console.WriteLine(result); ///returns  how many numbers are > 10 , here only 2 ;

            //numbers.Where();
            //numbers.FindAll(x => x >10); // find that are bigget than 10;
            // remove all //
            //numbers.RemoveAll(x => x < 50);
            foreach (var number in numbers.FindAll(n => n % 2 == 0))
            {
                Console.WriteLine(number);
            }

           
        }
    }
}
