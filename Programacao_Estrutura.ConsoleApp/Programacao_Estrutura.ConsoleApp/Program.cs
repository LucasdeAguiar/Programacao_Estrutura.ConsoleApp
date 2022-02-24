using System;

namespace Programacao_Estrutura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] numeros = new int[10];
             int[] numerosNegativos = new int[numeros.Length];
             int maiorValor=0,menorValor=0;
            
            atribuirValores(numeros);
            limpar();

            mostrarValores(numeros);
            espacamento();
          
            valorMaior(numeros , ref maiorValor);
            espacamento();

           menorValor = valorMenor(numeros, out menorValor);
            Console.WriteLine("Menor valor: " + menorValor);

            espacamento();

            valorNegativo(numeros ,numerosNegativos);

            espacamento();
            valorMedia(numeros);
            espacamento();

            removerValor(numeros);



        }
        public static void espacamento()
        {
            Console.WriteLine("\n");
          
        }
        public static void limpar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void atribuirValores(int[] numeros)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor da posição: " + i);
                numeros[i] = System.Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void mostrarValores(int[] numeros)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Valor da posição: " + i + ": " + numeros[i]);
               
            }
        }

        public static void valorMaior(int[] numeros,ref int maiorValor)
        {
            for (int i=0; i < numeros.Length; i++)
            {
                if (i == 0)
                {
                    maiorValor = numeros[i];
                }
                else
                {
                    if (numeros[i]> maiorValor)
                    {
                        maiorValor = numeros[i];
                    }
                }
            }
            Console.WriteLine("Maior Valor da sequencia: " + maiorValor);
        }

        public static int valorMenor(int[] numeros,out int menorValor)
        {
            menorValor = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i == 0)
                {
                    menorValor = numeros[i];
                }
                else
                {
                    if (numeros[i] < menorValor)
                    {
                        menorValor = numeros[i];
                    }
                }
            }
            return menorValor;
          
            Console.WriteLine("Menor Valor da sequencia: " + menorValor);
        }

        public static void valorMedia(int[] numeros)
        {
            decimal mediaValor=0;
         
            for (int i = 0; i < numeros.Length; i++)
            {
                mediaValor = mediaValor + numeros[i];


            }
            mediaValor = mediaValor / numeros.Length;
            Console.WriteLine("Valor médio da sequencia: " + mediaValor);
        }

        public static void valorNegativo(int[] numeros, int [] numerosNegativos)
        {
            int contadorNegativo=0;

            for (int i = 0; i< numeros.Length; i++)
            {
                if (numeros[i]<0)
                {
                    contadorNegativo++;
                }
            }


            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    numerosNegativos[i] = numeros[i];
                }


            }

           

            Console.Write("Valores Negativos: ");
            for (int i = 0; i< numerosNegativos.Length; i++)
            {
                if (numerosNegativos[i] == 0)
                {

                }
                else
                {
                    Console.Write(" " + numerosNegativos[i] + " ");
                }
            }
            Console.WriteLine(" ");
           
        }

        public static void tresMaioresValores(int[] numeros)
        {
            int maiorValor=0, segundoMaior=0, terceiroMaior=0;

            for (int i=0; i<numeros.Length;i++)
            {
                if (i == 0)
                {
                    maiorValor = numeros[i];
                }

                if (i == 1)
                {
                    if (numeros[i] > maiorValor)
                    {
                        segundoMaior = maiorValor;
                        maiorValor = numeros[i];
                    }
                }
                if (i>=2)
                {
                    if (numeros[i]>maiorValor)
                    {
                        terceiroMaior = segundoMaior;
                        segundoMaior = maiorValor;
                        maiorValor=numeros[i];
                    
                    }else if (numeros[i]>segundoMaior && numeros[i]<maiorValor)
                    {
                        terceiroMaior = segundoMaior;
                        segundoMaior = numeros[i];
                    } 

                }
            }
            Console.WriteLine("Maior Valor: " + maiorValor);
            Console.WriteLine("Segundo maior Valor: " + segundoMaior);
            Console.WriteLine("Terceiro maior Valor: " + terceiroMaior);
        }

        public static void removerValor(int [] numeros)
        {
            string opcao;
            int numeroRemove,qtdpararemover=0;
            
            

            do
            {
                Console.WriteLine("Deseja remover um número da sequência?(s/n)");
                opcao = Console.ReadLine();
                if (opcao == "s")
                {
                    Console.WriteLine("Digite o número em que deseja remover");
                     numeroRemove = System.Convert.ToInt32(Console.ReadLine());

                    
                    for (int i=0;i<numeros.Length;i++)
                    {
                        if (numeroRemove == numeros[i])
                        {
                            qtdpararemover++;
                        }
                        
                        
                    }

                    int[] aux = new int[numeros.Length - qtdpararemover];
                    int j = 0;
                    Console.WriteLine("Lista com o número removido:");


                    for (int i = 0;i<numeros.Length;i++)
                    {
                        if (numeros[i] != numeroRemove)
                        {
                            aux[j] = numeros[i];
                            j++;
                        }
                    }

                    for (int i=0; i < aux.Length; i++)
                    {
                       
                            Console.WriteLine(" " + aux[i] + " ");
                     }

                }else 
                if (opcao != "s" && opcao != "n")
                {

                    Console.WriteLine("Digite uma opção válida..");
                }
                else
                {
                    Console.WriteLine("Nenhum número foi removido..");
                }
             
            }while (opcao != "s" && opcao != "n");
                  
        }

    }
}
