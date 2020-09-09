
using System;
using System.Text;

namespace tinhbmi
{
    class Program
    {
        static double Tinh(double a, double b)
        {
            a = a / 100;
            double result = b / (a * a);
            return result;

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double height, weight, bmi;
            //Chiều cao: cm
            //Cân nặng: kg
            Console.WriteLine("Nhập chiều cao : ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng : ");
            weight = Convert.ToDouble(Console.ReadLine());
            bmi = Program.Tinh(height, weight);
            Console.WriteLine("BMI của bạn là: {0}", Math.Round(bmi, 4));

            if (bmi < 18.5)
                Console.WriteLine("Bạn xếp vào loại: Underweight.");
            else if (bmi >= 18.5 && bmi < 25)
                Console.WriteLine("Bạn xếp vào loại: Normal");
            else if (bmi >= 25 && bmi < 30)
                Console.WriteLine("Bạn xếp vào loại: Overweight");
            else if (bmi >= 30)
                Console.WriteLine("Bạn xếp vào loại: Obese");
        }
    }
}
