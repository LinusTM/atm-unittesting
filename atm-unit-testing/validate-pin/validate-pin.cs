namespace validate_pin;
public class ValidatePin
{
	public bool Compare(int userInput, int accountPin) {
		return userInput == accountPin;
	}
}
