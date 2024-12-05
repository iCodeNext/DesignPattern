namespace Payment;

public class Program
{
	public static void Main()
	{
		Console.Write("Enter payment type (CreditCard/CryptoCurrency): ");
		var input = Console.ReadLine();

		if (!Enum.TryParse(input, true, out PaymentType paymentType))
		{
			paymentType = PaymentType.Unsupported;
		}

		Console.Write("Enter payment amount: ");
		if (!decimal.TryParse(Console.ReadLine(), out var price))
		{
			Console.WriteLine("Invalid price. Please enter a valid number.");
			return;
		}

		var payment = PaymentService.Create(paymentType, price);

		var response = payment.ProcessPayment(price);

		Console.WriteLine(response.Message);
	}
}

public class PaymentService
{
	public static IPaymentService Create(PaymentType type, decimal price)
	{
		switch (type)
		{
			case PaymentType.CreditCard:
				{
					var factory = new CreditCardFactory();
					return factory.CreateInstance();
				}
			case PaymentType.CryptoCurrency:
				{
					var factory = new CryptoCurrencyFactory();
					return factory.CreateInstance();
				}
			default:
				return new UnsupportedPayment();
		}
	}
}

public interface IPaymentService
{
	Payment ProcessPayment(decimal price);
}

public sealed class Payment
{
	public decimal? Price { get; init; }
	public string? Message { get; init; }
}

public enum PaymentType
{
	CreditCard,
	CryptoCurrency,
	Unsupported
}


public class CreditCard : IPaymentService
{
	public Payment ProcessPayment(decimal price)
	{
		var calc = new CreditCardCalculator();
		var finalAmount = calc.CalculatePayment(price);

		var response = new Payment
		{
			Message = $"Processed credit card payment of {finalAmount}.",
			Price = finalAmount
		};
		return response;
	}
}

public class CryptoCurrencyAdapter : IPaymentService
{
	private readonly CryptoCurrency _cryptoCurrency = new();

	public Payment ProcessPayment(decimal price)
	{
		var response = new Payment
		{
			Message = $"Processed crypto currency payment of {price}.",
			Price = _cryptoCurrency.PayByCrypto(price)
		};
		return response;
	}
}

public interface IPaymentCalculator
{
	decimal CalculatePayment(decimal price);
}

public class CreditCardCalculator : IPaymentCalculator
{
	public decimal CalculatePayment(decimal price)
	{
		return price + price * (decimal)0.02;
	}
}

public class UnsupportedPayment : IPaymentService
{
	public Payment ProcessPayment(decimal price)
	{
		return new Payment
		{
			Message = "Unsupported Payment"
		};
	}
}


public interface IPaymentServiceFactory
{
	IPaymentService CreateInstance();
}

public class CreditCardFactory : IPaymentServiceFactory
{
	public IPaymentService CreateInstance()
	{
		return new CreditCard();
	}
}

public class CryptoCurrencyFactory : IPaymentServiceFactory
{
	public IPaymentService CreateInstance()
	{
		return new CryptoCurrencyAdapter();
	}
}

// External library class (inaccessible for modification)
//public class CryptoCurrency
//{
//	public decimal PayByCrypto(decimal price)
//	{
//		return price;
//	}
//}

public sealed class CryptoCurrency
{
	private const decimal ConversionRate = 0.0005m; 
	private const decimal TransactionFee = 0.02m; 

	public decimal PayByCrypto(decimal price)
	{
		var cryptoAmount = ConvertToCrypto(price);
		var totalAmount = ApplyTransactionFee(cryptoAmount);

		Console.WriteLine($"پرداخت کریپتو به مبلغ {totalAmount} در حال پردازش است.");

		return totalAmount;
	}

	private decimal ConvertToCrypto(decimal price)
	{
		return price * ConversionRate;
	}

	private decimal ApplyTransactionFee(decimal cryptoAmount)
	{
		return cryptoAmount - (cryptoAmount * TransactionFee);
	}
}


