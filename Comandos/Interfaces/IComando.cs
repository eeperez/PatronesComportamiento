using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos.Interfaces
{
	public interface IComando
	{
		string cId { get; set; }

		string cNombreAccion { get; set; }

		string EjecutarAccion(GuerreroDTO _guerreroDTO);
	}
}
