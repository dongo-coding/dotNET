using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            for(char c= '0' ; c<='9';c++){
                s=s.Replace(c + "", "");             //in ra những kí tự không phải số bằng phương phức thay thế
            }
            Console.WriteLine(s);
        }
    }
}
