namespace Comandos.Receivers
{
	public class ReceiverPlasma
	{
		string cNombrePlasma = "Rifle de Plasma";

		public string ConseguirPlasma(ref string _cNombreAccion)
		{
			if (_cNombreAccion != null)
				_cNombreAccion = $"Disparar {cNombrePlasma}";

			return $"Ya se puede usar {cNombrePlasma.ToLower()}";
		}
	}
}
