using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1, v2); 에러
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");
            Console.WriteLine("v1 = {0,10:D}, v2 = {1, 10:F2}", v1, v2); // 형식 지정자 N, D, C, F, E 많이 사용
            Console.WriteLine("v1 = {0:#.##}, v2 = {1:#.##}", v1, v2); // #으로도 가능
        }
    }
}
