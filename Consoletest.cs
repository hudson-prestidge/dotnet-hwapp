using System;

namespace ConsoleApplication
{
    public class ConsoleTest {
       
        public static void Main (string[] args){
            Console.WriteLine("testing console.writeline");
            int[] myArr = new int[3];
            myArr[0] = 1;
            Console.WriteLine("the first element in my array is: " + myArr[0]);
        }
    }
}