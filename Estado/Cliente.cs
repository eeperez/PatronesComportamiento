using Estado.Estados;
using System;
using System.Collections.Generic;

namespace Estado
{
	public class Cliente
	{
		private Alarma alarma { get; set; }

		public void MostrarMenu()
		{
			List<string> lstMenu = new List<string>
			{
				"1. Activar",
				"2. Desactivar",
				"3. Salir"
			};

			foreach (string cMenu in lstMenu)
			{
				Console.WriteLine(cMenu);
			}
		}

		public void IniciarAlarma()
		{
			var estadoInicial = new AlarmaInactiva();
			alarma = new Alarma(estadoInicial);
			estadoInicial.AsignarAlarma(alarma);
		}

		public string RealizarAccion(string _cAccion)
		{
			string cResultado = string.Empty;

			if (_cAccion == "1")
				cResultado = alarma.ActivarAlarma();

			if (_cAccion == "2")
				cResultado = alarma.InactivarAlarma();

			return cResultado;
		}
	}
}
