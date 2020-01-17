using CadenaResponsabilidades.Interfaces;
using CadenaResponsabilidades.Responsabilidades;

namespace CadenaResponsabilidades
{
	public class Cliente
	{
		public string Iniciar(string _cSolicitud, decimal _dMonto)
		{
			INivelResponsabilidad coordinador = new Coordinador();
			INivelResponsabilidad gerente = new Gerente();
			INivelResponsabilidad subdirector = new Subdirector();
			INivelResponsabilidad director = new Director();

			coordinador.AgregarSiguiente(gerente);
			gerente.AgregarSiguiente(subdirector);
			subdirector.AgregarSiguiente(director);

			string cRespuesta = coordinador.Autorizar(_cSolicitud, _dMonto);

			return cRespuesta;
		}
	}
}
