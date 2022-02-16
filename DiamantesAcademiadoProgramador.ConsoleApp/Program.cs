using System;

namespace Terrenosretangulares.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Algoritmo para desenhar um Diamante");

                Console.WriteLine("Digite 1 para ser desenhado um diamante");

                Console.WriteLine("Digite s para sair");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;

                if (opcao != "1" && opcao != "s")
                {
                    Console.WriteLine("Opção do Menu Invalida ");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Digite o numero do Diamante: ( apenas numeros impares ) ");
                string strnumero = Console.ReadLine();
                int numero = System.Convert.ToInt32(strnumero);

                int espacoi = (numero - 1) / 2;
                int espacos = (numero - 1) / 2;

                int qtdinicialx = 1;

                if (opcao == "1")
                {

                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("Valor informado é não é um numero Impar");
                    }
                    else
                    {

                        #region Codigo que desenha a parte de cima do diamante

                        for (int linha = 0; linha < espacos; linha++ )
                        {
                            for (int i = 0; i < espacoi; i++) //escrever os espaços
                            {
                                Console.Write(" ");
                            }
                           
                            for (int i = 0;i < qtdinicialx; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("x");
                            }

                            espacoi--;
                            qtdinicialx += 2;

                            Console.WriteLine();

                        }

                            #endregion


                            #region Codigo que desenha a parte do meio do diamante
                            for (int coluna = 0; coluna < numero; coluna++)
                            {
                                Console.Write("x");
                            }

                            espacoi++;
                            qtdinicialx -= 2;

                            Console.WriteLine();

                        #endregion


                        #region Codigo que desenha a parte de baixo do diamante

                        for (int linha = 0; linha < espacos; linha++)
                        {
                            for (int i = 0; i < espacoi; i++) //escrever os espaços
                            {
                                Console.Write(" ");
                            }

                            for (int i = 0; i < qtdinicialx; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("x");
                            }

                            espacoi++;
                            qtdinicialx -= 2;

                            Console.WriteLine();

                        }

                        #endregion


                        Console.ReadLine();
                        

                    }

                }



                Console.ReadLine();


            } while (true);
        }
    }
}