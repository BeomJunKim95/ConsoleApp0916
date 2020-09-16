using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
	class Button
	{
		//스태틱만 붙여주게 되면 모든 인스턴스가 멤버변수를 공유하게됨
		/*static*/ int buttonCnt = 0; //버튼 인스턴스를 세는 변수
		static Button btn; //싱글톤을 위한 스태틱 멤버변수 => 정적은 정적끼리
		int click = 0;
		
		// 싱글톤 방식 : 하나의 인스턴스만 쓰고싶을때 쓰는방법
		private Button() // 생성자를 프라이빗으로 두고 메서드하나를 만듬 
		{				 //  ㄴ>> 이 생성자를 지우면 안됨 지우면 기본생성자가 만들어지는데 이건 public이라 클래스 밖에서 맘대로 호출가능

			//싱글톤 방식에서는 어차피 인스턴스가 하나라 아래의 인스턴스의 개수를 세는 코드는 의미가 없음 
			//buttonCnt++;
			//Console.WriteLine("버튼{0}",buttonCnt);
		}
		public static Button CreateInstance()  //인스턴스 메서드를 호출하려면 new를 해야하는데 못함 그래서 static을 붙여줘야함
		{									   //이렇게 퍼블릭 스태틱 메서드를 만들어 호출할수 있게 해줌
			if (btn == null)
			{
				btn = new Button();
			}
			return btn;
		}
		public void Click()
		{
			click++;
			Console.WriteLine(click);
		}
	}
	class ClickCount
	{
		static void Main(string[] args)
		{
			if (args.Length == 2)
			{
				Console.WriteLine(args[0] + "/" + args[1]);
			}

			#region 일반적인 여러개의 인스턴스
			//Button btn1 = new Button(); //인스턴스 변수가 하나만 만들어져서 멤버변수를 공유함
			//btn1.Click(); //1
			//btn1.Click(); //2
			//btn1.Click(); //3

			//Button btn2 = new Button(); //새로운 인스턴스가 만들어져 새로운 메모리가 생겨 다시 초기화
			//btn2.Click(); //1
			#endregion

			#region 싱글톤 방식
			//하나의 인스턴스만 생성됨
			Button btn1 = Button.CreateInstance();
			btn1.Click(); //1
			btn1.Click(); //2
			btn1.Click(); //3

			Button btn2 = Button.CreateInstance(); 
			btn2.Click(); //4
			#endregion
		}
		#region 두개의 Main
		//같은 클래스여도 Main은 두개가 올수없다
		//static void Main(string[] args)
		//{
		//	Console.WriteLine("두번째 Main 실행");
		//}
		#endregion
	}
}
