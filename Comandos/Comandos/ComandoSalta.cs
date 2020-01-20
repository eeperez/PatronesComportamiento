using Comandos.Interfaces;

namespace Comandos.Comandos
{
	public class ComandoSalta : IComando
	{
		public string cNombreAccion { get; set; }
		public string cId { get; set; }

		public ComandoSalta(string _cId)
		{
			cId = _cId;
			cNombreAccion = "Saltar";
		}

		public string EjecutarAccion(GuerreroDTO _guerreroDTO)
		{
			string cAccion = Saltar();

			return $"{_guerreroDTO.cNombre} {cAccion} con altura de {_guerreroDTO.iPoder}";
		}

		private string Saltar()
		{
			return "SALTANDO";
		}
	}
}
