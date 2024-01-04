
/*
    날짜: 2023/11/07 
    이름: 황원진
    내용: while 반목문 실습
 */

class WhileTest
{
    public static void Main(string[] args)
    {
        int i = 0;

        while (true)
        {
            Console.WriteLine(i);
            i++;

            if(i > 10)
                break;
        }
    }
}
