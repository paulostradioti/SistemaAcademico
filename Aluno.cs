using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico
{
    class Aluno
    {
        public List<int> Notas { get; set; }
        public string PrimeiroNome { get; init; }
        public string Sobrenome { get; init; }
        public string Matricula { get; init; }
        public string Nome
        {
            get
            {
                return $"{PrimeiroNome} {Sobrenome}";
            }
        }
        public Aluno()
        {
            Notas = new List<int>();
        }

        public override string ToString()
        {
            var media = Notas.Count > 0 ? Notas.Average() : 0;
            return $"{Matricula} - {Nome} - {media}";
        }

    }

}