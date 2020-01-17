using Estado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estado
{
	public class Alarma
	{
		public IEstadoAlarma estadoAlarma { get; set; }

		public Alarma(IEstadoAlarma _estadoAlarma)
		{
			estadoAlarma = _estadoAlarma;
		}

		public void CambiarEstado(IEstadoAlarma _estadoAlarma)
		{
			estadoAlarma = _estadoAlarma;
		}

		public string ActivarAlarma()
		{
			string cMensaje = string.Empty;
			cMensaje = estadoAlarma.Activar();

			return cMensaje;
		}

		public string InactivarAlarma()
		{
			string cMensaje = string.Empty;
			cMensaje = estadoAlarma.Inactivar();

			return cMensaje;
		}

	}
}
