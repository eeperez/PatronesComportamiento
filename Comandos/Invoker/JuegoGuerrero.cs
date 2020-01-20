using Comandos.Interfaces;
using System;

namespace Comandos.Invoker
{
	public class JuegoGuerrero
	{
		private IComando comandoJuego { get; set; }

		private GuerreroDTO guerreroDTO { get; set; }

		public JuegoGuerrero(IComando _comandoJuego, GuerreroDTO _guerreroDTO)
		{
			guerreroDTO = _guerreroDTO;
			comandoJuego = _comandoJuego ?? throw new Exception("Es necesario un comando");
		}

		public string Ejecutar()
		{
			string cResultado;

			cResultado = comandoJuego.EjecutarAccion(guerreroDTO);

			return cResultado;
		}
	}
}
