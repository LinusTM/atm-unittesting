namespace atm.Tests;

public class UnitTest1
{
    [Fact]
    public void Is_Pin_Correct()
    {
		// Instances
		Account account1 = new account("Gabe", 4918, 40000);
		ValidatePin PinValidator = new ValidatorPin(account1.pin);

		// Act
		bool actual = PinValidator.Compare(4918);

		// Assert
		Assert.True(actual);

		Assert.Equal()
    }

    [Fact]
	public void Is_Withdrawal_Possible()
	{
		Account account2 = new account("Greg", 6732, 32000);
		Withdraw withdraw = new withdraw();
	}

	[Fact]
	public void Add_Account_To_Bank()
	{
		
	}
}
