using System.Collections;

class MainClass
{
    public static void Main(string[] args)
    {
        Stack st = new Stack();

        // push 메소드를 통해 Stack에 아이템 추가
        st.Push(1);
        st.Push(2);
        st.Push(3);

        //Console.WriteLine(st.ToString());

        // Pop 메소드를 통해 아이템을 제거
        while (st.Count > 0)
        {
            Console.WriteLine(st.Pop());
        }
    }
}
