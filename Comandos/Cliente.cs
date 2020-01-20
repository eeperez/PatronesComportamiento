using Comandos.Comandos;
using Comandos.Guerreros;
using Comandos.Interfaces;
using Comandos.Invoker;
using Comandos.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Comandos
{
	public class Cliente
	{
		private List<IComando> lstComandos;

		public List<IGuerrero> ObtenerClasesGuerreros()
		{
			List<IGuerrero> lstInstanciasGuerrero = new List<IGuerrero>();

			lstInstanciasGuerrero.Add(new GuerreroBajo("1"));
			lstInstanciasGuerrero.Add(new GuerreroMedio("2"));
			lstInstanciasGuerrero.Add(new GuerreroAlto("3"));
			
			return lstInstanciasGuerrero;
		}

		public List<IComando> ObtenerComandos()
		{
			lstComandos = new List<IComando>();

			lstComandos.Add(new ComandoCamina("1"));
			lstComandos.Add(new ComandoSalta("2"));
			lstComandos.Add(new ComandoGolpea("3"));
			lstComandos.Add(new ComandoDispara("4"));
			lstComandos.Add(new ComandoLanzaGranada(new ReceiverLanzaGrandas(), "5"));
			lstComandos.Add(new ComandoRiflePlasma(new ReceiverPlasma(), "6"));

			return lstComandos;
		}

		public string EjecutarJuego(string _cNombre, string _cIdOpcionGuerrero, string _cIdComando, List<IGuerrero> _lstGuerreros)
		{
			string cRespuesta;
			GuerreroDTO guerreroDTO;
			IComando IcomandoSeleccionado;
			JuegoGuerrero juego;

			try
			{
				guerreroDTO = ArmarDatosGuerreroSelecionado(_cNombre, _cIdOpcionGuerrero, _lstGuerreros);
				IcomandoSeleccionado = ObtenerComandoSeleccionado(_cIdComando, lstComandos);
				juego = new JuegoGuerrero(IcomandoSeleccionado, guerreroDTO);
				cRespuesta = juego.Ejecutar();
			}
			catch (Exception excepcion)
			{
				cRespuesta = excepcion.Message;
			}

			return cRespuesta;
		}

		private GuerreroDTO ArmarDatosGuerreroSelecionado(string _cNombre, string _cOpcionGuerrero, List<IGuerrero> _lstGuerreros)
		{
			GuerreroDTO guerreroDTO = new GuerreroDTO();

			var Iguerrero = _lstGuerreros.Where(g => g.cIdOpcion == _cOpcionGuerrero).FirstOrDefault();
			guerreroDTO.iPoder = Iguerrero.ObtenerPoder();
			guerreroDTO.cNombre = _cNombre;

			return guerreroDTO;
		}

		private IComando ObtenerComandoSeleccionado(string _cIdOpcion, List<IComando> _lstComandos)
		{
			return _lstComandos.Where(c => c.cId == _cIdOpcion).FirstOrDefault();
		}

		
	}
}
