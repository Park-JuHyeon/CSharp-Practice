using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_ex
{
    // foreach란 끝을 지정해주는 다른 반복문과 달리, 인자로 들어온 itrable-itme의 내부 인덱스 끝까지
    // 알아서 순환 해주는 반복문

    // 에제 1 : 1차원 배열에서의 foreach
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

        //    Console.WriteLine("##foreach 사용!!");
        //    int index = 0;
        //    foreach (int elem in arr)
        //    {
        //        Console.WriteLine("arr[" + index + "] : " + elem);
        //        ++index;
        //    }

        //    Console.WriteLine("current i : " + index);

        //    // for문 작성시
        //    Console.WriteLine();
        //    Console.WriteLine("## for문 사용!!");
        //    for(int i=0; i < 8; i++)
        //    {
        //        Console.WriteLine("arr[" + i + "] : " + arr[i]);
        //    }

        //}

        // 예제2 : 2차원 배열에서의 foreach
        //static void Main(string[] args)
        //{
        //    int[,] arr = new int[4, 3]
        //    {
        //        {11, 12, 13 },
        //        {21, 22, 23 },
        //        {32, 32, 33 },
        //        {41, 42, 43 }
        //    };

        //    Console.WriteLine("foreach문 시작!!");
        //    int index = 0;
        //    foreach (int elem in arr)
        //    {
        //        Console.WriteLine("arr[" + index + "] : " + elem);
        //        ++index;
        //    }
        //    Console.WriteLine("current i : " + index);

        //    // for문으로 사용시
        //    Console.WriteLine();
        //    Console.WriteLine("## for문 사용!!");

        //    for(int i = 0; i <4; i++)
        //    {
        //        for(int j = 0; j <3; j++)
        //        {
        //            Console.WriteLine("arr[" + i + "," + j + "] :" + arr[i, j]);
        //        }
        //    }
        //}

        // enum을 순회할 수 있는 foreach
        enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            Setember,
            October,
            November,
            December
        };

        static void Main(string[] args)
        {
            Console.WriteLine("## foreach int 열거형 출력! - Enum.GetValues()");
            foreach (int elem in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine(elem + "월");
            }

            Console.WriteLine();
            Console.WriteLine("## foreach string 열거형 출력! - Enum.GetValues()");
            foreach(string elem in  Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine(elem);
            }
        }
    }


}
