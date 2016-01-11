using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на входни параметри
			Console.WriteLine ("Стойността на A е 5");
			Console.Write ("Моля въведете b: ");
			b = Convert.ToInt32 (Console.ReadLine ());

			//Показване на резултат
			Console.WriteLine ("Резултата а+b е: "+(a+b).ToString ()+ "\n\n\n");
		}
	}
}
