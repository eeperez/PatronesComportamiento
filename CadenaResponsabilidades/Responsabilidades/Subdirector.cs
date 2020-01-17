using CadenaResponsabilidades.Interfaces;

namespace CadenaResponsabilidades.Responsabilidades
{
	public class Subdirector : INivelResponsabilidad
	{
		private INivelResponsabilidad siguienteResponsable { get; set; }

		public void AgregarSiguiente(INivelResponsabilidad _responsable)
		{
			siguienteResponsable = _responsable;
		}

		public string Autorizar(string _cSolicitud, decimal _dMonto)
		{
			string cRespuesta = string.Empty;

			if (_dMonto > 10000m && _dMonto <= 15000m)
				cRespuesta = $"Compra de {_cSolicitud} AUTORIZADA por el Subdirector";
			else
			{
				if (siguienteResponsable != null)
					cRespuesta = siguienteResponsable.Autorizar(_cSolicitud, _dMonto);
			}

			return cRespuesta;
		}
	}
}
