#Array belong to CSharp
using System;

namespace Method {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumOfArray(arr));
        }

        public static int sumOfArray(int[] arr) {
            int s=0;
            for(int i=0;i<arr.Length;i++){
                s+=arr[i];
            }
            return s;
	    }

    }
}
