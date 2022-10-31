using Exercicio_de_Fixacao.Entities;

namespace Exercicio_de_Fixacao.Services
{
    internal class InstallmentService
    {
        public void ProcessContract(Contract contract, int mounths)
        {
            double installmentValue = contract.TotalValue / mounths;

            for (int i = 1; i <= mounths ; i++)
            {
                double monthValue = installmentValue + installmentValue * (0.01 * i);

                monthValue += monthValue * 0.02 ;

                DateTime date = contract.Date.AddMonths(i);

                Installment installment = new Installment(date, monthValue);

                contract.AddInstallment(installment);
            }
        }
    }
}
