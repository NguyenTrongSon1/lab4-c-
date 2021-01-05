using System;
using System.Collections.Generic;
using System.Text;

namespace asm
{
    class sale
    {
		int mediCode;
		int qtySold;
		int plaSales;
		int acSales;
		string region;
		public void Accpect()
		{
			Console.Write("Enter medicine Code: ");
			mediCode = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter qty Sold: ");
			qtySold = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter place Sales: ");
			plaSales = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter ac Sales: ");
			acSales = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter Region: ");
			region = Console.ReadLine();

		}

		public void Display()
		{
			Console.WriteLine("Medicine Code : " + mediCode);
			Console.WriteLine("QTY Sales : " + qtySold);
			Console.WriteLine("Places Sales : " + plaSales);
			Console.WriteLine("Actual Sales : " + acSales);
			Console.WriteLine("Region : " + region);
		}
	}
}
