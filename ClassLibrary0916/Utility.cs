using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary0916
{
	public class Utility //public을 붙여줘야 다른 어셈블리에서 호출가능 => 디폴트값이 internal 이기 때문
	{
		//문자열을 int로 형변환
		//static을 쓴이유 : 호출할때 스태틱이 아니면 인스턴스변수를 하나 만들고 써야하기 때문에 스태틱으로 선언후 메서드명으로 호출하면 편해짐
		public static int ConvertInt(string str) 
		{
			//제대로된 값만을 받기 위해 루프돌게 코딩
			//하지만 이렇게 하면 콘솔에서 밖에 쓰지 못함
			int num = 0;
			bool bFlag = false;
			//while (!bFlag) //숫자가 아닌값을 입력받으면 bflag에 false를 반환 받으니 false를 반환받으면 루프
			//{
			bFlag = int.TryParse(str, out num);
			//}
			if (bFlag == false)
				num = 0;
			return num;
		}

		//문자열을 double로 형변환
		public static double ConvertDouble(string str)
		{
			double num;
			bool bFlag = double.TryParse(str, out num); // TryParse : out이라는 키워드 꼭필요, 숫자가 아닌경우 false를 반환받기 위해 bool타입 선언
			if (!bFlag)
				num = 0; //숫자가 아닌경우 숫자의 기본값인 0반환

			return num;
		}
	}
}
