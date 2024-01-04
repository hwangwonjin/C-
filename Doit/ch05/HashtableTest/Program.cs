using System.Collections;

public class MainClass
{
    public static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();

        ht["apple"] = "사과";
        ht["banana"] = "바나나";
        ht["orange"] = "오렌지";

        Console.WriteLine(ht["apple"]);
        Console.WriteLine(ht["banana"]);
        Console.WriteLine(ht["orange"]);
    }
}