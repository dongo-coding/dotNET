using System;

namespace String {
    class Program {
        static void Main(string[] args) {
			string s = Console.ReadLine();
            char c = char.Parse(Console.ReadLine());
            int temp=-1;
            for(int i=0;i<s.Length;i++){
                if(s[i]==c){
                    temp=i;                                      //Tìm vị trí xuất hiện của kí tự c trong xâu s
                    break;
                }
            }
            Console.WriteLine(temp);
		}
    }
}
