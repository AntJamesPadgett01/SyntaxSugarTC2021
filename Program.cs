using System;

namespace SyntaxSugarTC2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //var answer = 3;
            //string response;


            //if (answer < 12)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + "greater than or equal to nine";
            //}

            var answer = 3;
            var response = (answer < 12) ? $"{answer} is less than twelve" : $"{answer} is greater than or equal to twelve";
            Console.WriteLine(response);
        }

    }
}
