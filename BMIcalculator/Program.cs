using BMIcalculator;
using System;
using System.Runtime.CompilerServices;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			string h = BMI.getHeight();
			string w = BMI.getWeight();
			double h1 = double.Parse(h);
			double w1 = double.Parse(w);
			Console.Clear();

			double bmiResult = w1 / ((h1/100) * (h1/100));
			Console.WriteLine($"Your BMI is: {bmiResult}. ");
			BMI.checkCondition(bmiResult);
		}
	}
}