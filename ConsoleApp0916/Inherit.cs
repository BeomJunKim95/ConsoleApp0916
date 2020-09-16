using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
	class Man
	{
		private string fName;
		public string FirstName 
		{
			get { return fName; }
			set { fName = value; }
		}

		private string lName;
		public string LastName
		{
			get { return lName; }
			set { lName = value; }
		}

		public virtual void PrintInfo()  //virtual : 키워드는 상속받을 클래스를 위해 오버라이드를 허락해주는 키워드
		{
			Console.WriteLine("======== Man =========");
			Console.WriteLine($"First Name : {fName}");
			Console.WriteLine($"Last Name : {lName}");
			Console.WriteLine("======================");
		}

		public override string ToString()  //object클래스 ToString오버라이드
		{	
			//string 타입은 리턴이 필요함
			return $"{fName} {lName}";
		}
	}

	class Employee : Man //Employee가 Man 상속받음
	{
		int employeeID;
		public Employee(int employeeID)
		{
		this.employeeID = employeeID;
		}
		public override void PrintInfo() //명시적으로 상속받은 PrintInfo를 숨기기 위해 new명령어 사용가능 => public new void PrintInfo()
		{								 //하지만 new를 많이 쓰진않음
										 //이런경우 제일 많이쓰는 override(재정의), 부모클래스가 virtual 명령어로 오버라이딩을 허락해 줘야함
			Console.WriteLine("======== Employee =========");
			Console.WriteLine($"employeeID : {employeeID}");
			Console.WriteLine($"First Name : {this.FirstName}"); //클래스 내부에서 자신을 가리킬때 쓰는 this
																 //this를 쓰는경우 : 매개변수 와 지역변수 가 이름이 같을때 지역변수를 가리키기 위해
			Console.WriteLine($"Last Name : {LastName}");		 // 지금은 this를 안써도 되는 경우
			Console.WriteLine("===========================");
		}

	}

	class InheritTest
	{
		static void Main()
		{
			Man man = new Man();
			man.FirstName = "류";
			man.LastName = "현진";
			man.PrintInfo();

			Employee emp1 = new Employee(2020005);
			emp1.FirstName = "아";
			emp1.LastName = "이유";
			emp1.PrintInfo();

			Console.WriteLine(man.ToString());
		}
	}
}
