using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalGR_Aniversariantes.Aniversariantes
{
    public class GerenciadorDeAniversariantes
    {
        private string _diretorioDeColaboradores = @"C:\Users\Victor\source\repos\ModalGR_Aniversariantes\ModalGR_Aniversariantes\Dados\Colaboradores.txt";



        public void ExibeTitulo()
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine();
            Console.WriteLine("                 ANIVERSARIANTES                       ");
            Console.WriteLine();
            Console.WriteLine("   Desafio prático - Processo de Formação ModalGR 2024 ");
            Console.WriteLine();
            Console.WriteLine("=======================================================");

        }

        //Método que lê e lista os colaboradores do arquivo-fonte
        public List<Colaborador> LeEListaColaborador()
        {

        }

        //Metodo que grava a lista dos aniversariantes do mês
        public List<Colaborador> GravaListaAniversariante()
        {

        }

        //Método que informa ao usuário os aniversariantes do mês e o diretório de onde está o arquivo.
        public void InformaUsuario(List<Colaborador> colaboradores)
        {
            
        }
    }
}
