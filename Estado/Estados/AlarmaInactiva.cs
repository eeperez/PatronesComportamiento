using Estado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estado.Estados
{
	public class AlarmaInactiva : IEstadoAlarma
	{
		private Alarma alarma { get; set; }

		public string Activar()
		{
			string cMensaje = "Se Activa la alarma";
			var activa = new AlarmaActiva();
			activa.AsignarAlarma(alarma);
			alarma.CambiarEstado(activa);

			return cMensaje;
		}

		public string Inactivar()
		{
			string cMensaje = "La alarma ya esta Inactiva";
			return cMensaje;
		}

		public void AsignarAlarma(Alarma _alarma)
		{
			alarma = _alarma;
		}
	}
}
