using System;
using System.Linq;
using System.Collections.Generic;
namespace SistemaAcademico
{
    class Program
    {
        static void Main(string[] args)
        {

            int operacao;
        	SistemaAcademico sistemaAcademico = new SistemaAcademico();

            do
            {
                operacao = Menu.Exibir();
                switch (operacao)
                {
                    case Menu.ListarAlunos:
                        //sistemaAcademico.Alunos.ToList().ForEach(item => Console.WriteLine(item));
                        foreach (var aluno in sistemaAcademico.Alunos)
                        {
                            Console.WriteLine(aluno);
                        }

                        break;

                    case Menu.EmitirCertificado:
                        sistemaAcademico.EmitirCertificado();
                        break;

                    case Menu.InformarNotaAvaliacao:
                        sistemaAcademico.InformarNotaAvaliacao();
                        break;

                    default:
                        return;
                }
            }
            while (operacao != Menu.Sair);
        }
    }
}
