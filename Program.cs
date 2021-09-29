using System;

namespace UsandoSwitchCaseMes
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Este mês tem 31 dias");
                break;

                case 2:
                    Console.WriteLine("Este mês tem 28 ou 29 dias");
                break;

                case 3:
                    Console.WriteLine("Este mês tem 31 dias");
                break;

                case 5:
                    Console.WriteLine("Este mês tem 31 dias");
                break;

                case 7:
                    Console.WriteLine("Este mês tem 31 dias");
                break;

                case 8:
                    Console.WriteLine("Este mês tem 31 dias");
                break;

                case 10:
                    Console.WriteLine("Este mês tem 31 dias");
                break;

                case 12:
                    Console.WriteLine("Este mês tem 31 dias");
                break;
                
                default:
                    Console.WriteLine("Este mês tem 30 dias");
                break;
            }
        }
    }
}
