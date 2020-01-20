using Comandos.Interfaces;

namespace Comandos.Guerreros
{
	public class GuerreroMedio : IGuerrero
	{
		public string cTitulo => "Guerrero de Clase Media";

		public string cIdOpcion { get; }

		public GuerreroMedio(string _cIdOpcion)
		{
			cIdOpcion = _cIdOpcion;
		}

		public int ObtenerPoder()
		{
			return 20;
		}
	}
}
