using Comandos.Interfaces;
using Comandos.Receivers;

namespace Comandos.Comandos
{
	public class ComandoLanzaGranada : IComando
	{
		public string cNombreAccion { get; set; }

		public string cId { get; set; }

		private ReceiverLanzaGrandas receiverLanzaGrandas { get; set; }

		private bool lSeTiene { get; set; }

		public ComandoLanzaGranada(ReceiverLanzaGrandas _receiverLanzaGrandas, string _cId)
		{
			cId = _cId;
			lSeTiene = false;
			receiverLanzaGrandas = _receiverLanzaGrandas;
			cNombreAccion = "Conseguir Lanza Granadas";
		}

		public string EjecutarAccion(GuerreroDTO _guerreroDTO)
		{
			string cResultado;
			string cAccion = string.Empty;

			if (lSeTiene)
			{
				cAccion = DispararGrandas();
				cResultado = $"{_guerreroDTO.cNombre} {cAccion} con potencia de {_guerreroDTO.iPoder}";
			}
			else
			{
				cResultado = receiverLanzaGrandas.ConseguirLanzaGrandas(ref cAccion);
				cNombreAccion = cAccion;
				lSeTiene = true;
			}

			return cResultado;
		}

		private string DispararGrandas()
		{
			return "DISPARANDO GRANADAS";
		}
	}
}
