using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjetoFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância do Facade
            Facade concedeCredito = new Facade();

            // Cria uma instância de um  novo Cliente informando o nome
            Cliente cliente1 = new Cliente("Macoratti");

            //Utiliza o Facade para verificar condições de concessão ou não
            bool resultado = concedeCredito.ConcederEmprestimo(cliente1, 201000.00);

            //exibe o resultado
            Console.WriteLine("O empréstimo pleiteado pelo cliente " + cliente1.Nome + " foi  " + (resultado ? "Aprovado" : "Negado"));

            //aguarda
            Console.ReadKey();
        }
    }
}
