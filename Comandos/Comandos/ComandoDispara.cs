using Comandos.Interfaces;

namespace Comandos.Comandos
{
	public class ComandoDispara : IComando
	{
		public string cNombreAccion { get; set; }

		public string cId { get; set; }

		public ComandoDispara(string _cId)
		{
			cId = _cId;
			cNombreAccion = "Disparar Pistola";
		}

		public string EjecutarAccion(GuerreroDTO _guerreroDTO)
		{
			string cAccion = Disparar();

			return $"{_guerreroDTO.cNombre} {cAccion} con potencia de {_guerreroDTO.iPoder}";
		}

		private string Disparar()
		{
			return "DISPARANDO PISTOLA";
		}
	}
}
