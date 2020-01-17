using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaResponsabilidades.Interfaces
{
	public interface INivelResponsabilidad
	{
		string Autorizar(string _cSolicitud, decimal _dMonto);

		void AgregarSiguiente(INivelResponsabilidad _responsable);
	}
}
