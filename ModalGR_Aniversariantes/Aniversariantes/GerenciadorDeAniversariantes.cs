using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModalGR_Aniversariantes.Aniversariantes
{
    public class GerenciadorDeAniversariantes
    {
        private string _diretorioDeColaboradores = Environment.CurrentDirectory + '\\' + "Dados";
        private string _nomeDoArquivoColaboradores = "Colaboradores.txt";



        public void ExibeTitulo()
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine();
            Console.WriteLine("                 ANIVERSARIANTES                       ");
            Console.WriteLine();
            Console.WriteLine("   Desafio prático - Processo de Formação ModalGR 2024 ");
            Console.WriteLine();
            Console.WriteLine("=======================================================");
            Console.WriteLine();

        }


        public List<Colaborador> LeEListaColaboradores()
        {
            Console.WriteLine("Localizando arquivo de colaboradores...");
            Console.WriteLine("Diretório: " + _diretorioDeColaboradores + "\n");
            Console.WriteLine();
            Console.WriteLine("Obtendo lista do arquivo de colaboradores...");
            Console.WriteLine();

            var manipuladorDeArquivos = new ManipuladorDeArquivos();
            List<string> listaDeStrings = manipuladorDeArquivos.LeArquivo(_diretorioDeColaboradores, _nomeDoArquivoColaboradores);

            List<Colaborador> resultado = new List<Colaborador>();
            Console.WriteLine("Lista obtida com sucesso...\n");
            Console.WriteLine("Procurando aniversariantes...");

            var mesAtual = DateTime.Now.Month;
            foreach (string str in listaDeStrings)
            {
                string[] dados = str.Split('|');

                var colaboradores = new Colaborador();
                colaboradores.Nome = dados[0];
                colaboradores.Email = dados[1];
                colaboradores.dataNascimento = DateTime.ParseExact(dados[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (colaboradores.dataNascimento.Month == DateTime.Now.Month)
                {
                    resultado.Add(colaboradores); 
                }
            }

            if (resultado.Any())
            {
                Console.WriteLine("Foram encontrados " + resultado.Count + " aniversariantes");
            }
            else
            {
                Console.WriteLine("Não há aniversariantes este mês.");
            }

            return resultado;
        }

        public List<Colaborador> GravaListaAniversariante()
        {
            throw new NotImplementedException();
        }


        public void InformaUsuario(List<Colaborador> colaboradores)
        {

        }
    }
}
