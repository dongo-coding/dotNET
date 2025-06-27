using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            char c = char.Parse(Console.ReadLine());
            int cnt=0;
            for(int i=0;i<s.Length;i++){
                if(s[i]==c){
                    cnt++;                                      //đếm số lần kí tự c xuất hiện trong xâu s
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
