namespace Comandos.Interfaces
{
	public interface IGuerrero
	{
		string cIdOpcion { get; }

		string cTitulo { get; }

		int ObtenerPoder();
	}
}
