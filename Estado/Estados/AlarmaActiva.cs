using Estado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estado.Estados
{
	public class AlarmaActiva : IEstadoAlarma
	{
		private Alarma alarma { get; set; }

		public string Activar()
		{
			string cMensaje = "La alarma ya esta Activa";
			return cMensaje;
		}

		public string Inactivar()
		{
			string cMensaje = "Se Desactiva la alarma";
			var inactiva = new AlarmaInactiva();
			inactiva.AsignarAlarma(alarma);
			alarma.CambiarEstado(inactiva);

			return cMensaje;
		}

		public void AsignarAlarma(Alarma _alarma)
		{
			alarma = _alarma;
		}
	}
}
