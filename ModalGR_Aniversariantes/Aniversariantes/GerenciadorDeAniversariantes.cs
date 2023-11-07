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

            foreach (string str in listaDeStrings)
            {
                string[] dados = str.Split('|');

                var colaboradores = new Colaborador();
                colaboradores.Nome = dados[0];
                colaboradores.Email = dados[1];
                colaboradores.dataNascimento = DateTime.ParseExact(dados[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                resultado.Add(colaboradores);
            }

            return resultado;
        }

        public List<Colaborador> GravaListaAniversariante(List<Colaborador> colaboradores)
        {
            List<Colaborador> aniversariantes = new List<Colaborador>();
            List<string> aniversariantesParaGravar = new List<string>();

            var mesAtual = DateTime.Now.Month;

            var manipuladorDeArquivos = new ManipuladorDeArquivos();

            foreach (Colaborador colab in colaboradores)
            {
                if (colab.dataNascimento.Month == mesAtual)
                {
                    aniversariantes.Add(colab);
                    string colabParaGravar = colab.Nome + "|" + colab.Email + "|" + colab.dataNascimento.ToShortDateString();

                    aniversariantesParaGravar.Add(colabParaGravar);

                }
            }

            string arquivoAniversariantes = "aniversariantes_" + mesAtual + ".txt";
            manipuladorDeArquivos.EscreveArquivo(_diretorioDeColaboradores, arquivoAniversariantes, aniversariantesParaGravar);




            if (aniversariantes.Any())
            {
                Console.WriteLine("Foram encontrados " + aniversariantes.Count);
                Console.WriteLine("Lista de aniversariantes gravada em: " + _diretorioDeColaboradores + "\\" + arquivoAniversariantes);
            }
            else
            {
                Console.WriteLine("Não há aniversariantes este mês.");
            }

            return aniversariantes;
        }

        public void InformaUsuario(List<Colaborador> aniversariantes)
        {
            Console.WriteLine("Aniversariantes do mês: ");

            foreach (var niver in aniversariantes)
            {
                Console.WriteLine();
                Console.WriteLine($"{niver.Nome} {niver.Email} {niver.dataNascimento.ToShortDateString()}");
            }

        }

    }
}
