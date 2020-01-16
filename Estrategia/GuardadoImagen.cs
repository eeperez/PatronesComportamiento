using Estrategia.Interfaces;

namespace Estrategia
{
	public class GuardadoImagen
	{
		private IFormatoImagen formatoImagen { get; set; }

		public void AgregarImagen(IFormatoImagen _imagen)
		{
			formatoImagen = _imagen;
		}

		public string Guardar(string _cNombre)
		{
			return formatoImagen.GuardarImagen(_cNombre);
		}
	}
}
