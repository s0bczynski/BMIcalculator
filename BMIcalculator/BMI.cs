using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIcalculator
{
	public class BMI
	{
		public static string getWeight()
		{
			Console.Clear();
			Console.Write("Enter your weight in kg: ");
			return Console.ReadLine();
		}
		public static string getHeight()
		{
			Console.Clear();
			Console.Write("Enter your height in cm: ");
			return Console.ReadLine();
		}
		public static void checkCondition(double bmiResult)
		{
			if(bmiResult < 18.5)
			{
				 Console.WriteLine("You're underweight - for your own health you have to gain some weight!");
			}
			if(bmiResult > 18.5 && bmiResult < 24.9)
			{
				Console.WriteLine("You're in perfect weight!");
			}
			if(bmiResult > 24.9 && bmiResult < 30)
			{
				Console.WriteLine("You're overweight - consider hitting a gym");
			}
			if(bmiResult > 30)
			{
				Console.WriteLine("You're obese! For your own health you have to lose some weight! ");
			}
			
		}

		
	}
}
