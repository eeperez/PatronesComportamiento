﻿using PatronesComportamiento.Interfaces;
using System;

namespace PatronesComportamiento
{
	public class CodigoCSharp : IObservador
	{
		string cNombreCodigo = "C#";
		public void Compilar()
		{
			string cMensaje = $"Compilar código: {cNombreCodigo}";
			Console.WriteLine(cMensaje);
		}

		public void EjecutarPruebasUnitarias()
		{
			string cMensaje = $"Ejecutar PU {cNombreCodigo}";
			Console.WriteLine(cMensaje);
		}

		public void EnviarCorreo()
		{
			string cMensaje = $"Enviar correo {cNombreCodigo}";
			Console.WriteLine(cMensaje);
		}

		public void InstalarVersion()
		{
			string cMensaje = $"Instalar código {cNombreCodigo}";
			Console.WriteLine(cMensaje);
		}
	}
}
