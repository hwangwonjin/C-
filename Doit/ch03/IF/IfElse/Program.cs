class IfElseTest
{
    public static void Main(string[] args)
    {
        int num = 5;

        if(num == 5)
        {
            Console.WriteLine("입력된 값이 5입니다.");
        }
        else if(num == 6)
        {
            Console.WriteLine("입력된 값이 6입니다.");
        }
        else
        {
            Console.WriteLine("예외 입니다.");
        }
    }
}
