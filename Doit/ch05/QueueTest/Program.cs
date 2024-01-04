using System.Collections;

class MyClass
{
    public static void Main(string[] args)
    {
        Queue qu = new Queue();

        // Equeue 메소드를 통해 아이템 추가
        qu.Enqueue(1);
        qu.Enqueue(2);
        qu.Enqueue(3);

        // Dequeue 메소드를 통해 아이템을 제거
        while(qu.Count > 0)
        {
            Console.WriteLine(qu.Dequeue());
        }
    }
}