using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IComparableTest.Exam2_1;

namespace Chapter17_1
{
    internal class Exam17_1
    {
        delegate void MyDelegate(int val);
        delegate int MyDelegate1(int val);
        public void Run()
        {
            int a = 3;
            Console.WriteLine(a);
            Student st = new Student();
            st.Name = "rkdrkd";
            Console.WriteLine(st);

            DelegateTest(3);
            MyDelegate date = new MyDelegate(DelegateTest) ;
            MyDelegate1 date1 = new MyDelegate1(DeleteTest1) ;
            
        }

        private void DelegateTest(int myVal)
        {
            Console.WriteLine($"DelegateTest() Called {myVal}");
        }

        private int DeleteTest1(int myVal)
        {
            return myVal = 1;
        }
    }
}
