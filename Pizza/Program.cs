using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            double chopp = 0.80;
            double pizza = 10.00;
            double cobertura = 1.50;
            int quantidade = 0;
            int continuar = 1;

            do
            {



                Console.WriteLine("1 - para pizza de banana");
                Console.WriteLine("2 - para pizza de chocolate");
                Console.WriteLine("3 - para pizza de presunto");

                switch (quantidade)
                {
                    case 1:
                        {
                            Console.WriteLine("pizza de banana");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("pizza de chocolate");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("pizza de presunto");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Deseja mias uma pizza? ");
                            Console.WriteLine("1 - sim");
                            break;
                        }


                }

                Console.WriteLine("Deseja mias uma pizza? ");
                Console.WriteLine("1 - sim");


                try
                {
                    continuar = Convert.ToInt16(Console.ReadLine());

                    if (continuar == 1)
                    {
                        Console.WriteLine("Opção invalida");
                    }
                    else
                    {
                        continuar = 1;
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opção invalida");
                    continuar = 0;
                }


                Console.ReadKey();

            } while (continuar == 1);




            Console.WriteLine("Entre com o nomero de pizzas");
            pizza = double.Parse("52.8725945", System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o nomero de chopps");
            chopp = double.Parse("52.8725945", System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o nomero de pizzas");
            cobertura = double.Parse("52.8725945", System.Globalization.CultureInfo.InvariantCulture);


            Console.ReadLine();


        }
    }

}
