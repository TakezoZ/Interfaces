namespace Exercicio_de_Fixacao.Services
{
    internal interface OnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int mounths);
    }
}
