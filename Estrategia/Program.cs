using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
	class Program
	{
		static void Main(string[] args)
		{
			string cNombre = string.Empty;
			string cOpcion = string.Empty;
			Cliente cliente = new Cliente();

			Console.WriteLine("Capture el nombre de la imagen a guardar:");
			cNombre = Console.ReadLine().Trim();

			Console.WriteLine("Seleccione el formato:");
			cliente.MostrarMenu();
			cOpcion = Console.ReadLine().Trim();

			string cResultado = cliente.EjecutarEstrategia(cNombre, cOpcion);
			Console.WriteLine(cResultado);

			Console.ReadLine();
		}
	}
}
