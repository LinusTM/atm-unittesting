namespace account;
public class Account
{
	private string accountOwner;
    public string AccountOwner {
        get => accountOwner;
    }

	private string accountNumber;
	public stirng AccountNumber {
		get => accountNumber;
	}

	private string cardNumber;
	public string CardNumber {
		get => cardNumber;
	}

	private int pin;
	public int Pin {
		get => pin;
	}

	private double balance;
	public double Balance {
		get => balance;
		set => balance = value;
	}

	public Account(string accountOwner, double balance) {
		this.accountOwner = accountOwner;
		this.accountNumber = GenerateAccountNumber();
		this.cardNumber = GenerateCardNumber();
		this.pin = GeneratePin();
		this.balance = balance;
	}

	private string GenerateAccountNumber() {
		stirng accountNumber;

        while(accountNumber.Length < 16) {
            accountNumber += Random.Shared.Next(0, 10).ToString();
        }

        return accountNumber;
	}

	private string GenerateCardNumber() {
		stirng cardNumber;

		while(cardNumber.Length < 10) {
            cardNumber += Random.Shared.Next(0, 10).ToString();
        }
        
		return cardNumber;
	}

	private string GeneratePin() {
		stirng pin;

		while(pin.Length < 4) {
            pin += Random.Shared.Next(0, 10).ToString();
        }
        
		return pin;
	}
}
