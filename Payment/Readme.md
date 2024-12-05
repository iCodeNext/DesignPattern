## Description:
You are building an e-commerce application where users can pay using multiple payment methods: CreditCard, PayPal, and CryptoCurrency.

The CryptoCurrency payment system comes from a third-party library, and it is incompatible with your IPaymentProcessor interface.
You want to support a dynamic pricing strategy where discounts or additional fees are applied based on the payment method.
If the user selects an unsupported payment method, the system should default to a NullPaymentProcessor that logs an error gracefully.


## Input:

Payment Method: CreditCard
Amount: 100

### Output:
Applying 2% fee for credit card payment.
Processing credit card payment of $102.00


## Input:

Payment Method: CryptoCurrency
Amount: 200

### Output:
No adjustment for the selected payment method.
Processing cryptocurrency payment of $200.00 via third-party library


## Input:

Payment Method: Unsupported
Amount: 150

### Output:
No adjustment for the selected payment method.
Payment method not supported. Unable to process $150.00.