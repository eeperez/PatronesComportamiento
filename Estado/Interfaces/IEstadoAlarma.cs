using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estado.Interfaces
{
	public interface IEstadoAlarma
	{
		string Activar();

		string Inactivar();
	}
}
