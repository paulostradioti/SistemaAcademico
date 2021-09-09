using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademico
{
    class SistemaAcademico
    {
        const double NotaMinimaAprovacao = 60;

        public List<Aluno> Alunos { get; set; }
        //private List<Aluno> _alunos;
        //public IReadOnlyList<Aluno> Alunos { get => _alunos; }
        public SistemaAcademico()
        {
            CarregaDadosDeExemplo();
        }

        //public void ListarAlunos()
        //{
        //    _alunos.ForEach(Console.WriteLine);
        //}

        public void EmitirCertificado()
        {
            Console.WriteLine("Digite o número da Matrícula: ");
            var matricula = Console.ReadLine();

            Aluno aluno = ObtemAlunoPeloNumeroDaMatricula(matricula);
            if (aluno == null)
            {
                Console.WriteLine("Matricula não encontrada");
                return;
            }

            if (aluno.Notas.Count < 3)
            {
                Console.WriteLine("O aluno ainda não completou as 3 avaliações");
                return;
            }

            var media = aluno.Notas.Count > 0 ? aluno.Notas.Average() : 0;
            if (media < SistemaAcademico.NotaMinimaAprovacao)
            {
                Console.WriteLine("O aluno ainda não domina o mínimo necessário para aprovação");
                return;
            }
            
            // Registrar o certificado no banco de dados, registrar, solicitar a impressão, enviar pelo correio
            Console.WriteLine($"Certificado solicitado com sucesso para a matrícula número {matricula} ({aluno.Nome})");
        }

        public void InformarNotaAvaliacao()
        {
            Console.WriteLine("Digite o número da Matrícula: ");
            var matricula = Console.ReadLine();

            Aluno aluno = ObtemAlunoPeloNumeroDaMatricula(matricula);
            if (aluno == null)
            {
                Console.WriteLine("Matricula não encontrada");
                return;
            }

            var quantidadeNotas = aluno.Notas.Count >= 3;
            if (quantidadeNotas)
            {
                Console.WriteLine("O aluno já possui as 3 notas das avaliações.");
                return;
            }

            System.Console.Write("Digite a nota do Aluno (inteiro entre 0 e 100): ");
            Int32.TryParse(Console.ReadLine(), out var nota);

            aluno.Notas.Add(nota);
            System.Console.WriteLine("Nota adicionada com sucesso!");
        }

        private Aluno ObtemAlunoPeloNumeroDaMatricula(string matricula)
        {
            return Alunos.FirstOrDefault(aluno => aluno.Matricula == matricula);
        }

        public void AdicionarAluno(Aluno novoAluno)
        {
            _alunos.Add(novoAluno);
        }
        private void CarregaDadosDeExemplo()
        {
            _alunos = new List<Aluno>{
                new Aluno
                {
                    Matricula = "102030",
                    PrimeiroNome = "Leia",
                    Sobrenome= "Barbosa"
                },
                new Aluno
                {
                    Matricula = "102031",
                    PrimeiroNome = "Joana",
                    Sobrenome = "Galindo"
                },
                new Aluno
                {
                    Matricula = "102032",
                    PrimeiroNome = "Osias",
                    Sobrenome = "Nascimento"
                },
                new Aluno
                {
                    Matricula = "102033",
                    PrimeiroNome = "Kyan",
                    Sobrenome = "Meireles"
                }
            };

        }
    }
}