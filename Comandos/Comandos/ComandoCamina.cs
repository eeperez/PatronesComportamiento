using Comandos.Interfaces;

namespace Comandos.Comandos
{
	public class ComandoCamina : IComando
	{
		public string cNombreAccion { get; set; }

		public string cId { get; set; }

		public ComandoCamina(string _cId)
		{
			cId = _cId;
			cNombreAccion = "Caminar";
		}

		public string EjecutarAccion(GuerreroDTO _guerreroDTO)
		{
			string cAccion = Caminar();

			return $"{_guerreroDTO.cNombre} {cAccion} con velocidad de {_guerreroDTO.iPoder}";
		}

		private string Caminar()
		{
			return "CAMINANDO";
		}
	}
}
