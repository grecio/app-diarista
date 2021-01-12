using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Core.Models.DataModels
{
    public class EnderecoModel
    {
        public Guid Id { get; set; }
        CidadeModel Cidade { get; set; }
        EstadoModel Estado { get; set; }
        public String Logradouro { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
    }
}
