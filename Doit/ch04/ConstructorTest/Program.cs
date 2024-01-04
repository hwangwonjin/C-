class Cat
{
    public string Name;

    public Cat(string name)
    {
        Name = name;
        Console.WriteLine("고양이의 이름은 " + Name + "입니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Cat CoCo = new Cat("코코");
        Cat Moly = new Cat("몰리");
    }
}