using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estado
{
	class Program
	{
		static void Main(string[] args)
		{
			string cOpcion = string.Empty;
			Cliente cliente = new Cliente();
			cliente.IniciarAlarma();

			while (cOpcion != "3")
			{
				Console.WriteLine("Seleccione la acción de la alarma a realizar:");
				cliente.MostrarMenu();

				cOpcion = Console.ReadLine().Trim();
				string cResultado = cliente.RealizarAccion(cOpcion);
				Console.WriteLine(cResultado);

				Console.ReadLine();
			}
		}
	}
}
