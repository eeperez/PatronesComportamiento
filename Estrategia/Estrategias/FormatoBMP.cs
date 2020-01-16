using Estrategia.Interfaces;

namespace Estrategia.Estrategias
{
	public class FormatoBMP : IFormatoImagen
	{
		public string GuardarImagen(string _cNombreImagen)
		{
			return $"Se ha guardado {_cNombreImagen}.BMP";
		}
	}
}
