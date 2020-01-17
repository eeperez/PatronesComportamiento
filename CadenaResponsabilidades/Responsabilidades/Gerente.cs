using CadenaResponsabilidades.Interfaces;

namespace CadenaResponsabilidades.Responsabilidades
{
	public class Gerente : INivelResponsabilidad
	{
		private INivelResponsabilidad siguienteResponsable { get; set; }

		public void AgregarSiguiente(INivelResponsabilidad _responsable)
		{
			siguienteResponsable = _responsable;
		}

		public string Autorizar(string _cSolicitud, decimal _dMonto)
		{
			string cRespuesta = string.Empty;

			if (_dMonto > 5000m && _dMonto <= 10000m)
				cRespuesta = $"Compra de {_cSolicitud} AUTORIZADA por el Gerente";
			else
			{
				if (siguienteResponsable != null)
					cRespuesta = siguienteResponsable.Autorizar(_cSolicitud, _dMonto);
			}

			return cRespuesta;
		}
	}
}
