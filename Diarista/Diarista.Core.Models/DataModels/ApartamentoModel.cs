using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Core.Models.DataModels
{
    public class ApartamentoModel
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        EnderecoModel EnderecoModel { get; set; }
        public int QtdQuartos { get; set; }
        public int QtdBanheiros { get; set; }
        public int QtdCozinhas { get; set; }
        public int QtdSalas { get; set; }
    }
}
