﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModalGR_Aniversariantes.Aniversariantes
{

    public class ManipuladorDeArquivos
    {
        public void EscreveArquivo(string diretorio, string nomeDoArquivo, List<string> conteudoDoArquivo)
        {

        }



        public List<string> LeArquivo(string diretorio, string nomeDoArquivo)
        {
            List<string> dados = new List<string>();

            string filePath = diretorio + '\\' + nomeDoArquivo;

            string linha;

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((linha = reader.ReadLine()) != null)
                    {
                        dados.Add(linha);
                    }
                }
            }

            return dados;
        }
    }
}
