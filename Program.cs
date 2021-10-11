﻿using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Alunos[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new aluno();
                        Aluno.Nome = Console.ReadLine();

                        Console.Writeline("Informe a nota do aluno:");
                        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve serr decimal");
                        }

                        aluno[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        // TODO: listar alunos                        
                        break;
                    case "3":
                        // TODO: calcular media geral
                        break;        
                    default:
                        throw new ArgumentOutOfRangeException();
                }
              
                opcaoUsuario = obterOpcaoUsuario();
            }

        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
