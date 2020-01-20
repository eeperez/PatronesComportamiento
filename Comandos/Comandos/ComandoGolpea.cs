using Comandos.Interfaces;

namespace Comandos.Comandos
{
	public class ComandoGolpea : IComando
	{
		public string cNombreAccion { get; set; }
		public string cId { get; set; }

		public ComandoGolpea(string _cId)
		{
			cId = _cId;
			cNombreAccion = "Golpear";
		}

		public string EjecutarAccion(GuerreroDTO _guerreroDTO)
		{
			string cAccion = Golpear();

			return $"{_guerreroDTO.cNombre} {cAccion} con potencia de {_guerreroDTO.iPoder}";
		}

		private string Golpear()
		{
			return "GOLPEANDO";
		}
	}
}
