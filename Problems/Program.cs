using System;
//using System.String;
namespace Problems
{
    public class Program
    {
       private string Prefix(string input)
        {
            int length=input.Length; //get string length
            string[] wordcount = input.Split(' '); //Seperate by words into array
            int count = wordcount.Length; //Get the wordcount
            string output = $"{length},{count}:{input}"; //Put it all together
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
