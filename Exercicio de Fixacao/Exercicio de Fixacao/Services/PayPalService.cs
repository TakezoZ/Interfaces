namespace Exercicio_de_Fixacao.Services
{
    internal class PayPalService : OnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double Interest(double amount, int months)
        {
            return (months * 0.01) * months;
        }
    }
}
