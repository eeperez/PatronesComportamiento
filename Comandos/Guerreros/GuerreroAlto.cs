using Comandos.Interfaces;

namespace Comandos.Guerreros
{
	public class GuerreroAlto : IGuerrero
	{
		public string cTitulo { get => "Guerrero de Clase Alta,"; }

		public string cIdOpcion { get; }

		public GuerreroAlto(string _cIdOpcion)
		{
			cIdOpcion = _cIdOpcion;
		}

		public int ObtenerPoder()
		{
			return 30;
		}
	}
}
