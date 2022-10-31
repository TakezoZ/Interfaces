﻿using Exercicio_de_Fixacao.Entities;
using Exercicio_de_Fixacao.Services;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime initialDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double cotractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(contractNumber, initialDate, cotractValue);
            InstallmentService installmentService = new InstallmentService();

            installmentService.ProcessContract(contract, numberOfInstallments);

            foreach (var item in contract.Installments)
            {
                Console.WriteLine(item);
            }
        }
    }
}