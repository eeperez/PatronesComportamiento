using Estrategia.Estrategias;
using Estrategia.Interfaces;
using System;
using System.Collections.Generic;

namespace Estrategia
{
	public class Cliente
	{
		public void MostrarMenu()
		{
			List<string> lstMenu = new List<string>
			{
				"1. BMP",
				"2. PNG",
				"3. JPEG"
			};

			foreach (string cMenu in lstMenu)
			{
				Console.WriteLine(cMenu);
			}
		}

		private IFormatoImagen CrearEstrategia(string _cOpcion)
		{
			IFormatoImagen imagen = new FormatoBMP();

			switch (_cOpcion)
			{
				case "1":
					imagen = new FormatoBMP();
					break;
				case "2":
					imagen = new FormatoPNG();
					break;
				case "3":
					imagen = new FormatoJPEG();
					break;
			}

			return imagen;
		}

		public string EjecutarEstrategia(string _cNombre, string _cOpcionFormato)
		{
			GuardadoImagen guardado = new GuardadoImagen();
			var imagen = CrearEstrategia(_cOpcionFormato);
			guardado.AgregarImagen(imagen);
			string cMensaje = guardado.Guardar(_cNombre);

			return cMensaje;
		}
	}
}
