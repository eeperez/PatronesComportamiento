using Estrategia.Interfaces;

namespace Estrategia.Estrategias
{
	public class FormatoJPEG : IFormatoImagen
	{
		public string GuardarImagen(string _cNombreImagen)
		{
			return $"Se ha guardado {_cNombreImagen}.JPEG";
		}
	}
}
