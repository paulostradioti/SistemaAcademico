using System;
using System.Collections.Generic;

namespace SistemaAcademico
{
    public static class Menu
    {
        public const int ListarAlunos = 1;
        public const int EmitirCertificado = 2;
        public const int InformarNotaAvaliacao = 3;
        public const int Sair = 4;
        private static Dictionary<int, string> Opcoes { get; set; }

        static Menu()
        {
            Opcoes = new Dictionary<int, string>()
            {
                {ListarAlunos, "Listar Alunos"},
                {EmitirCertificado, "Emitir Certificado"},
                {InformarNotaAvaliacao, "Informar Nota de Avaliação"},
                {Sair, "Sair"}
            };
        }

        public static int Exibir()
        {
            int escolha;
            do
            {
                Console.WriteLine("Digite a opção Desejada:");
                foreach (var opcao in Opcoes)
                {
                    System.Console.WriteLine($"{opcao.Key} - {opcao.Value}");
                }

                Int32.TryParse(Console.ReadLine(), out escolha);
            } while (!Opcoes.ContainsKey(escolha));

            return escolha;
        }
    }
}