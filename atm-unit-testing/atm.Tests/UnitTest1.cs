namespace atm.Tests;

public class UnitTest1
{
    [Fact]
    public void IsPinCorrect()
    {
		// Instances
		Account account1 = new Account("Gabe", 40000);
		int userInput = account1.pin;

		ValidatePin pinValidate = new ValidatePin();
		
		// Act
		bool actual = pinValidate.Compare(userInput, account1.pin);

		// Assert
		Assert.True(actual);
    }

	[Theory]
}

