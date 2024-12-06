using Microsoft.Extensions.DependencyInjection;

namespace Payment;

public class Program
{
	public static void Main()
	{
		// DI
		var serviceProvider = ConfigureServices();
		var paymentService = serviceProvider.GetRequiredService<PaymentService>();

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

		var payment = paymentService.Create(paymentType);
		var response = payment.ProcessPayment(price, input);

		Console.WriteLine(response.Message);
	}

	// Config DI
	private static ServiceProvider ConfigureServices()
	{
		return new ServiceCollection()
			.AddTransient<ILogger, ConsoleLogger>()
			.AddTransient<IPaymentServiceFactory, CreditCardFactory>()
			.AddTransient<IPaymentServiceFactory, CryptoCurrencyFactory>()
			.AddTransient<UnsupportedPayment>()
			.AddTransient<PaymentService>()
			.BuildServiceProvider();
	}
}

public class PaymentService(IEnumerable<IPaymentServiceFactory> factories)
{
	public IPaymentService Create(PaymentType type)
	{
		return factories
			       .FirstOrDefault(f => f.PaymentType == type)?.CreateInstance()
		       ?? new UnsupportedPayment();
	}
}

public interface IPaymentService
{
	Payment ProcessPayment(decimal price, string type);
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
	private readonly IPaymentCalculator _paymentCalculator = new CreditCardCalculator();

	public Payment ProcessPayment(decimal price, string type)
	{
		var finalAmount = _paymentCalculator.CalculatePayment(price);

		var response = new Payment
		{
			Message = PaymentMessageGenerator.GeneratePaymentMessage($"{type}", price, finalAmount),
			Price = finalAmount
		};
		return response;
	}
}

public class CryptoCurrencyAdapter : IPaymentService
{
	private readonly CryptoCurrency _cryptoCurrency = new();
	private readonly CryptoCurrencyCalculator _paymentCalculator = new();

	public Payment ProcessPayment(decimal price, string type)
	{
		var adjustedPrice = _paymentCalculator.CalculatePayment(price);
		var finalCryptoAmount = _cryptoCurrency.PayByCrypto(adjustedPrice);
		
		var response = new Payment
		{
			Message = PaymentMessageGenerator.GeneratePaymentMessage(
				$"{type}",
				adjustedPrice,
				finalCryptoAmount),
			Price = finalCryptoAmount
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

public class CryptoCurrencyCalculator : IPaymentCalculator
{
	private const decimal TaxRate = 0.05m;
	private const decimal DiscountRate = 0.1m; 
	private const decimal TransactionFeeRate = 0.02m;

	public decimal CalculatePayment(decimal price)
	{
		var discountedPrice = price - (price * DiscountRate);
		
		var taxedPrice = discountedPrice + (discountedPrice * TaxRate);
		var finalPrice = taxedPrice - (taxedPrice * TransactionFeeRate);

		return finalPrice;
	}
}


public class UnsupportedPayment : IPaymentService
{
	private readonly ILogger _logger = new ConsoleLogger();

	public Payment ProcessPayment(decimal price,string type)
	{
		_logger.Log($"Unsupported payment type {type}. Price: {price}. Timestamp: {DateTime.UtcNow}");

		return new Payment
		{
			Message = $"Unsupported {type} payment. Unable to process {price} at this time."
		};
	}
}

public interface ILogger
{
	void Log(string message);
}

public class ConsoleLogger : ILogger
{
	public void Log(string message)
	{
		Console.WriteLine($"[LOG]: {message}");
	}
}


public interface IPaymentServiceFactory
{
	PaymentType PaymentType { get; }
	IPaymentService CreateInstance();
}

public class CreditCardFactory : IPaymentServiceFactory
{
	public PaymentType PaymentType => PaymentType.CreditCard;

	public IPaymentService CreateInstance()
	{
		return new CreditCard();
	}
}

public class CryptoCurrencyFactory : IPaymentServiceFactory
{
	public PaymentType PaymentType => PaymentType.CryptoCurrency;

	public IPaymentService CreateInstance()
	{
		return new CryptoCurrencyAdapter();
	}
}

public static class PaymentMessageGenerator
{
	public static string GeneratePaymentMessage(string paymentType, decimal originalPrice, decimal adjustedPrice)
	{
		return adjustedPrice == originalPrice
			? $"Payment via {paymentType}: Amount {originalPrice}."
			: $"Payment via {paymentType}: Original amount {originalPrice}, Final amount after adjustment {adjustedPrice}.";
	}
}


// External library class (inaccessible for modification)

public sealed class CryptoCurrency
{
	private const decimal ConversionRate = 0.0005m;
	private const decimal TransactionFee = 0.02m;

	public decimal PayByCrypto(decimal price)
	{
		var cryptoAmount = ConvertToCrypto(price);
		var totalAmount = ApplyTransactionFee(cryptoAmount);

		Console.WriteLine($"Processing cryptocurrency payment of {totalAmount} units.");

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


