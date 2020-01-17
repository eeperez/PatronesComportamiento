using CadenaResponsabilidades.Interfaces;

namespace CadenaResponsabilidades.Responsabilidades
{
	public class Coordinador : INivelResponsabilidad
	{
		private INivelResponsabilidad siguienteResponsable { get; set; }

		public string Autorizar(string _cSolicitud, decimal _dMonto)
		{
			string cRespuesta = string.Empty;

			if (_dMonto <= 5000m)
				cRespuesta = $"Compra de {_cSolicitud} AUTORIZADA por el Coordinador";
			else
			{
				if (siguienteResponsable != null)
					cRespuesta = siguienteResponsable.Autorizar(_cSolicitud, _dMonto);
			}

			return cRespuesta;
		}

		public void AgregarSiguiente(INivelResponsabilidad _responsable)
		{
			siguienteResponsable = _responsable;
		}
	}
}
