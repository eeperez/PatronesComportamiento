using PatronesComportamiento.Interfaces;
using System;
using System.Collections.Generic;

namespace PatronesComportamiento
{
	public class ConcentradorCodigo
	{
		public List<IObservador> lstSubscriptores { get; set; }

		public ConcentradorCodigo()
		{
			lstSubscriptores = new List<IObservador>();
		}

		public void Suscribir(IObservador _observador)
		{
			lstSubscriptores.Add(_observador);
		}

		private void NotificarSubscriptores()
		{
			foreach (var subscriptor in lstSubscriptores)
			{
				subscriptor.Compilar();
				subscriptor.EjecutarPruebasUnitarias();
				subscriptor.InstalarVersion();
				subscriptor.EnviarCorreo();
			}
		}

		public void SubirCodigo()
		{
			Console.WriteLine("Al subir código:");
			NotificarSubscriptores();
		}
	}
}
