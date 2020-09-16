using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class Button1
    {
        static int buttonCnt = 0;
        int click = 0;
        
        //정적 생성자
        //클래스에 한개만 존재할수있고(오버로딩 불가), 정적멤버를 초기화 하는기능
        static Button1()
		{
            buttonCnt = 10;
		}

        public Button1()
        {
            buttonCnt++;
            Console.WriteLine("버튼 {0}", buttonCnt);
        }

        public void Click()
        {
            click++;
            Console.WriteLine(click);
        }
    }

    class ClickCount1
    {
        static void Main(string[] args)
        {
            Button1 btn1 = new Button1();
            btn1.Click();
            btn1.Click();
            btn1.Click();

            Button1 btn2 = new Button1();
            btn2.Click();

            Button1 btn3 = new Button1();
        }
    }
}
