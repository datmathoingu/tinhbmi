using System;
using System.Text;

namespace tinhbmi
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			double height;
			double weight;
			double bmi;
			//Chiều cao: cm
			//Cân nặng: kg
			Console.WriteLine("Nhập chiều cao : ");
			height = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Nhập cân nặng : ");
			weight = Convert.ToDouble(Console.ReadLine());
			height = height / 100;
			bmi = weight / (height * height);
			Console.WriteLine("BMI của bạn là:{0}", Math.Round(bmi, 4));
			if (bmi < 18.5)
				Console.WriteLine("Underweight.");
			else if (bmi >= 18.5 && bmi < 25)
				Console.WriteLine("Normal");
			else if (bmi >= 25 && bmi < 30)
				Console.WriteLine("Overweight");
			else if (bmi >= 30)
				Console.WriteLine("Obese");

		}
	}
}
