using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_2
{
    internal class ConsoleMenu
    {
        public List<MenuItem> MenuList { get; set; }
        public ConsoleMenu() 
        {
            MenuList = new List<MenuItem>();
        }

        public void Show()
        {
            foreach (MenuItem item in MenuList) 
            { 
                Console.WriteLine($"{item.MenuChar},  {item.MenuTitle}");
            }
            Console.WriteLine();
        }

        public void Read()
        {
            Console.WriteLine("메뉴선택 : ");
            string reVal = Console.ReadLine();  //1,2,q
            foreach (MenuItem item in MenuList) 
            {
                //if (item.MenuChar == reVal && item.MenuKeyPress != null)
                if (item.MenuChar == reVal)
                    item.CallEvent(this, reVal);
              
            }
        }
    }
}
