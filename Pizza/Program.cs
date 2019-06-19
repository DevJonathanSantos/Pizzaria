using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        const float VALOR_DO_SHOP = 0.80f;
        const float VALOR_DA_PIZZA = 11.50f;

        static void Main(string[] args)
        {
            int pessoas = 0;
            int chopp = 0;
            int continuar = 1;
            int banana = 0;
            int chocolate = 0;
            int presunto = 0;
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("[1] - Pizza de banana");
                        Console.WriteLine("[2] - Pizza de chocolate");
                        Console.WriteLine("[3] - Pizza de presunto");
                        Console.Write("Selecione a opção desejada: ");

                        int opcao = 0;
                        do
                        {
                            switch (opcao = Convert.ToInt16(Console.ReadLine()))
                            {
                                case 1:
                                    {
                                        Console.WriteLine("\n--- Pizza de banana ---");
                                        Console.Write("Quantidade: ");
                                        banana = Convert.ToInt16(Console.ReadLine());
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("pizza de chocolate");
                                        Console.WriteLine("Quantas ?");
                                        chocolate = Convert.ToInt16(Console.ReadLine());
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("pizza de presunto");
                                        Console.WriteLine("Quantas ?");
                                        presunto = Convert.ToInt16(Console.ReadLine());
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("\nEscolha uma opção valida!!");

                                        Console.WriteLine("[1] - Pizza de banana");
                                        Console.WriteLine("[2] - Pizza de chocolate");
                                        Console.WriteLine("[3] - Pizza de presunto");
                                        Console.Write("Selecione a opção desejada: ");
                                        break;
                                    }
                            }
                        } while (opcao != 1 && opcao != 2 && opcao != 3);

                        Console.WriteLine("\nDeseja mais pizzas? ");
                        Console.WriteLine("[1] - Sim");
                        Console.WriteLine("[0] - Não");
                        Console.Write("Opção: ");
                        continuar = Convert.ToInt16(Console.ReadLine());

                    } while (continuar == 1);

                    if (continuar == 1)
                    {
                        Console.WriteLine(continuar);
                    }

                    Console.WriteLine("\nGostaria de quantos chopps?");
                    chopp = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("\nQual a quantidade de pessoas?");
                    pessoas = Convert.ToInt16(Console.ReadLine());

                    string saida = (banana != 0) ? $"{ banana.ToString() } pizzas de banna" : null;
                    saida += (presunto != 0) ? $", {presunto.ToString()} pizzas de presunto" : null;
                    saida += (chocolate != 0) ? $", {chocolate.ToString()} pizzas de chocolate" : null;
                    saida += (chopp != 0) ? $", {chopp.ToString()} chopp" : null;


                    Console.WriteLine($"Seu pedido foi {saida}");
                    Console.WriteLine($"O total deu R$ { VALOR_DA_PIZZA * (banana + presunto + chocolate) + chopp}");
                    Console.WriteLine($"A taxa do garçom é r${ (VALOR_DA_PIZZA * (banana + presunto + chocolate) + chopp)* 0.10}");
                    Console.WriteLine($"O total a ser pago por pessoa é: r$ { (((VALOR_DA_PIZZA * (banana + presunto + chocolate) + chopp) * 0.10)+ VALOR_DA_PIZZA * (banana + presunto + chocolate) + chopp)/pessoas}");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opção ivalida ");
                    continuar = 1;
                }


            } while (continuar == 1);







        }
    }

}
