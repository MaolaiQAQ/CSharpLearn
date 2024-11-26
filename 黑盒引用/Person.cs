using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 黑盒引用
{
    public class Person
    {
        //创建了一个可以调用的方法，并生成dll文件
        public static void PersonSay()
        {
            Console.WriteLine("person say");
        }
    }
}
