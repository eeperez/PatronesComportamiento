using Estrategia.Interfaces;

namespace Estrategia.Estrategias
{
	class FormatoPNG : IFormatoImagen
	{
		public string GuardarImagen(string _cNombreImagen)
		{
			return $"Se ha guardado {_cNombreImagen}.PNG";
		}
	}
}
