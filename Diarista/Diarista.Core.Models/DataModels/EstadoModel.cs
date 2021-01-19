using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Core.Models.DataModels
{
    public class EstadoModel
    {
        public int Id { get; set;}
        public String Nome { get; set;}
        public String Sigla { get; set;}

        public int CidadeEstadoId { get; set; }
        public CidadeModel Cidade { get; set; }

        public EnderecoModel Endereco { get; set; }
        public Guid EstadoEnderecoId { get; set; }
    }
}
