
/*
    날짜 : 2023/11/07
    이름: 황원진
    내용: class 실습
 */

class Person
{
    // 속성(Property)
    public string Name;
    public string Birthdat;
    public string Gender;

    // 메소드(Method)
    public void Eat()
    {
        Console.WriteLine(Name + "이 아침을 먹습니다.");
    }

    public void Walk()
    {
        Console.WriteLine(Name + "이 걷습니다.");
    }

    public void Run()
    {
        Console.WriteLine(Name + "이 뜁니다.");
    }

    
}

class Mainclass
{
    public static void Main(string[] args)
    {
        Person p1;
        p1 = new Person();
        p1.Name = "서준";
        p1.Walk();
        p1.Eat();
        p1.Run();
    }

}
