using CadenaResponsabilidades.Interfaces;

namespace CadenaResponsabilidades.Responsabilidades
{
	public class Director : INivelResponsabilidad
	{
		private INivelResponsabilidad siguienteResponsable { get; set; }

		public void AgregarSiguiente(INivelResponsabilidad _responsable)
		{
			siguienteResponsable = _responsable;
		}

		public string Autorizar(string _cSolicitud, decimal _dMonto)
		{
			string cRespuesta = "Compra Denegada";

			if (_dMonto > 15000m && _dMonto <= 50000m)
				cRespuesta = $"Compra de {_cSolicitud} AUTORIZADA por el Director";
			else
			{
				if (siguienteResponsable != null)
					cRespuesta = siguienteResponsable.Autorizar(_cSolicitud, _dMonto);
			}

			return cRespuesta;
		}
	}
}
