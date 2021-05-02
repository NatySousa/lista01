using Lista01.Entities;
using System;
using Lista01.Repositories;

namespace Lista01.Repositories
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** CONTROLE DE FUNCIONÁRIOS ***\n");

            var funcionario = new Funcionario();

            funcionario.Id = Guid.NewGuid();

            Console.Write("Informe o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informe o Cpf do funcionário: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Matrícula  do funcionário: ");
            funcionario.Matricula = Console.ReadLine();

            Console.WriteLine("Data de Admissão do funcionário: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe o cargo do funcionário: ");
            funcionario.Cargo = Console.ReadLine();

            Console.WriteLine("Informe o salário do funcionário: ");
            funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n*** DADOS DO FUNCIONÁRIO ***\n");
            Console.WriteLine("ID......................:" + funcionario.Id);
            Console.WriteLine("Nome....................:" + funcionario.Nome);
            Console.WriteLine("Cpf.....................:" + funcionario.Cpf);
            Console.WriteLine("Matricula...............:" + funcionario.Matricula);
            Console.WriteLine("Data de Admissão....... :" + funcionario.DataAdmissao);
            Console.WriteLine("Cargo...................:" + funcionario.Cargo);
            Console.WriteLine("Salário.................:" + funcionario.Salario);

            var funcionarioRepository = new FuncinarioRepository();

            try
            {
                funcionarioRepository.ExportarDados(funcionario);

                Console.WriteLine("\nDados gravados com sucesso!");

            }
            catch (Exception e)
            {

                Console.WriteLine("\nErro: " + e.Message);

            }

            Console.ReadKey();


        }

    }
}
