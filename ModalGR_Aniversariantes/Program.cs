
using ModalGR_Aniversariantes.Aniversariantes;
using System.Collections.Generic;

var gerenciador = new GerenciadorDeAniversariantes();


try
{

    gerenciador.ExibeTitulo();

    var lista = gerenciador.LeEListaColaboradores();

    var aniversariante = gerenciador.GravaListaAniversariante(lista);

    gerenciador.InformaUsuario(aniversariante);
}
catch(Exception EX)
{
    Console.WriteLine("Erro: " + EX.Message);
}

