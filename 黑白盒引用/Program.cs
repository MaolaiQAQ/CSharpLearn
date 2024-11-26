using 黑盒引用;//添加引用
using 白盒引用;//添加引用
namespace 黑白盒引用
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用了黑盒项目里Person类下的PersonSay方法
            Person.PersonSay();
            //使用了白盒引用里Animal类下的AnimalSay方法
            Animal.AnimalSay();
        }
    }
}
