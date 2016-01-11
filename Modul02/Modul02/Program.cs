using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0, sum = 0;

			//Събиране на числа
			a = 10;
			b = 5;


			sum = a + b;

			//Писане в конзала
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine ( sum );

			//Допълнителни оператори
			Console.WriteLine (" \n използване на += ");
			a += b;
			Console.WriteLine (a);

			Console.WriteLine (" \n използване на -= ");
			a -= b;
			Console.WriteLine (a);

			Console.WriteLine (" \n използване на *= ");
			a *= b;
			Console.WriteLine (a);

			Console.WriteLine (" \n използване на ++ ");
			a ++;
			Console.WriteLine (a);
			Console.WriteLine (" \n използване на -- ");
			a --;
			Console.WriteLine (a);

			Console.WriteLine ("\nСтандартно делене "  +  ( 15/4 ) .ToString( )); // - 2 (7/3=2.333333)
			Console.WriteLine ("\nОстатък делене    "  +  ( 15%4 ) .ToString( )); //- 1 (1/3=0.3333333)
		}
	}
}
