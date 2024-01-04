using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13_1
{
    internal class Exam13_1
    {
        public void Run()
        {
            //string str = GetString();
            //if(Find해묘미(str)) Console.WriteLine("해묘미 합입니다.");
            //if(Find인오술(str)) Console.WriteLine("인오술 합입니다.");
            DateTime dt = new DateTime();
            Console.WriteLine( DateTime.Now);
        }

        private bool Find인오술(string str)
        {
            string[] Ios = new string[] { "인", "오", "술" };
            return Ios.All(s => str.Contains(s));

            //foreach(string s in Ios)
            //{
            //    if(str.IndexOf(s) < 0) return false;
            //}
            //return true;
        }

        //str은 6자를 가지고 있음
        //여기에 해, 묘, 미 세 글자라 포함되어 있으면 true를 반환, 그렇지 않으면 false를 반환
        private bool Find해묘미(string str)
        {
            if (str.Contains("해") && str.Contains("묘") && str.Contains("미"))
            {
                return true;
            }
            return false;
        }

        private string GetString()
        {
            while (true)
            {
                Console.WriteLine("6자 입력 : ");
                string str = Console.ReadLine();
                if (str.Length != 6)
                {
                    continue;
                }
                else
                {
                    return str;
                }
            }
        }
    }
}
