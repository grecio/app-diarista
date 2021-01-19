using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Core.Models.DataModels
{
    public class ApartamentoModel
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public int QtdQuartos { get; set; }
        public int QtdBanheiros { get; set; }
        public int QtdCozinhas { get; set; }
        public int QtdSalas { get; set; }

        public EnderecoModel Endereco { get; set; }

    }
}
