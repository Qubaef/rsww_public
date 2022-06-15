namespace PaymentManager.Services;

public class PaymentService
{
    // Time int seconds to wait for payment proceed
    private const int SimulatedDelay = 3000;

    public async Task<bool> PerformPayment(string cardNumber)
    {
        // Wait for SimulatedDelay seconds
        await Task.Delay(SimulatedDelay);

        // Card number must be a valid credit card number
        if (cardNumber.Length != 16)
        {
            return false;
        }

        if (!cardNumber.All(char.IsDigit))
        {
            return false;
        }

        // If sum of digits is divisible by 2, then payment is successful
        // If not, then payment is not successful
        int sumOfDigits = 0;
        foreach (char digit in cardNumber)
        {
            sumOfDigits += int.Parse(digit.ToString());
        }

        bool paymentResult = sumOfDigits % 2 == 0;

        return paymentResult;
    }
}