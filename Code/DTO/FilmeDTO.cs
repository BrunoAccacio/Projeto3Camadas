using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class FilmeDTO
    {
        //propriedade privadas
        private int _id;
        private string _filme;
        private string _genero;

        //Métodos de encapsulamento (CTRL+R,E)
        public int Id { get => _id; set => _id = value; }
        public string Filme { get => _filme; set => _filme = value; }
        public string Genero { get => _genero; set => _genero = value; }
    }
}
