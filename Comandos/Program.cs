using Comandos.Interfaces;
using System;
using System.Collections.Generic;

namespace Comandos
{
	class Program
	{
		static void Main(string[] args)
		{
			Cliente cliente = new Cliente();
			string cNombreGuerrero;
			string cOpcionGuerrero;
			string cOpcionComando;
			string cRespuesta;

			List<IGuerrero> lstGuerrerosMostrar = cliente.ObtenerClasesGuerreros();
			List<IComando> lstComandosMostrar = cliente.ObtenerComandos();

			MostrarGuerreros(lstGuerrerosMostrar);
			Console.WriteLine("x. Salir");
			cOpcionGuerrero = Console.ReadLine();
			if (cOpcionGuerrero.ToLower() == "x")
				Environment.Exit(0);

			Console.WriteLine("Capture el nombre del personaje:");
			cNombreGuerrero = Console.ReadLine();

			while (true)
			{
				MostrarComandos(lstComandosMostrar);
				cOpcionComando = Console.ReadLine();

				cRespuesta = cliente.EjecutarJuego(cNombreGuerrero, cOpcionGuerrero, cOpcionComando, lstGuerrerosMostrar);
				Console.WriteLine(cRespuesta);

				Console.ReadLine();
			}

		}

		private static void MostrarGuerreros(List<IGuerrero> _lstGuerrerosMostrar)
		{
			List<string> lstImpresion = new List<string>();

			lstImpresion.Add("Seleccione un Tipo de Guerrero:");
			foreach (var guerrero in _lstGuerrerosMostrar)
			{
				lstImpresion.Add($"{guerrero.cIdOpcion}. {guerrero.cTitulo}");
			}

			Console.WriteLine(string.Join("\n", lstImpresion));
		}

		private static void MostrarComandos(List<IComando> _lstComandos)
		{
			List<string> lstImpresion = new List<string>();

			lstImpresion.Add("Seleccione una Acción:");
			foreach (var comando in _lstComandos)
			{
				lstImpresion.Add($"{comando.cId}. {comando.cNombreAccion}");
			}

			Console.WriteLine(string.Join("\n", lstImpresion));
		}
	}
}
