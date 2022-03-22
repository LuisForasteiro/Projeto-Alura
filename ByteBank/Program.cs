using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }


            Console.WriteLine("Execucao finalizada, tecle enter");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {

                leitor.LerProximaLinha();
            }



            //----------------------------------


            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();


            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Excecao do tipo IOException capturada e tratada");
            //}
            //finally
            //{
            //    Console.WriteLine("EXECUTANDO O FINALLY");
            //   if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }

            //}
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(8889, 9999);
                ContaCorrente conta2 = new ContaCorrente(6789, 9876);

                // conta1.Transferir(1000, conta2);
                conta1.Sacar(1000);

            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informacoes da INNER EXCEPTION (execucao interna): ");


            }
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                Dividir(10, divisor);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("capturado pelo NullReference");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("capturado pelo Exceptio ex");
                Console.WriteLine(ex.StackTrace);
            }

        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Excecao com numero = " + numero + "e divisor= " + divisor);
                throw;
                Console.WriteLine("ESTA EXECUTANDO?");
                //A LINHA DE CIMA NAO VAI EXECUTAR POIS OQ ESTA DEPOIS DO THROW NAO FUNCIONA MAIS -->RETORNO EH THROW
            }


        }
    }
}
