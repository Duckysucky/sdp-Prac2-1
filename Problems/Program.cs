using System;
//using System.String;
namespace Problems
{
    public class Program
    {
       public static string Prefix(string input)
        {
            if(input=="")
            {
                return "0,0:";
            }
            int length=input.Length; //get string length
            string empty = "";
            string[] wordcount = input.Split(' ');
            int count = wordcount.Length;
            string output = $"{length},{count}:{input}"; //Put it all together
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
