using System.Collections;

/*
    날짜 : 2023/11/08
    이름: 황원진
    내용: ArrayList 실습
 */

class MainClass
{
    public static void Main(string[] args)
    {
        ArrayList al = new ArrayList();

        // add  메소드를 통해 아이템 추가
        al.Add(1);
        al.Add("Hello");
        al.Add(3.3);
        al.Add(true);

        foreach(var item in al)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Remove 메소드를 통해 아이템 삭제
        al.Remove("Hello");

        foreach(var item in al)
        {
            Console.WriteLine(item);
        }
    }
}
