using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importação da camada de negócio
using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;


namespace Projeto3Camadas.Code.BLL
{
    class FilmesBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_filmes";


        //O método de inserir recebe os dados via DTO
        public void Inserir (FilmeDTO flmdto)
        {
            string inserir = $"insert into {tabela} values(null,'{flmdto.Filme}','{flmdto.Genero}')";
            conexao.ExecutarComando(inserir);
        }
        public void Editar(FilmeDTO flmdto)
        {






        }
        public void Excluir(FilmeDTO flmdto)
        {






        }
        public void Listar(FilmeDTO flmdto)
        {






        }

    }
}
