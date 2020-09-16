using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary0916;  //using을 추가해 네임스페이스 생략

namespace ConsoleApp0916
{
	class Person
	{
		string name;
		int age;
		double height;
		double weight;

		//public string Name
		//{
		//	get { return name; }
		//	set { name = value; }
		//}

		// 리팩토링 => 필드캡슐화
		public string Name { get => name; set => name = value; }  //람다식 표기 라인수를 줄이기 위해
		public int Age { get => age; set => age = value; }
		public double Height { get => height; set => height = value; }
		public double Weight { get => weight; set => weight = value; }
	}
	class Program
	{
		static void Main(string[] args)
		{//Person 클래스의 프로퍼티(property)를 정의하고,
		 //Main()에서 사용자에게 3명의 Person 정보를 입력받고,
		 //3명의 Person 정보를 출력하여 보십시오.
			Person[] arr = new Person[3];
			Person person1 = new Person(); //전역변수
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("이름을 입력하세요 : ");
				person1.Name = Console.ReadLine();

				Console.Write("나이를 입력하세요 : ");
				person1.Age = Utility.ConvertInt(Console.ReadLine());

				Console.Write("키를 입력하세요 : ");
				person1.Height = Utility.ConvertDouble(Console.ReadLine());

				Console.Write("몸무게를 입력하세요 : ");
				person1.Weight = Utility.ConvertDouble(Console.ReadLine());
				Console.WriteLine();
				
				//레퍼런스타입의 배열은 처음 값이 다 null이기 때문에 먼저 배열에 참조할 주소값을 담아 줘야함
				//person1의 인스턴스변수에 담고 레퍼런스 배열에 참조주소값을 담아 줘야함
				arr[i] = person1; 

				//Console.WriteLine($"이름 : {arr[i].Name}\n나이 : {arr[i].Age}세\n키 : {arr[i].Height}cm\n몸무게 : {arr[i].Weight}kg\n");
			}
			//입력된 3명의 정보를 출력 
			//포이치문은 0번째부터 끝까지 알아서 인덱스를 읽고 순서대로 끝까지 0번째 부터 알아서 써내줌
			foreach(Person person in arr)
			{
				Console.WriteLine($"이름 : {person.Name}\n나이 : {person.Age}세\n키 : {person.Height}cm\n몸무게 : {person.Weight}kg\n");
			}

			for(int i=0;i<arr.Length;i++)
			{
				Console.WriteLine($"{arr[i].Name}");
			}
		}
	}
}
