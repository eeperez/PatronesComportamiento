using System;

namespace PatronesComportamiento
{
	class Program
	{
		static void Main(string[] args)
		{
			Cliente cliente = new Cliente();

			cliente.AgregarSubscritptores();

			
			cliente.SubirCodigo();

			Console.ReadLine();
		}
	}
}
