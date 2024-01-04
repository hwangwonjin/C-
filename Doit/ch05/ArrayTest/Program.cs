class play
{
    public static void Main(string[] args)
    {
        // 배열을 초기화 하는 첫 번째 방법
        int[] array1 = new int[3];
        array1[0] = 1;
        array1[1] = 2;
        array1[2] = 3;

        // 배열을 초기화하는 두 번째 방법
        int[] array2 = new int[3] {10, 11, 12};

        // 배열을 초기화 하는 세 번째 방법
        int[] array3 = { 4, 5, 6 };

/*      배열 내의 정보를 확인 할 수 없음
        Console.WriteLine(array1);
        Console.WriteLine(array2);
        Console.WriteLine(array3);*/

        for(int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(array2[i]);
        }

        // foreach 문을 통해 배열에 담긴 값 출력
        foreach(int i in array3)
        {
            Console.WriteLine(i);
        }
    }
}
