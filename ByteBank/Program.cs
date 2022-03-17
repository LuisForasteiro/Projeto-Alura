using System;
using System.Collections.Generic;
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
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("OCORREU UM EXCECAO DO TIPO (ARGUMENTEXCEPTION).");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Metodo();


            Console.WriteLine("Execucao finalizada, tecle enter");
            Console.ReadLine();
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
