namespace validate_pin.Tests;

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
	[InlineData(2994, 20010, 2003)]
	[InlineData(2994, 2010, 2013)]
	[InlineData(true, false, false)]
	public void PinLengthShouldMatch(int inputPin, int accountPin, bool expected)
	{
		ValidatePin pinValidate = new ValidatePin();

		bool result = pinValidate.Compare(inputPin, accountPin);

		Assert.Equal(expected, result);
	}
}

