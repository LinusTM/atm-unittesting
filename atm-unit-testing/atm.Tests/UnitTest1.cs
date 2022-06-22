namespace atm.Tests;

public class UnitTest1
{
    [Fact]
    public void IsPinCorrect()
    {
		// Instances
		Account account1 = new Account("Gabe", 4918, 40000);
		ValidatePin pinValidate = new ValidatePin(account1.pin);

		// Act
		bool actual = pinValidate.Compare(4918);

		// Assert
		Assert.True(actual);

		Assert.Equal()
    }

    [Fact]
	public void IsWithdrawalPossible()
	{
		Account account2 = new Account("Greg", 6732, 32000);
		Withdraw withdraw = new Withdraw();
	}

	[Fact]
	public void AddAccountToBank()
	{
		
	}
}
