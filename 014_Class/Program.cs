using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _014_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            //랜덤 숫자 5개를 출력
            for (int i = 0; i < 5; i++)
                Console.WriteLine(r.Next(100));

            //숫자 20개를 랜덤하게 만들어 배열에 저장한 후 최소, 최대, 평균값 계산
            int[] a = new int[20];
            for (int i = 0; i < 20; i++)
                a[i] = r.Next(100);

            Console.WriteLine("배열의 내용 : ");
            foreach (var x in a)
                Console.Write(x + " ");
            Console.WriteLine();

            int min = a[0];
            int max = a[0];
            int sum = 0;
            for (int i = 0; i < 20; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
                sum += a[i];
            }
            Console.WriteLine("최솟값 = {0}, 최댓값 = {1}, 평균 = {2}", min, max, sum / 20.0);
        }
    }
}
