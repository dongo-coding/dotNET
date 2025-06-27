/* using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Cod3l3arn".Replace('3', 'e'));
            Console.WriteLine("Blackcat".Replace("Black", "White"));          //Phương thức thay thế
        }
    }
}


using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string s = "CoDeLeArN";
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());                                //Phương thức ToUpper/ToLower
        }
    }
}



using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string s = "Codelearn";
            Console.WriteLine(s.IndexOf("learn"));
            Console.WriteLine(s.IndexOf("black"));                         //Phương thức IndexOf
        }
    }
}




using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string name = "Codelearn";
            Console.WriteLine(name.StartsWith("Code"));
            Console.WriteLine(name.StartsWith("abc"));
            Console.WriteLine(name.EndsWith("rn"));                        //Phương thức StartsWith-EndsWith
            Console.WriteLine(name.EndsWith("z"));
        }
    }
}


using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string s = "Welcome to Codelearn!";
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++) {                      //Phương thức Split
                Console.WriteLine(words[i]);
            }
        }
    }
}



using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string name = "Codelearn";
            Console.WriteLine(name.Substring(0, 2));
            Console.WriteLine(name.Substring(0, 4));                       //Phương thức Substring
            Console.WriteLine(name.Substring(4));
        }
    }
}
*/



using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            s1 = s1.ToLower();                                             // tìm kiếm vị trí đầu tiên mà chuỗi s2 xuất hiện trong xâu s1
            s2 = s2.ToLower();
            Console.WriteLine(s1.IndexOf(s2));
		}
    }
}
