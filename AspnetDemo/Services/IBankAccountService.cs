namespace AspnetDemo.Services
{
	public interface IBankAccountService
	{
		int Balance();
		int Depositing(int a);
		int WithDrawing(int a);
	}
}
