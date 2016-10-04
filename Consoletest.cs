using System;

namespace ConsoleApplication
{
    public class ConsoleTest {
       
        public static void Main (string[] args){
            Console.WriteLine("testing console.writeline");
            int[] myArr = new int[10];
            for(int i = 0; i < myArr.Length; i++){
                myArr[i] = Double(i) + 1;
                Console.WriteLine(myArr[i]);
            }
        }
        public static int Double (int i) {
            return i*2;
        }
    }
}