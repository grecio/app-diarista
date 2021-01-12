using System;
using System.Collections.Generic;
using System.Text;

namespace Diarista.Core.Models.DataModels
{
    public class CidadeModel
    {
        public Guid Id { get; set; }
        public String Nome {get; set; }
        EstadoModel Estado { get; set; }
    }
}
