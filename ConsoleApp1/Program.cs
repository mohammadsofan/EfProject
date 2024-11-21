using CC.Europe.France;
namespace ConsoleApp1
{
    internal class Program
    {
        static void fun(out int age)
        {
            age = 2;
        }
        static void Main(string[] args)
        {
            Employee e = new Employee() { name="sami",age=22,numbers=new int[] {1,23,4,5}};
            Employee[] s=new Employee[2];
            s[0] = new Employee();
            s[1] = new Employee();
            s[0].print();
            e.print();

        }
    }
}
