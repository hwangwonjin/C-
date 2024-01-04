/*
    날짜: 2023/11/07
    이름: 황원진
    내용: 연산자 실습
 */

class OperatorTest
{
    public static void Main(string[] args)
    {
        int result, num1, num2;

        result = 3 + 1;
        Console.WriteLine(result);

        result = 3 - 1;
        Console.WriteLine(result);

        num1 = 3;
        result = 5 * num1;
        Console.WriteLine(result);

        num2 = 100;
        result = num2 / 3;
        Console.WriteLine(result);

        result = 10 % 2;
        Console.WriteLine(result);

        // 증감 연산자
        int num = 0;
        Console.WriteLine(num++);
        Console.WriteLine(num);
        Console.WriteLine(--num);
        Console.WriteLine(num++);

        //관계 연산자
        bool result1;
        int num10, num20;

        num10 = 3;
        num20 = 5;

        result1 = num10 > num20;
        Console.WriteLine(result1);

        result1 = num10 < num20;
        Console.WriteLine(result1);

        result1 = num10 >= num20;
        Console.WriteLine(result1);

        result1 = num10 <= num20;
        Console.WriteLine(result1);

        result1 = num10 == num20;
        Console.WriteLine(result1);

        result1 = num10 != num20;
        Console.WriteLine(result1);

        // 논리 연산자
        bool A, B;

        A = true;
        B = false;

        // 논리합
        Console.WriteLine(A && A);
        Console.WriteLine(A && B);

        // 논리곱
        Console.WriteLine(A || B);
        Console.WriteLine(B || B);

        // 부정
        Console.WriteLine(!A);
        Console.WriteLine(!B);
    }
}
