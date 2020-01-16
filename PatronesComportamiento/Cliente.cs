using PatronesComportamiento.Interfaces;

namespace PatronesComportamiento
{
	public class Cliente
	{
		ConcentradorCodigo concentrador;

		public void AgregarSubscritptores()
		{
			concentrador = new ConcentradorCodigo();
			IObservador codigoCSharp = new CodigoCSharp();
			IObservador codigoJava = new CodigoJava();

			concentrador.Suscribir(codigoCSharp);
			concentrador.Suscribir(codigoJava);
		}

		public void SubirCodigo()
		{
			concentrador.SubirCodigo();
		}
	}
}
