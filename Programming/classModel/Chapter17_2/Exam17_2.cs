using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_2
{
    internal class Exam17_2
    {
        ConsoleMenu Menu;
        public Exam17_2() 
        {
            Menu = new ConsoleMenu();
        }
        public void Run()
        {
            CreateMenu();
            for(; ; )
            {
                Menu.Show();
                Menu.Read();
            }
        }

        private void CreateMenu()
        {

            MenuItem item = new MenuItem("1", "Menu_Title1");
            item.MenuKeyPressEnventHandler += Menu_1_callback;
            Menu.MenuList.Add(item);

            item = new MenuItem("2", "Menu_Title2");
            item.MenuKeyPressEnventHandler += Menu_2_callback;
            Menu.MenuList.Add(item);

            item = new MenuItem("q", "프로그램 종료");
            item.MenuKeyPressEnventHandler += Quit_Callback;
            Menu.MenuList.Add(item);
        }

        private void Quit_Callback(object sender, EventArgs args)
        {
            Console.WriteLine($"Menu_1_Callback() 호출됨 sender = {sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
            Console.WriteLine("bye!!");
            Environment.Exit(0);

        }

        private void Menu_1_callback(object sender, EventArgs args)
        {
            Console.WriteLine($"Menu1_Callback() 호출됨 sender = {sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
        }

        private void Menu_2_callback(object sender, EventArgs args)
        {
            Console.WriteLine($"Menu2_Callback() 호출됨 sender = {sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
        }
    }
}
