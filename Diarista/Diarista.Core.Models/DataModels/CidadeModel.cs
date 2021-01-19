using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Core.Models.DataModels
{
    public class CidadeModel
    {
        public Guid Id { get; set; }
        public String Nome {get; set; }
        public EstadoModel Estado { get; set; }

        public Guid CidadeEstadoId { get; set; }

        public EnderecoModel Endereco { get; set; }
        public Guid CidadeEnderecoId { get; set; }


    }
}
