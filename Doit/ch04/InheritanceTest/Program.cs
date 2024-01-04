class Robot
{
    public void move()
    {
        Console.WriteLine("로봇이 움직입니다.");
    }
}

class CleanRobot : Robot
{
    public static void Clean()
    {
        Console.WriteLine("청소를 시작합니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        CleanRobot CleanRobot = new CleanRobot();
        CleanRobot.move();
        CleanRobot.Clean();
    }
}
