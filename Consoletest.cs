using System;

namespace ConsoleApplication
{
    public class ConsoleTest {
       
        public static void Main (string[] args){
            Console.WriteLine("testing console.writeline");
            int[] myArr = new int[10];
            for(int i = 0; i < myArr.Length; i++){
                myArr[i] = i*2 + 1;
                Console.WriteLine(myArr[i]);
            }
        }
    }
}