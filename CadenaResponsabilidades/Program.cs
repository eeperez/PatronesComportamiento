using System;

namespace CadenaResponsabilidades
{
	class Program
	{
		static void Main(string[] args)
		{
			Cliente cliente = new Cliente();
			string cNombre = string.Empty;

			while (true)
			{
				Console.WriteLine("Capture el nombre de la solicitud de compra:");
				cNombre = Console.ReadLine().Trim();

				Console.WriteLine("Capture el monto:");
				decimal dMonto = Convert.ToDecimal(Console.ReadLine().Trim());

				string cRespuesta = cliente.Iniciar(cNombre, dMonto);
				Console.WriteLine($"==> {cRespuesta}");

				Console.ReadLine();
			}
		}
	}
}
