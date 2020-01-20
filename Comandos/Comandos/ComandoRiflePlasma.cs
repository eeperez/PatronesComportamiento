using Comandos.Interfaces;
using Comandos.Receivers;

namespace Comandos.Comandos
{
	public class ComandoRiflePlasma : IComando
	{
		public string cNombreAccion { get; set; }

		public string cId { get; set; }

		private ReceiverPlasma receiverPlasma { get; set; }

		private bool lSeTiene { get; set; }

		public ComandoRiflePlasma(ReceiverPlasma _receiverPlasma, string _cId)
		{
			cId = _cId;
			lSeTiene = false;
			receiverPlasma = _receiverPlasma;
			cNombreAccion = "Conseguir Rifle de Plasma";
		}

		public string EjecutarAccion(GuerreroDTO _guerreroDTO)
		{
			string cResultado;
			string cAccion = string.Empty;

			if (lSeTiene)
			{
				cAccion = DispararPlasma();
				cResultado = $"{_guerreroDTO.cNombre} {cAccion} con potencia de {_guerreroDTO.iPoder}";
			}
			else //Invocar el receiver de Plasma (cambiar el nombre de la accion y regresar el mensaje de Obtenido...)
			{
				cResultado = receiverPlasma.ConseguirPlasma(ref cAccion);
				cNombreAccion = cAccion;
				lSeTiene = true;
			}

			return cResultado;
		}

		private string DispararPlasma()
		{
			return "DISPARANDO PLASMA";
		}
	}
}
