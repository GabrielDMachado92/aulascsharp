using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class Aluno
    {
        public String nomeAluno { get; set; }

        public String matricula { get; set; }

        public DateTime dataNascimento { get; set; }

        public List<Double> notasAluno { get; set; }
    }
}
