using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_2
{
    internal class MenuItem
    {
        //public delegate void MenuKeyPressDelegate(object sender, EventArgs args);
        public event EventHandler MenuKeyPressEnventHandler;
        public string MenuChar {  get; set; }   //1
        public string MenuTitle { get; set; }   //Menu1
        //public MenuKeyPressDelegate MenuKeyPress { get; set; }  //func{sender, args}

        public MenuItem(string menu_char, string menu_title) 
        {
            MenuChar = menu_char;
            MenuTitle = menu_title;
            //MenuKeyPress = dele;
        }

        public MenuItem() : this(null, null)
        {

        }

        public void CallEvent(object sender, string args)
        {
            if(MenuKeyPressEnventHandler != null) 
            {
                MenuKeyPressEnventHandler(sender, new MenuKeyPressArgs(args));
            }
        }
    }
}
