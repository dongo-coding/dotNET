using System;
namespace B1{
    class Program{
        public static void Main(){
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++){
                a[i] = int.Parse(Console.ReadLine());
            }
            int Sum = 0;
            for(int i = 0; i < n; i++){
                Sum += a[i];
            }
            Console.WriteLine(Sum);
        }
    }
