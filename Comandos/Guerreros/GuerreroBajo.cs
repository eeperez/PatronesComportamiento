using Comandos.Interfaces;

namespace Comandos.Guerreros
{
	public class GuerreroBajo : IGuerrero
	{
		public string cTitulo => "Guerrero de Clase Baja";

		public string cIdOpcion { get; }

		public GuerreroBajo(string _cIdOpcion)
		{
			cIdOpcion = _cIdOpcion;
		}

		public int ObtenerPoder()
		{
			return 10;
		}
	}
}
