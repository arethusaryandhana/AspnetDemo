namespace AspnetDemo.Services
{
	public class BankAccountService : IBankAccountService
	{
		public int Balance()
		{
			return 1000000;
		}
		public int Depositing(int a)
		{
			return Balance() + a;
		}
		public int WithDrawing(int a)
		{
			return Balance() - a;
		}
	}
}
