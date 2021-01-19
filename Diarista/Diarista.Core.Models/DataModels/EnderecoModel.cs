using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Core.Models.DataModels
{
    public class EnderecoModel
    {
        public Guid Id { get; set; }
        public CidadeModel Cidade { get; set; }
        public EstadoModel Estado { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }

        public int ApartamentoEnderecoId { get; set; }
        public ApartamentoModel Apartamento { get; set; }

        public Guid EndecoCidadeId { get; set; }
        public EnderecoModel Endereco { get; set; }

    }
}
