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

			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";
			test += ", 5";
			test += ", 6";

			Console.WriteLine ("Събиране с +=: " + test+ "\n");
			Console.WriteLine ("Третият знак: " + test.Split (',')[2]+ "\n");

			test = test.Replace ( ",",";");
			Console.WriteLine ("Работа с Replace: " + test+ "\n");

			Console.WriteLine ("Третият знак: " + test.Split (';')[2]+ "\n");


		}
	}
}
