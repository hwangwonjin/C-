/*
    날짜 : 2023/11/07
    이름 : 황원진
    내용 : 오버로딩 실습
 */

class Cat
{
    private string name;
    public int Age;

    public Cat(string name)
    {
        this.name = name;
        Console.WriteLine("고양이의 이름은 " + name + "입니다.");
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return this.name;
    }

   /* public Cat(string name)
    {
        this.name = name;
        Console.WriteLine("고양이의 이름은 " + name + " 입니다.");
    }

    public Cat(string name, int age) 
    { 
        this.name=name;
        Age = age;

        Console.WriteLine("고양이의 이름과 나이는 " + name +" "+ Age + " 입니다.");
    }

    ~Cat() {
        Console.WriteLine(name + "이 사라집니다.");
    }*/
}

class Plus
{
    public int Num;
    public int A;
    public int B;

    public Plus(int num, int a, int  b)
    {
        Num = num;
        A = a;
        B = b;

        int r1 = num + a + b;

        Console.WriteLine("합은 " + r1 + "입니다.");
    }


}

class MainClass
{
    public static void Main(string[] args)
    {
        Cat coco = new Cat("코코");
        coco.SetName("몰리");
        Console.WriteLine("고양이의 이름은 " + coco.GetName() + "입니다.");

/*        Cat Coco = new Cat("코코");
        Cat Moly = new Cat("몰리", 5);
        Coco.Name = "콜링";
        Console.WriteLine("고양이의 이름은 " + Coco.Name + "입니다.");
        Plus result1 = new Plus(1, 2, 3);
        Plus result2 = new Plus(4, 3, 2);*/
    }
}
