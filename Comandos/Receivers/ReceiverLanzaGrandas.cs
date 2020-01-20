namespace Comandos.Receivers
{
	public class ReceiverLanzaGrandas
	{
		string cNombreLanzaGranada = "Lanza Granadas";

		public string ConseguirLanzaGrandas(ref string _cNombreAccion)
		{
			if (_cNombreAccion != null)
				_cNombreAccion = $"Disparar {cNombreLanzaGranada}";

			return $"Ya se puede usar {cNombreLanzaGranada.ToLower()}";
		}
	}
}
